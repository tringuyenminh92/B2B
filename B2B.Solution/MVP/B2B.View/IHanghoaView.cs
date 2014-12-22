/********************************************************************
	Interface file: 
    Author: Pham Xuan Vinh
    Date Created: 03/09/2014
	Last Updated: 03/09/2014
	Updated By: Pham Xuan Vinh
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
    public interface IHanghoaView:IView
    {
        List<HanghoaModel> HanghoaItems { get; set; }
        HanghoaModel HanghoaCurrent { get; }
        List<NhomHanghoaModel> NhomHanghoaItems { get; set; }
        Guid? NhomHanghoaCurrentId { get; }
        void RefreshDataNhomHanghoa();
    }
}
