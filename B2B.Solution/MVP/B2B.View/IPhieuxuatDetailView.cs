/********************************************************************
	Class file: 
    Author: Pham Xuan Vinh
    Date Created: 23/09/2014
	Last Updated: 04/11/2014
	Updated By: Tran Nguyen Hoang Khuyen
	Update Description: Pham Xuan Vinh
*********************************************************************/
using B2B.Model;
using BMIModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.View
{
    public interface IPhieuxuatDetailView:IView
    {
        List<KhoModel> KhoItems { get; set; }
        KhoModel KhoCurent { get; }
        List<NhanvienModel> NhanvienGiaohangItems { get; set; }
        NhanvienModel NhanvienGiaohangCurrent { get; }
        List<TinhtrangModel> TinhtrangItems { get; set; }
        TinhtrangModel TinhtrangCurrent { get; }
        List<NguyennhanLydoModel> NguyennhanLydoItems { get; set; }
        NguyennhanLydoModel NguyennhanLydoCurrent { get; }
        //TinhtrangPhieuxuatModel TinhtrangPhieuxuatMoinhat { get; set; }
        PhieuxuatModel ValuePhieuxuat { get; set; }
        //List<int?> LstSoluongXuatBandau { get; set; }
        //Guid? TinhtrangIdBandau { get; set; }
    }
}
