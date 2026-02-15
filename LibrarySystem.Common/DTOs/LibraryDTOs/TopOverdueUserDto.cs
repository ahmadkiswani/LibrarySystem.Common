namespace LibrarySystem.Common.DTOs.Library;

public class TopOverdueUserDto
{
    public int UserId { get; set; }
    public string UserName { get; set; } = "";
    public int OverdueCount { get; set; }
}
