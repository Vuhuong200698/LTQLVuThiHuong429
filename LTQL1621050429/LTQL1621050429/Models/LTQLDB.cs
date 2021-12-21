using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LTQL1621050429.Models
{
    public partial class LTQLDB : DbContext
    {
        public LTQLDB()
            : base("name=Model1")
        {
        }
        public DbSet<Nhacungcap> Nhacungcaps { get; set; }
        public DbSet<Sanpham> Sanphams { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
