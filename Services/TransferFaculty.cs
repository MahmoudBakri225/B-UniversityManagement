using B_UniversityManagement.DTOs;
using B_UniversityManagement.Models;

namespace B_UniversityManagement.Services
{
    public static class TransferFaculty
    {

        public static FacultyDTO TransferCollegeToDto(Faculty faculty)
        {
            return new FacultyDTO()
            {
                Name = faculty.Name,
                Description = faculty.Description
            };
        }

        public static List<FacultyDTO> TransferListToDto(List<Faculty> faculties)
        {
            List<FacultyDTO> facultyDTOs = new List<FacultyDTO>();
            foreach (var faculty in faculties)
            {
                var dto = TransferCollegeToDto(faculty);
                facultyDTOs.Add(dto);
            }
            return facultyDTOs;
        }


        public static Faculty TransferDtoToCollege(FacultyDTO facultyDto)
        {
            return new Faculty()
            {
                Name = facultyDto.Name,
                Description = facultyDto.Description
            };
        }
    }
}
