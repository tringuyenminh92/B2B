/********************************************************************
	Class file: 
    Author: Tran Nguyen Hoang Khuyen
    Date Created: 23/09/2014
	Last Updated: 13/12/2014
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
            try
            {
                var DonhangCurrent = View.DonhangCurrent as DonhangModel;
                if (DonhangCurrent == null)
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
                    //KhoId = DonhangCurrent.KhoId,
                    //TenKho = DonhangCurrent.TenKho,
                    CodeDonhang = DonhangCurrent.Code,
                    TonkhoItems = new List<TonkhoModel>(),
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
            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("Add new", ex);
                }
                return false;
            }
        }


        public bool Save()
        {
            //try
            //{
                List<PhieuxuatModel> PhieuxuatLuu = new List<PhieuxuatModel>();
                for (int i = 0; i < View.PhieuxuatItems.Count; ++i)
                {
                    if (View.PhieuxuatItems[i].State == RowState.Insert || View.PhieuxuatItems[i].State == RowState.Update)
                    {
                        PhieuxuatLuu.Add(View.PhieuxuatItems[i]);
                    }
                }
                var PhieuxuatLuuTonkho = PhieuxuatLuu as List<PhieuxuatModel>;
                foreach (var item in View.PhieuxuatItems)
                {
                    item.NgayCapnhat = DateTime.Now;
                }
                Model.Set(View.PhieuxuatItems);
                for (int i = 0; i < PhieuxuatLuu.Count; ++i)
                {
                    if (View.PhieuxuatItems[i].State == RowState.Insert || View.PhieuxuatItems[i].State == RowState.Update)
                    {
                        //Save chi tiet phieu xuat
                        Model.Set(PhieuxuatLuu[i].ChitietPhieuxuatItems);

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
                    }
                }
                foreach (var px in PhieuxuatLuuTonkho)
                {
                    px.ChitietPhieuxuatItems = px.ChitietPhieuxuatItems.GroupBy(p => p.HanghoaId).Select(u => new ChitietPhieuxuatModel
                    {
                        Soluong = u.Sum(e => e.Soluong),
                        HanghoaId = u.First().HanghoaId,
                        Thanhtien = u.Sum(e => e.Thanhtien),
                    }).ToList();
                    CapnhatTonkho(px);
                    Model.Set(px.TonkhoItems);
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
            //try
            //{
            //    View.DonhangItems = Model.Get<DonhangModel>("Khuyen_GetDonhang");
            //    View.RefreshDataDonhang();
            //}
            //catch (System.Exception ex)
            //{
            //    //Check log flag and log error to file.
            //    if (isErrorEnabled)
            //    {
            //        logger.Error("Khuyen_GetDonhang", ex);
            //    }
            //    return;
            //}

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

        public void CapnhatTonkho(PhieuxuatModel px)
        {
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

                    var tonkho = tonkhoItems[0] as TonkhoModel;

                    TonkhoModel tk = new TonkhoModel()
                    {
                        HanghoaId = chitietPhieuxuat.HanghoaId,
                        KhoId = px.KhoId,
                        NgayCapnhat = DateTime.Now,
                        Ngay = DateTime.Now.Day,
                        Thang = DateTime.Now.Month,
                        Nam = DateTime.Now.Year,
                        GioCapnhat = DateTime.Now,
                        SoduDauky = tonkho.SoluongTon,
                        SoluongNhap = 0,
                        SoluongXuat = chitietPhieuxuat.Soluong,
                        SoluongTon = tonkho.SoluongTon,
                        NhanvienCapnhat = px.NhanvienCapnhatId,
                        Active = true,
                        ThanhtienXuat = chitietPhieuxuat.Thanhtien
                    };
                    if(px.TinhtrangPhieuxuatCurrentId == tinhtrangChot.TinhtrangId)
                    {
                        tk.SoluongTonDukien = tonkho.SoluongTonDukien - chitietPhieuxuat.Soluong;
                        tk.SoluongTon = tk.SoluongTonDukien;
                        px.TonkhoItems.Add(tk);
                    }
                    else if(px.TinhtrangPhieuxuatCurrentId == tinhtrangHuy.TinhtrangId)
                    {
                        if(px.State == RowState.Update)
                        {
                            tk.SoluongTonDukien = tonkho.SoluongTonDukien + chitietPhieuxuat.Soluong;
                            px.TonkhoItems.Add(tk);
                        }
                    }
                    else
                    {
                        if (px.State == RowState.Insert)
                        {
                            tk.SoluongTonDukien = tonkho.SoluongTonDukien - chitietPhieuxuat.Soluong;
                            px.TonkhoItems.Add(tk);
                        }
                    }
                    
                }
            }

        }
    }
}
