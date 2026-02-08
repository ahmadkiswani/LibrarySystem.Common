using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Common.DTOs.Library.Borrows
{
    public class BorrowRequestByBookDto
    {
        [Required]
        public int BookId { get; set; }
    }
}
