/********************************************************************
	Interface file: 
    Author: Nguyen Minh Tri
    Date Created: 20/09/2014
	Last Updated: 20/09/2014
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
    public interface IPhongbanView:IView
    {
        List<PhongbanModel> PhongbanItems { get; set; }

        PhongbanModel PhongbanCurrent { get; }


    }
}
