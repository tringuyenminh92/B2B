/********************************************************************
	Interface file: 
    Author: Tran Nguyen Hoang Khuyen
    Date Created: 13/09/2014
	Last Updated: 13/09/2014
	Updated By: Tran Nguyen Hoang Khuyen
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
    public interface IBaogiaView : IView
    {
        List<HanghoaModel> BaogiaItems { get; set; }
        List<KhachhangModel> KhachhangItems { get; set; }
        KhachhangModel KhachhangCurrent { get; }
        void RefreshDataKhachhang(); 

    }
}
