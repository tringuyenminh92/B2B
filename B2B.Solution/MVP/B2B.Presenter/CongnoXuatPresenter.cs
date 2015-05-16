/********************************************************************
	Class file: 
    Author: Tran Nguyen Hoang Khuyen
    Date Created: 22/12/2014
	Last Updated: 06/01/2015
	Updated By: Tran Nguyen Hoang Khuyen
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
    public class CongnoXuatPresenter:Presenter<ICongnoXuatView>
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        public CongnoXuatPresenter(ICongnoXuatView view)
            : base(view) { }
        public void DisplayCongnoXuat()
        {
            //try
            //{
                View.CongnoXuatItems = Model.Get<CongnoXuatModel>("Khuyen_GetCongnoXuat");
                View.RefreshData();
            //}
            //catch (System.Exception ex)
            //{
            //    //Check log flag and log error to file.
            //    if (isErrorEnabled)
            //    {
            //        logger.Error("Khuyen_GetCongnoXuat", ex);
            //    }
            //    return;
            //}
        }
    }
}
