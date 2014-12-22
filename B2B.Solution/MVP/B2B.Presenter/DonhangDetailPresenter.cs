﻿// ***********************************************************************
// Assembly         : B2B.Presenter
// Author           : Ga9286
// Created          : 11-10-2014
//
// Last Modified By : Ga9286
// Last Modified On : 30-11-2014
// ***********************************************************************

using System;
using System.Linq;
using System.Reflection;
using B2B.Model;
using B2B.View;
using BMIModel;
using log4net;
using BusinessObject;
using System.Collections.Generic;

/// <summary>
/// The Presenter namespace.
/// </summary>
namespace B2B.Presenter
{
    /// <summary>
    /// Class DonhangDetailPresenter.
    /// </summary>
    public class DonhangDetailPresenter : Presenter<IDonhangDetailView>
    {
        //Create instance of logger for using log4net methods
        /// <summary>
        /// The logger
        /// </summary>
        private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        //Flag to check if error level was enabled.
        /// <summary>
        /// The is error enabled
        /// </summary>
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        /// <summary>
        /// Initializes a new instance of the <see cref="DonhangDetailPresenter" /> class.
        /// </summary>
        /// <param name="view">The view.</param>
        public DonhangDetailPresenter(IDonhangDetailView view) : base(view) { }

        /// <summary>
        /// Displays the khachhang.
        /// </summary>
        public void DisplayKhachhang()
        {
            //try
            //{
            View.KhachhangItems = Model.Get<KhachhangModel>("Tri_GetKhachhangDemo");
            if (View.KhachhangCurrentId == null)
            {
                View.KhachhangCurrentId = View.Value.KhachhangId;
            }

            //}
            //catch (Exception ex)//{//    //Check log flag and log error to file.
            //    if (isErrorEnabled)
            //    {
            //        logger.Error("Tri_GetKhachhangDemo", ex);
            //    }
            //}
        }

        /// <summary>
        /// Displays the thongtin giaohang.
        /// </summary>
        public void DisplayThongtinGiaohang()
        {
            //try
            //{
            var KhachhangCurrent =
                View.KhachhangItems.FirstOrDefault(p => p.KhachhangId == View.KhachhangCurrentId) as KhachhangModel;
            if (KhachhangCurrent == null)
            {
                return;
            }
            View.Value.TenQuanhuyenGiao = KhachhangCurrent.TenQuanhuyen;
            View.Value.TenTinhthanhGiao = KhachhangCurrent.TenTinhthanh;
            View.Value.DiachiGiao = string.IsNullOrWhiteSpace(KhachhangCurrent.DiachiGiaohang)
                ? KhachhangCurrent.Diachi
                : KhachhangCurrent.DiachiGiaohang;
            var soDienthoai = "";
            soDienthoai += string.IsNullOrWhiteSpace(KhachhangCurrent.Mobile) ? "" : KhachhangCurrent.Mobile + ", ";
            soDienthoai += string.IsNullOrWhiteSpace(KhachhangCurrent.Tel) ? "" : KhachhangCurrent.Tel + ", ";
            soDienthoai += string.IsNullOrWhiteSpace(KhachhangCurrent.PhoneCongty) ? "" : KhachhangCurrent.PhoneCongty;
            View.Value.SoDienthoai = soDienthoai;
            //}
            //catch (Exception ex)
            //{
            //    //Check log flag and log error to file.
            //    if (isErrorEnabled)
            //    {
            //        logger.Error("", ex);
            //    }
            //}
        }

        /// <summary>
        /// Displays the nhanvien lap.
        /// </summary>
        public void DisplayNhanvienLap()
        {
            //try
            //{
            var items = new List<AutoItem>();
            items.Add(new AutoItem
            {
                Name = "UserId",
                SqlType = System.Data.SqlDbType.UniqueIdentifier,
                Value = ModelCore.UserId
            });
            var NhanvienLapCurrent =
                Model.Get<NhanvienModel>(new AutoObject { Items = items, SpName = "Vinh_GetNhanvienTheoUserId" })[0];

            if (NhanvienLapCurrent != null && !View.Value.NhanvienId.HasValue)
            {
                View.Value.NhanvienId = NhanvienLapCurrent.NhanvienId;
                View.Value.TenNhanvienLap = NhanvienLapCurrent.HovatenNhanvien;
            }
            //}
            //catch (Exception ex)
            //{
            //    //Check log flag and log error to file.
            //    if (isErrorEnabled)
            //    {
            //        logger.Error("Vinh_GetNhanvienTheoUserId", ex);
            //    }
            //}
        }

