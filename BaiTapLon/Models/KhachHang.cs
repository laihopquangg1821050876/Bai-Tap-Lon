using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTapLon.Models
{
    [Table("KhachHangs")]
    public class KhachHang
    {
        [Key]
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        [AllowHtml]
        public string DiachiKH { get; set; }
    }
}