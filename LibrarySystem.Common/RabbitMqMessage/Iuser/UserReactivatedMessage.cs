namespace LibrarySystem.Common.Messaging
{
    public class UserReactivatedMessage : RabbitMqMessage
    {
        public int UserId { get; set; }
        public DateTime OccurredAt { get; set; }
    }
}

