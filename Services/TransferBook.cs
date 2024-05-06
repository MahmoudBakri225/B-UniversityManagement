using B_UniversityManagement.DTOs;
using B_UniversityManagement.Models;

namespace B_UniversityManagement.Services
{
    public class TransferBook
    {
        public static BookDTO TransferBookToDto(Book book)
        {
            return new BookDTO()
            {
                Id = book.Id,
                Name = book.Name,
                Author = book.Author,
                PublicationYear = book.PublicationYear
            };
        }

        public static List<BookDTO> TransferListToDto(List<Book> books)
        {
            List<BookDTO> bookDTOs = new List<BookDTO>();
            foreach (var book in books)
            {
                var dto = TransferBookToDto(book);
                bookDTOs.Add(dto);
            }
            return bookDTOs;
        }

        public static Book TransferDtoToBook(BookDTO bookDto)
        {
            return new Book()
            {
                Id = bookDto.Id,
                Name = bookDto.Name,
                Author = bookDto.Author,
                PublicationYear = bookDto.PublicationYear
            };
        }
    }
}
