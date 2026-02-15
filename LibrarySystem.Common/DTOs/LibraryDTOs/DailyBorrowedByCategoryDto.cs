namespace LibrarySystem.Common.DTOs.Library;

/// <summary>
/// Borrow counts per category for a specific day (from Reporting Mongo).
/// </summary>
public class DailyBorrowedByCategoryDto
{
    public string Date { get; set; } = string.Empty; // yyyy-MM-dd
    public int CategoryId { get; set; }
    public string CategoryName { get; set; } = string.Empty;
    public int BorrowCount { get; set; }
}

