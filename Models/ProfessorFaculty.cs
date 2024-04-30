using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace B_UniversityManagement.Models;

[PrimaryKey("ProfessorId", "FacultyId")]
[Table("Professor_Faculty")]
public partial class ProfessorFaculty
{
    [Key]
    [Column("Professor_ID")]
    public int ProfessorId { get; set; }

    [Column("start_date", TypeName = "date")]
    public DateTime? StartDate { get; set; }

    [Column("end_date", TypeName = "date")]
    public DateTime? EndDate { get; set; }

    [Key]
    [Column("Faculty_ID")]
    public int FacultyId { get; set; }

    [ForeignKey("FacultyId")]
    [InverseProperty("ProfessorFaculties")]
    public virtual Faculty Faculty { get; set; } = null!;

    [ForeignKey("ProfessorId")]
    [InverseProperty("ProfessorFaculties")]
    public virtual Prof Professor { get; set; } = null!;
}
