using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace B_UniversityManagement.Models;

[PrimaryKey("StudentId", "CourseId")]
[Table("Student_Course")]
public partial class StudentCourse
{
    [Key]
    [Column("Student_id")]
    public int StudentId { get; set; }

    [Key]
    [Column("Course_id")]
    public int CourseId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Degree { get; set; }

    public int? Year { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Semester { get; set; }

    [ForeignKey("CourseId")]
    [InverseProperty("StudentCourses")]
    public virtual Course Course { get; set; } = null!;

    [ForeignKey("StudentId")]
    [InverseProperty("StudentCourses")]
    public virtual Student Student { get; set; } = null!;
}
