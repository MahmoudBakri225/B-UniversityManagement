using B_UniversityManagement.DTOs;
using B_UniversityManagement.IRepository;
using B_UniversityManagement.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace B_UniversityManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseRepo courseRepo;

        public CourseController(ICourseRepo courseRepo)
        {
            this.courseRepo = courseRepo;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var courses = courseRepo.GetAll();
            var courseDTOs = TransferCourse.TransferListToDto(courses);
            return Ok(courseDTOs);
        }

        [HttpPost]
        public IActionResult Create(CourseDTO courseDTO)
        {
            if (ModelState.IsValid)
            {
                var course = TransferCourse.TransferDtoToCourse(courseDTO);
                courseRepo.Create(course);
                return Ok(courseDTO);
            }
            return BadRequest();
        }
    }
}
