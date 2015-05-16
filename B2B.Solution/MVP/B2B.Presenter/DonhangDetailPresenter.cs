// ***********************************************************************
// Assembly         : B2B.Presenter
// Author           : Ga9286
// Created          : 11-10-2014
//
// Last Modified By : Ga9286
// Last Modified On : 30-11-2014
//
// Last Modified By : Ga9286
// Last Modified On : 27-04-2015
//
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
            try
            {
                View.KhachhangItems = Model.Get<KhachhangModel>("Tri_GetKhachhangDemo");
                if (View.KhachhangCurrentId == null)
                {
                    View.KhachhangCurrentId = View.Value.KhachhangId;
                }

            }
            catch (Exception ex)
            {//    //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("Tri_GetKhachhangDemo", ex);
                }
            }
        }

        /// <summary>
        /// Displays the thongtin giaohang.
        /// </summary>
        public void DisplayThongtinGiaohang()
        {
            try
            {
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

        /// <summary>
        /// Displays the nhanvien lap.
        /// </summary>
        public void DisplayNhanvienLap()
        {
            try
            {
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
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("Vinh_GetNhanvienTheoUserId", ex);
                }
            }
        }

        /// <summary>
        /// Displays the nhanvien capnhat.
        /// </summary>
        public void DisplayNhanvienCapnhat()
        {
            try
            {
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
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("Vinh_GetNhanvienTheoUserId", ex);
                }
            }
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
            try
            {
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
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("DisplayHanghoaTheoKhachhang", ex);
                }
            }
        }

        /// <summary>
        /// Sets the hanghoa current.
        /// </summary>
        public void SetHanghoaCurrent()
        {
            View.HanghoaCurrent = View.HanghoaItems.FirstOrDefault(p => p.HanghoaId == View.HanghoaCurrentId);
        }

        public void CongdonChitietItemsCurrent()
        {

            var tmp = View.ChitietDonhangItems.GroupBy(p => p.HanghoaId).Select(ct => new ChitietDonhangModel
             {
                 DonhangId = ct.First().DonhangId,
                 HanghoaId = ct.First().HanghoaId,
                 Mahang = ct.First().Mahang,
                 TenHanghoa = ct.First().TenHanghoa,
                 NgayCapnhat = DateTime.Now,
                 PhantramGiam = 0,
                 VAT = 0,
                 Tiengiam = 0,
                 Soluong = ct.Sum(c => c.Soluong),
                 Thanhtien = ct.Sum(t => t.Thanhtien),
             }).ToList();
            View.ChitietDonhangItems.Clear();
            View.ChitietDonhangItems.AddRange(tmp);
            foreach (var ct in View.ChitietDonhangItems)
            {
                ct.Giaban = ct.Thanhtien / ct.Soluong;
            }
            View.RefreshData();
        }

        /// <summary>
        /// Addnews this instance.
        /// </summary>
        public void Addnew()
        {
            try
            {
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
                var existHanghoa = View.ChitietDonhangItems.FirstOrDefault(p => p.HanghoaId == chitietDonhangNew.HanghoaId);
                if (View.IsCongdon && existHanghoa != null)
                {
                    existHanghoa.Soluong += chitietDonhangNew.Soluong;
                    existHanghoa.Thanhtien += chitietDonhangNew.Thanhtien;
                }
                else
                {
                    View.ChitietDonhangItems.Add(chitietDonhangNew);
                }

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
            View.Value.Tongtien = 0;
            foreach (var ct in View.ChitietDonhangItems)
            {
                if (ct.State != RowState.Delete)
                    View.Value.Tongtien += ct.Thanhtien;
            }
            View.Value.TenTinhtrangDonhang =
                View.TinhtrangItems.FirstOrDefault(p => p.TinhtrangId == View.Value.TinhtrangDonhangCurrentId)
                    .TenTinhtrang;
            View.Value.NgayCapnhat = DateTime.Now;
            //   View.Value.MakeUpdate();
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
            try
            {
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
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("Tri_GetChitietDonhangTheoDonhang", ex);
                }

            }
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

        public void ChotDonhang()
        {
            //try
            //{
            //Get Tinhtrang chot to assign new Tinhtrang
            var itemsTinhtrang = new List<AutoItem>();
            itemsTinhtrang.Add(new AutoItem
            {
                Name = "Code",
                Value = "TTDH06",
                SqlType = System.Data.SqlDbType.NVarChar
            });

            var TinhtrangChots = Model.Get<TinhtrangModel>(new AutoObject
            {
                Items = itemsTinhtrang,
                SpName = "Tri_GetTinhtrangDalap"
            });
            if (TinhtrangChots.Count == 0)
            {
                return;
            }
            var TinhtrangChot = TinhtrangChots[0];
            View.Value.TinhtrangDonhangCurrentId = TinhtrangChot.TinhtrangId;
            View.Value.TenTinhtrangDonhang = TinhtrangChot.TenTinhtrang;
            //Insert new line TinhtrangDonhang to table TinhtrangDonhang
            var tinhtrangDonhang = new TinhtrangDonhangModel
            {
                DonhangId = View.Value.DonhangId,
                TinhtrangId = View.Value.TinhtrangDonhangCurrentId,
                NgayCapnhat = DateTime.Now
            };


            var itemsTinhtrangChotPx = new List<AutoItem>();
            itemsTinhtrangChotPx.Add(new AutoItem
            {
                Name = "Code",
                Value = "TTPX002",
                SqlType = System.Data.SqlDbType.NVarChar
            });

            var tinhtrangChotPhieuxuats = Model.Get<TinhtrangModel>(new AutoObject
            {
                Items = itemsTinhtrangChotPx,
                SpName = "Tri_GetTinhtrangDalap"
            });
            if (TinhtrangChots.Count == 0)
            {
                return;
            }
            var tinhtrangChotPhieuxuat = tinhtrangChotPhieuxuats[0];

            //Get Phieuxuat of Donhang to assign Chot status
            var items = new List<AutoItem>();
            items.Add(new AutoItem
            {
                Name = "DonhangId",
                Value = View.Value.DonhangId,
                SqlType = System.Data.SqlDbType.UniqueIdentifier
            });
            var currentPhieuxuatItems = Model.Get<PhieuxuatModel>(new AutoObject
            {
                Items = items,
                SpName = "Khuyen_GetPhieuxuatTheoDonhang"
            });

            var newTinhtrangPhieuxuat = new List<TinhtrangPhieuxuatModel>();
            foreach (var px in currentPhieuxuatItems)
            {
                px.TinhtrangPhieuxuatCurrentId = tinhtrangChotPhieuxuat.TinhtrangId;
                px.TenTinhtrangPhieuxuat = tinhtrangChotPhieuxuat.TenTinhtrang;
                newTinhtrangPhieuxuat.Add(new TinhtrangPhieuxuatModel
                {
                    TinhtrangPhieuxuatId = Guid.NewGuid(),
                    PhieuxuatId = px.PhieuxuatId,
                    TinhtrangId = px.TinhtrangPhieuxuatCurrentId,
                    NgayCapnhat = DateTime.Now
                });
            }

            Model.Set(tinhtrangDonhang);
            Model.Set(View.Value);
            Model.Set(currentPhieuxuatItems);
            Model.Set(newTinhtrangPhieuxuat);

            //}
            //catch (Exception ex)
            //{
            //    //Check log flag and log error to file.
            //    if (isErrorEnabled)
            //    {
            //        logger.Error(string.Format("Code: {0}, DonhangId: {1}", "TTDH06", View.Value.DonhangId), ex);
            //    }
            //}
        }


        public void HuyDonhang()
        {
            //try
            //{
            //Get Tinhtrang chot to assign new Tinhtrang
            var itemsTinhtrang = new List<AutoItem>();
            itemsTinhtrang.Add(new AutoItem
            {
                Name = "Code",
                Value = "TTDH03",
                SqlType = System.Data.SqlDbType.NVarChar
            });

            var TinhtrangHuys = Model.Get<TinhtrangModel>(new AutoObject
            {
                Items = itemsTinhtrang,
                SpName = "Tri_GetTinhtrangDalap"
            });
            if (TinhtrangHuys.Count == 0)
            {
                return;
            }
            var TinhtrangHuy = TinhtrangHuys[0];
            View.Value.TinhtrangDonhangCurrentId = TinhtrangHuy.TinhtrangId;
            View.Value.TenTinhtrangDonhang = TinhtrangHuy.TenTinhtrang;
            //Insert new line TinhtrangDonhang to table TinhtrangDonhang
            var tinhtrangDonhang = new TinhtrangDonhangModel
            {
                DonhangId = View.Value.DonhangId,
                TinhtrangId = View.Value.TinhtrangDonhangCurrentId,
                NgayCapnhat = DateTime.Now
            };


            var itemsTinhtrangHuyPx = new List<AutoItem>();
            itemsTinhtrangHuyPx.Add(new AutoItem
            {
                Name = "Code",
                Value = "TTPX003",
                SqlType = System.Data.SqlDbType.NVarChar
            });

            var tinhtrangHuyPhieuxuats = Model.Get<TinhtrangModel>(new AutoObject
            {
                Items = itemsTinhtrangHuyPx,
                SpName = "Tri_GetTinhtrangDalap"
            });
            if (tinhtrangHuyPhieuxuats.Count == 0)
            {
                return;
            }
            var tinhtrangHuyPhieuxuat = tinhtrangHuyPhieuxuats[0];

            //Get Phieuxuat of Donhang to assign Chot status
            var items = new List<AutoItem>();
            items.Add(new AutoItem
            {
                Name = "DonhangId",
                Value = View.Value.DonhangId,
                SqlType = System.Data.SqlDbType.UniqueIdentifier
            });
            var currentPhieuxuatItems = Model.Get<PhieuxuatModel>(new AutoObject
            {
                Items = items,
                SpName = "Khuyen_GetPhieuxuatTheoDonhang"
            });

            var newTinhtrangPhieuxuat = new List<TinhtrangPhieuxuatModel>();
            foreach (var px in currentPhieuxuatItems)
            {
                px.TinhtrangPhieuxuatCurrentId = tinhtrangHuyPhieuxuat.TinhtrangId;
                px.TenTinhtrangPhieuxuat = tinhtrangHuyPhieuxuat.TenTinhtrang;
                newTinhtrangPhieuxuat.Add(new TinhtrangPhieuxuatModel
                {
                    TinhtrangPhieuxuatId = Guid.NewGuid(),
                    PhieuxuatId = px.PhieuxuatId,
                    TinhtrangId = px.TinhtrangPhieuxuatCurrentId,
                    NgayCapnhat = DateTime.Now
                });
            }

            Model.Set(tinhtrangDonhang);
            Model.Set(View.Value);
            Model.Set(currentPhieuxuatItems);
            Model.Set(newTinhtrangPhieuxuat);

            //}
            //catch (Exception ex)
            //{
            //    //Check log flag and log error to file.
            //    if (isErrorEnabled)
            //    {
            //        logger.Error(string.Format("Code: {0}, DonhangId: {1}", "TTDH06", View.Value.DonhangId), ex);
            //    }
            //}
        }
    }
}