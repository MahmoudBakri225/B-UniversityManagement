using B_UniversityManagement.DTOs;
using B_UniversityManagement.IRepository;
using B_UniversityManagement.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace B_UniversityManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepo bookRepo;

        public BookController(IBookRepo bookRepo)
        {
            this.bookRepo = bookRepo;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var books = bookRepo.GetAll();
            var bookDTOs = TransferBook.TransferListToDto(books);
            return Ok(bookDTOs);
        }

        [HttpPost]
        public IActionResult Create(BookDTO bookDTO)
        {
            if (ModelState.IsValid)
            {
                var book = TransferBook.TransferDtoToBook(bookDTO);
                bookRepo.Create(book);
                return Ok(bookDTO);
            }
            return BadRequest();
        }
    }
}
