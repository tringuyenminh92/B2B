using System;
using System.Reflection;
using B2B.Model;
using B2B.View;
using BMIModel;
using log4net;

namespace B2B.Presenter
{
    public class CongnoNhapPresenter : Presenter<ICongnoNhapView>
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        public CongnoNhapPresenter(ICongnoNhapView view)
            : base(view)
        {
        }

        public void DisplayCongnoNhap()
        {
            try
            {
                View.CongnoNhapItems = Model.Get<CongnoNhapModel>("Tin_SelectCongnoNhap");
                View.RefreshData();
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("Tin_SelectCongnoNhap", ex);
                }
            }
        }
    }
}