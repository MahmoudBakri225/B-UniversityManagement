using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace B_UniversityManagement.DTOs
{
    public class BookDTO
    {
        [Key]
        public int Id { get; set; }

        [StringLength(255)]
        [Unicode(false)]
        public string? Name { get; set; }

        [StringLength(255)]
        [Unicode(false)]
        public string? Author { get; set; }

        public int? PublicationYear { get; set; }
    }
}
