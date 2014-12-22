/***********************************
Author: Lý Hoàng Tín
Date Created: 10/09/2014
Last Updated: 11/09/2014
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
using B2B.Model;

namespace B2B.Forms
{
    public partial class ThuoctinhHanghoaDetailForm : DevExpress.XtraEditors.XtraForm
    {
        public ThuoctinhHanghoaDetailForm()
        {
            InitializeComponent();
        }
        public ThuoctinhHanghoaDetailForm(ThuoctinhHanghoaModel value)
            :this()
        {
            thuoctinhHanghoaModelBindingSource.DataSource = value;
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

        private void ThuoctinhHanghoaDetailForm_KeyUp(object sender, KeyEventArgs e)
        {
            thuoctinhHanghoaModelBindingSource.EndEdit();
        }
    }
}