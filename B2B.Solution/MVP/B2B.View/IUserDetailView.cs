/********************************************************************
	Interface file: 
    Author: Nguyen Minh Tri
    Date Created: 04/09/2014
	Last Updated: 04/09/2014
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
    public interface IUserDetailView:IView
    {
        List<NhanvienModel> NhanvienItems { get; set; }
        UserModel Value { get; set; }
    }
}
