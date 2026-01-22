using System.ComponentModel.DataAnnotations;
namespace LibrarySystem.Common.DTOs.Library.Authors
{
    public class AuthorListDto
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string AuthorName { get; set; }= string.Empty;   
    }
}

