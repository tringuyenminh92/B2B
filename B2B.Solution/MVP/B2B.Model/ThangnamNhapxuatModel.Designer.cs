using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Model
{
    public partial class ThangnamNhapxuatModel
    {
        public string Thogian { get { return onNgay + "/" + inMonth + "/" + inYear; } }
    }
}
