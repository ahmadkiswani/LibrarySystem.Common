using System.Collections.Generic;
using LibrarySystem.Common.DTOs.Library.Authors;
using LibrarySystem.Common.DTOs.Library.Categories;
using LibrarySystem.Common.DTOs.Library.Publishers;

namespace LibrarySystem.Common.DTOs.Library.Books
{
    public class BookCreateDropdownsDto
    {
        public List<CategoryListDto> Categories { get; set; } = new();
        public List<AuthorListDto> Authors { get; set; } = new();
        public List<PublisherListDto> Publishers { get; set; } = new();
    }
}

