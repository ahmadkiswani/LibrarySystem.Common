using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibrarySystem.Common.DTOs.Library.Categories

{
    public class CategoryCreateDto
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }= string.Empty; 
    }
}

