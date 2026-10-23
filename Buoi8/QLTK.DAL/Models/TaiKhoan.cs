using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QLTK.DAL.Models
{
    public class TaiKhoan
    {
        [Key]
        [Column(TypeName = "nvarchar(10)")]
        [MaxLength(10)]
        public string STK { get; set; }

        [Required]
        [MaxLength(150)]
        public string TenNH { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,0)")]
        public decimal SoDuDauKy { get; set; }

        // Navigation property phía 1
        public virtual ICollection<GiaoDich> GiaoDiches { get; set; }
    }
}
