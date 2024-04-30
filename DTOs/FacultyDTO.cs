using System.ComponentModel.DataAnnotations;

namespace B_UniversityManagement.DTOs
{
    public class FacultyDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
    }
}

