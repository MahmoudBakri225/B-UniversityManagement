using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace B_UniversityManagement.Models;

[Table("Student")]
public partial class Student
{
    [Key]
    public int Id { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Fname { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Lname { get; set; }

    public bool Gender { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Email { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Phone { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Address { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Password { get; set; }

    [Column(TypeName = "date")]
    public DateTime? DateOfBirth { get; set; }

    public int? LevelYear { get; set; }

    [Column("Dept_id")]
    public int? DeptId { get; set; }

    [ForeignKey("DeptId")]
    [InverseProperty("Students")]
    public virtual Department? Dept { get; set; }

    [InverseProperty("Student")]
    public virtual ICollection<Fee> Fees { get; set; } = new List<Fee>();

    [InverseProperty("Student")]
    public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();

    [ForeignKey("StudentId")]
    [InverseProperty("Students")]
    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
