/********************************************************************
	Class file: 
    Author: Pham Xuan Vinh
    Date Created: 23/12/2014
	Last Updated: 29/12/2014
	Updated By: Pham Xuan Vinh
	Update Description:
*********************************************************************/

using B2B.Model;
using B2B.View;
using BMIModel;
using BusinessObject;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Presenter
{
    public class PhieuThuchiReportPresenter : Presenter<IPhieuThuchiReportView>
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        public PhieuThuchiReportPresenter(IPhieuThuchiReportView view) : base(view) { }
        
        public void DisplayThongtinThu()
        {
            if (View.ValueThu == null)
                return;



        }

        public void DisplayThongtinChi()
        {
            if (View.ValueChi == null)
                return;
        }

        public void RefestData()
        { }




    }
}
