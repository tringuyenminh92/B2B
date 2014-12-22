/********************************************************************
	Interface file: 
    Author: Nguyen Minh Tri
    Date Created: 14/09/2014
	Last Updated: 14/09/2014
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
    public interface IKhachhangDetailView:IView
    {
        List<QuanhuyenModel> QuanhuyenItems { get; set; }

        QuanhuyenModel QuanhuyenCurrent { get; }

        List<TinhthanhModel> TinhthanhItems { get; set; }

        TinhthanhModel TinhthanhCurrent { get; }

        List<NhomKhachhangModel> NhomKhachhangItems { get; set; }

        void RefreshDataNhomKhachhang();

        void RefreshDataQuanhuyen();

        void RefreshDataTinhthanh();

        KhachhangModel Value { get; set; }

    }
}
