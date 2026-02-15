using LibrarySystem.Common.DTOs.Library.Search;

namespace LibrarySystem.Common.DTOs.Library.Users;

public class UserSearchDto : SearchBaseDto
{
    public int? Number { get; set; }
    /// <summary>Filter by status: "active" (IsDeleted=false), "deactivated" (IsDeleted=true), or null for all.</summary>
    public string? Status { get; set; }
}
