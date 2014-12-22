
using B2B.Model;
using BMIModel;
/********************************************************************
	Interface file: 
    Author: Pham Xuân Vinh
    Date Created: 05/09/2014
	Last Updated: 05/09/2014
	Updated By: Pham Xuân Vinh
	Update Description:
*********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.View
{
    public interface IHanghoaDetailView :IView
    {
        List<NhomHanghoaModel> NhomHanghoaItems { get; set; }
        NhomHanghoaModel NhomHanghoaCurrent { get; }

        List<DonviModel> DonviItems { get; set; }
        DonviModel DonviCurrent { get; }

        void RefreshDataNhomHanghoa();
        void RefreshDataDonvi();

        HanghoaModel Value { get; set; }
    }
}
