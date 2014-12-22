/********************************************************************
	Class file: 
    Author: Tran Nguyen Hoang Khuyen
    Date Created: 
	Last Updated: 
	Updated By: Tran Nguyen Hoang Khuyen
	Update Description: 
*********************************************************************/

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
using B2B.Presenter;
using B2B.View;
using log4net;
using B2B.Model;

namespace B2B.Forms
{
    public partial class NhomKhachhangDetailForm : DevExpress.XtraEditors.XtraForm
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        public NhomKhachhangDetailForm()
        {
            InitializeComponent();
        }

        public NhomKhachhangDetailForm(NhomKhachhangModel value)
            : this()
        {
            nhomKhachhangModelBindingSource.DataSource = value;
        }

        private void OKSimpleButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; 
            this.Close(); 
        }

        private void CancelSimpleButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void NhomKhachhangDetailForm_KeyUp(object sender, KeyEventArgs e)
        {
            nhomKhachhangModelBindingSource.EndEdit();
        }

    }
}