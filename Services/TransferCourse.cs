using B_UniversityManagement.DTOs;
using B_UniversityManagement.Models;

namespace B_UniversityManagement.Services
{
    public class TransferCourse
    {
        public static CourseDTO TransferCourseToDto(Course course)
        {
            return new CourseDTO()
            {
                Id = course.Id,
                Name = course.Name,
                CourseCode = course.CourseCode,
                Description = course.Description
            };
        }

        public static List<CourseDTO> TransferListToDto(List<Course> courses)
        {
            List<CourseDTO> courseDTOs = new List<CourseDTO>();
            foreach (var course in courses)
            {
                var dto = TransferCourseToDto(course);
                courseDTOs.Add(dto);
            }
            return courseDTOs;
        }

        public static Course TransferDtoToCourse(CourseDTO courseDto)
        {
            return new Course()
            {
                Id = courseDto.Id,
                Name = courseDto.Name,
                CourseCode = courseDto.CourseCode,
                Description = courseDto.Description
            };
        }
    }
}
