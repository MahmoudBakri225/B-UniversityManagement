using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace B_UniversityManagement.Models;

[Table("Faculty")]
public partial class Faculty
{
    [Key]
    public int Id { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("Library_id")]
    public int? LibraryId { get; set; }

    [InverseProperty("Faculty")]
    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();

    [InverseProperty("Faculty")]
    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    [ForeignKey("LibraryId")]
    [InverseProperty("Faculties")]
    public virtual Library? Library { get; set; }

    [InverseProperty("Faculty")]
    public virtual ICollection<ProfessorFaculty> ProfessorFaculties { get; set; } = new List<ProfessorFaculty>();
}
