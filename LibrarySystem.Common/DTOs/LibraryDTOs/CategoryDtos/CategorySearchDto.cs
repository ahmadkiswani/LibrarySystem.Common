using LibrarySystem.Common.DTOs.Library.Search;
using System;
using System.Collections.Generic;
using System.Text;
namespace LibrarySystem.Common.DTOs.Library.Categories
{
    public class CategorySearchDto : SearchBaseDto
    {
        public int? Number { get; set; }
    }
}
