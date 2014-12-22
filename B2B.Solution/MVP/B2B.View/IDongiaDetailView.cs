/***********************************
Author: Lý Hoàng Tín
Date Created: 09/09/2014
Last Updated: 11/09/2014
Updated By: Lý Hoàng Tín
Update description: 
************************************/
using System;
using BMIModel;
using B2B.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.View
{
    public interface IDongiaDetailView:IView
    {

        List<HanghoaModel> HanghoaItems { get; set; }

        List<NhomKhachhangModel> NhomKhachhangItems { get; set; }

        void RefreshDataNhomKhachhang();
    }
}
