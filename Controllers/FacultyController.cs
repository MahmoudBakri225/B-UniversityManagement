using B_UniversityManagement.DTOs;
using B_UniversityManagement.IRepository;
using B_UniversityManagement.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace B_UniversityManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollegeController : ControllerBase
    {
        private readonly IFacultyRepo facultyRepo;

        public CollegeController(IFacultyRepo facultyRepo)
        {
            this.facultyRepo = facultyRepo;
        }
        [HttpGet]
        [EnableCors("MyAllowSpecificOrigins")]
        public IActionResult GetAll()
        {
            var faculties = facultyRepo.GetAll();
            var facultyDtos = TransferFaculty.TransferListToDto(faculties);
            return Ok(facultyDtos);
        }

        [HttpPost]
        public IActionResult Create(FacultyDTO facultyDTO)
        {
            if (ModelState.IsValid)
            {
                var faculty = TransferFaculty.TransferDtoToCollege(facultyDTO);
                facultyRepo.Create(faculty);
                return Ok(facultyDTO);
            }
            return BadRequest();
        }

    }
}
