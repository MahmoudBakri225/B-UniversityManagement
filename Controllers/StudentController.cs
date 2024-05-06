using B_UniversityManagement.DTOs;
using B_UniversityManagement.IRepository;
using B_UniversityManagement.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace B_UniversityManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepo studentRepo;

        public StudentController(IStudentRepo studentRepo)
        {
            this.studentRepo = studentRepo;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var students = studentRepo.GetAll();
            var studentDTOs = TransferStudent.TransferListToDto(students);
            return Ok(studentDTOs);
        }

        [HttpPost]
        public IActionResult Create(StudentDTO studentDTO)
        {
            if (ModelState.IsValid)
            {
                var student = TransferStudent.TransferDtoToStudent(studentDTO);
                studentRepo.Create(student);
                return Ok(studentDTO);
            }
            return BadRequest();
        }
    }
}
