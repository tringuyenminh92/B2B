/********************************************************************
	Class file: 
    Author: Pham Xuan Vinh
    Date Created: 23/12/2014
	Last Updated: 
	Updated By: 
	Update Description: Pham Xuan Vinh
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
    public interface IPhieuGiaohangReportView : IView
    {

        PhieuxuatModel ValuePhieuxuat { get; set; }
        
    }
}
