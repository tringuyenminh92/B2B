/***********************************
Author: Lý Hoàng Tín
Date Created: 29/01/2015
Last Updated: 31/01/2015
Updated By: Lý Hoàng Tín
Update description: 
************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMIModel;
using log4net;
using BusinessObject;
using B2B.View;
using System.Reflection;
using B2B.Model;

namespace B2B.Presenter
{
    public class PhieuchiDetailPresenter : Presenter<IPhieuchiDetailView>
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        public PhieuchiDetailPresenter(IPhieuchiDetailView view)
            : base(view) { }
        public void DisplayPhieunhap()
        {
            try
            {
                var listPhieunhap = new List<PhieunhapModel>();
                listPhieunhap.Add(new PhieunhapModel
                {
                    PhieunhapId = new Guid("00000000-0000-0000-0000-000000000000"),
                    Code = "Khác"
                });
                listPhieunhap.AddRange(Model.Get<PhieunhapModel>("sys_PhieunhapSelect"));
                View.PhieunhapItems = listPhieunhap;
            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("sys_PhieunhapSelect", ex);
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

        public void DisplayNhaCungcap()
        {
            try
            {
                var pxId = View.PhieunhapCurrentId as Guid?;
                if (pxId == new Guid("00000000-0000-0000-0000-000000000000"))
                {
                    View.NhaCungcapItems = Model.Get<NhaCungcapModel>("sys_NhaCungcapSelect");
                }
                else
                {
                    var items = new List<AutoItem>();
                    items.Add(new AutoItem
                    {
                        Name = "PhieunhapId",
                        Value = pxId,
                        SqlType = System.Data.SqlDbType.UniqueIdentifier
                    });

                    View.NhaCungcapItems = Model.Get<NhaCungcapModel>(new AutoObject
                    {
                        Items = items,
                        SpName = "Khuyen_GetNhacungcapTheoPhieunhap"
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
                    logger.Error("Display nha cung cap", ex);
                }
                return;
            }
        }

        public bool Save()
        {
            //try
            //{
                Model.Set(View.ValuePhieuchi);
                return true;
            //}
            //catch (Exception ex)
            //{
            //    //Check log flag and log error to file.
            //    if (isErrorEnabled)
            //    {
            //        logger.Error("Save Phieu thu", ex);
            //    }
            //    return false;
            //}
        }

        public void GetTenNhannopTien()
        {
            NhaCungcapModel ncc = Model.Get<NhaCungcapModel>("sys_NhaCungcapSelect").FirstOrDefault(k => k.NhaCungcapId == View.ValuePhieuchi.NhannopTienId) as NhaCungcapModel;
            View.ValuePhieuchi.TenNhannopTien = ncc.TenNhaCungcap;
        }
    }
}
