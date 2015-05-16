using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace B2B.Model
{
    public partial class PhieunhapModel
    {
        public string TenNhanvien { set; get; }
        public string TenKho {set;get; }
        public string TenNhaCungcap { set; get; }
        public string TenTinhtrang { set; get; }
        public string Noidung { get; set; }
        public List<ChitietPhieunhapModel> ListChitietPhieuNhap{set;get;}
        public List<TinhtrangPhieunhapModel> ListTinhtrangPhieunhap { set; get; }
    }
}
