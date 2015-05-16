/********************************************************************
	Interface file: 
    Author: Tran Nguyen Hoang Khuyen
    Date Created: 17/01/2015
	Last Updated: 03/02/2015
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
    public interface IPhieuthuDetailView:IView
    {
        List<PhieuxuatModel> PhieuxuatItems { get; set; }
        PhieuxuatModel PhieuxuatCurrent { get; }
        ThuchiModel ValuePhieuthu { get; set; }
        //Guid? PhieuxuatCurrentId { get; set; }
        List<NhanvienModel> NhanvienItems { get; set; }
        List<KhachhangModel> KhachhangItems { get; set; }
        Guid? PhieuxuatCurrentId { get; }
    }
}
