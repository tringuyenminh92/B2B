using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Model
{
    public partial class HanghoaModel
    {
        public string TenNhomhanghoa { get; set; }
        public string TenDonVi { get; set; }
        public double? Dongia { get; set; }
        public double? GiaHienthi
        {
            get
            {
                if (Dongia == null)
                {
                    return Giagoc;
                }
                return Dongia;
            }
            set { Dongia = value; }
        }

        public int SoluongTonHienthi { get; set; }

        public int SoluongKhachmua { get; set; }

        public float? TiengiamHienthi { get; set; }

        public float? PhantramVAT { get; set; }

        public float? PhantramGiam { get; set; }
        public bool ChonBaogia { get; set; }
    }
}
