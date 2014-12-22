/********************************************************************
	Class file: 
    Author: Nguyen Minh Tri
    Date Created: 20/09/2014
	Last Updated: 20/09/2014
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
    public class PhongbanPresenter : Presenter<IPhongbanView>
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;
        public PhongbanPresenter(IPhongbanView view)
            : base(view)
        { }

        public void Display()
        {
            try
            {
                View.PhongbanItems = Model.Get<PhongbanModel>("sys_PhongbanSelect");
                View.RefreshData();
            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("sys_PhongbanSelect", ex);
                }
                return;
            }
        }

        public bool Addnew()
        {
            try
            {
                View.PhongbanItems.Add(new PhongbanModel { Active = true, NgayCapnhat = DateTime.Now });
                View.RefreshData();
                return true;
            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("", ex);
                }
                return false;
            }
        }

        public void Save()
        {
            try
            {
                foreach (var item in View.PhongbanItems)
                {
                    item.NgayCapnhat = DateTime.Now;
                }
                Model.Set(View.PhongbanItems);
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
                var current = View.PhongbanCurrent as PhongbanModel;
                if (current == null)
                {
                    return;
                }

                if(current.State== BusinessObject.RowState.Insert)
                {
                    View.PhongbanItems.Remove(current);
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
                	logger.Error("", ex);
                }
                return;
            }
        }
    }
}
