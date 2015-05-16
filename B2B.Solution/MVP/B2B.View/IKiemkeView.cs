/***********************************
Author: Lý Hoàng Tín
Date Created: 09/01/2014
Last Updated: 14/01/2014
Updated By: Lý Hoàng Tín
Update description: 
************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMIModel;
using B2B.Model;

namespace B2B.View
{
    public interface IKiemkeView:IView
    {

        void RefreshKiemke();

        List<Model.KiemkeModel> KiemkeItems { get; set; }
        KiemkeModel KiemkeCurrent { get; }
        List<Model.ChitietKiemkeModel> ChitietKiemkeItems { get; set; }
        ChitietKiemkeModel ChitietKiemkeCurrent { get; }

        List<HanghoaModel> HanghoaItems { get; set; }

        void RefreshHanghoa();

        Guid? KhoCurrentId { get; }
        Guid? HanghoaCurrentId { get; }
        void RefreshChitietKiemke();

        List<KhoModel> Khoitems { get; set; }

        void RefreshKho();
    }
}
