/********************************************************************
	Interface file: 
    Author: Nguyen Minh Tri
    Date Created: 10/09/2014
	Last Updated: 10/09/2014
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
    public interface IDonhangView:IView
    {
        List<DonhangModel> DonhangItems { get; set; }

        DonhangModel DonhangCurrent { get; }

        DateTime filterValue { get; }

        List<LoaiDonhangModel> LoaiDonhangItems { get; set; }

        int? LoaiDonhangCurrentValue { get; set; }

    }
}
