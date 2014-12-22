/********************************************************************
	Class file: 
    Author: Nguyen Minh Tri
    Date Created: 29/08/2014
	Last Updated: 29/08/2014
	Updated By: Nguyen Minh Tri
	Update Description: 
*********************************************************************/

using B2B.Model;
using B2B.View;
using BMIModel;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Presenter
{
    public class DonviPresenter : Presenter<IDonviView>
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        public DonviPresenter(IDonviView view)
            : base(view)
        { }

        public void Display()
        {
            try
            {
                View.DonviItems = Model.Get<DonviModel>("sys_DonviSelect");
                View.RefreshData();
            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("sys_DonviSelect", ex);
                }
                return;
            }
        }

        public bool Addnew()
        {
            try
            {
                View.DonviItems.Add(new DonviModel { NgayCapnhat = DateTime.Now, Active = true });
                View.RefreshData();
                return true;
            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("none", ex);
                }
                return false;
            }
        }

        public void Save()
        {
            try
            {
                foreach (var item in View.DonviItems)
                {
                    item.NgayCapnhat = DateTime.Now;
                }
                Model.Set(View.DonviItems);
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
                var current = View.DonviCurrent as DonviModel;
                if (current == null)
                {
                    return;
                }

                if (current.State == BusinessObject.RowState.Insert)
                {
                    View.DonviItems.Remove(current);
                    View.RefreshData();
                    return;
                }
                current.MakeDelete();
                return;
            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error(string.Format("{0}", View.DonviCurrent.DonviId), ex);
                }
                return;
            }
        }
    }
}
