using B_UniversityManagement.DTOs;
using B_UniversityManagement.IRepository;
using B_UniversityManagement.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace B_UniversityManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private readonly ILibraryRepo libraryRepo;

        public LibraryController(ILibraryRepo libraryRepo)
        {
            this.libraryRepo = libraryRepo;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var libraries = libraryRepo.GetAll();
            var libraryDTOs = TransferLibrary.TransferListToDto(libraries);
            return Ok(libraryDTOs);
        }

        [HttpPost]
        public IActionResult Create(LibraryDTO libraryDTO)
        {
            if (ModelState.IsValid)
            {
                var library = TransferLibrary.TransferDtoToLibrary(libraryDTO);
                libraryRepo.Create(library);
                return Ok(libraryDTO);
            }
            return BadRequest();
        }
    }
}
