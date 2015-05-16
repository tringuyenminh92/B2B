using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Model
{
    public partial class ThuchiModel
    {
        public string TenNhanvien { get; set; }
        public string LoaiThuchi 
        {
            get 
            {
                if (PhieuxuatId != null && Step == 1)
                    return "Phiếu thu";
                else if (PhieunhapId != null && Step == 2)
                    return "Phiếu chi";
                else if (Step == 1)
                    return "Thu khác";
                else if (Step == 2)
                    return "Chi khác";
                else return null;
            } 
        }
        public string VaolucGio 
        { 
            get 
            {
                return Vaoluc.Value.TimeOfDay.ToString();
            } 
        }
    }
}
