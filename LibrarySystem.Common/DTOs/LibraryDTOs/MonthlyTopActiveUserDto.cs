namespace LibrarySystem.Common.DTOs.Library;

/// <summary>
/// Top active users per month (from Reporting Mongo).
/// </summary>
public class MonthlyTopActiveUserDto
{
    public string Month { get; set; } = string.Empty; // yyyy-MM
    public int UserId { get; set; }
    public string UserName { get; set; } = string.Empty;
    public int BorrowCount { get; set; }
}

