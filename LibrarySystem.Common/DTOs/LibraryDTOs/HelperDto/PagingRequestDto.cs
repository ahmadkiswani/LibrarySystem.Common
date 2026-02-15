namespace LibrarySystem.Common.DTOs.Library.Helpers
{
    /// <summary>
    /// Standard paging request used across services.
    /// </summary>
    public class PagingRequestDto
    {
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }
}
