/********************************************************************
	Interface file: 
    Author: Nguyen Minh Tri
    Date Created: 11/09/2014
	Last Updated: 11/09/2014
	Updated By: Nguyen Minh Tri
	Update Description: Update Comments
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
    public interface IKhuvucTinhthanhView:IView
    {
        List<KhuvucModel> KhuvucItems { get; set; }
        KhuvucModel KhuvucCurrent { get; }

        List<TinhthanhModel> TinhthanhItems { get; set; }
        TinhthanhModel TinhthanhCurrent { get; }

        void RefreshDataKhuvuc();

        void RefreshDataTinhthanh();
    }
}
