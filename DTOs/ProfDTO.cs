using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace B_UniversityManagement.DTOs
{
    public class ProfDTO
    {
        [Key]
        public int Id { get; set; }

        [StringLength(255)]
        [Unicode(false)]
        public string? Fname { get; set; }

        [StringLength(255)]
        [Unicode(false)]
        public string? Lname { get; set; }

        [StringLength(10)]
        [Unicode(false)]
        public string? Gender { get; set; }

        [StringLength(255)]
        [Unicode(false)]
        public string? Email { get; set; }

        [StringLength(20)]
        [Unicode(false)]
        public string? Phone { get; set; }

        [StringLength(255)]
        [Unicode(false)]
        public string? Address { get; set; }

        [StringLength(20)]
        [Unicode(false)]
        public string? OfficeNumber { get; set; }

        [StringLength(255)]
        [Unicode(false)]
        public string? Password { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfBirth { get; set; }
    }
}
