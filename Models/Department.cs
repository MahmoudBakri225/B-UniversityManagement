using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace B_UniversityManagement.Models;

[Table("Department")]
public partial class Department
{
    [Key]
    public int Id { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Description { get; set; }

    public int? FacultyId { get; set; }

    [InverseProperty("Dept")]
    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

    [ForeignKey("FacultyId")]
    [InverseProperty("Departments")]
    public virtual Faculty? Faculty { get; set; }

    [InverseProperty("Dept")]
    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
