namespace LibrarySystem.Common.DTOs.Library.Books
{
    public class BookSearchDto
    {
        public string? Title { get; set; } 
        public int? AuthorId { get; set; } 
        public int? CategoryId { get; set; } 
        public int? PublisherId { get; set; }
        public int? Page { get; set; }
        public int? PageSize { get; set; } 



    }

}
