/***********************************
Author: Lý Hoàng Tín
Date Created: 09/09/2014
Last Updated: 11/09/2014
Updated By: Lý Hoàng Tín
Update description: 
************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B2B.View;
using B2B.Model;
using BMIModel;
using log4net;

namespace B2B.Presenter
{
    public class DongiaDetailPresenter : Presenter<IDongiaDetailView>
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;
        public DongiaDetailPresenter(IDongiaDetailView view)
            : base(view)
        { }
        public void DisplayHanghoa()
        {
            try
            {
                View.HanghoaItems = Model.Get<HanghoaModel>("Tin_GetHanghoaActive");
                View.RefreshData();
            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("Tin_GetHanghoaActive", ex);
                }
                return;
            }
        }
        public void DisplayNhomKhachhang()
        {
            try
            {
                View.NhomKhachhangItems = Model.Get<NhomKhachhangModel>("Tin_GetNhomKhachhangActive");
                View.RefreshDataNhomKhachhang();
            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("Tin_GetNhomKhachhangActive", ex);
                }
                return;
            }
        }

    }
}
