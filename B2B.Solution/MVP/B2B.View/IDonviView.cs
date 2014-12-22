/********************************************************************
	Interface file: 
    Author: Nguyen Minh Tri
    Date Created: 29/08/2014
	Last Updated: 29/08/2014
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
    public interface IDonviView:IView
    {
        List<DonviModel> DonviItems { get; set; }

        DonviModel DonviCurrent { get; }
    }
}
