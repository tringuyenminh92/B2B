/********************************************************************
	Interface file: 
    Author: Tran Nguyen Hoang Khuyen
    Date Created: 28/08/2014
	Last Updated: 28/08/2014
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
    public class NhomKhachhangPresenter : Presenter<INhomKhachhangView>
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        public NhomKhachhangPresenter(INhomKhachhangView view)
            : base(view)
        { }

        public void Display()
        {
            try
            {
                View.NhomKhachhangItems = Model.Get<NhomKhachhangModel>("sys_NhomKhachhangSelect");
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("sys_NhomKhachhangSelect", ex);
                }
                return;
            }
        }

        public void Save()
        {
            try
            {
                foreach (var item in View.NhomKhachhangItems)
                {
                    if (item.State == RowState.Insert || item.State == RowState.Update)
                    {
                        item.NgayCapnhat = DateTime.Now;
                    }
                }

                Model.Set(View.NhomKhachhangItems);
                View.RefreshData();
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

        public bool Addnew()
        {
            try
            {
                View.NhomKhachhangItems.Add(new NhomKhachhangModel { NgayCapnhat = DateTime.Now, Active = true });
                View.RefreshData();
                return true;
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("None", ex);
                }
                return false;
            }
        }

        public void Delete()
        {
            try
            {
                var current = View.NhomKhachhangCurrent as NhomKhachhangModel;
                if (current == null)
                {
                    return;
                }
                if (current.State == BusinessObject.RowState.Insert)
                {
                    View.NhomKhachhangItems.Remove(current);
                    View.RefreshData();
                    return;
                }
                current.MakeDelete();
                View.RefreshData();
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error(string.Format("{0} {1}", View.NhomKhachhangCurrent.NhomKhachhangId, View.NhomKhachhangCurrent.State), ex);
                }
                return;
            }
        }
    }
}
