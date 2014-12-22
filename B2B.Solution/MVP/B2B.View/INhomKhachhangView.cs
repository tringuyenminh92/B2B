/********************************************************************
	Interface file: 
    Author: Tran Nguyen Hoang Khuyen
    Date Created: 28/08/2014
	Last Updated: 28/08/2014
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
    public interface INhomKhachhangView : IView
    {
        List<NhomKhachhangModel> NhomKhachhangItems { get; set; }

        NhomKhachhangModel NhomKhachhangCurrent { get; }
    }
}