        /// <summary>
        /// Displays the nhanvien capnhat.
        /// </summary>
        public void DisplayNhanvienCapnhat()
        {
            //try
            //{
            var items = new List<AutoItem>();
            items.Add(new AutoItem
            {
                Name = "UserId",
                SqlType = System.Data.SqlDbType.UniqueIdentifier,
                Value = ModelCore.UserId
            });
            var NhanvienCapnhatCurrent =
                Model.Get<NhanvienModel>(new AutoObject { Items = items, SpName = "Vinh_GetNhanvienTheoUserId" })[0];
            if (NhanvienCapnhatCurrent != null)
            {
                View.Value.NhanvienCapnhatId = NhanvienCapnhatCurrent.NhanvienId;
                View.Value.TenNhanvienCapnhat = NhanvienCapnhatCurrent.HovatenNhanvien;
            }
            //}
            //catch (Exception ex)
            //{
            //    //Check log flag and log error to file.
            //    if (isErrorEnabled)
            //    {
            //        logger.Error("Vinh_GetNhanvienTheoUserId", ex);
            //    }
            //}
        }

        /// <summary>
        /// Displays the kho.
        /// </summary>
        public void DisplayKho()
        {
            //try
            //{
            View.KhoItems = Model.Get<KhoModel>("sys_KhoSelect");
            //}
            //catch (Exception ex)
            //{//    //Check log flag and log error to file.
            //    if (isErrorEnabled)
            //    {
            //        logger.Error("sys_KhoSelect", ex);
            //    }

            //}
        }

        /// <summary>
        /// Displays the loai donhang.
        /// </summary>
        public void DisplayLoaiDonhang()
        {
            try
            {
                View.LoaiDonhangItems = LoaiDonhangModel.listLoaiDonhang;
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("LoaiDonhangModel.listLoaiDonhang", ex);
                }

            }
        }

