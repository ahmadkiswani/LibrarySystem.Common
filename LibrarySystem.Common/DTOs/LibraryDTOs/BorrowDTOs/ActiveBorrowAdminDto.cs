namespace LibrarySystem.Common.DTOs.Library.Borrows
{
    public class ActiveBorrowAdminDto
    {
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string BookTitle { get; set; } = string.Empty;
        public string CategoryName { get; set; } = string.Empty;
        public string CopyCode { get; set; } = string.Empty;
        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }
        public int Status { get; set; }
        public string StatusText { get; set; } = string.Empty;
    }
}


