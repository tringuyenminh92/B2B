using B2B.Model;
// ***********************************************************************
// Assembly         : B2B.Presenter
// Author           : Ga9286
// Created          : 04-11-2014
//
// Last Modified By : Ga9286
// Last Modified On : 04-11-2014
// ***********************************************************************
using B2B.View;
using BMIModel;
using log4net;
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
    /// Class TinhtrangDetailPresenter.
    /// </summary>
    public class TinhtrangDetailPresenter : Presenter<ITinhtrangDetailView>
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        /// <summary>
        /// Initializes a new instance of the <see cref="TinhtrangDetailPresenter"/> class.
        /// </summary>
        /// <param name="view">The view.</param>
        public TinhtrangDetailPresenter(ITinhtrangDetailView view)
            : base(view)
        { }

        /// <summary>
        /// Displays the loai tinhtrang.
        /// </summary>
        public void DisplayLoaiTinhtrang()
        {
            try
            {
                View.LoaiTinhtrangItems = LoaiTinhtrangModel.listLoaiTinhtrang;
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("", ex);
                }

            }
        }
    }
}
