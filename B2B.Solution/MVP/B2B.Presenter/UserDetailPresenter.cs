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
    public class UserDetailPresenter : Presenter<IUserDetailView>
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        public UserDetailPresenter(IUserDetailView view)
            : base(view)
        {

        }

        public void DisplayNhanvien()
        {
            try
            {
                View.NhanvienItems = Model.Get<NhanvienModel>("Tri_GetNhanvienActive");
                View.RefreshData();
            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("Tri_GetNhanvienActive", ex);
                }
                return;
            }
        }
    }
}
