namespace LibrarySystem.Common.DTOs.Library.Books;

/// <summary>
/// Paged book search result. Pagination is computed in LibraryManagement; consumers (e.g. Presentation) only display.
/// </summary>
public class BookSearchResultDto
{
    public List<BookListDto> Data { get; set; } = new();
    public int TotalCount { get; set; }
    public int Page { get; set; } = 1;
    public int PageSize { get; set; } = 10;
    public int TotalPages { get; set; }
    public bool HasNextPage { get; set; }
}
