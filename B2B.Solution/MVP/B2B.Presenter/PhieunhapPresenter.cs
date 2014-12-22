/***********************************
Author: Lý Hoàng Tín 
Date Created: 15/09/2014
Last Updated: 16/09/2014
Updated By: Lý Hoàng Tín
Update description: 
************************************/

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
    public class PhieunhapPresenter : Presenter<IPhieunhapView>
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        public PhieunhapPresenter(IPhieunhapView view)
            : base(view)
        {
        }

        public void DisplayPhieunhap()
        {
            //try
            //{
                if (View.filterValue.Equals(null))
                {
                    View.filterValue = DateTime.Now;
                }
                var items = new List<AutoItem>
                {
                    new AutoItem
                    {
                        Name = "Ngaylap",
                        Value = View.filterValue,
                        SqlType = SqlDbType.DateTime,
                    },
                    //new AutoItem
                    //{
                    //    Name = "KhoId",
                    //    Value = View.KhoCurrentId,
                    //    SqlType = SqlDbType.UniqueIdentifier,
                    //}
                };

                View.PhieunhapItems = Model.Get<PhieunhapModel>(new AutoObject
                {
                    Items = items,
                    SpName = "Tin_GetPhieunhapTheoThang",
                });
                foreach (PhieunhapModel p in View.PhieunhapItems)
                {
                    var chitietItems = new List<AutoItem>
                    {
                        new AutoItem
                        {
                            Name = "PhieunhapId",
                            Value = p.PhieunhapId,
                            SqlType = SqlDbType.UniqueIdentifier
                        }
                    };
                    p.ListChitietPhieuNhap = Model.Get<ChitietPhieunhapModel>(new AutoObject
                    {
                        Items = chitietItems,
                        SpName = "Tin_GetChitietPhieunhapTheoPhieunhap",
                    });

                }
                List<PhieunhapModel> dsd = View.PhieunhapItems;
                View.RefreshData();
            //}
            //catch (Exception ex)
            //{
            //    //Check log flag and log error to file.
            //    if (isErrorEnabled)
            //    {
            //        logger.Error("Tin_GetPhieunhapTheoThang", ex);
            //    }
            //}
        }

        //public void DisplayNhacungcap()
        //{
        //    try
        //    {
        //        var listNhacungcap = new List<NhaCungcapModel>
        //        {
        //            new NhaCungcapModel
        //            {
        //                NhaCungcapId = new Guid("00000000-0000-0000-0000-000000000000"),
        //                TenNhaCungcap = "Tất cả",
        //                Active = false,
        //            }
        //        };
        //        listNhacungcap.AddRange(Model.Get<NhaCungcapModel>("sys_NhacungcapSelect"));
        //        View.NhacungcapItems = listNhacungcap;
        //        View.RefreshDataNhacungcap();
        //    }
        //    catch (Exception ex)
        //    {
        //        //Check log flag and log error to file.
        //        if (isErrorEnabled)
        //        {
        //            logger.Error("sys_NhacungcapSelect", ex);
        //        }
        //    }
        //}
        //public void DisplayKho()
        //{
        //    try
        //    {
        //        var listKho = new List<KhoModel>
        //        {
        //            new KhoModel
        //            {
        //                KhoId = new Guid("00000000-0000-0000-0000-000000000000"),
        //                TenKho = "Tất cả",
        //                Active = false,
        //            }
        //        };
        //        listKho.AddRange(Model.Get<KhoModel>("sys_KhoSelect"));
        //        View.KhoItems = listKho;
        //        View.RefreshDataKho();
        //    }
        //    catch (Exception ex)
        //    {
        //        //Check log flag and log error to file.
        //        if (isErrorEnabled)
        //        {
        //            logger.Error("sys_KhoSelect", ex);
        //        }
        //    }
        //}

        public void DisplayNhanvienCapnhat()
        {
            try
            {
                var items = new List<AutoItem>
                {
                    new AutoItem
                    {
                        Name = "UserId",
                        Value = ModelCore.UserId,
                        SqlType = SqlDbType.UniqueIdentifier
                    }
                };


                List<NhanvienModel> listNhanvien = Model.Get<NhanvienModel>(new AutoObject
                {
                    Items = items,
                    SpName = "Vinh_GetNhanvienTheoUserId"
                });
                if (listNhanvien == null)
                    return;
                View.NhanvienCapnhat = listNhanvien[0];
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
        /// Gets the hanghoa_ ton kho current.(Lấy tồn kho mới nhất của hàng hóa trong kho đó đó)
        /// </summary>
        /// <param name="hanghoaId">The hanghoa identifier.</param>
        /// <param name="khoId">The kho identifier.</param>
        /// <returns></returns>
        public TonkhoModel GetHanghoaTheoTonkhoCurrent(Guid? hanghoaId, Guid? khoId)
        {
            //try
            //{
            var items = new List<AutoItem>
            {
                new AutoItem
                {
                    Name = "KhoId",
                    Value = khoId.Value,
                    SqlType = SqlDbType.UniqueIdentifier
                },
                new AutoItem
                {
                    Name = "HanghoaId",
                    Value = hanghoaId.Value,
                    SqlType = SqlDbType.UniqueIdentifier
                }
            };
            //var tondemo = Model.Get<TonkhoModel>("sys_TonkhoSelect");
            var tonkhoitems = Model.Get<TonkhoModel>(new AutoObject
            {
                Items = items,
                SpName = "Tin_GetTonkhoMoinhatHanghoaTheoKho"
            });
            if (tonkhoitems.Count > 0)
            {
                var tonkhoitem = tonkhoitems[0];

                return tonkhoitem;
            }
            return null;

            //}
            //catch (Exception ex)
            //{
            //    //Check log flag and log error to file.
            //    if (isErrorEnabled)
            //    {
            //        logger.Error("Tin_GetTonkhoMaxHang_Kho", ex);
            //    }
            //    return null;
            //}
        }
        public Guid? GetPhieunhapTheoMa(PhieunhapModel p)
        {
            var items = new List<AutoItem>()
            {
                new AutoItem
                {
                   Name="PhieunhapId",
                   Value=p.PhieunhapId,
                   SqlType=SqlDbType.UniqueIdentifier
                }
            };
            var phieunhaps=Model.Get<PhieunhapModel>(new AutoObject{
                Items=items,
                SpName = "Tin_GetPhieunhapTheoMa"
            });
            return phieunhaps[0].TinhtrangPhieunhapCurrentId;
        }
        private List<TonkhoModel> UpdateTonkho(PhieunhapModel phieunhapitem, string codeTinhtrang)
        {
            //try
            //{
            var tonkhoitems = new List<TonkhoModel>();
            //Thêm mới tồn vào
            foreach (var p in phieunhapitem.ListChitietPhieuNhap)
            {
                // dong ton kho max cua hang hoa
                var Current = GetHanghoaTheoTonkhoCurrent(p.HanghoaId, phieunhapitem.KhoId);
                //se co nut cấu hình tồn kho ban đầu
                var tonkhoitem = new TonkhoModel
                {
                    HanghoaId = p.HanghoaId,
                    KhoId = phieunhapitem.KhoId,
                    NgayCapnhat = DateTime.Now,
                    SoduDauky = Current.SoluongTon,
                    SoluongNhap = p.Soluong,
                    SoluongTonDukien = p.Soluong + Current.SoluongTonDukien,
                    SoluongXuat = 0,
                    SoluongTon = Current.SoluongTon,
                    NhanvienCapnhat = phieunhapitem.NhanvienId,
                    Active = true

                    //set 

                };
                if (codeTinhtrang == "TTPN03") //Hủy
                {
                    tonkhoitem.SoluongTonDukien = Current.SoluongTonDukien - p.Soluong;

                }
                if (codeTinhtrang == "TTPN02") //Chốt
                {
                    tonkhoitem.SoluongTonDukien = Current.SoluongTonDukien;
                    tonkhoitem.SoluongTon = Current.SoluongTon + p.Soluong;


                }
                tonkhoitems.Add(tonkhoitem);
            }


            return tonkhoitems;
            //}
            //catch (Exception ex)
            //{
            //    //Check log flag and log error to file.
            //    if (isErrorEnabled)
            //    {
            //        logger.Error("Null", ex);
            //    }
            //    return null;
            //}
        }


        public bool AddNew()
        {
            //try
            //{
            //Guid? khocurrentId = View.KhoCurrentId;
            //if (khocurrentId == null)
            //{
            //    return false;
            //}
            //KhoModel khoCurrent = View.KhoItems.FirstOrDefault(p => p.KhoId == khocurrentId);
            //if (khoCurrent != null)
            //{
            //    if (khoCurrent.Active == false)
            //    {
            //        return false;
            //    }
            //}
            //Guid? nhacungcapCurrentId = View.NhacungcapCurrentId;
            ////
            //if (nhacungcapCurrentId == null)
            //{
            //    return false;
            //}
            //NhaCungcapModel nhacungcapCurrent =
            //    View.NhacungcapItems.FirstOrDefault(p => p.NhaCungcapId == nhacungcapCurrentId);
            //if (nhacungcapCurrent != null)
            //{
            //    if (nhacungcapCurrent.Active == false)
            //        return false;
            //}

            //if (nhacungcapCurrent != null)
            //    if (khoCurrent != null)
            //    {

                    var pn = new PhieunhapModel
                    {

                        //KhoId = khocurrentId,
                        //TenKho = khoCurrent.TenKho,
                        NhanvienId = View.NhanvienCapnhat.NhanvienId,
                        //NhacungcapId = nhacungcapCurrentId,
                        //TenNhaCungcap = nhacungcapCurrent.TenNhaCungcap,
                        TenNhanvien = View.NhanvienCapnhat.HovatenNhanvien,
                        Ngaylap = DateTime.Now,
                        ListChitietPhieuNhap = new List<ChitietPhieunhapModel>(),
                        ListTinhtrangPhieunhap = new List<TinhtrangPhieunhapModel>(),

                    };
                    var tinhtrangItems = Model.Get<TinhtrangModel>("sys_TinhtrangSelect");
                    if (tinhtrangItems != null)
                    {
                        var tinhtrangdalap = tinhtrangItems.FirstOrDefault(p => p.Code == "TTPN01") as TinhtrangModel;
                        //Set Tinh Trang ID da lap
                        pn.TinhtrangPhieunhapCurrentId = tinhtrangdalap.TinhtrangId;
                    }
                    View.PhieunhapItems.Add(pn);
                //}

            //Cập nhật thêm tình trạng
            //cập nhật tình trạng trước khi cập nhật vào tồn(lấy luôn cái tình trạng trên gd khỏi phải lọc database rùi lấy)
            View.RefreshData();
            return true;
            //}
            //catch (Exception ex)
            //{
            //    //Check log flag and log error to file.
            //    if (isErrorEnabled)
            //    {
            //        logger.Error("", ex);
            //    }
            //    return false;
            //}
        }

        /// <summary>
        /// Saves this instance.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            //try
            //{

            var phieunhapLuu =
                View.PhieunhapItems.Where(
                    p => (p.State == RowState.Insert || p.State == RowState.Update || p.State == RowState.Delete))
                    .Select(p=>p).ToList();
            ////_____________Thử group by_________________
            //var phieunhapLuu1 = phieunhapLuu;
            //foreach (var p in phieunhapLuu1)
            //{
            //    //p.ListChitietPhieuNhap = p.ListChitietPhieuNhap.GroupBy(l => l.HanghoaId).SelectMany(k => k.Select(kl => new ChitietPhieunhapModel
            //    //{
            //    //    ChitietPhieunhapId = kl.ChitietPhieunhapId,
            //    //    PhieunhapId = kl.PhieunhapId,
            //    //    HanghoaId = kl.HanghoaId,
            //    //    Soluong = k.Sum(c => c.Soluong),
            //    //    HSD = kl.HSD,
            //    //    NSX = kl.NSX,
            //    //    Gianhap = kl.Gianhap,
            //    //    Barcode = kl.Barcode,
            //    //    TenHanghoa = kl.TenHanghoa,
            //    //    Ghichu = kl.Ghichu,

            //    //})).ToList<ChitietPhieunhapModel>();
            //    p.ListChitietPhieuNhap = p.ListChitietPhieuNhap.GroupBy(l => l.HanghoaId).SelectMany(k => k.Select(kl => new ChitietPhieunhapModel
            //    {
            //        ChitietPhieunhapId = kl.ChitietPhieunhapId,
            //        PhieunhapId = kl.PhieunhapId,
            //        HanghoaId = kl.HanghoaId,
            //        Soluong = k.Sum(c => c.Soluong),
            //        HSD = kl.HSD,
            //        NSX = kl.NSX,
            //        Gianhap = kl.Gianhap,
            //        Barcode = kl.Barcode,
            //        TenHanghoa = kl.TenHanghoa,
            //        Ghichu = kl.Ghichu,

            //    })).ToList<ChitietPhieunhapModel>();
            //}
            ////nen xem xet dung first();
            //var hj = phieunhapLuu1;
            ////__________________________________________________
            //phieunhapCapnhatTonkho dùng để lấy những phiếu nhập cần cập nhật và group theo hàng hóa và sum lại trong chi tiết phiếu nhập
            //var phieunhapCapnhatTonkho =
            //    View.PhieunhapItems.Where(p => p.ListChitietPhieuNhap.Count(ct => (ct.State == RowState.Update || ct.State == RowState.Insert)) > 0).ToList();
            //foreach (var pn in phieunhapCapnhatTonkho)
            //{

            //    pn.ListChitietPhieuNhap = pn.ListChitietPhieuNhap.GroupBy(p => p.HanghoaId).Select(u =>new ChitietPhieunhapModel {
            //        ChitietPhieunhapId=u.First().ChitietPhieunhapId,
            //        Soluong=u.Sum(e=>e.Soluong),
            //        PhieunhapId=u.First().PhieunhapId,
            //        HanghoaId=u.First().HanghoaId,
            //        Gianhap=u.First().Gianhap,
            //        HSD=u.First().HSD,
            //        NSX=u.First().NSX,
            //        TenHanghoa=u.First().Ghichu,
            //        Thanhtien=u.Sum(e=>e.Thanhtien),
            //        Ghichu=u.First().Ghichu,
            //        //State=u.First().State,
            //        Step=u.First().Step,
            //        Barcode=u.First().Barcode,
            //        Version=u.First().Version
            //    }).ToList();
                
            //}
            //var democnton = phieunhapCapnhatTonkho;
            //Model.Set(View.PhieunhapItems);//2
            //Model.Set(phieunhapLuu);
            ////Cập nhật tình trạng phiếu nhập

            //var tonkhoitems = new List<TonkhoModel>();

            //foreach (PhieunhapModel p in View.PhieunhapItems) //2
            var phieunhapCapnhatTonkho = View.PhieunhapItems.Where(p => (p.State == RowState.Insert || p.State == RowState.Update)).ToList();
            Model.Set(phieunhapLuu);
            //var phieunhapCapnhatTonkho =
            //   View.PhieunhapItems.Where(p => (p.ListChitietPhieuNhap.Count(ct => (ct.State == RowState.Update || ct.State == RowState.Insert)) > 0)).ToList();
            foreach (PhieunhapModel p in phieunhapLuu)
            {
                var tinhtrangPhieunhapCurrent = new TinhtrangPhieunhapModel
                {
                    PhieunhapId = p.PhieunhapId,
                    TinhtrangId = p.TinhtrangPhieunhapCurrentId,
                    NhanvienCapnhat = p.NhanvienId,
                    NgayCapnhat = DateTime.Now
                };
                Model.Set(tinhtrangPhieunhapCurrent);
                Model.Set(p.ListChitietPhieuNhap); //(chỗ này nguy hiểm có thể sai cần xem lại)
            }
            //_________________________________group by________
            foreach (var pn in phieunhapCapnhatTonkho)
            {
                pn.ListChitietPhieuNhap = pn.ListChitietPhieuNhap.GroupBy(p => p.HanghoaId).Select(u => new ChitietPhieunhapModel
                {
                    ChitietPhieunhapId = u.First().ChitietPhieunhapId,
                    Soluong = u.Sum(e => e.Soluong),
                    PhieunhapId = u.First().PhieunhapId,
                    HanghoaId = u.First().HanghoaId,
                    Gianhap = u.First().Gianhap,
                    HSD = u.First().HSD,
                    NSX = u.First().NSX,
                    TenHanghoa = u.First().Ghichu,
                    Thanhtien = u.Sum(e => e.Thanhtien),
                    Ghichu = u.First().Ghichu,
                    //State=u.First().State,
                    Step = u.First().Step,
                    Barcode = u.First().Barcode,
                    Version = u.First().Version
                }).ToList();
            }
            //___________________________________________________
            //__________________________________________1
            foreach (var p in phieunhapCapnhatTonkho)
            {

                //foreach (ChitietPhieunhapModel p1 in p.ListChitietPhieuNhap)
                //{
                //    //if (p.State == RowState.Insert || p.State == RowState.Update || p.State == RowState.Delete)
                //    //{
                //    var tonkhoitem = GetHanghoaTheoTonkhoCurrent(p1.HanghoaId, p.KhoId);
                //    tonkhoitem.SoluongNhap = p1.Soluong;
                    var tinhtrangItems = Model.Get<TinhtrangModel>("sys_TinhtrangSelect");
                    var tinhtrangCurrent =
                        tinhtrangItems.FirstOrDefault(f => f.TinhtrangId == p.TinhtrangPhieunhapCurrentId);
                    //var tonkhoitems1 = new List<TonkhoModel>();
                    if (tinhtrangCurrent != null)
                    {
                        var tonkhoitems = UpdateTonkho(p, tinhtrangCurrent.Code);
                        Model.Set(tonkhoitems);
                    }
                    //_____________________________________________________________________________________________1
                //}
            }

            //}
            //___________________________________________________________________________________
            //}//2

            //Model.Set(tonkhoitems);

            View.RefreshData();
            return true;
            //}
            //catch (Exception ex)
            //{
            //    //Check log flag and log error to file.
            //    if (isErrorEnabled)
            //    {
            //        logger.Error("Save", ex);
            //    }
            //    return false;
            //}
        }

        public bool Delete()
        {
            try
            {
                PhieunhapModel current = View.PhieunhapCurrent;
                if (current == null)
                {
                    return false;
                }

                if (current.State == RowState.Insert)
                {
                    View.PhieunhapItems.Remove(current);
                    View.RefreshData();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("Delete", ex);
                }
                return false;
            }
        }
    }
}