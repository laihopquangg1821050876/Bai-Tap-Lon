using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BaiTapLon.Models
{
    [Table("DonHangs")]
    public class DonHang
    {
        [Key]
        public int DonHangID { get; set; }
        public string MaKH { get; set; }
        public DateTime CreateDate { get; set; }
        public string MaNV { get; set; }
    }
}