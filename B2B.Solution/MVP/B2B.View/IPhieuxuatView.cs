
/********************************************************************
	Interface file: 
    Author: Tran Nguyen Hoang Khuyen
    Date Created: 23/09/2014
	Last Updated: 14/10/2014
	Updated By: Tran Nguyen Hoang Khuyen
	Update Description:
*********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMIModel;
using B2B.Model;

namespace B2B.View
{
    public interface IPhieuxuatView : IView
    {
        List<PhieuxuatModel> PhieuxuatItems { get; set; }
        PhieuxuatModel PhieuxuatCurrent { get; }
        List<DonhangModel> DonhangItems { get; set; }
        DonhangModel DonhangCurrent { get; }
        NhanvienModel NhanvienCapNhat { get; set; }
        void RefreshDataDonhang();
        DateTime filterValue { get; }
    }
}
