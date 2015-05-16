/***********************************
Author: Lý Hoàng Tín
Date Created: 09/09/2014
Last Updated: 09/09/2014
Updated By: Lý Hoàng Tín
Update description: 
************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B2B.Model;
using B2B.View;
using log4net;
using BMIModel;
using BusinessObject;

namespace B2B.Presenter
{
    public class ThuoctinhHanghoaPresenter : Presenter<IThuoctinhHanghoaView>
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;
        public ThuoctinhHanghoaPresenter(IThuoctinhHanghoaView view)
            : base(view)
        { }
        public void DisplayThuoctinhHanghoaTheoHanghoa()
        {
            //try
            //{
                var items = new List<AutoItem>();
                items.Add(new AutoItem
                {
                    Name = "HanghoaId",
                    Value = View.HanghoaCurrentId,
                    SqlType = System.Data.SqlDbType.UniqueIdentifier
                });
                View.ThuoctinhHanghoaItems = Model.Get<ThuoctinhHanghoaModel>(new AutoObject { Items = items, SpName = "Tin_GetThuoctinHanghoaTheoHanghoa" });
                View.RefreshData();
            //}
            //catch (System.Exception ex)
            //{
            //    //Check log flag and log error to file.
            //    if (isErrorEnabled)
            //    {
            //        logger.Error("", ex);
            //    }
            //    return;
            //}
        }
        public void DisplayHanghoa()
        {
            //try
            //{
            var listHanghoa = new List<HanghoaModel>();
            listHanghoa.Add(new HanghoaModel
            {
                HanghoaId = new Guid("00000000-0000-0000-0000-000000000000"),
                TenHanghoa = "Tất cả",
                Active = false
            });
            var hh = Model.Get<HanghoaModel>("sys_HanghoaSelect");
            listHanghoa.AddRange(hh);
            //View.HanghoaItems = Model.Get<HanghoaModel>("sys_HanghoaSelect");
            View.HanghoaItems = listHanghoa;
            //View.RefreshData();
            //}
            //catch (System.Exception ex)
            //{
            //    //Check log flag and log error to file.
            //    if (isErrorEnabled)
            //    {
            //        logger.Error("", ex);
            //    }
            //    return;
            //}
        }
        public bool Addnew()
        {
            //try
            //{
            var HanghoaCurrentId = View.HanghoaCurrentId as Guid?;
            if (HanghoaCurrentId == null)
            {
                return false;
            }
            //var ThuoctinhHanghoaCurrent = View.ThuoctinhHanghoaCurrent as ThuoctinhHanghoaModel;
            var HanghoaCurrent = View.HanghoaItems.Where(p=>p.HanghoaId==HanghoaCurrentId).FirstOrDefault();
            if (HanghoaCurrent != null)
            {
                if (HanghoaCurrent.Active == false)
                    return false;
            }
            if (HanghoaCurrent == null)
            {
                return false;
            }
            //if (View.ThuoctinhHanghoaItems==null)
            //{
            //    View.ThuoctinhHanghoaItems = new List<ThuoctinhHanghoaModel>();
            //} 
            View.ThuoctinhHanghoaItems.Add(new ThuoctinhHanghoaModel
             {
                 NgayCapnhat = DateTime.Now,
                 Active = true,
                 HanghoaId = HanghoaCurrentId,
                 TenHanghoa=HanghoaCurrent.TenHanghoa
             });
            View.RefreshData();
            return true;
            //}
            //catch (System.Exception ex)
            //{
            //    //Check log flag and log error to file.
            //    if (isErrorEnabled)
            //    {
            //        logger.Error(string.Format("HanghoaId: {0}",View.HanghoaCurrent.HanghoaId), ex);
            //    }
            //    return false;
            //}
        }
        public bool Save()
        {
            try
            {
                foreach (var item in View.ThuoctinhHanghoaItems)
                {
                    if (item.State == RowState.Insert || item.State == RowState.Update)
                    {
                        item.NgayCapnhat = DateTime.Now;
                    }
                }
                Model.Set(View.ThuoctinhHanghoaItems);
                View.RefreshData();
                return true;
            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error(string.Format("HanghoaId: {0}", View.HanghoaCurrent.HanghoaId), ex);
                }
                return false;
            }
        }
        public void Delete()
        {
            try
            {
                var current = View.ThuoctinhHanghoaCurrent as ThuoctinhHanghoaModel;
                if (current == null)
                {
                    return;
                }
                if (current.State == RowState.Insert)
                {
                    View.ThuoctinhHanghoaItems.Remove(current);
                    View.RefreshData();
                }
            }
            catch (System.Exception ex)
            {
                if (isErrorEnabled)
                {
                    logger.Error("", ex);
                }
                return;
            }
        }

    }
}
