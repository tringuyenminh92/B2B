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
using B2B.Presenter;
using B2B.Model;

namespace B2B.Forms
{
    public partial class QuanhuyenDetailForm : DevExpress.XtraEditors.XtraForm,IQuanhuyenDetailView
    {
        QuanhuyenDetailPresenter presenter;
        public QuanhuyenDetailForm()
        {
            InitializeComponent();
            presenter = new QuanhuyenDetailPresenter(this);
            presenter.DisplayTinhthanh();
        }
        public QuanhuyenDetailForm(QuanhuyenModel value):this()
        {
            quanhuyenModelBindingSource.DataSource = value;
        }

        private void CancelSimpleButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void OkSimpleButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public List<TinhthanhModel> TinhthanhItems
        {
            get
            {
                return tinhthanhModelBindingSource.DataSource as List<TinhthanhModel>;
            }
            set
            {
                tinhthanhModelBindingSource.DataSource = value;
            }
        }

        public void RefreshData()
        {
            tenTinhthanhTextEdit.RefreshEditValue();
        }

        private void QuanhuyenDetailForm_KeyUp(object sender, KeyEventArgs e)
        {
            quanhuyenModelBindingSource.EndEdit();
        }
    }
}