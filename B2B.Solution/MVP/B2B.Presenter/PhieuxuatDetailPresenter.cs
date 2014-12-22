/********************************************************************
	Interface file: 
    Author: Pham Xuân Vinh
    Date Created: 23/09/2014
	Last Updated: 08/11/2014
	Updated By: Pham Xuân Vinh
	Update Description:
*********************************************************************/
using BMIModel;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B2B.Model;
using B2B.View;
using BusinessObject;

namespace B2B.Presenter
{
    public class PhieuxuatDetailPresenter : Presenter<IPhieuxuatDetailView>
    {
       
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        public PhieuxuatDetailPresenter(IPhieuxuatDetailView view) : base(view) { }

        public void DisplayKho()
        {
            try
            {
                View.KhoItems = Model.Get<KhoModel>("Vinh_GetKhoActive");
            }
            catch (System.Exception ex)
            {
            	//Check log flag and log error to file.
            	if (isErrorEnabled)
            	{
                    logger.Error("Vinh_GetKhoActive", ex);
            	}
            	return;
            }
        }

        public void DisplayNhanvienGiaohang()
        {
            try
            {
                View.NhanvienGiaohangItems = Model.Get<NhanvienModel>("Tri_GetNhanvienActive");
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

        public void DisplayTinhtrang()
        {
            try
            {
                View.TinhtrangItems = Model.Get<TinhtrangModel>("Vinh_GetTinhtrangActive");
            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("Vinh_GetTinhtrangActive", ex);
                }
                return;
            }
        }
        
        public void DisplayNguyennhanLydo()
        {
            try
            {
                View.NguyennhanLydoItems = Model.Get<NguyennhanLydoModel>("Vinh_GetNguyennhanLydoActive");
            }
            catch (System.Exception ex)
            {
                {
                    if (isErrorEnabled)
                    {
                        logger.Error("Vinh_GetNguyennhanLydoActive", ex);
                    }
                    return;
                }
            }
        }

        public void DisplayDonhang()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem
            {
                Name = "DonhangId",
                Value = View.ValuePhieuxuat.DonhangId,
                SqlType = System.Data.SqlDbType.UniqueIdentifier
            });
            var donhang = Model.Get<DonhangModel>(new AutoObject
            {
                Items = items,
                SpName = "Vinh_GetDonhangTheoDonhangId"
            }) as List<DonhangModel>;

            View.ValuePhieuxuat.Donhang = donhang[0];
        }

