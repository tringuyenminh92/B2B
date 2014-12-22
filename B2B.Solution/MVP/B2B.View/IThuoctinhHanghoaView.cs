/***********************************
Author: Lý Hoàng Tín
Date Created: 09/09/2014
Last Updated: 11/09/2014
Updated By: Lý Hoàng Tín
Update description: 
************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B2B.Model;
using BMIModel;

namespace B2B.View
{
    public interface IThuoctinhHanghoaView : IView
    {
        Guid? HanghoaCurrentId { get;}
        HanghoaModel HanghoaCurrent { get; set; }

        List<ThuoctinhHanghoaModel> ThuoctinhHanghoaItems { get; set; }

        List<HanghoaModel> HanghoaItems { get; set; }

        ThuoctinhHanghoaModel ThuoctinhHanghoaCurrent { get; set; }
    }
}
