using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace B_UniversityManagement.Models;

public partial class Book
{
    [Key]
    public int Id { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Author { get; set; }

    public int? PublicationYear { get; set; }

    [Column("Library_id")]
    public int? LibraryId { get; set; }

    [ForeignKey("LibraryId")]
    [InverseProperty("Books")]
    public virtual Library? Library { get; set; }

    [ForeignKey("BookId")]
    [InverseProperty("Books")]
    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
