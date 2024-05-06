using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace B_UniversityManagement.DTOs
{
    public class EmployeeDTO
    {
        [Key]
        public int Id { get; set; }

        [Column("FName")]
        [StringLength(255)]
        [Unicode(false)]
        public string? Fname { get; set; }

        [Column("LName")]
        [StringLength(255)]
        [Unicode(false)]
        public string? Lname { get; set; }

        [StringLength(255)]
        [Unicode(false)]
        public string? Address { get; set; }

        [StringLength(20)]
        [Unicode(false)]
        public string? Phone { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal? Salary { get; set; }

        [StringLength(255)]
        [Unicode(false)]
        public string? Email { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfBirth { get; set; }

        [StringLength(255)]
        [Unicode(false)]
        public string? Password { get; set; }
    }
}
