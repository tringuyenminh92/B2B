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
using B2B.View;
using B2B.Model;
using B2B.Presenter;

namespace B2B.Forms
{
    public partial class TinhthanhDetailForm : DevExpress.XtraEditors.XtraForm,ITinhthanhDetailView
    {
        TinhthanhDetailPresenter presenter;

        public TinhthanhDetailForm()
        {
            InitializeComponent();
            presenter = new TinhthanhDetailPresenter(this);
            presenter.DisplayKhuvucActive();

        }
        public TinhthanhDetailForm(TinhthanhModel value):this()
        {
            tinhthanhModelBindingSource.DataSource = value;
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

        public List<KhuvucModel> KhuvucItems
        {
            get
            {
                return khuvucModelBindingSource.DataSource as List<KhuvucModel>;
            }
            set
            {
                khuvucModelBindingSource.DataSource = value;
            }
        }

        public void RefreshData()
        {
            khuvucIdTextEdit.RefreshEditValue();
        }

        private void khuvucIdTextEdit_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void TinhthanhDetailForm_KeyUp(object sender, KeyEventArgs e)
        {
            tinhthanhModelBindingSource.EndEdit();
        }
    }
}