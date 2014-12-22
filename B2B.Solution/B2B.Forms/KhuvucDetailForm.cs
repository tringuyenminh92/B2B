/********************************************************************
	Class file: 
    Author: Nguyen Minh Tri
    Date Created: 23/08/2014
	Last Updated: 23/08/2014
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
    public partial class KhuvucDetailForm : DevExpress.XtraEditors.XtraForm
    {
        public KhuvucDetailForm()
        {
            InitializeComponent();
        }
        public KhuvucDetailForm(KhuvucModel value):this()
        {
            khuvucModelBindingSource.DataSource = value;
        }

        private void LoginSimpleButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelSimpleButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void KhuvucDetailForm_KeyUp(object sender, KeyEventArgs e)
        {
            khuvucModelBindingSource.EndEdit();
        }
    }
}