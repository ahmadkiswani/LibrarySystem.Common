using System;
using System.Collections.Generic;
using System.Text;
namespace LibrarySystem.Common.DTOs.Library.BookCopies
{
    public class BookCopyListDto
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string CopyCode { get; set; } = string.Empty;
        public bool IsAvailable { get; set; }
    }
}
