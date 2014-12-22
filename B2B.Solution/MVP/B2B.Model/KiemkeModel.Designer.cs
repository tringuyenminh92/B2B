using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Model
{
    public partial class KiemkeModel
    {
        public string TenNhanvien { get; set; }
        public string TenKho { get; set; }
        public List<ChitietKiemkeModel> ListChitietKiemke { get; set; }
    }
}
