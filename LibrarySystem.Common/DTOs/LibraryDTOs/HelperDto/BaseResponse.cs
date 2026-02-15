namespace LibrarySystem.Common.DTOs.Library.Helpers
{
    /// <summary>
    /// Single shared API response shape used across Library, Identity, and Presentation.
    /// </summary>
    public class BaseResponse<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
        public T? Data { get; set; }
        public List<string> Errors { get; set; } = new();

        public static BaseResponse<T> SuccessResponse(T data, string message = "")
            => new() { Success = true, Message = message, Data = data };

        public static BaseResponse<T> FailureResponse(string message, List<string>? errors = null)
            => new() { Success = false, Message = message, Errors = errors ?? new List<string>() };
    }
}

