/********************************************************************
	Class file: 
    Author: Tran Nguyen Hoang Khuyen
    Date Created: 17/01/2015
	Last Updated: 27/01/2015
	Updated By: Tran Nguyen Hoang Khuyen
	Update Description:
*********************************************************************/

using B2B.Model;
using B2B.View;
using BMIModel;
using BusinessObject;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Presenter
{
    public class PhieuthuDetailPresenter:Presenter<IPhieuthuDetailView>
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        public PhieuthuDetailPresenter(IPhieuthuDetailView view) : base(view) { }

        public void DisplayPhieuxuat()
        {
            try
            {
                var listPhieuxuat = new List<PhieuxuatModel>();
                listPhieuxuat.Add(new PhieuxuatModel
                {
                    PhieuxuatId = new Guid("00000000-0000-0000-0000-000000000000"),
                    Code = "Khác"
                });
                listPhieuxuat.AddRange(Model.Get<PhieuxuatModel>("Khuyen_GetPhieuxuat"));
                var phieuxuatTemp = new List<PhieuxuatModel>();
                var tinhtrangDachot = Model.Get<TinhtrangModel>("sys_TinhtrangSelect").FirstOrDefault(p => p.Code == "TTPX002");
                var tinhtrangDahuy = Model.Get<TinhtrangModel>("sys_TinhtrangSelect").FirstOrDefault(p => p.Code == "TTPX003");
                for (int i = 0; i < listPhieuxuat.Count; ++i)
                {
                    if (listPhieuxuat[i].TinhtrangPhieuxuatCurrentId == tinhtrangDachot.TinhtrangId || listPhieuxuat[i].TinhtrangPhieuxuatCurrentId == tinhtrangDahuy.TinhtrangId)
                    {
                        phieuxuatTemp.Add(listPhieuxuat[i]);
                    }   
                }
                for (int i = 0; i < phieuxuatTemp.Count;++i )
                {
                    listPhieuxuat.Remove(phieuxuatTemp[i]);
                } 
                View.PhieuxuatItems = listPhieuxuat;
            }
            catch (System.Exception ex)
            {
            	//Check log flag and log error to file.
            	if (isErrorEnabled)
            	{
                    logger.Error("sys_PhieuxuatSelect", ex);
            	}
            	return;
            }
        }

        public void DisplayNhanvien()
        {
            try
            {
                View.NhanvienItems = Model.Get<NhanvienModel>("Tri_GetNhanvienActive");
            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("Tri_GetNhanvienActive", ex);
                }
                return;
            }
        }

        public void DisplayKhachhang()
        {
            try
            {
                var pxId = View.PhieuxuatCurrentId as Guid?;
                if (pxId == new Guid("00000000-0000-0000-0000-000000000000"))
                {
                    View.KhachhangItems = Model.Get<KhachhangModel>("sys_KhachhangSelect"); 
                }
                else
                {
                    var items = new List<AutoItem>();
                    items.Add(new AutoItem
                    {
                        Name = "PhieuxuatId",
                        Value = pxId,
                        SqlType = System.Data.SqlDbType.UniqueIdentifier
                    });

                    View.KhachhangItems = Model.Get<KhachhangModel>(new AutoObject
                    {
                        Items = items,
                        SpName = "Khuyen_GetKhachhangTheoPhieuxuat"
                    });
                }

                //View.RefreshData();
                //View.KhachhangItems = Model.Get<KhachhangModel>("sys_KhachhangSelect");
            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("sys_KhachhangSelect", ex);
                }
                return;
            }
        }

        //public void DisplayThongtinPhieuthu()
        //{
        //    //try
        //    //{
        //        var phieuxuatCurrent =
        //        View.PhieuxuatItems.FirstOrDefault(p => p.PhieuxuatId == View.PhieuxuatCurrentId) as PhieuxuatModel;
        //        if (phieuxuatCurrent == null)
        //        {
        //            return;
        //        }
        //        View.ValuePhieuthu.Tongtien = phieuxuatCurrent.Tongtien;
        //        var donhangCurrent =
        //        Model.Get<DonhangModel>("sys_DonhangSelect").FirstOrDefault(p => p.DonhangId == phieuxuatCurrent.DonhangId) as DonhangModel;
        //        View.ValuePhieuthu.NhannopTienId = donhangCurrent.KhachhangId;
        //        View.ValuePhieuthu.TenNhannopTien = donhangCurrent.TenKhachhang;
        //    //}
        //    //catch (System.Exception ex)
        //    //{
        //    //    //Check log flag and log error to file.
        //    //    if (isErrorEnabled)
        //    //    {
        //    //        logger.Error("PhieuthuDetailPresenter_DisplayThongtinPhieuthu", ex);
        //    //    }
        //    //}
        //}
        public bool Save()
        {
            try
            {
                //if(View.ValuePhieuthu.PhieuxuatId == null)
                //{
                //    View.ValuePhieuthu.PhieuxuatId = new Guid("00000000-0000-0000-0000-000000000000");
                //}

                Model.Set(View.ValuePhieuthu);
                return true;
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("Save Phieu thu", ex);
                }
                return false;
            }
        }

        public void GetTenNhannopTien()
        {
            KhachhangModel khachhang = Model.Get<KhachhangModel>("sys_KhachhangSelect").FirstOrDefault(k => k.KhachhangId == View.ValuePhieuthu.NhannopTienId) as KhachhangModel;
            View.ValuePhieuthu.TenNhannopTien = khachhang.HotenKhachhang;
        }
    }
}
