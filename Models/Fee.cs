using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace B_UniversityManagement.Models;

public partial class Fee
{
    [Key]
    [Column("FeeID")]
    public int FeeId { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? FeeType { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Amount { get; set; }

    [Column(TypeName = "date")]
    public DateTime? PaymentDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("student_id")]
    public int? StudentId { get; set; }

    [ForeignKey("StudentId")]
    [InverseProperty("Fees")]
    public virtual Student? Student { get; set; }
}
