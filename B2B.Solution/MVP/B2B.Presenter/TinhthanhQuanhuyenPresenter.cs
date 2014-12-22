/********************************************************************
	Class file: 
    Author: Nguyen Minh Tri
    Date Created: 23/08/2014
	Last Updated: 23/08/2014
	Updated By: Nguyen Minh Tri
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
    public class TinhthanhQuanhuyenPresenter : Presenter<ITinhthanhQuanhuyenView>
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;



        public TinhthanhQuanhuyenPresenter(ITinhthanhQuanhuyenView view)
            : base(view)
        { }

        public void DisplayTinhthanh()
        {
            try
            {
                View.TinhthanhItems = Model.Get<TinhthanhModel>("Tri_GetTinhthanhVoiTenKhuvuc");
                View.RefreshDataTinhthanh();
            }
            catch (Exception ex)
            {
                if (isErrorEnabled)
                {
                    logger.Error("Tri_GetTinhthanhVoiTenKhuvuc", ex);
                }
            }
        }

        public void DisplayQuanhuyenByTinhthanh()
        {
            try
            {
                var current = View.TinhthanhCurrent as TinhthanhModel;
                if (current == null)
                {
                    return;
                }

                var items = new List<AutoItem>();
                items.Add(new AutoItem { Name = "TinhthanhId", Value = current.TinhthanhId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
                View.QuanhuyenItems = Model.Get<QuanhuyenModel>(new AutoObject { Items = items, SpName = "Tri_GetQuanhuyenTheoTinhthanh" });
                View.RefreshDataQuanhuyen();
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error(string.Format("{0} {1}", View.TinhthanhCurrent.TinhthanhId, "Tri_GetQuanhuyenTheoTinhthanh"), ex);
                }
                return;
            }
        }

        public void SaveQuanhuyen()
        {
            try
            {
                foreach (var item in View.QuanhuyenItems)
                {
                    if (item.State == RowState.Insert || item.State == RowState.Update)
                    {
                        item.NgayCapnhat = DateTime.Now;
                    }
                }
                Model.Set(View.QuanhuyenItems);
                View.RefreshDataQuanhuyen();
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("Save", ex);
                }
                return;
            }
        }

        public bool AddnewQuanhuyen()
        {
            try
            {
                var current = View.TinhthanhCurrent as TinhthanhModel;

                if (current == null)
                {
                    return false;
                }

                if (current.Active.HasValue)
                {
                    if (!current.Active.Value)
                    {
                        return false;
                    }
                    View.QuanhuyenItems.Add(new QuanhuyenModel
                    {
                        TinhthanhId = current.TinhthanhId,
                        NgayCapnhat = DateTime.Now,
                        Active = true
                    });
                    View.RefreshDataQuanhuyen();
                }
                return true;
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error(string.Format("View.TinhthanhCurrent: {0}", View.TinhthanhCurrent.TinhthanhId), ex);
                }
                return false;
            }
        }

        public void DeleteQuanhuyen()
        {
            try
            {
                var current = View.QuanhuyenCurrent as QuanhuyenModel;

                //Check if null cause there are no khuvuc in datasource
                if (current == null)
                {
                    return;
                }

                if (current.State == RowState.Insert)
                {
                    View.QuanhuyenItems.Remove(current);
                    View.RefreshDataQuanhuyen();
                    return;
                }

                current.MakeDelete();
                View.RefreshDataQuanhuyen();
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error(string.Format("Current {0} {1}", View.QuanhuyenCurrent.QuanhuyenId, View.QuanhuyenCurrent.State), ex);
                }
                return;
            }
        }
    }
}
