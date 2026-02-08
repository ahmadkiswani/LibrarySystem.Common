


namespace LibrarySystem.Common.DTOs.Library.Users
{
    public class UserDetailsDto
    {
        public int Id { get; set; }
        public int ExternalUserId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string UserEmail { get; set; } = string.Empty;
        public string? RoleName { get; set; }
    }
}