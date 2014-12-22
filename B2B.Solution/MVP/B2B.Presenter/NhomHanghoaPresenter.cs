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
    public class NhomHanghoaPresenter : Presenter<INhomHanghoaView>
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        public NhomHanghoaPresenter(INhomHanghoaView view)
            : base(view)
        { }

        public void Display()
        {
            try
            {
                View.NhomHanghoaItems = Model.Get<NhomHanghoaModel>("sys_NhomHanghoaSelect");
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
                foreach (var item in View.NhomHanghoaItems)
                {
                    if(item.State==RowState.Insert || item.State==RowState.Update)
                    {
                        item.NgayCapnhat = DateTime.Now;
                    }
                }

                Model.Set(View.NhomHanghoaItems);
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
                View.NhomHanghoaItems.Add(new NhomHanghoaModel { NgayCapnhat = DateTime.Now, Active = true });
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
                var current = View.NhomHanghoaCurrent as NhomHanghoaModel;
                if (current == null)
                {
                    return;
                }
                if(current.State == RowState.Insert)
                {
                    View.NhomHanghoaItems.Remove(current);
                    View.RefreshData();
                    return;
                }
                current.MakeDelete();
                View.RefreshData();
            }
            catch (System.Exception ex)
            {
            	//Check log flag and log error to file.
            	if (isErrorEnabled)
            	{
            		logger.Error(String.Format("{0} {1}",View.NhomHanghoaCurrent.NhomHanghoaId, View.NhomHanghoaCurrent.State), ex);
            	}
            	return;
            }
        }
    }
}
