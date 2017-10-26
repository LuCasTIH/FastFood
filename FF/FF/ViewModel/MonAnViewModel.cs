
using FF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FF.ViewModel
{
    public class MonAnViewModel
    {
        public string TenMon { get; set; }
        public double DonGia { get; set; }
        public string HinhAnh { get; set; }
        public IEnumerable<MonAn> MonAns { get; set; }

    }
}