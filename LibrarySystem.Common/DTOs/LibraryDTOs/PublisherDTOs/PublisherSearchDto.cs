using LibrarySystem.Common.DTOs.Library.Search;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem.Common.DTOs.Library.Publishers
{
    public class PublisherSearchDto:SearchBaseDto
    {
        public int? Number { get; set; }
    }
}
