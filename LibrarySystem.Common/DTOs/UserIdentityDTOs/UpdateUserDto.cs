using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Common.DTOs.UserIdentity.Auth
{
    public class UpdateUserDto
    {
        [Required]
        public int UserId { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 2)]
        public string UserName { get; set; } = string.Empty;

        [Required, EmailAddress]
        [StringLength(120)]
        public string Email { get; set; } = string.Empty;

        public string? Role { get; set; }
    }
}
