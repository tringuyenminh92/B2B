/********************************************************************
	Interface file: 
    Author: Nguyen Minh Tri
    Date Created: 24/08/2014
	Last Updated: 24/08/2014
	Updated By: Nguyen Minh Tri
	Update Description: 
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
    public interface IKhoDetailView:IView
    {
        List<TinhthanhModel> TinhthanhItems { get; set; }

        TinhthanhModel TinhthanhCurrent { get; }

        List<QuanhuyenModel> QuanhuyenItems { get; set; }

        KhoModel Value { get; set; }
        void RefreshDataQuanhuyen();
    }
}
