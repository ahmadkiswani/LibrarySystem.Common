using System.ComponentModel.DataAnnotations;
namespace LibrarySystem.Common.DTOs.Library.Authors
{
    public class AuthorUpdateDto
    {
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string AuthorName { get; set; }= string.Empty;   
        public int Id { get; set; }

    }
}
