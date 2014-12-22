/********************************************************************
	Interface file: 
    Author: Tran Nguyen Hoang Khuyen
    Date Created: 03/09/2014
	Last Updated: 03/09/2014
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
    public interface INhomHanghoaView : IView
    {
        List<NhomHanghoaModel> NhomHanghoaItems { get; set; }

        NhomHanghoaModel NhomHanghoaCurrent { get; }
    }
}
