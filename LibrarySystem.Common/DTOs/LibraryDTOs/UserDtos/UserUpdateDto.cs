using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Common.DTOs.Library.Users
{
    public class UserUpdateDto
    {
        

        [Required]
        [StringLength(40, MinimumLength = 2)]
        public string UserName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [StringLength(120)]
        public string UserEmail { get; set; } = string.Empty;
        public string? RoleName { get; set; }
    }

}
