using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Model
{
    public partial class DonhangModel
    {
        public string TenNhanvienLap { get; set; }

        public string TenNhanvienCapnhat { get; set; }

        public string TenKhachhang { get; set; }
        public string TenKho { get; set; }

        public string TenLoaiDonhang
        {
            get { return LoaiDonhangModel.GetTenLoaiDonhang(LoaiDonhang.Value); }
        }

        public List<ChitietDonhangModel> ChitietDonhangItems { get; set; }

    }
}
