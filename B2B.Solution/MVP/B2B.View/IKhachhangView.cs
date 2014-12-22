/********************************************************************
	Interface file: 
    Author: Nguyen Minh Tri
    Date Created: 13/09/2014
	Last Updated: 13/09/2014
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
    public interface IKhachhangView:IView
    {
        List<KhachhangModel> KhachhangItems { get; set; }

        KhachhangModel KhachhangCurrent { get; }

        List<NhomKhachhangModel> NhomKhachhangItems { get; set;}

        Guid? NhomKhachhangCurrentId { get; }

        void RefreshDataNhomKhachhang();
    }
}
