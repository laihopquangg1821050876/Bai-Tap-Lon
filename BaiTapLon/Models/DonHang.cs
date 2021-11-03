using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTapLon.Models
{
    public class DonHang:KhachHang
    {
        public string MaDH { get; set; }
        public string Ngay { get; set; }
        public string MaNV { get; set; }
    }
}