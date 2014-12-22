/********************************************************************
	Interface file: 
    Author: Nguyen Minh Tri
    Date Created: 24/08/2014
	Last Updated: 24/08/2014
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
    public interface IKhoView:IView
    {
        List<KhoModel> KhoItems { get; set; }

        KhoModel KhoCurrent { get; }
    }
}
