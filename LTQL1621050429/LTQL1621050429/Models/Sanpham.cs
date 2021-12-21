using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL1621050429.Models
{
    public class Sanpham
    {
        [Key]
        [StringLength(20)]
        public string Masanpham { get; set; }
        [StringLength (50)]
        public string Tensanpham { get; set; }
        //Manhacungcap la khoa phu
        public int Manhacungcap { get; set; }
        [ForeignKey("Manhacungcap")]
        public virtual Nhacungcap Nhacungcap { get; set; }
    }
}