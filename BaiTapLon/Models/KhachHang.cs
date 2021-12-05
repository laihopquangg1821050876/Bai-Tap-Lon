﻿using System;
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
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number Required!")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                      ErrorMessage = "Entered phone format is not valid.")]
        public string SoDT { get; set; }
    }
}