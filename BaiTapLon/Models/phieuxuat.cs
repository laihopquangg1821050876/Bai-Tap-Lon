﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BaiTapLon.Models
{
    [Table("phieuxuat")]
    public class phieuxuat
    {
        [Key]
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string DonHangID { get; set; }
        public string TenHang { get; set; }
        public int Soluong { get; set; }
        public string thanhtien { get; set; }
        public DateTime Ngaytao { get; set; }
        public virtual DonHang DonHangs { get; set; }
    }
}