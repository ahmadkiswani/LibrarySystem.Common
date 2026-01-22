using System.ComponentModel.DataAnnotations;


namespace LibrarySystem.Common.DTOs.Library.Authors
{
    public class AuthorCreateDto
    {
        [Required(ErrorMessage = "Author name is required")]
        [StringLength(60, MinimumLength = 3)]
        public string AuthorName { get; set; } = string.Empty;
    }
}
