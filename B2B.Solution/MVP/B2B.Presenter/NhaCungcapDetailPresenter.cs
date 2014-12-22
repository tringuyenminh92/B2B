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
using BusinessObject;
using log4net;
using System;
using System.Collections.Generic;

namespace B2B.Presenter
{
    public class NhaCungcapDetailPresenter : Presenter<INhaCungcapDetailView>
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        public NhaCungcapDetailPresenter(INhaCungcapDetailView view)
            : base(view)
        { }

        public void DisplayTinhthanh()
        {
            try
            {
                View.TinhthanhItems = Model.Get<TinhthanhModel>("Tri_GetTinhthanhActive");
                View.RefreshData();
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("Tri_GetTinhthanhActive", ex);
                }
            }
        }
        public void DisplayQuanhuyen()
        {
            try
            {
                View.QuanhuyenItems = Model.Get<QuanhuyenModel>("Tri_GetQuanhuyenActive");
                View.RefreshDataQuanhuyen();
            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("Tri_GetQuanhuyenActive", ex);
                }
            }
        }
        public void DisplayQuanhuyenTheoTinhthanh()
        {
            try
            {
                var current = View.NhaCungcapCurrent as NhaCungcapModel;
                if (current == null)
                {
                    return;
                }

                var items = new List<AutoItem>();
                items.Add(new AutoItem { Name = "TinhthanhId", Value = View.NhaCungcapCurrent.TinhthanhId, SqlType = System.Data.SqlDbType.UniqueIdentifier });
                View.QuanhuyenItems = Model.Get<QuanhuyenModel>(new AutoObject { Items = items, SpName = "Tri_GetQuanhuyenActiveTheoTinhthanh" });
                View.RefreshDataQuanhuyen();
            }
            catch (Exception ex)
            {
                if (isErrorEnabled)
                {
                    logger.Error(string.Format("{0} {1}", View.NhaCungcapCurrent.TinhthanhId, "Tri_GetQuanhuyenTheoTinhthanh"), ex);
                }
            }
        }
    }
}
