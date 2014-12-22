/***********************************
Author: Lý Hoàng Tín
Date Created: 08/09/2014
Last Updated: 09/09/2014
Updated By: Lý Hoàng Tín
Update description: 
************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using B2B.View;
using B2B.Model;
using B2B.Presenter;
using log4net;

namespace B2B.Forms
{
    public partial class DongiaDetailForm : DevExpress.XtraEditors.XtraForm
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;
        public DongiaDetailForm()
        {
            InitializeComponent();
        }
        public DongiaDetailForm(DongiaModel value)
            :this()
        {
            dongiaModelBindingSource.DataSource = value;
        }

        private void OkSimpleButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelSimpleButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void DongiaDetailForm_KeyUp(object sender, KeyEventArgs e)
        {
            dongiaModelBindingSource.EndEdit();
        }
    }
}