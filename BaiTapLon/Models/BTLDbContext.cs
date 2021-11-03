using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BaiTapLon.Models
{
    public partial class BTLDbContext : DbContext
    {
        public BTLDbContext()
            : base("name=BTLDbContext")
        {
        }

        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<DanhMucHang> DanhMucHangs { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public System.Data.Entity.DbSet<BaiTapLon.Models.DonHang> DonHangs { get; set; }

        public System.Data.Entity.DbSet<BaiTapLon.Models.ChiTietDonHang> ChiTietDonHangs { get; set; }
    }
}
