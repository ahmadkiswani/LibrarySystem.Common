using LibrarySystem.Common.Helpers;

namespace LibrarySystem.Common.DTOs.Library.Helpers
{
    /// <summary>Obsolete: use <see cref="AppHelper"/> instead.</summary>
    [Obsolete("Use AppHelper.NormalizePage and AppHelper.BuildPagingInfo instead.")]
    public static class PagingHelper
    {
        public static void Normalize(ref int page, ref int pageSize, int defaultPageSize = 10, int maxPageSize = 200)
            => AppHelper.NormalizePage(ref page, ref pageSize, defaultPageSize, maxPageSize);

        public static PagingInfoDto BuildInfo(long totalCount, int page, int pageSize)
            => AppHelper.BuildPagingInfo(totalCount, page, pageSize);
    }
}
