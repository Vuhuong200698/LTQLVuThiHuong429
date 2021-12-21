using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LTQL1621050429.Models
{
    public class Nhacungcap
    {
        [Key]
        public int MaNhaCungCap { get; set; }
        [StringLength(50)]
        public string Tennhacungcap { get; set; }
        public ICollection<Sanpham> Sanphams { get; set; }

    }
}