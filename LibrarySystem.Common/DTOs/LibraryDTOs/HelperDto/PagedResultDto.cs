namespace LibrarySystem.Common.DTOs.Library.Helpers;

/// <summary>
/// Generic paged result for Author, Publisher, Category, User and other list endpoints.
/// </summary>
public class PagedResultDto<T>
{
    public List<T> Data { get; set; } = new();
    public int TotalCount { get; set; }
    public int Page { get; set; } = 1;
    public int PageSize { get; set; } = 10;
    public int TotalPages { get; set; }
    public bool HasNextPage { get; set; }
}
