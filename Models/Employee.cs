using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace B_UniversityManagement.Models;

[Table("Employee")]
public partial class Employee
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

    public int? FacultyId { get; set; }

    [ForeignKey("FacultyId")]
    [InverseProperty("Employees")]
    public virtual Faculty? Faculty { get; set; }
}
