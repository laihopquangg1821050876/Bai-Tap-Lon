using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BaiTapLon.Models
{
    [Table("ChiTietDonHangs")]
    public class ChiTietDonHang
    {
        [Key]
        public int ChiTietDonHangID { get; set; }
        public int DonHangID { get; set; }
        //Ma san pham, so luong....
    }
}