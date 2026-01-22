using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem.Common.DTOs.Library.Books
{
    public class BookListDto
    {
        public int Id { get; set; }
        public string Title { get; set; }= string.Empty;    
        public string AuthorName { get; set; }= string.Empty;   
        public string? CategoryName { get; set; }
        public string? PublisherName { get; set; }
        public int TotalCopies { get; set; }
        public int AvailableCopies { get; set; }    



    }

}
