/********************************************************************
	Interface file: 
    Author: Tran Nguyen Hoang Khuyen
    Date Created: 17/01/2015
	Last Updated: 17/01/2015
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
    public interface IThuchiView:IView
    {
        List<ThuchiModel> ThuchiItems { get; set; }
        ThuchiModel ThuchiCurent { get;}
        NhanvienModel NhanvienCapNhat { get; set; }
    }
}
