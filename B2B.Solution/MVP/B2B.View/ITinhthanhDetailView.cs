/********************************************************************
	Interface file: 
    Author: Nguyen Minh Tri
    Date Created: 11/09/2014
	Last Updated: 11/09/2014
	Updated By: Nguyen Minh Tri
	Update Description: Add Comments
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
    public interface ITinhthanhDetailView:IView
    {
        List<KhuvucModel> KhuvucItems { get; set; }

    }
}
