using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BaiTapLon.Models
{
    [Table("Donhang")]
    public class DonHang:KhachHang
    {
        [Key]
        public string MaDH { get; set; }
        [Column(TypeName = "date")]
        public DateTime Ngaytao { get; set; }
        public string MaNV { get; set; }
        public string TenSP { get; set; }
        public string GiaSP {get; set; }

    }
}