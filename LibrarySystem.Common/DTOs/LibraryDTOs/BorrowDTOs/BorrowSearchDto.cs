using LibrarySystem.Common.DTOs.Library.Search;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem.Common.DTOs.Library.Borrows
{
    public class BorrowSearchDto : SearchBaseDto
    {
        public int? Number { get; set; }
        public int? UserId { get; set; }
        public int? BookCopyId { get; set; }
        public bool? Returned { get; set; }
    }
}
