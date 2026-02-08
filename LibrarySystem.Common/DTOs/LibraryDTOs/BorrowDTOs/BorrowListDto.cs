namespace LibrarySystem.Common.DTOs.Library.Borrows
{
    public class BorrowListDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookCopyId { get; set; }
        public string? CopyCode { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int Status { get; set; }
        public int? OverdueDays { get; set; }
        public string? BookTitle { get; set; }
    }
}

  