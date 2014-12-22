/********************************************************************
	Class file: 
    Author: Nguyen Minh Tri
    Date Created: 24/08/2014
	Last Updated: 24/08/2014
	Updated By: Nguyen Minh Tri
	Update Description: 
*********************************************************************/

using B2B.Model;
using BMIModel;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using B2B.View;

namespace B2B.Presenter
{
    public class KhoPresenter : Presenter<IKhoView>
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        public KhoPresenter(IKhoView view)
            : base(view)
        { }

        public void Display()
        {
            try
            {
                View.KhoItems = Model.Get<KhoModel>("Tri_GetKho");
                View.RefreshData();
            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("Tri_GetKho", ex);
                }
                return;
            }
        }

        public void Save()
        {
            try
            {
                foreach (var item in View.KhoItems)
                {
                    if (item.State == RowState.Insert || item.State == RowState.Update)
                    {
                        item.NgayCapnhat = DateTime.Now;
                    }
                }
                Model.Set(View.KhoItems);
                View.RefreshData();
            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("", ex);
                }
                return;
            }
        }

        public void Delete()
        {
            try
            {
                var current = View.KhoCurrent as KhoModel;
                if (current == null)
                {
                    return;
                }
                if (current.State == RowState.Insert)
                {
                    View.KhoItems.Remove(current);
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
                    logger.Error(string.Format("{0}", View.KhoCurrent.KhoId), ex);
                }
                return;
            }
        }

        public bool Addnew()
        {
            try
            {
                View.KhoItems.Add(new KhoModel { NgayCapnhat = DateTime.Now, Active = true });
                View.RefreshData();
                return true;
            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("None", ex);
                }
                return false;
            }
        }
    }
}
