using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace B_UniversityManagement.Models;

public partial class Course
{
    [Key]
    public int Id { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CourseCode { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("Dept_id")]
    public int? DeptId { get; set; }

    [ForeignKey("DeptId")]
    [InverseProperty("Courses")]
    public virtual Department? Dept { get; set; }

    [InverseProperty("Course")]
    public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();

    [ForeignKey("CourseId")]
    [InverseProperty("Courses")]
    public virtual ICollection<Prof> Professors { get; set; } = new List<Prof>();
}
