using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BaiTapLon.Models
{
    [Table("Chitietdonhang")]
    public class ChiTietDonHang:DonHang
    {
        [Key] 
        public string MaHang { get; set; }
        public string DonGia{ get; set; }
        public string SoLuong { get; set; }
        public string ThanhTien { get; set; }
    }
}