/********************************************************************
	Class file: 
    Author: Ly Hoang Tin
    Date Created: 20/12/2014
	Last Updated: 17/01/2015
	Updated By: Ly Hoang Tin
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
    public class KiemkePresenter : Presenter<IKiemkeView>
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        public KiemkePresenter(IKiemkeView view)
            : base(view)
        {
        }

        public void DisplayKiemkeTheoKho()
        {
            //try
            //{
                //var timeValueCurrent = View.KhoCurrentId;
                var items = new List<AutoItem>
                {
                    new AutoItem
                    {
                        Name = "KhoId",
                        Value = View.KhoCurrentId,
                        SqlType = SqlDbType.UniqueIdentifier
                    }
                };
                View.KiemkeItems = Model.Get<KiemkeModel>(new AutoObject
                {
                    Items = items,
                    SpName = "Tin_SelectKiemkeTheoKho"
                });
            foreach(var kk in View.KiemkeItems)
            {
                kk.ListChitietKiemke = new List<ChitietKiemkeModel>();
                var itemkks = new List<AutoItem>
                {               
                    new AutoItem
                    {
                        Name = "KiemkeId",
                        Value = kk.KiemkeId,
                        SqlType = SqlDbType.UniqueIdentifier
                    }
                };

                kk.ListChitietKiemke = Model.Get<ChitietKiemkeModel>(new AutoObject
                {
                    Items = itemkks,
                    SpName = "Tin_SelectChitietKiemkeTheoKiemke"
                });
                
            }
                View.RefreshKiemke();
            //}
            //catch (Exception ex)
            //{
            //    //Check log flag and log error to file.
            //    if (isErrorEnabled)
            //    {
            //        logger.Error("Tin_SelectKiemkeTheoKho", ex);
            //    }
            //}
        }

        public void DisplayChitietKiemke()
        {
            try
            {
                if(View.KiemkeCurrent.KiemkeId==null)
                {
                    View.ChitietKiemkeItems = null;
                    View.RefreshChitietKiemke();
                    return;
                }
             var items = new List<AutoItem>
                {               
                    new AutoItem
                    {
                        Name = "KiemkeId",
                        Value = View.KiemkeCurrent.KiemkeId,
                        SqlType = SqlDbType.UniqueIdentifier
                    }
                };
            
                View.KiemkeCurrent.ListChitietKiemke = Model.Get<ChitietKiemkeModel>(new AutoObject
                {
                    Items = items,
                    SpName = "Tin_SelectChitietKiemkeTheoKiemke"
                });
                View.ChitietKiemkeItems = View.KiemkeCurrent.ListChitietKiemke;
                //View.KiemkeCurrent.ListChitietKiemke = Model.Get<ChitietKiemkeModel>(new AutoObject
                //{
                //    Items = items,
                //    SpName = "Tin_SelectChitietKiemkeTheoKiemke"
                //});
                View.RefreshChitietKiemke();
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("Tin_SelectChitietKiemkeTheoKiemke", ex);
                }
            }
        }

        public void DisplayHanghoaTheoKho()
        {
            try
            {
            var items = new List<AutoItem>
            {
                new AutoItem
                {
                    Name = "KhoId",
                    Value = View.KhoCurrentId,
                    SqlType = SqlDbType.UniqueIdentifier
                }
            };
            View.HanghoaItems = Model.Get<HanghoaModel>(new AutoObject
            {
                Items = items,
                SpName = "Tin_GetHanghoaTheoKho"
            });
            View.RefreshHanghoa();
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("Tin_GetHanghoaTheoKho", ex);
                }
                return;
            }
        }

        public void DisplayKho()
        {
            //try
            //{
            View.Khoitems = Model.Get<KhoModel>("sys_KhoSelect");
            View.RefreshKho();
            //}
            //catch(Exception ex)
            //{
            //    //Check log flag and log error to file.
            //    if (isErrorEnabled)
            //    {
            //        logger.Error("sys_KhoSelect", ex);
            //    }
            //    return;
            //}
        }

        public bool Addnew()
        {
            //try
            //{
            //Lấy thông tin nhân viên
            var nvitems = new List<AutoItem>
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
                Items = nvitems,
                SpName = "Vinh_GetNhanvienTheoUserId"
            });
            if (listNhanvien == null)
                return false;
            NhanvienModel nhanvienCapnhat = listNhanvien[0];
            //new Kiem ke
            var kk = new KiemkeModel
            {
                KhoId = View.KhoCurrentId,
                NhanvienId = nhanvienCapnhat.NhanvienId,
                TenNhanvien = nhanvienCapnhat.HovatenNhanvien,
                Ngaylap = DateTime.Now,
                Active = true,
                ListChitietKiemke = new List<ChitietKiemkeModel>()
            };
            View.KiemkeItems.Add(kk);
            View.RefreshKiemke();
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

        public bool AddnewDetail()
        {
            //try
            //{
            //Lấy số lượng tồn
            int? slton = 0;
            var items = new List<AutoItem>
            {
                new AutoItem
                {
                    Name = "KhoId",
                    Value = View.KhoCurrentId,
                    SqlType = SqlDbType.UniqueIdentifier
                },
                new AutoItem
                {
                    Name = "HanghoaId",
                    Value = View.HanghoaCurrentId,
                    SqlType = SqlDbType.UniqueIdentifier
                }
            };
            List<TonkhoModel> tonkho = Model.Get<TonkhoModel>(new AutoObject
            {
                Items = items,
                SpName = "Tin_GetSoluongtonTheoHanghoaTrongKho"
            });
            if (tonkho != null)
            {
                slton = tonkho[0].SoluongTon;
            }
            //Kiểm tra giá trị đầu vào
            Guid? hanghoaCurrentId = View.HanghoaCurrentId;
            if (hanghoaCurrentId == null)
            {
                return false;
            }
            var firstOrDefault = View.HanghoaItems.FirstOrDefault(p => p.HanghoaId == (Guid) hanghoaCurrentId);
            if (firstOrDefault != null)
            {
                string tenHanghoacurrent =
                    firstOrDefault.TenHanghoa;
                if (tenHanghoacurrent == null)
                {
                    return false;
                }
                var kiemkeDetail = new ChitietKiemkeModel
                {
                    KiemkeId=View.KiemkeCurrent.KiemkeId,
                    HanghoaId = hanghoaCurrentId,
                    TenHanghoa = tenHanghoacurrent,
                    SoluongTon = slton
                };
                //View.ChitietKiemkeItems.Add(kiemkeDetail);
                View.KiemkeCurrent.ListChitietKiemke.Add(kiemkeDetail);
            }
            View.RefreshChitietKiemke();
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

        public bool Delete()
        {
            try
            {
                KiemkeModel current = View.KiemkeCurrent;
                if (current == null)
                    return false;
                if (current.State == RowState.Insert)
                {
                    View.KiemkeItems.Remove(current);
                }
                View.RefreshKiemke();
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

        public bool DeleteDetail()
        {
            try
            {
                ChitietKiemkeModel current = View.ChitietKiemkeCurrent;
                if (current == null)
                {
                    return false;
                }
                if (current.State == RowState.Insert)
                {
                    View.ChitietKiemkeItems.Remove(current);
                }
                View.RefreshChitietKiemke();
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

        public bool Save()
        {
            //try
            //{
                //List<KiemkeModel> kiemkeLuu =
                //    View.KiemkeItems.Where(p => (p.State == RowState.Insert || p.State == RowState.Update)).ToList();
                Model.Set(View.KiemkeItems);
                foreach (KiemkeModel kk in View.KiemkeItems)
                {
                    Model.Set(kk.ListChitietKiemke);
                }
                View.RefreshKiemke();
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
    }
}