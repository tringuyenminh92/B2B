/***********************************
Author: Lý Hoàng Tín
Date Created: 15/09/2014
Last Updated: 16/09/2014
Updated By: Lý Hoàng Tín
Update description: 
************************************/
using System;
using System.Collections.Generic;
using B2B.Model;
using BMIModel;

namespace B2B.View
{
    public interface IPhieunhapView:IView
    {
        List<PhieunhapModel> PhieunhapItems { get; set; }
        void RefreshDataNhacungcap();

        //List<KhoModel> KhoItems { get; set; }

        void RefreshDataKho();
        PhieunhapModel PhieunhapCurrent { get;}
        DateTime filterValue { get; set; }
        NhanvienModel NhanvienCapnhat { get; set; }
    }
}
