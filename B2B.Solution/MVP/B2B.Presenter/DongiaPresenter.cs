/********************************************************************
	Class file: 
    Author: Nguyen Minh Tri
    Date Created: 06/09/2014
	Last Updated: 06/09/2014
	Updated By: Nguyen Minh Tri
	Update Description: 
*********************************************************************/

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using B2B.Model;
using B2B.View;
using BMIModel;
using BusinessObject;
using log4net;

namespace B2B.Presenter
{
    public class DongiaPresenter : Presenter<IDongiaView>
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        public DongiaPresenter(IDongiaView view)
            : base(view)
        {
        }

        public void Display()
        {
            try
            {
                View.DongiaItems = Model.Get<DongiaModel>("sys_DongiaSelect");
                View.RefreshData();
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("sys_DongiaSelect", ex);
                }
            }
        }

        public void DisplayDongiaTheoNhomKhachhang()
        {
            try
            {
                var items = new List<AutoItem>
                {
                    new AutoItem
                    {
                        Name = "NhomKhachhangId",
                        Value = View.NhomKhachhangCurrent.NhomKhachhangId,
                        SqlType = SqlDbType.UniqueIdentifier
                    }
                };
                View.DongiaItems =
                    Model.Get<DongiaModel>(new AutoObject {Items = items, SpName = "Tri_GetDongiaTheoNhomKhachhang"});
                //View.QuanhuyenItems = Model.Get<QuanhuyenModel>(new AutoObject { Items = items, SpName = "Tri_GetQuanhuyenActiveTheoTinhthanh" });
                View.RefreshData();
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("", ex);
                }
            }
        }

        public void DisplayNhomKhachhang()
        {
            try
            {
                var listNhomKhachhang = new List<NhomKhachhangModel>
                {
                    new NhomKhachhangModel
                    {
                        NhomKhachhangId = new Guid("00000000-0000-0000-0000-000000000000"),
                        TenNhomKhachhang = "Tất cả",
                        Active = false
                    }
                };
                View.NhomKhachhangItems = Model.Get<NhomKhachhangModel>("sys_NhomKhachhangSelect");
                View.RefreshDataNhomKhachhang();
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("sys_NhomKhachhangSelect", ex);
                }
            }
        }

        public void DisplayHanghoa()
        {
            try
            {
                var listHanghoa = new List<HanghoaModel>
                {
                    new HanghoaModel
                    {
                        HanghoaId = new Guid("00000000-0000-0000-0000-000000000000"),
                        TenHanghoa = "Tất cả",
                        Active = false
                    }
                };
                View.HanghoaItems = Model.Get<HanghoaModel>("sys_HanghoaSelect");
                View.RefreshDataHanghoa();
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("sys_HanghoaSelect", ex);
                }
            }
        }

        public bool Addnew()
        {
            try
            {
                Guid? NhomKhachhangCurrentId = View.NhomKhachhangCurrentId;
                Guid? HanghoaCurrentId = View.HanghoaCurrentId;
                NhomKhachhangModel NhomKhachhangCurrent =
                    View.NhomKhachhangItems.FirstOrDefault(p => p.NhomKhachhangId == NhomKhachhangCurrentId);
                HanghoaModel HanghoaCurrent = View.HanghoaItems.FirstOrDefault(p => p.HanghoaId == HanghoaCurrentId);

                if (NhomKhachhangCurrent == null || HanghoaCurrent == null)
                {
                    return false;
                }
                if (NhomKhachhangCurrent != null)
                {
                    if (NhomKhachhangCurrent.Active == false)
                        return false;
                }
                if (HanghoaCurrent != null)
                {
                    if (HanghoaCurrent.Active == false)
                        return false;
                }

                View.DongiaItems.Add(new DongiaModel
                {
                    NgayCapnhat = DateTime.Now,
                    Active = true,
                    NhomKhachhangId = NhomKhachhangCurrent.NhomKhachhangId,
                    TenNhomKhachhang = NhomKhachhangCurrent.TenNhomKhachhang,
                    HanghoaId = HanghoaCurrent.HanghoaId,
                    TenHanghoa = HanghoaCurrent.TenHanghoa
                });
                View.RefreshData();
                return true;
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error(
                        string.Format("NhomId: {0} - HanghoaId: {1}", View.NhomKhachhangCurrent.NhomKhachhangId,
                            View.HangHoaCurrent.HanghoaId), ex);
                }
                return false;
            }
        }

        public bool Save()
        {
            try
            {
                foreach (DongiaModel item in View.DongiaItems)
                {
                    if (item.State == RowState.Insert || item.State == RowState.Update)
                    {
                        item.NgayCapnhat = DateTime.Now;
                    }
                }
                Model.Set(View.DongiaItems);
                View.RefreshData();
                return true;
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("Save", ex);
                }
                return false;
            }
        }

        public void Delete()
        {
            DongiaModel current = View.DongiaCurrent;
            if (current == null)
            {
                return;
            }

            if (current.State == RowState.Insert)
            {
                View.DongiaItems.Remove(current);
                View.RefreshData();
                return;
            }
            current.MakeDelete();
            View.RefreshData();
        }
    }
}