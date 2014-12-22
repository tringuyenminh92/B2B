/********************************************************************
	Interface file: 
    Author: Nguyen Minh Tri
    Date Created: 06/09/2014
	Last Updated: 06/09/2014
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
    public interface IDongiaView : IView
    {
        Guid? NhomKhachhangCurrentId { get; set; }
        List<DongiaModel> DongiaItems { get; set; }

        DongiaModel DongiaCurrent { get; }

        List<NhomKhachhangModel> NhomKhachhangItems { get; set; }

        NhomKhachhangModel NhomKhachhangCurrent { get; }

        List<HanghoaModel> HanghoaItems { get; set; }

        HanghoaModel HangHoaCurrent { get; }

        void RefreshDataNhomKhachhang();

        void RefreshDataHanghoa();

        Guid? HanghoaCurrentId { get; }
    }
}
