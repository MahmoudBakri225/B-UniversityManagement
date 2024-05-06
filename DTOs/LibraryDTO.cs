using System.ComponentModel.DataAnnotations;

namespace B_UniversityManagement.DTOs
{
    public class LibraryDTO
    {
        [Key]
        public int Id { get; set; }

        public int? NoOfBooks { get; set; }
    }
}
