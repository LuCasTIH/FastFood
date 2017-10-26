using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FF.Models
{
    public class MonAn
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Tên Món")]
        public string TenMon { get; set; }
        [Required]
        [Display(Name ="Đơn giá")]
        public double DonGia { get; set; }

        public string HinhAnh { get; set; }
    }
}