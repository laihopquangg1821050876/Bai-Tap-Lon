using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTapLon.Models
{
    public class ChiTietDonHang:DonHang
    {
        public string MaHang { get; set; }
        public string DonGia{ get; set; }
        public string SoLuong { get; set; }
        public string ThanhTien { get; set; }
    }
}