using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace LibrarySystem.Common.DTOs.Library.Search

{
    public class SearchBaseDto
    {
        public string? Text { get; set; }
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }
}
