using B_UniversityManagement.DTOs;
using B_UniversityManagement.Models;

namespace B_UniversityManagement.Services
{
    public class TransferLibrary
    {
        public static LibraryDTO TransferLibraryToDto(Library library)
        {
            return new LibraryDTO()
            {
                Id = library.Id,
                NoOfBooks = library.NoOfBooks
            };
        }

        public static List<LibraryDTO> TransferListToDto(List<Library> libraries)
        {
            List<LibraryDTO> libraryDTOs = new List<LibraryDTO>();
            foreach (var library in libraries)
            {
                var dto = TransferLibraryToDto(library);
                libraryDTOs.Add(dto);
            }
            return libraryDTOs;
        }

        public static Library TransferDtoToLibrary(LibraryDTO libraryDto)
        {
            return new Library()
            {
                Id = libraryDto.Id,
                NoOfBooks = libraryDto.NoOfBooks
            };
        }
    }
}
