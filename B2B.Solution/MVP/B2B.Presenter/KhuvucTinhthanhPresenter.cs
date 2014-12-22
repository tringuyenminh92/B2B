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
    public class KhuvucTinhthanhPresenter : Presenter<IKhuvucTinhthanhView>
    {

        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        public KhuvucTinhthanhPresenter(IKhuvucTinhthanhView view)
            : base(view)
        {
        }
        public void HienthiKhuvuc()
        {
            try
            {
                //Get all Khuvucs from database
                View.KhuvucItems = Model.Get<KhuvucModel>("sys_KhuvucSelect");

                //Request khuvuc's gridcontrol to update datasoruce
                View.RefreshDataKhuvuc();
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("sys_KhuvucSelect", ex);
                }
                return;
            }
        }

        public void HienthiTinhthanhTheoKhuvuc()
        {
            try
            {
                //Check if null cause there are no khuvuc in datasource
                var current = View.KhuvucCurrent;
                if (current == null)
                {
                    return;
                }

                //Add parameters to AutoItem list to query.
                var items = new List<AutoItem>();
                items.Add(new AutoItem
                {
                    Name = "KhuvucId",
                    Value = View.KhuvucCurrent.KhuvucId,
                    SqlType = System.Data.SqlDbType.UniqueIdentifier
                });

                //Request to get Tinhthanhs by list autoitems above
                View.TinhthanhItems = Model.Get<TinhthanhModel>(new AutoObject { Items = items, SpName = "Tri_GetTinhthanhTheoKhuvuc" });

                //Request tinhthanh's gridcontrol to update datasoruce
                View.RefreshDataTinhthanh();
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error(string.Format("{0} {1}", View.KhuvucCurrent.KhuvucId, "Tri_GetTinhthanhTheoKhuvuc"), ex);
                }
                return;
            }
        }

        public void SaveKhuvuc()
        {
            try
            {
                if (View.KhuvucItems == null)
                {
                    return;
                }

                foreach (var item in View.KhuvucItems)
                {
                    if (item.State == RowState.Update)
                    {
                        item.NgayCapnhat = DateTime.Now;
                    }
                }
                Model.Set(View.KhuvucItems);
                View.RefreshDataKhuvuc();
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error(string.Format("Number of items {0}", View.KhuvucItems.Count), ex);
                }
                return;
            }
        }

        public void DeleteKhuvuc()
        {
            try
            {
                var current = View.KhuvucCurrent as KhuvucModel;

                //Check if null cause there are no khuvuc in datasource
                if (current == null)
                {
                    return;
                }

                if (current.State == RowState.Insert)
                {
                    View.KhuvucItems.Remove(current);
                    View.RefreshDataKhuvuc();
                    return;
                }

                current.MakeDelete();
                View.RefreshDataKhuvuc();
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error(string.Format("Current {0} {1}", View.KhuvucCurrent.KhuvucId, View.KhuvucCurrent.State), ex);
                }
                return;
            }
        }

        public bool AddnewKhuvuc()
        {
            try
            {
                View.KhuvucItems.Add(new KhuvucModel() { NgayCapnhat = DateTime.Now, Active = true });
                View.RefreshDataKhuvuc();
                return true;
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error(string.Format("Number of items: {0}", View.KhuvucItems.Count), ex);
                }
                return false;
            }
        }

        public void SaveTinhthanh()
        {
            try
            {
                if (View.TinhthanhItems == null)
                {
                    return;
                }

                foreach (var item in View.TinhthanhItems)
                {
                    if (item.State == RowState.Update)
                    {
                        item.NgayCapnhat = DateTime.Now;
                    }
                }

                Model.Set(View.TinhthanhItems);
                View.RefreshDataTinhthanh();
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error(string.Format("Number of items {0}", View.TinhthanhItems.Count), ex);
                }
            }
        }

        public void DeleteTinhthanh()
        {
            try
            {
                var current = View.TinhthanhCurrent as TinhthanhModel;

                //Check if null cause there are no tinhthanh in datasource
                if (current == null)
                {
                    return;
                }

                if (current.State == RowState.Insert)
                {
                    View.TinhthanhItems.Remove(current);
                    View.RefreshDataTinhthanh();
                    return;
                }

                current.MakeDelete();
                View.RefreshDataTinhthanh();
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error(string.Format("Current {0} {1}", View.TinhthanhCurrent.KhuvucId, View.TinhthanhCurrent.State), ex);
                }
                return;
            }
        }

        public bool AddnewTinhthanh()
        {
            try
            {
                var current = View.KhuvucCurrent as KhuvucModel;

                //Check if null cause there are no khuvuc in datasource
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
                    View.TinhthanhItems.Add(new TinhthanhModel { KhuvucId = current.KhuvucId, NgayCapnhat = DateTime.Now, Active = true });
                    View.RefreshDataTinhthanh();
                }
                return true;
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error(string.Format("View.KhuvucCurrent: {0}", View.KhuvucCurrent.KhuvucId), ex);
                }
                return false;
            }
        }
    }
}
