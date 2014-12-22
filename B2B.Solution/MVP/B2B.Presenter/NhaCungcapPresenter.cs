/********************************************************************
	Class file: 
    Author: Nguyen Minh Tri
    Date Created: 
	Last Updated: 
	Updated By: Nguyen Minh Tri
	Update Description: 
*********************************************************************/

using B2B.Model;
using B2B.View;
using BMIModel;
using BusinessObject;
using log4net;
using System;

namespace B2B.Presenter
{
    public class NhaCungcapPresenter : Presenter<INhaCungcapView>
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        public NhaCungcapPresenter(INhaCungcapView view)
            : base(view)
        { }

        public void Display()
        {
            try
            {
                View.NhaCungcapItems = Model.Get<NhaCungcapModel>("Tri_GetNhaCungcap");
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("Tri_GetNhaCungcap", ex);
                }
                return;
            }
        }

        public bool Save()
        {
            try
            {
                foreach (var item in View.NhaCungcapItems)
                {
                    if (item.State == RowState.Insert || item.State == RowState.Update)
                    {
                        item.NgayCapnhat = DateTime.Now;
                    }
                }

                Model.Set(View.NhaCungcapItems);
                View.RefreshData();
                return true;
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("Save", ex);
                }
                return false;
            }
        }

        public bool Addnew()
        {
            try
            {
                View.NhaCungcapItems.Add(new NhaCungcapModel { NgayCapnhat = DateTime.Now, Active = true });
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

        public bool Delete()
        {
            try
            {
                var current = View.NhaCungcapCurrent as NhaCungcapModel;
                if (current == null)
                {
                    return false;
                }
                if (current.State == BusinessObject.RowState.Insert)
                {
                    View.NhaCungcapItems.Remove(current);
                    View.RefreshData();
                    return true;
                }
                current.MakeDelete();
                View.RefreshData();
                return true;
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error(string.Format("{0} {1}", View.NhaCungcapCurrent.NhaCungcapId, View.NhaCungcapCurrent.State), ex);
                }
                return false;
            }
        }
    }
}