        public void DisplayChitietPhieuxuat()
        {
            var lstChitietDonhang = View.ValuePhieuxuat.Donhang.ChitietDonhangItems as List<ChitietDonhangModel>;

            var items = new List<AutoItem>();
            items.Add(new AutoItem
            {
                Name = "PhieuxuatId",
                Value = View.ValuePhieuxuat.PhieuxuatId,
                SqlType = System.Data.SqlDbType.UniqueIdentifier
            });
            var chitietPhieuxuatItems = Model.Get<ChitietPhieuxuatModel>(new AutoObject
            {
                Items = items,
                SpName = "Vinh_GetChitietPhieuxuatTheoPhieuxuat"
            }) as List<ChitietPhieuxuatModel>; 
            
            if(chitietPhieuxuatItems.Count==0)
            {
                //tao chi tiet phieu xuat moi ung voi cac mat hang trong don hang
                for (int i = 0; i < lstChitietDonhang.Count; ++i)
                {
                    chitietPhieuxuatItems.Add(new ChitietPhieuxuatModel()
                    {
                        PhieuxuatId = View.ValuePhieuxuat.PhieuxuatId,
                        ChitietDonhangId = lstChitietDonhang[i].ChitietDonhangId,
                        HanghoaId = lstChitietDonhang[i].HanghoaId,
                        TenHanghoa = lstChitietDonhang[i].TenHanghoa,
                        Soluong = 0,
                        Thanhtien = lstChitietDonhang[i].Thanhtien
                    });
                }
            }
            else
            {
                int flag = 0;
                foreach (var ctdh in lstChitietDonhang)
                {
                    foreach (var ctpx in chitietPhieuxuatItems)
                    {
                        if (ctdh.ChitietDonhangId == ctpx.ChitietDonhangId)
                        {
                            flag = 1;
                        }
                    }
                    if (flag == 0)
                    {
                        chitietPhieuxuatItems.Add(new ChitietPhieuxuatModel()
                        {
                            PhieuxuatId = View.ValuePhieuxuat.PhieuxuatId,
                            ChitietDonhangId = ctdh.ChitietDonhangId,
                            HanghoaId = ctdh.HanghoaId,
                            TenHanghoa = ctdh.TenHanghoa,
                            Soluong = 0,
                            Thanhtien = ctdh.Thanhtien
                        });
                    }
                    else { flag = 0; }
                }
            }
            foreach (var ctpx in chitietPhieuxuatItems)
            {
                foreach (var ctdh in lstChitietDonhang)
                {
                    if (ctpx.ChitietDonhangId == ctdh.ChitietDonhangId)
                    {
                        ctpx.SoluongCanXuat = ctdh.Soluong;
                        ctpx.SoluongDaXuat = ctdh.SoluongGiao;

                    }
                }
            }
            //for (int i = 0; i < lstChitietDonhang.Count; ++i)
            //{
            //    //chitietPhieuxuatItems[i].SoluongCanXuat = lstChitietDonhang[i].Soluong - lstChitietDonhang[i].SoluongGiao;
            //    chitietPhieuxuatItems[i].SoluongCanXuat = lstChitietDonhang[i].Soluong;
            //    chitietPhieuxuatItems[i].SoluongDaXuat = lstChitietDonhang[i].SoluongGiao;
            //}

            View.ValuePhieuxuat.ChitietPhieuxuatItems = chitietPhieuxuatItems;
        }

        public void DisplayTinhtrangPhieuxuat()
        {
            //var items = new List<AutoItem>();
            //items.Add(new AutoItem
            //{
            //    Name = "PhieuxuatId",
            //    Value = View.ValuePhieuxuat.PhieuxuatId,
            //    SqlType = System.Data.SqlDbType.UniqueIdentifier
            //});

            //Lay list tinh trang cua phieu xuat
            //View.ValuePhieuxuat.TinhtrangPhieuxuatItems = Model.Get<TinhtrangPhieuxuatModel>(new AutoObject
            //{
            //    Items = items,
            //    SpName = "Vinh_GetTinhtrangPhieuxuatTheoPhieuxuat"
            //}) as List<TinhtrangPhieuxuatModel>;

            //Lay tinh trang phieu xuat moi nhat
            //var tinhtrangPhieuxuatMoinhat = Model.Get<TinhtrangPhieuxuatModel>(new AutoObject
            //{
            //    Items = items,
            //    SpName = "Vinh_GetTinhtrangPhieuxuatMoiNhatTheoPhieuxuat"
            //}) as List<TinhtrangPhieuxuatModel>;

            //if (tinhtrangPhieuxuatMoinhat.Count != 0)
            //{
            //    View.ValuePhieuxuat.TinhtrangPhieuxuatCurrentId = tinhtrangPhieuxuatMoinhat[0].TinhtrangId;
            //    View.ValuePhieuxuat.TenTinhtrangPhieuxuat = tinhtrangPhieuxuatMoinhat[0].TenTinhtrang;
            //}
        }

