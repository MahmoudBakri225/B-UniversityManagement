using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace B_UniversityManagement.DTOs
{
    public class FeeDTO
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
    }
}
