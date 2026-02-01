using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibrarySystem.Common.DTOs.Library.Borrows

{
    public class BorrowCreateDto
    {

        [Required]
        public int BookCopyId { get; set; }

    }
}



