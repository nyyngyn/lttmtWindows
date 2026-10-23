using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QLTK.DAL.Models
{
    public class GiaoDich
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int SoTien { get; set; }

        [MaxLength(255)]
        public string NoiDung { get; set; }

        [Required]
        [MaxLength(10)]
        [Column(TypeName = "nvarchar(10)")]
        public string STK { get; set; }

        [ForeignKey("STK")]
        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
