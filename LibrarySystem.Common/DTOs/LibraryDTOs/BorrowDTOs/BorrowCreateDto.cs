using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Common.DTOs.Library.Borrows

{
    public class BorrowCreateDto
    {

        [Required]
        public int BookCopyId { get; set; }

    }
}



