using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace B_UniversityManagement.Models;

[Table("Library")]
public partial class Library
{
    [Key]
    public int Id { get; set; }

    public int? NoOfBooks { get; set; }

    [InverseProperty("Library")]
    public virtual ICollection<Book> Books { get; set; } = new List<Book>();

    [InverseProperty("Library")]
    public virtual ICollection<Faculty> Faculties { get; set; } = new List<Faculty>();
}
