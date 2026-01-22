using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace LibrarySystem.Common.DTOs.Library.Search

{
    public class SearchBaseDto
    {
        public string? Text { get; set; }
        public int Page { get; set; }
        
        public int PageSize { get; set; } 
    }
}
