using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace B_UniversityManagement.Models;

[Table("Prof")]
public partial class Prof
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

    [InverseProperty("Professor")]
    public virtual ICollection<ProfessorFaculty> ProfessorFaculties { get; set; } = new List<ProfessorFaculty>();

    [ForeignKey("ProfessorId")]
    [InverseProperty("Professors")]
    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
