using B2B.Model;
using B2B.View;
using BMIModel;
using log4net;
// ***********************************************************************
// Assembly         : B2B.Presenter
// Author           : Ga9286
// Created          : 08-11-2014
//
// Last Modified By : Ga9286
// Last Modified On : 08-11-2014
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// The Presenter namespace.
/// </summary>
namespace B2B.Presenter
{
    /// <summary>
    /// Class NguyennhanDetailPresenter.
    /// </summary>
    public class NguyennhanDetailPresenter : Presenter<INguyennhanDetailView>
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        public NguyennhanDetailPresenter(INguyennhanDetailView view)
            : base(view)
        { }

        public void DisplayLoaiNguyennhan()
        {
            try
            {
                View.LoaiNguyennhanItems = LoaiNguyennhanModel.listLoaiNguyennhan;
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("", ex);}

            }
        }
    }
}