        public void DisplayChitietDonhang()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem
            {
                Name = "DonhangId",
                Value = View.ValuePhieuxuat.Donhang.DonhangId,
                SqlType = System.Data.SqlDbType.UniqueIdentifier
            });

            var chitietDonhangItems = Model.Get<ChitietDonhangModel>(new AutoObject
            {
                Items = items,
                SpName = "Vinh_GetChitietDonhangTheoDonHang"
            }) as List<ChitietDonhangModel>;

            //Gan gia tri ban dau cho so luong giao va so luong con lai neu bang null
            foreach (var ctdh in chitietDonhangItems)
            {
                ctdh.SoluongGiao = ctdh.SoluongGiao.HasValue ? ctdh.SoluongGiao.Value : 0;
                ctdh.SoluongConlai = ctdh.SoluongConlai.HasValue ? ctdh.SoluongConlai.Value : 0;
            }

            View.ValuePhieuxuat.Donhang.ChitietDonhangItems = chitietDonhangItems;
            
        }
        public void CapnhatChitietPhieuxuat()
        {
            var chitietPhieuxuatTemp = new List<ChitietPhieuxuatModel>();
            for (int i = 0; i < View.ValuePhieuxuat.ChitietPhieuxuatItems.Count; ++i)
            {
                if (View.ValuePhieuxuat.ChitietPhieuxuatItems[i].Soluong == 0)
                {
                    chitietPhieuxuatTemp.Add(View.ValuePhieuxuat.ChitietPhieuxuatItems[i]);
                }
            }
            for(int i = 0; i<chitietPhieuxuatTemp.Count;++i)
            {
                View.ValuePhieuxuat.ChitietPhieuxuatItems.Remove(chitietPhieuxuatTemp[i]);
            }
        }
        public void CapnhatChitietDonhang()
        {
            foreach ( var ctdh in View.ValuePhieuxuat.Donhang.ChitietDonhangItems)
            {
                foreach (var ctpx in View.ValuePhieuxuat.ChitietPhieuxuatItems)
                {
                    if(ctdh.ChitietDonhangId == ctpx.ChitietDonhangId)
                    {
                        int? soLuongXuat = ctpx.Soluong;
                        int? soLuongConlai = ctdh.SoluongConlai;
                        int? soLuongDukien = ctdh.Soluong;
                        int? soLuongDaGiao = ctdh.SoluongGiao;

                        //Cap nhat so luong giao
                        soLuongDaGiao += soLuongXuat;

                        //Cap nhat so luong du kien o don hang neu so luong xuat lon hon so luong du kien
                        if (soLuongDaGiao > soLuongDukien)
                        {
                            soLuongDukien = soLuongDaGiao;
                        }

                        //Cap nhat so luong con lai
                        soLuongConlai = soLuongDukien - soLuongDaGiao;

                        ctdh.SoluongGiao = soLuongDaGiao;
                        ctdh.Soluong = soLuongDukien;
                        ctdh.SoluongConlai = soLuongConlai;
                    }
                }
            }

            //for(int i = 0; i<View.ValuePhieuxuat.Donhang.ChitietDonhangItems.Count;++i)
            //{
            //    if (View.ValuePhieuxuat.ChitietPhieuxuatItems[i].ChitietDonhangId == View.ValuePhieuxuat.Donhang.ChitietDonhangItems[i].ChitietDonhangId)
            //    {
                    // View.ValuePhieuxuat.ChitietPhieuxuatItems.Where(p=>p.ChitietDonhangId==View.ValueDonhang.DonhangId)
                    //int? soLuongXuat = View.ValuePhieuxuat.ChitietPhieuxuatItems[i].Soluong;
                    //int? soLuongConlai = View.ValuePhieuxuat.Donhang.ChitietDonhangItems[i].SoluongConlai;
                    //int? soLuongDukien = View.ValuePhieuxuat.Donhang.ChitietDonhangItems[i].Soluong;
                    //int? soLuongDaGiao = View.ValuePhieuxuat.Donhang.ChitietDonhangItems[i].SoluongGiao;

                    ////Cap nhat so luong giao
                    //soLuongDaGiao += soLuongXuat;

                    ////Cap nhat so luong du kien o don hang neu so luong xuat lon hon so luong du kien
                    //if (soLuongDaGiao > soLuongDukien)
                    //{
                    //    soLuongDukien = soLuongDaGiao;
                    //}

                    ////Cap nhat so luong con lai
                    //soLuongConlai = soLuongDukien - soLuongDaGiao;

                    //View.ValuePhieuxuat.Donhang.ChitietDonhangItems[i].SoluongGiao = soLuongDaGiao;
                    //View.ValuePhieuxuat.Donhang.ChitietDonhangItems[i].Soluong = soLuongDukien;
                    //View.ValuePhieuxuat.Donhang.ChitietDonhangItems[i].SoluongConlai = soLuongConlai;
            //    } 
            //}
        }

        //public void CapnhatTonkho()
        //{
        //    for (int i = 0; i < View.ValuePhieuxuat.ChitietPhieuxuatItems.Count; ++i)
        //    {
        //        if (View.ValuePhieuxuat.ChitietPhieuxuatItems[i].Soluong != 0)
        //        {
        //            var chitietPhieuxuat = View.ValuePhieuxuat.ChitietPhieuxuatItems[i] as ChitietPhieuxuatModel;

        //            //Lay ton kho hien tai cua mat hang o kho tuong ung
        //            var items = new List<AutoItem>();
        //            items.Add(new AutoItem()
        //            {
        //                Name = "KhoId",
        //                Value = View.ValuePhieuxuat.KhoId,
        //                SqlType = System.Data.SqlDbType.UniqueIdentifier
        //            });
        //            items.Add(new AutoItem()
        //            {
        //                Name = "HanghoaId",
        //                Value = chitietPhieuxuat.HanghoaId,
        //                SqlType = System.Data.SqlDbType.UniqueIdentifier
        //            });

        //            //var tonkhoItems = Model.Get<TonkhoModel>(new AutoObject()
        //            //{
        //            //    Items = items,
        //            //    SpName = "Tin_GetTonkhoMoinhatHanghoaTheoKho"
        //            //}) as List<TonkhoModel>;

        //            var tonkhoItems = Model.Get<TonkhoModel>(new AutoObject
        //            {
        //                Items = items,
        //                SpName = "Tin_GetTonkhoMoinhatHanghoaTheoKho"
        //            }) as List<TonkhoModel>;

        //            var tonkho = tonkhoItems[0] as TonkhoModel;
                    
        //            TonkhoModel tk = new TonkhoModel()
        //            {
        //                HanghoaId = chitietPhieuxuat.HanghoaId,
        //                KhoId = View.ValuePhieuxuat.KhoId,
        //                NgayCapnhat = DateTime.Now,
        //                Ngay = DateTime.Now.Day,
        //                Thang = DateTime.Now.Month,
        //                Nam = DateTime.Now.Year,
        //                GioCapnhat = DateTime.Now,
        //                SoduDauky = tonkho.SoluongTon,
        //                SoluongNhap = 0,
        //                SoluongXuat = chitietPhieuxuat.Soluong,
        //                SoluongTon = tonkho.SoluongTon,
        //                NhanvienCapnhat = View.ValuePhieuxuat.NhanvienCapnhatId,
        //                Active = true,
        //                SoluongTonDukien = tonkho.SoluongTonDukien + chitietPhieuxuat.Soluong
        //            };
        //            View.ValuePhieuxuat.TonkhoItems.Add(tk);
        //        }
        //    }
        //}

        public void ResetCurrent()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem()
            {
                Name = "PhieuxuatId",
                Value = View.ValuePhieuxuat.PhieuxuatId,
                SqlType = System.Data.SqlDbType.UniqueIdentifier
            });
            var pxItems = Model.Get<PhieuxuatModel>(new AutoObject
            {
                Items = items,
                SpName = "Vinh_GetPhieuxuatTheoMa"
            }) as List<PhieuxuatModel>;

            if (pxItems.Count > 0)
            {
                var pxCurrent = pxItems[0];
                View.ValuePhieuxuat = pxCurrent;
            }
            
        }
    }
}