        /// <summary>
        /// Displays the tinhtrang.
        /// </summary>
        public void DisplayTinhtrang()
        {
            try
            {
                View.TinhtrangItems = Model.Get<TinhtrangModel>("sys_TinhtrangSelect").Where(p => p.Step == 0).ToList();
                var t = View.TinhtrangItems;
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("sys_TinhtrangSelect", ex);
                }

            }
        }

        /// <summary>
        /// Displays the hanghoa theo khachhang.
        /// </summary>
        public void DisplayHanghoaTheoKhachhang()
        {
            //try
            //{
            var KhachhangCurrent = View.KhachhangItems.FirstOrDefault(p => p.KhachhangId == View.KhachhangCurrentId);
            if (KhachhangCurrent == null)
            {
                return;
            }
            var items = new List<AutoItem>();
            items.Add(new AutoItem
            {
                Name = "NhomKhachhangId",
                SqlType = System.Data.SqlDbType.UniqueIdentifier,
                Value = KhachhangCurrent.NhomKhachhangId
            });

            View.HanghoaItems =
                Model.Get<HanghoaModel>(new AutoObject { Items = items, SpName = "Tri_GetHanghoaTheoNhomKhachhang" });
            //}
            //catch (Exception ex)
            //{
            //    //Check log flag and log error to file.
            //    if (isErrorEnabled)
            //    {
            //        logger.Error("DisplayHanghoaTheoKhachhang", ex);
            //    }
            //}
        }

        /// <summary>
        /// Sets the hanghoa current.
        /// </summary>
        public void SetHanghoaCurrent()
        {
            View.HanghoaCurrent = View.HanghoaItems.FirstOrDefault(p => p.HanghoaId == View.HanghoaCurrentId);
        }


        /// <summary>
        /// Addnews this instance.
        /// </summary>
        public void Addnew()
        {
            //try
            //{
            var HanghoaCurrent = View.HanghoaCurrent;
            if (HanghoaCurrent == null)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(HanghoaCurrent.SoluongKhachmua.ToString()) ||
                HanghoaCurrent.SoluongKhachmua <= 0)
            {
                HanghoaCurrent.SoluongKhachmua = 1;
            }
            // check trigger soluongmua <= soluong ton du kien if(HanghoaCurrent.SoluongKhachmua>)
            var chitietDonhangNew = new ChitietDonhangModel
            {
                DonhangId = View.Value.DonhangId,
                Giaban = HanghoaCurrent.GiaHienthi,
                HanghoaId = HanghoaCurrent.HanghoaId,
                Mahang = HanghoaCurrent.Code,
                TenHanghoa = HanghoaCurrent.TenHanghoa,
                NgayCapnhat = DateTime.Now,
                PhantramGiam = HanghoaCurrent.PhantramGiam.HasValue ? HanghoaCurrent.PhantramGiam.Value : 0,
                VAT = HanghoaCurrent.PhantramVAT.HasValue ? HanghoaCurrent.PhantramVAT.Value : 0,
                Tiengiam = HanghoaCurrent.TiengiamHienthi.HasValue ? HanghoaCurrent.TiengiamHienthi.Value : 0,
                Soluong = HanghoaCurrent.SoluongKhachmua
            };

            //check lai cong thuc
            chitietDonhangNew.Thanhtien = (chitietDonhangNew.Soluong * chitietDonhangNew.Giaban *
                                           (1 - chitietDonhangNew.PhantramGiam / 100) - chitietDonhangNew.Tiengiam) *
                                          (1 - chitietDonhangNew.VAT / 100);
            View.ChitietDonhangItems.Add(chitietDonhangNew);
            View.RefreshData();
            //}
            //catch (Exception ex)
            //{
            //    //Check log flag and log error to file.
            //    if (isErrorEnabled)
            //    {
            //        logger.Error("", ex);
            //    }

            //}

        }

        /// <summary>
        /// Capnhats the khachhang tongtien.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool CapnhatKhachhangTongtienTenTinhtrangNgayCapnhat()
        {
            if (View.Value.KhachhangId == null)
            {
                return false;
            }
            View.Value.KhachhangId = View.KhachhangCurrentId;
            View.Value.TenKhachhang =
                View.KhachhangItems.FirstOrDefault(p => p.KhachhangId == View.KhachhangCurrentId).HotenKhachhang;
            foreach (var ct in View.ChitietDonhangItems)
            {
                View.Value.Tongtien += ct.Thanhtien;
            }
            View.Value.TenTinhtrangDonhang =
                View.TinhtrangItems.FirstOrDefault(p => p.TinhtrangId == View.Value.TinhtrangDonhangCurrentId)
                    .TenTinhtrang;
            View.Value.NgayCapnhat = DateTime.Now;
            return true;
        }

        /// <summary>
        /// Deletes this instance.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Delete()
        {
            try
            {
                var ChitietDonhangCurrent = View.ChitietDonhangCurrent as ChitietDonhangModel;
                if (ChitietDonhangCurrent == null)
                {
                    return false;
                }

                //Delete theo nghia giao dien.
                if (ChitietDonhangCurrent.State == BusinessObject.RowState.Insert)
                {
                    View.ChitietDonhangItems.Remove(ChitietDonhangCurrent);
                    View.RefreshData();
                    return true;
                }

                //Da xuat khong cho delete
                if (ChitietDonhangCurrent.SoluongGiao > 0)
                {
                    return false;
                }

                ChitietDonhangCurrent.MakeDelete();
                View.RefreshData();
                return true;
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("", ex);
                }
                return false;
            }
        }

        /// <summary>
        /// Displays the chitiet donhang.
        /// </summary>
        public void DisplayChitietDonhang()
        {
            //try
            //{
            var chitietItems = new List<AutoItem>();
            chitietItems.Add(new AutoItem
            {
                Name = "DonhangId",
                SqlType = System.Data.SqlDbType.UniqueIdentifier,
                Value = View.Value.DonhangId
            });
            View.Value.ChitietDonhangItems =
                Model.Get<ChitietDonhangModel>(new AutoObject
                {
                    Items = chitietItems,
                    SpName = "Tri_GetChitietDonhangTheoDonhang"
                });
            View.RefreshData();
            //}//catch (Exception ex)
            //{
            //    //Check log flag and log error to file.
            //    if (isErrorEnabled)
            //    {
            //        logger.Error("Tri_GetChitietDonhangTheoDonhang", ex);
            //    }

            //}
        }

        /// <summary>
        /// Reverts the current value.
        /// </summary>
        public void RevertCurrentValue()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem
            {
                Name = "DonhangId",
                Value = View.Value.DonhangId,
                SqlType = System.Data.SqlDbType.UniqueIdentifier
            });
            var donhangCurrentValue = Model.Get<DonhangModel>(new AutoObject
            {
                Items = items,
                SpName = "Tri_GetDonhangTheoId"
            })[0];

            View.Value = donhangCurrentValue;

        }
    }
}