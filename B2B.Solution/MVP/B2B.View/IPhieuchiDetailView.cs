/***********************************
Author: Lý Hoàng Tín
Date Created: 29/01/2015
Last Updated: 31/01/2015
Updated By: Lý Hoàng Tín
Update description: 
************************************/
using B2B.Model;
using BMIModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.View
{
    public interface IPhieuchiDetailView:IView
    {
        List<PhieunhapModel> PhieunhapItems { get; set; }
        PhieunhapModel PhieunhapCurrent { get; }
        ThuchiModel ValuePhieuchi { get; set; }
        //Guid? PhieuxuatCurrentId { get; set; }
        List<NhanvienModel> NhanvienItems { get; set; }
        List<NhaCungcapModel> NhaCungcapItems { get; set; }
        Guid? PhieunhapCurrentId { get; }
    }
}
