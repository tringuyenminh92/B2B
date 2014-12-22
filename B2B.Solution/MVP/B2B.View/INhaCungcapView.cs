/********************************************************************
	Interface file: 
    Author: Nguyen Minh Tri
    Date Created: 11/09/2014
	Last Updated: 11/09/2014
	Updated By: Nguyen Minh Tri
	Update Description: Add comments
*********************************************************************/

using B2B.Model;
using BMIModel;
using System.Collections.Generic;

namespace B2B.View
{
    public interface INhaCungcapView:IView
    {
        List<NhaCungcapModel> NhaCungcapItems { get; set; }

        NhaCungcapModel NhaCungcapCurrent { get; }

    }
}
