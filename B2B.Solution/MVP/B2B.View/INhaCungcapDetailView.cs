/********************************************************************
	Interface file: 
    Author: Nguyen Minh Tri
    Date Created: 
	Last Updated: 
	Updated By: Nguyen Minh Tri
	Update Description: 
*********************************************************************/

using B2B.Model;
using BMIModel;
using System.Collections.Generic;

namespace B2B.View
{
    public interface INhaCungcapDetailView:IView
    {
        List<TinhthanhModel> TinhthanhItems { get; set; }

        TinhthanhModel TinhthanhCurrent { get; }

        List<QuanhuyenModel> QuanhuyenItems { get; set; }

        NhaCungcapModel NhaCungcapCurrent { get; set; }
        void RefreshDataQuanhuyen();



    }
}
