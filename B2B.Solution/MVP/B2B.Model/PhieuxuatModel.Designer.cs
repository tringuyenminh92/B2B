/********************************************************************
	Class file: 
    Author: Tran Nguyen Hoang Khuyen
    Date Created: 23/09/2014
	Last Updated: 23/10/2014
	Updated By: Tran Nguyen Hoang Khuyen
	Update Description:
*********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Model
{
    public partial class PhieuxuatModel
    {
        public string TenNhanvienLap { get; set; }
        public string TenKho { get; set; }
        public string TenNhanvienGiaohang { get; set; }
        //public List<TinhtrangPhieuxuatModel> TinhtrangPhieuxuatItems { get; set; }
        //public TinhtrangPhieuxuatModel TinhtrangPhieuxuatCurrent { get; set; }
        //public Guid? TinhtrangPhieuxuatCurrentId
        //{
        //    get { return TinhtrangPhieuxuatCurrent.TinhtrangId; }
        //    set { TinhtrangPhieuxuatCurrent.TinhtrangId = value; }
        //}
        public List<ChitietPhieuxuatModel> ChitietPhieuxuatItems { get; set; }
        public List<TonkhoModel> TonkhoItems { get; set; }
        public Guid NhanvienCapnhatId { get; set; }
        public string TenNhanvienCapnhat { get; set; }
        public DateTime? NgaylapDonhang { get; set; }
        public string CodeDonhang { get; set; }
        public string TenNguyennhanLydo { get; set; }
        public DonhangModel Donhang { get; set; }
        public CongnoXuatModel CongnoXuat { get; set; }
    }
}
