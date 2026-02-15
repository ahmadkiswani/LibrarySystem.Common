namespace LibrarySystem.Common.DTOs.Library.Helpers
{
    /// <summary>
    /// Common paging metadata that can be embedded in responses.
    /// </summary>
    public class PagingInfoDto
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public long TotalCount { get; set; }
        public int TotalPages { get; set; }
        public bool HasNextPage { get; set; }
    }
}
