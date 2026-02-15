
namespace LibrarySystem.Common.Events
{
    public class CheckOverdueBorrowsCommand
    {
        public Guid EventId { get; set; }
        public DateTime OccurredAt { get; set; }
    }
}
