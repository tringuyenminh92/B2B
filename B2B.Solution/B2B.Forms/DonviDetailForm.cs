/********************************************************************
	Class file: 
    Author: Nguyen Minh Tri
    Date Created: 29/08/2014
	Last Updated: 18/09/2014
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
    public partial class DonviDetailForm : DevExpress.XtraEditors.XtraForm
    {
        public DonviDetailForm()
        {
            InitializeComponent();
        }
        
        public DonviDetailForm(DonviModel value):this()
        {
            donviModelBindingSource.DataSource = value;
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

        private void DonviDetailForm_KeyUp(object sender, KeyEventArgs e)
        {
            donviModelBindingSource.EndEdit();
        }
    }
}