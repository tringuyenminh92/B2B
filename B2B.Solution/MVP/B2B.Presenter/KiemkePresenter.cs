/********************************************************************
	Class file: 
    Author: Ly Hoang Tin
    Date Created: 20/12/2014
	Last Updated: 20/12/2014
	Updated By: Ly Hoang Tin
	Update Description:
*********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using BusinessObject;
using BMIModel;
using B2B.View;
using B2B.Model;

namespace B2B.Presenter
{
    public class KiemkePresenter:Presenter<IKiemkeView>
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;
        public KiemkePresenter(IKiemkeView view)
            : base(view) 
        { }
        public void DisplayKiemkeTheoThang()
        {
            try
            {
                var timeValueCurrent = View.timeValue;
                var items = new List<AutoItem>()
                {
                    new AutoItem
                    {
                        Name="KhoId",
                        Value=View.KhoValue,
                        SqlType=System.Data.SqlDbType.UniqueIdentifier
                    }
                };
                View.KiemkeItems=Model.Get<KiemkeModel>(new AutoObject
                {
                    Items=items,
                    SpName="Tin_SelectKiemkeTheoKho"
                });
                View.RefeshKiemke();
            }
            catch(Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("Tin_SelectKiemkeTheoKho", ex);
                }
                return;
            }
        }
        public void DisplayHanghoaTheoKho()
        {
            try
            {
                var items = new List<AutoItem>()
                {
                    new AutoItem()
                    {
                        Name="KhoId",
                        Value=View.KhoValue,
                        SqlType=System.Data.SqlDbType.UniqueIdentifier
                    }
                };
                View.HanghoaItems = Model.Get<HanghoaModel>(new AutoObject
                    {
                        Items=items,
                        SpName="Tin_GetHanghoaTheoKho"
                    });
                View.RefeshHanghoa();
            }
            catch(Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("Tin_GetHanghoaTheoKho", ex);
                }
                return;
            }
        }
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
                        SqlType = System.Data.SqlDbType.UniqueIdentifier
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
        public bool Addnew()
        {
            try
            {
                var kk = new KiemkeModel()
                {
                    NhanvienId=View.NhanvienCapnhat.NhanvienId,
                    TenNhanvien=View.NhanvienCapnhat.TenNhanvien,
                    Ngaylap=DateTime.Now,
                    Active=true,
                    ListChitietKiemke=new List<ChitietKiemkeModel>()
                };
                View.KiemkeItems.Add(kk);
                View.RefreshData();
                return true;
            }
            catch(Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("", ex);
                }
                return false;
            }
        }
        public bool AddnewDetail()
        {
            try
            {
                var hanghoaCurrentId=View.HanghoaCurrentId;
                if(hanghoaCurrentId==null)
                {
                    return false;
                }
                var tenHanghoacurrent=View.TenHanghoaCurrent;
                if(tenHanghoacurrent==null)
                {
                    return false;
                }
                var kiemkeDetail = new ChitietKiemkeModel()
                {
                    HanghoaId=hanghoaCurrentId,
                    TenHanghoa=tenHanghoacurrent,
                    SoluongTon=View.SoluongTonValue,
                    SoluongThuc=View.SoluongThucValue,
                    Ghichu=View.GhichuValue
                };
                View.ChitietKiemkeItems.Add(kiemkeDetail);
                View.RefeshChitietKiemke();
                return true;
            }
            catch(Exception ex)
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
            //var kiemkeLuu=View.KiemkeItems.where
            return true;
        }
        public bool Delete()
        {
            try
            {
                KiemkeModel current = View.KiemkeCurrent;
                if (current == null)
                    return false;
                if(current.State==RowState.Insert)
                {
                    View.KiemkeItems.Remove(current);
                }
                View.RefeshKiemke();
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
                if(current==null)
                {
                    return false
                }
                if(current.State==RowState.Insert)
                {
                    View.ChitietKiemkeItems.Remove(current);
                }
                View.RefeshChitietKiemke();
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
    }
}
