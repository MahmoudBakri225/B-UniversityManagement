using B_UniversityManagement.DTOs;
using B_UniversityManagement.Models;

namespace B_UniversityManagement.Services
{
    public class TransferStudent
    {
        public static StudentDTO TransferStudentToDto(Student student)
        {
            return new StudentDTO()
            {
                Id = student.Id,
                Fname = student.Fname,
                Lname = student.Lname,
                Gender = student.Gender,
                Email = student.Email,
                Phone = student.Phone,
                Address = student.Address,
                Password = student.Password,
                DateOfBirth = student.DateOfBirth,
                LevelYear = student.LevelYear
            };
        }

        public static List<StudentDTO> TransferListToDto(List<Student> students)
        {
            List<StudentDTO> studentDTOs = new List<StudentDTO>();
            foreach (var student in students)
            {
                var dto = TransferStudentToDto(student);
                studentDTOs.Add(dto);
            }
            return studentDTOs;
        }
        public static Student TransferDtoToStudent(StudentDTO studentDto)
        {
            return new Student()
            {
                Id = studentDto.Id,
                Fname = studentDto.Fname,
                Lname = studentDto.Lname,
                Gender = studentDto.Gender,
                Email = studentDto.Email,
                Phone = studentDto.Phone,
                Address = studentDto.Address,
                Password = studentDto.Password,
                DateOfBirth = studentDto.DateOfBirth,
                LevelYear = studentDto.LevelYear
            };
        }
    }
}
