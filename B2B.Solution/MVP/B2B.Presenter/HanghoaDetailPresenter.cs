/********************************************************************
	Class file: 
    Author: Pham Xuân Vinh
    Date Created: 05/09/2014
	Last Updated: 05/09/2014
	Updated By: Pham Xuân Vinh
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
     public class HanghoaDetailPresenter: Presenter<IHanghoaDetailView>
    {
         //Create instance of logger for using log4net methods
         private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
         //Flag to check if error level was enabled.
         private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

         public HanghoaDetailPresenter(IHanghoaDetailView view) : base(view) { }

         public void DisplayNhomHanghoa() 
         {
             try
             {
                 View.NhomHanghoaItems = Model.Get<NhomHanghoaModel>("Vinh_GetNhomHanghoaActive");
                 View.RefreshData();
             }
             catch (System.Exception ex)
             {
             	//Check log flag and log error to file.
             	if (isErrorEnabled)
             	{
                    logger.Error("Vinh_GetNhomHanghoaActive", ex);
             	}
             	return;
             }

         }

         public void DislpayDonvi()
         {
             try
             {
                 View.DonviItems = Model.Get<DonviModel>("Vinh_GetDonviActive");
                 View.RefreshData();
             }
             catch (System.Exception ex)
             {
                 //Check log flag and log error to file.
                 if (isErrorEnabled)
                 {
                     logger.Error("Vinh_GetDonviActive", ex);
                 }
                 return;
             }

         }


         
    }
}
