using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem.Common.DTOs.Library.Categories
{
    public class CategoryDetailsDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;    
        public int BooksCount { get; set; }
    }
}

