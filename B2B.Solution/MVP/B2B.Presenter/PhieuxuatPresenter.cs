/********************************************************************
	Class file: 
    Author: Tran Nguyen Hoang Khuyen
    Date Created: 23/09/2014
	Last Updated: 17/01/2014
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
    public class PhieuxuatPresenter : Presenter<IPhieuxuatView>
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        public PhieuxuatPresenter(IPhieuxuatView view)
            : base(view) { }



        public bool Addnew()
        {
            //try
            //{
                var DonhangCurrent = View.DonhangCurrent as DonhangModel;
                var TinhtrangDonhangDachot = Model.Get<TinhtrangModel>("sys_TinhtrangSelect").FirstOrDefault(p => p.Code == "TTDH06");
                var TinhtrangDonhangDahuy = Model.Get<TinhtrangModel>("sys_TinhtrangSelect").FirstOrDefault(p => p.Code == "TTDH03");
                if (DonhangCurrent == null || DonhangCurrent.TinhtrangDonhangCurrentId == TinhtrangDonhangDachot.TinhtrangId || DonhangCurrent.TinhtrangDonhangCurrentId == TinhtrangDonhangDahuy.TinhtrangId)
                {
                    return false;
                }
                var phieuxuat = new PhieuxuatModel
                {
                    NgayCapnhat = DateTime.Now,
                    DonhangId = DonhangCurrent.DonhangId,
                    Ngaylap = DateTime.Now,
                    NgaylapDonhang = DonhangCurrent.Ngaylap,
                    NhanvienLapId = View.NhanvienCapNhat.NhanvienId,
                    TenNhanvienLap = View.NhanvienCapNhat.HovatenNhanvien,
                    NhanvienCapnhatId = View.NhanvienCapNhat.NhanvienId,
                    TenNhanvienCapnhat = View.NhanvienCapNhat.HovatenNhanvien,
                    NhanvienDonhang = DonhangCurrent.NhanvienId,
                    //KhoId = DonhangCurrent.KhoId,
                    //TenKho = DonhangCurrent.TenKho,
                    CodeDonhang = DonhangCurrent.Code,
                    //TonkhoItems = new List<TonkhoModel>(),
                    ChitietPhieuxuatItems = new List<ChitietPhieuxuatModel>(),
                    Donhang = DonhangCurrent
                };
                var tinhtrangdalap = Model.Get<TinhtrangModel>("sys_TinhtrangSelect").FirstOrDefault(p => p.Code == "TTPX001") as TinhtrangModel;
                var khodalap = Model.Get<KhoModel>("sys_KhoSelect").First() as KhoModel;
                var nvgiaohangdalap = Model.Get<NhanvienModel>("sys_NhanvienSelect").First() as NhanvienModel;
                var nguyennhanlydodalap = Model.Get<NguyennhanLydoModel>("sys_NguyennhanLydoSelect").First() as NguyennhanLydoModel;
                phieuxuat.TinhtrangPhieuxuatCurrentId = tinhtrangdalap.TinhtrangId;
                phieuxuat.KhoId = khodalap.KhoId;
                phieuxuat.NhanvienGiaohangId = nvgiaohangdalap.NhanvienId;
                phieuxuat.NguyennhanLydo = nguyennhanlydodalap.NguyennhanLydoId;
                //phieuxuat.TenTinhtrangPhieuxuat = tinhtrangdalap.TenTinhtrang;
                //tao phieu xuat moi
                View.PhieuxuatItems.Add(phieuxuat);
                View.RefreshData();
                return true;
            //}
            //catch (System.Exception ex)
            //{
            //    //Check log flag and log error to file.
            //    if (isErrorEnabled)
            //    {
            //        logger.Error("Add new", ex);
            //    }
            //    return false;
            //}
        }


        public bool Save()
        {
            //try
            //{
                List<PhieuxuatModel> PhieuxuatLuu = new List<PhieuxuatModel>();
                List<int> rowStates = new List<int>();
                for (int i = 0; i < View.PhieuxuatItems.Count; ++i)
                {
                    if (View.PhieuxuatItems[i].State == RowState.Insert || View.PhieuxuatItems[i].State == RowState.Update)
                    {
                        if(View.PhieuxuatItems[i].State == RowState.Insert)
                        {
                            rowStates.Add(1);
                        }
                        else if(View.PhieuxuatItems[i].State == RowState.Update)
                        {
                            rowStates.Add(2);
                        }
                        else rowStates.Add(0);
                        PhieuxuatLuu.Add(View.PhieuxuatItems[i]);
                    }
                }
                //var PhieuxuatLuuTonkho = PhieuxuatLuu as List<PhieuxuatModel>;
                foreach (var item in View.PhieuxuatItems)
                {
                    item.NgayCapnhat = DateTime.Now;
                }
                Model.Set(View.PhieuxuatItems);
                for (int i = 0; i < PhieuxuatLuu.Count; ++i)
                {
                    //Save chi tiet phieu xuat
                    var chiTietPhieuXuatItemsLLuu = PhieuxuatLuu[i].ChitietPhieuxuatItems as List<ChitietPhieuxuatModel>;
                    Model.Set(chiTietPhieuXuatItemsLLuu);

                    //Save tinh trang phieu xuat
                    var TinhtrangPhieuXuatCurrent = new TinhtrangPhieuxuatModel
                    {
                        TinhtrangId = PhieuxuatLuu[i].TinhtrangPhieuxuatCurrentId,
                        PhieuxuatId = PhieuxuatLuu[i].PhieuxuatId,
                        NgayCapnhat = DateTime.Now
                    };
                    Model.Set(TinhtrangPhieuXuatCurrent);

                    //Save chi tiet don hang
                    Model.Set(PhieuxuatLuu[i].Donhang.ChitietDonhangItems);

                    //Save cong no xuat
                    CapnhatCongnoXuat(PhieuxuatLuu[i],rowStates[i]);
                    if (PhieuxuatLuu[i].CongnoXuat !=null)
                    {
                        Model.Set(PhieuxuatLuu[i].CongnoXuat);
                    }


                    //Save ton kho
                    PhieuxuatLuu[i].ChitietPhieuxuatItems = PhieuxuatLuu[i].ChitietPhieuxuatItems.GroupBy(p => p.HanghoaId).Select(u => new ChitietPhieuxuatModel
                    {
                        Soluong = u.Sum(e => e.Soluong),
                        HanghoaId = u.First().HanghoaId,
                        Thanhtien = u.Sum(e => e.Thanhtien),
                    }).ToList();
                    CapnhatTonkho(PhieuxuatLuu[i], rowStates[i]);
                    Model.Set(PhieuxuatLuu[i].TonkhoItems);

                }
                View.RefreshData();
                return true;
            //}
            //catch (System.Exception ex)
            //{
            //    //Check log flag and log error to file.
            //    if (isErrorEnabled)
            //    {
            //        logger.Error("Save", ex);
            //    }
            //    return false;
            //}
        }

        public void Delete()
        {
            try
            {
                var currentPhieuxuat = View.PhieuxuatCurrent as PhieuxuatModel;
                if (currentPhieuxuat == null)
                {
                    return;
                }
                if (currentPhieuxuat.State == BusinessObject.RowState.Insert)
                {
                    View.PhieuxuatItems.Remove(currentPhieuxuat);
                    View.RefreshData();
                    return;
                }
                currentPhieuxuat.MakeDelete();
                View.RefreshData();
            }
            catch (System.Exception ex)
            {
            	//Check log flag and log error to file.
            	if (isErrorEnabled)
            	{
            		logger.Error(string.Format("Delete id: {0} ", View.PhieuxuatCurrent.PhieuxuatId, ex));
            	}
            	return;
            }
        }

        public void DisplayDonhang()
        {
            try
            {

                var items = new List<AutoItem>();
                items.Add(new AutoItem
                {
                    Name = "Ngaylap",
                    Value = View.filterValue,
                    SqlType = System.Data.SqlDbType.DateTime
                });
                View.DonhangItems = Model.Get<DonhangModel>(new AutoObject
                {
                    Items = items,
                    SpName = "Vinh_GetDonhangTheoThang_koloaidonhang"
                });
                View.RefreshData();
            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error(string.Format("NgayLap: {0}, SProc: {1}", View.filterValue, "Vinh_GetDonhangTheoThang_koloaidonhang"), ex);
                }
            }
        }

        public void DisplayPhieuxuatTheoDonhang()
        {
            try
            {
                var current = View.DonhangCurrent as DonhangModel;
                if (current == null)
                {
                    return;
                }

                var items = new List<AutoItem>();
                items.Add(new AutoItem
                {
                    Name = "DonhangId",
                    Value = current.DonhangId,
                    SqlType = System.Data.SqlDbType.UniqueIdentifier
                });

                View.PhieuxuatItems = Model.Get<PhieuxuatModel>(new AutoObject
                {
                    Items = items,
                    SpName = "Khuyen_GetPhieuxuatTheoDonhang"
                });

                View.RefreshData();
            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error(string.Format("Name: {0} SpName: {1}", "DonhangId", "Khuyen_GetPhieuxuatTheoDonhang"), ex);
                }
            }
        }

        public void DisplayNhanvienCapnhat()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem
            {
                Name = "UserId",
                Value = ModelCore.UserId,
                SqlType = System.Data.SqlDbType.UniqueIdentifier
            });

            View.NhanvienCapNhat = Model.Get<NhanvienModel>(new AutoObject
            {
                Items = items,
                SpName = "Vinh_GetNhanvienTheoUserId"
            }).FirstOrDefault();
        }

        public void CapnhatTonkho(PhieuxuatModel px,int rowState)
        {
            px.TonkhoItems = new List<TonkhoModel>();
            var tinhtrangChot = Model.Get<TinhtrangModel>("sys_TinhtrangSelect").FirstOrDefault(p => p.Code == "TTPX002") as TinhtrangModel;
            var tinhtrangHuy = Model.Get<TinhtrangModel>("sys_TinhtrangSelect").FirstOrDefault(p => p.Code == "TTPX003") as TinhtrangModel;

            for (int i = 0; i < px.ChitietPhieuxuatItems.Count; ++i)
            {
                if (px.ChitietPhieuxuatItems[i].Soluong != 0)
                {
                    var chitietPhieuxuat = px.ChitietPhieuxuatItems[i] as ChitietPhieuxuatModel;

                    //Lay ton kho hien tai cua mat hang o kho tuong ung
                    var items = new List<AutoItem>();
                    items.Add(new AutoItem()
                    {
                        Name = "KhoId",
                        Value = px.KhoId,
                        SqlType = System.Data.SqlDbType.UniqueIdentifier
                    });
                    items.Add(new AutoItem()
                    {
                        Name = "HanghoaId",
                        Value = chitietPhieuxuat.HanghoaId,
                        SqlType = System.Data.SqlDbType.UniqueIdentifier
                    });

                    var tonkhoItems = Model.Get<TonkhoModel>(new AutoObject
                    {
                        Items = items,
                        SpName = "Tin_GetTonkhoMoinhatHanghoaTheoKho"
                    }) as List<TonkhoModel>;
                    int? SoluongTon = 0;
                    int? SoluongTonDukien = 0;
                    if(tonkhoItems.Count > 0)
                    {
                        var tonkho = tonkhoItems[0] as TonkhoModel;
                        SoluongTon = tonkho.SoluongTon;
                        SoluongTonDukien = tonkho.SoluongTonDukien;
                    }
                    


                    TonkhoModel tk = new TonkhoModel()
                    {
                        HanghoaId = chitietPhieuxuat.HanghoaId,
                        KhoId = px.KhoId,
                        NgayCapnhat = DateTime.Now,
                        Ngay = DateTime.Now.Day,
                        Thang = DateTime.Now.Month,
                        Nam = DateTime.Now.Year,
                        GioCapnhat = DateTime.Now,
                        SoduDauky = SoluongTon,
                        SoluongNhap = 0,
                        SoluongXuat = chitietPhieuxuat.Soluong,
                        SoluongTon = SoluongTon,
                        NhanvienCapnhat = px.NhanvienCapnhatId,
                        Active = true,
                        ThanhtienXuat = chitietPhieuxuat.Thanhtien
                    };
                    if(px.TinhtrangPhieuxuatCurrentId == tinhtrangChot.TinhtrangId)
                    {
                        tk.SoluongTonDukien = SoluongTonDukien - chitietPhieuxuat.Soluong;
                        tk.SoluongTon -= chitietPhieuxuat.Soluong;
                        px.TonkhoItems.Add(tk);
                    }
                    else if(px.TinhtrangPhieuxuatCurrentId == tinhtrangHuy.TinhtrangId)
                    {
                        if (rowState == 2)
                        {
                            tk.SoluongTonDukien = SoluongTonDukien + chitietPhieuxuat.Soluong;
                            px.TonkhoItems.Add(tk);
                        }
                    }
                    else
                    {
                        if (rowState == 1)
                        {
                            px.TonkhoItems.Add(tk);
                        }
                    }
                    
                }
            }

        }

        public void CapnhatCongnoXuat(PhieuxuatModel px, int rowState)
        {
            var tinhtrangHuy = Model.Get<TinhtrangModel>("sys_TinhtrangSelect").FirstOrDefault(p => p.Code == "TTPX003") as TinhtrangModel;
            if ((rowState == 1 && px.TinhtrangPhieuxuatCurrentId != tinhtrangHuy.TinhtrangId) || (px.TinhtrangPhieuxuatCurrentId == tinhtrangHuy.TinhtrangId && rowState == 2))
            { 
                px.CongnoXuat = new CongnoXuatModel();
                double? tongThanhtien = 0;
                for (int i = 0; i < px.ChitietPhieuxuatItems.Count; ++i)
                {
                    if (px.ChitietPhieuxuatItems[i].Thanhtien != null)
                    {
                        tongThanhtien += px.ChitietPhieuxuatItems[i].Thanhtien;
                    }
                }
                var items = new List<AutoItem>();
                items.Add(new AutoItem()
                {
                    Name = "KhachhangId",
                    Value = px.Donhang.KhachhangId,
                    SqlType = System.Data.SqlDbType.UniqueIdentifier
                });

                var congnoItems = Model.Get<CongnoXuatModel>(new AutoObject
                {
                    Items = items,
                    SpName = "Khuyen_GetCongnoXuatMoinhatTheoKhachhang"
                }) as List<CongnoXuatModel>;
                
                double? TongnoTheoCongNo = 0;
                if(congnoItems.Count > 0)
                {
                    var congnoMoinhat = congnoItems[0] as CongnoXuatModel;
                    TongnoTheoCongNo = congnoMoinhat.Tongno;
                }
                CongnoXuatModel cnx = new CongnoXuatModel
                {
                    KhachhangId = px.Donhang.KhachhangId,
                    Dienthoai = string.IsNullOrWhiteSpace(px.Donhang.SoDienthoai)?"":px.Donhang.SoDienthoai.Split(',')[0],
                    Diachi = px.Donhang.DiachiGiao,
                    NgayGiaodich = DateTime.Now,
                    SoduTruocGiaodich = TongnoTheoCongNo,
                    SotienGiaodich = tongThanhtien,
                    NgayhenTra = px.Donhang.HanDonhang,
                    NhanvienId = View.NhanvienCapNhat.NhanvienId,
                    Ghichu = px.Ghichu
                };
                if (rowState == 1)
                {
                    cnx.Tongno = TongnoTheoCongNo + cnx.SotienGiaodich;  
                }
                else if (px.TinhtrangPhieuxuatCurrentId == tinhtrangHuy.TinhtrangId)
                {
                    cnx.Tongno = TongnoTheoCongNo - cnx.SotienGiaodich;
                }
                px.CongnoXuat = cnx;
            }

        }

        public bool CheckTinhtrangPhieuxuatChotHoacHuy()
        {
            var TinhtrangPhieuxuatChot = Model.Get<TinhtrangModel>("sys_TinhtrangSelect").FirstOrDefault(p => p.Code == "TTPX002");
            var TinhtrangPhieuxuatHuy = Model.Get<TinhtrangModel>("sys_TinhtrangSelect").FirstOrDefault(p => p.Code == "TTPX003");
            if (View.PhieuxuatCurrent.TinhtrangPhieuxuatCurrentId == TinhtrangPhieuxuatChot.TinhtrangId || View.PhieuxuatCurrent.TinhtrangPhieuxuatCurrentId == TinhtrangPhieuxuatHuy.TinhtrangId)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool LapPhieuthuButtonDisable()
        {
            if (View.PhieuxuatCurrent != null)
            {
                if (CheckTinhtrangPhieuxuatChotHoacHuy() || View.PhieuxuatCurrent.State != RowState.UnChange)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            return true;
        }

        public void AddPhieuthu(ThuchiModel pt)
        {
            pt.PhieuxuatId = View.PhieuxuatCurrent.PhieuxuatId;
            pt.Vaoluc = DateTime.Now;
            pt.Ngay = pt.Vaoluc.Value.Day;
            pt.Thang = pt.Vaoluc.Value.Month;
            pt.Nam = pt.Vaoluc.Value.Year;
            pt.NhanvienId = View.NhanvienCapNhat.NhanvienId;
            pt.NhannopTienId = View.DonhangCurrent.KhachhangId;
            pt.TenNhannopTien = View.DonhangCurrent.TenKhachhang;
        }

        public bool HuyPhieuxuat()
        {
            try
            {
                var tinhtrangHuy = Model.Get<TinhtrangModel>("sys_TinhtrangSelect").FirstOrDefault(p => p.Code == "TTPX003") as TinhtrangModel;
                View.PhieuxuatCurrent.TinhtrangPhieuxuatCurrentId = tinhtrangHuy.TinhtrangId;
                Model.Set(View.PhieuxuatCurrent);

                //Cap nhat tinh trang
                var TinhtrangPhieuXuatCurrent = new TinhtrangPhieuxuatModel
                {
                    TinhtrangId = View.PhieuxuatCurrent.TinhtrangPhieuxuatCurrentId,
                    PhieuxuatId = View.PhieuxuatCurrent.PhieuxuatId,
                    NgayCapnhat = DateTime.Now
                };
                Model.Set(TinhtrangPhieuXuatCurrent);


                return true;
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("Huy phieu xuat", ex);
                }
                return false;
            }
            

        }
    }
}
