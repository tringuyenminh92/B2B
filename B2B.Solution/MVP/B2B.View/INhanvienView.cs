/********************************************************************
	Interface file: 
    Author: Nguyen Minh Tri
    Date Created: 30/08/2014
	Last Updated: 30/08/2014
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
    public interface INhanvienView:IView
    {
        List<NhanvienModel> NhanvienItems { get; set; }

        NhanvienModel NhanvienCurrent { get; }

        List<PhongbanModel> PhongbanItems { get; set; }

        Guid? PhongbanCurrentId { get;}

        void RefreshDataPhongban();
    }
}
