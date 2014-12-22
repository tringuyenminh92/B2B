/********************************************************************
	Class file: 
    Author: Nguyen Minh Tri
    Date Created: 21/09/2014
	Last Updated: 21/09/2014
	Updated By: Nguyen Minh Tri
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
using B2B.Model;

namespace B2B.Forms
{
    public partial class PhongbanDetailForm : DevExpress.XtraEditors.XtraForm
    {
        //Create instance of logger for using log4net methods
        public PhongbanDetailForm()
        {
            InitializeComponent();
        }
        public PhongbanDetailForm(PhongbanModel value)
            : this()
        {
            phongbanModelBindingSource.DataSource = value;
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
    }
}