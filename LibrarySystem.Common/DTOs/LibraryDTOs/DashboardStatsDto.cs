namespace LibrarySystem.Common.DTOs.Library
{
    public class DashboardStatsDto
    {
        public int TotalBooks { get; set; }
        public int ActiveUsers { get; set; }
        public int BorrowedToday { get; set; }
        public int Overdue { get; set; }
    }
}
