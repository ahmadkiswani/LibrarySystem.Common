using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Common.DTOs.Library.Authors

{
    public class AuthorDetailsDto
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string AuthorName { get; set; } = string.Empty;
        public int BooksCount { get; set; }
    }
}
