
/********************************************************************
	Class file: 
    Author: Tran Nguyen Hoang Khuyen
    Date Created: 13/09/2014
	Last Updated: 13/09/2014
	Updated By: Tran Nguyen Hoang Khuyen
	Update Description:
*********************************************************************/

using B2B.View;
using BMIModel;
using log4net;
using System.Collections.Generic;
using B2B.Model;
using BusinessObject;

namespace B2B.Presenter
{
    public class BaogiaPresenter : Presenter<IBaogiaView>
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        public BaogiaPresenter(IBaogiaView view)
            :base(view)
        { }

        public void DisplayKhachhang()
        {
            try
            {
                View.KhachhangItems = Model.Get<KhachhangModel>("Khuyen_GetKhachhang");
                View.RefreshDataKhachhang();
            }
            catch (System.Exception ex)
            {
            	//Check log flag and log error to file.
            	if (isErrorEnabled)
            	{
                    logger.Error("Khuyen_GetKhachhang", ex);
            	}
            	return;
            }
        }

        public void DisplayBaogiaTheoNhomKhachhang()
        {
            try
            {
                var KhachhangCurrent = View.KhachhangCurrent as KhachhangModel;
                if (KhachhangCurrent == null)
                {
                    return;
                }

                var items = new List<AutoItem>();
                items.Add(new AutoItem 
                {
                    Name = "NhomKhachhangId",
                    Value = KhachhangCurrent.NhomKhachhangId,
                    SqlType = System.Data.SqlDbType.UniqueIdentifier
                });

                View.BaogiaItems = Model.Get<HanghoaModel>(new AutoObject
                {
                    Items = items,
                    SpName = "Khuyen_GetBaogiaTheoNhomKhachhang"
                });                
            }
            catch (System.Exception ex)
            {
            	//Check log flag and log error to file.
            	if (isErrorEnabled)
            	{
                    logger.Error(string.Format("Name: {0} SpName: {1}", "NhomKhachhangId", "Khuyen_GetBaogiaTheoNhomKhachhang", ex));
            	}
            	return;
            }
        }
    }
}
