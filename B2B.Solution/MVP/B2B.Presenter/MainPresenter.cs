/********************************************************************
	Class file: 
    Author: Nguyen Minh Tri
    Date Created: 
	Last Updated: 
	Updated By: Nguyen Minh Tri
	Update Description: 
*********************************************************************/

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
    public class MainPresenter : Presenter<IMainView>
    {
        
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        public MainPresenter(IMainView view)
            : base(view)
        {
            try
            {
                ModelCore.SetDefaultLocalConfig();
                Model.Login("minhtri", "minhtri");
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error(string.Format("IMainView {0}", view.ToString()), ex);
                }
                return;
                
            }

        }
    }
}
