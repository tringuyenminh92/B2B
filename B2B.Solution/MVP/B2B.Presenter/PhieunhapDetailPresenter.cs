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
    public class PhieunhapDetailPresenter : Presenter<IPhieunhapDetailView>
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;


        public PhieunhapDetailPresenter(IPhieunhapDetailView view)
            : base(view)
        {
        }

        public void DisplayHanghoa()
        {
            try
            {
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
        public void DisplayNhacungcap()
        {
            try
            {
                var listNhacungcap = new List<NhaCungcapModel>
                {
                    new NhaCungcapModel
                    {
                        NhaCungcapId = new Guid("00000000-0000-0000-0000-000000000000"),
                        TenNhaCungcap = "Tất cả",
                        Active = false,
                    }
                };
                listNhacungcap.AddRange(Model.Get<NhaCungcapModel>("sys_NhacungcapSelect"));
                View.NhacungcapItems = listNhacungcap;
                View.RefreshDataNhacungcap();
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("sys_NhacungcapSelect", ex);
                }
            }
        }
        public void DisplayKho()
        {
            try
            {
                var listKho = new List<KhoModel>
                {
                    new KhoModel
                    {
                        KhoId = new Guid("00000000-0000-0000-0000-000000000000"),
                        TenKho = "Tất cả",
                        Active = false,
                    }
                };
                listKho.AddRange(Model.Get<KhoModel>("sys_KhoSelect"));
                View.KhoItems = listKho;
                View.RefreshDataKho();
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("sys_KhoSelect", ex);
                }
            }
        }
        public void DisplayChitietPhieunhap()
        {
            var chitietItems = new List<AutoItem>
                {
                    new AutoItem
                    {
                        Name = "PhieunhapId",
                        Value = View.CurrentPhieunhap.PhieunhapId,
                        SqlType = SqlDbType.UniqueIdentifier
                    }
                };
            View.CurrentPhieunhap.ListChitietPhieuNhap = Model.Get<ChitietPhieunhapModel>(new AutoObject
                    {
                        Items = chitietItems,
                        SpName = "Tin_GetChitietPhieunhapTheoPhieunhap",
                    });
        }
        public void DisplayTinhTrang()
        {
            try
            {
                View.TinhtrangItems = Model.Get<TinhtrangModel>("sys_TinhtrangSelect");
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

        public bool AddNew()
        {
            try
            {
                if (View.CurrentPhieunhap == null)
                {
                    return false;
                }
                HanghoaModel hanghoaCurrent =
                    View.HanghoaItems.FirstOrDefault(p => p.HanghoaId == View.CurrentHanghoaId);
                if (View.CurrentHanghoaId == null)
                {
                    return false;
                }
                if (hanghoaCurrent != null)
                    View.CurrentPhieunhap.ListChitietPhieuNhap.Add(new ChitietPhieunhapModel
                    {
                        PhieunhapId = View.CurrentPhieunhap.PhieunhapId,
                        HanghoaId = View.CurrentHanghoaId,
                        TenHanghoa = hanghoaCurrent.TenHanghoa,
                        HSD = View.HansudungValue,
                        Ghichu = View.GhichuValue,
                        Gianhap = View.GianhapValue<0?0:View.GianhapValue,
                        Soluong = View.SoluongValue<=0?1:View.SoluongValue,
                    });
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

        public bool Delete()
        {
            ChitietPhieunhapModel current = View.ChitietPhieunhapCurrent;
            if (current == null)
                return false;
            if (current.State == RowState.Insert)
            {
                View.CurrentPhieunhap.ListChitietPhieuNhap.Remove(current);
                View.RefreshData();
                return true;
            }
            current.MakeDelete();
            View.RefreshData();
            return true;
        }

        public void ResetCurrent()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem
            {
                Name = "PhieunhapId",
                Value = View.CurrentPhieunhap.PhieunhapId,
                SqlType = SqlDbType.UniqueIdentifier
            });
            var pnItems = Model.Get<PhieunhapModel>(new AutoObject
            {
                Items = items,
                SpName = "Tin_GetPhieunhapTheoMa"
            });
            if (pnItems.Count > 0)
            {
                var pnItem = pnItems[0];
                View.CurrentPhieunhap = pnItem;
            }
        }

        public void CapnhatTongtien()
        {
            double? tong = 0;
            foreach(var ct in View.CurrentPhieunhap.ListChitietPhieuNhap)
            {
                tong += ct.Thanhtien;                
            }
            View.CurrentPhieunhap.Tongtien = tong;
        }
    }
}