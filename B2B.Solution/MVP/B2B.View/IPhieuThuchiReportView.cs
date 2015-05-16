/********************************************************************
	Interface file: 
    Author: Pham Xuan Vinh
    Date Created: 17/01/2015
	Last Updated: 
	Updated By: 
	Update Description: Pham Xuan Vinh
*********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMIModel;
using B2B.Model;

namespace B2B.View
{
    public interface IPhieuThuchiReportView : IView
    {
        ThuchiModel ValueThu { get; set; }
        ThuchiModel ValueChi { get; set; }
    }
}
