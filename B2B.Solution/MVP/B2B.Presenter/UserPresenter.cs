/********************************************************************
	Class file: 
    Author: Nguyen Minh Tri
    Date Created: 04/09/2014
	Last Updated: 04/09/2014
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
    public class UserPresenter : Presenter<IUserView>
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        public UserPresenter(IUserView view)
            : base(view)
        { }
        
        public void Display()
        {
            try
            {
                View.UserItems = Model.Get<UserModel>("sys_UserSelect");
                View.RefreshData();
            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("sys_UserSelect", ex);
                }
                return;
            }
        }

        public bool Addnew()
        {
            try
            {
                View.UserItems.Add(new UserModel());
                View.RefreshData();
                return true;
            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("New", ex);
                }
                return false;
            }
        }
        public void Delete()
        {
            try
            {
                var current = View.UserCurrent as UserModel;
                if (current == null)
                {
                    return;
                }
                if (current.State == BusinessObject.RowState.Insert)
                {
                    View.UserItems.Remove(current);
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
                    logger.Error(string.Format("UserId: {0}, NhanvienId: {1}", View.UserCurrent.UserId, View.UserCurrent.NhanvienId.HasValue ? View.UserCurrent.NhanvienId.Value.ToString() : ""), ex);
                }
                return;
            }
        }

        public void Save()
        {
            try
            {
                foreach (var item in View.UserItems)
                {
                    if (item.State == BusinessObject.RowState.Insert || item.State == BusinessObject.RowState.Update)
                    {
                        if (item._Username.Length != 32)
                        {
                            item._Username = AutoFramework.Encrypt.MD5Hash(item._Username);
                        }
                        if (item._Password.Length != 32)
                        {
                            item._Password = AutoFramework.Encrypt.MD5Hash(item._Password);
                        }
                    }
                }
                Model.Set(View.UserItems);
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
