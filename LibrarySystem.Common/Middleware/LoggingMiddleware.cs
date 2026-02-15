using LibrarySystem.Common.Messaging;
using MassTransit;
using Microsoft.AspNetCore.Http;
using System.Text;

namespace LibrarySystem.Common.Middleware
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly string _serviceName;

        public LoggingMiddleware(RequestDelegate next, string serviceName)
        {
            _next = next;
            _serviceName = serviceName;
        }

        public async Task InvokeAsync(HttpContext context, IPublishEndpoint publishEndpoint)
        {
            var correlationId = Guid.NewGuid().ToString();
            context.Items["CorrelationId"] = correlationId;

            context.Request.EnableBuffering();

            string requestBody = string.Empty;
            if (context.Request.Body.CanRead)
            {
                using var reader = new StreamReader(
                    context.Request.Body,
                    Encoding.UTF8,
                    leaveOpen: true);

                requestBody = await reader.ReadToEndAsync();
                context.Request.Body.Position = 0;
            }
            var requestText =
                $"{context.Request.Method} {context.Request.Path} {requestBody}";

            var originalBody = context.Response.Body;
            using var responseBody = new MemoryStream();
            context.Response.Body = responseBody;

            try
            {
                await _next(context);

                responseBody.Position = 0;
                var responseText = await new StreamReader(responseBody).ReadToEndAsync();

                // إرجاع الرد للعميل أولاً حتى لا ينتظر RabbitMQ (سبب بطء اللوق أوت وغيره)
                responseBody.Position = 0;
                await responseBody.CopyToAsync(originalBody);
                context.Response.Body = originalBody;

                // تسجيل اللوق في الخلفية دون حجب الاستجابة
                var now = DateTime.UtcNow;
                var isLogicalError =
                    context.Response.StatusCode >= 400 ||
                    responseText.Contains("\"success\":false");

                _ = Task.Run(async () =>
                {
                    try
                    {
                        if (isLogicalError)
                        {
                            await publishEndpoint.Publish(new LogExceptionMessage
                            {
                                CorrelationId = correlationId,
                                Time = now,
                                ServiceName = _serviceName,
                                Message = "Logical / Business error",
                                Request = requestText,
                                Response = responseText,
                                ErrorType = "Business"
                            });
                        }
                        else
                        {
                            await publishEndpoint.Publish(new LogRequestMessage
                            {
                                CorrelationId = correlationId,
                                Time = now,
                                ServiceName = _serviceName,
                                Request = requestText
                            });
                            await publishEndpoint.Publish(new LogResponseMessage
                            {
                                CorrelationId = correlationId,
                                Time = now,
                                ServiceName = _serviceName,
                                Response = responseText
                            });
                        }
                    }
                    catch { /* عدم حجب الاستجابة عند فشل اللوق */ }
                });
            }
            catch (Exception ex)
            {
                context.Response.Body = originalBody;
                _ = Task.Run(async () =>
                {
                    try
                    {
                        await publishEndpoint.Publish(new LogExceptionMessage
                        {
                            CorrelationId = correlationId,
                            Time = DateTime.UtcNow,
                            ServiceName = _serviceName,
                            Message = ex.Message,
                            StackTrace = ex.StackTrace,
                            Request = requestText,
                            ErrorType = "Exception"
                        });
                    }
                    catch { }
                });
                throw;
            }
            }
    }
}