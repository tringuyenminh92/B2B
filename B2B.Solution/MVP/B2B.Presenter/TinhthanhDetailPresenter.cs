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
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Presenter
{
    public class TinhthanhDetailPresenter : Presenter<ITinhthanhDetailView>
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        public TinhthanhDetailPresenter(ITinhthanhDetailView view)
            : base(view)
        {
        }

        public void DisplayKhuvucActive()
        {
            try
            {
                View.KhuvucItems = Model.Get<KhuvucModel>("Tri_GetKhuvucActive");
                View.RefreshData();
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("Tri_GetKhuvucActive", ex);
                }
                return;
            }

        }
    }
}
