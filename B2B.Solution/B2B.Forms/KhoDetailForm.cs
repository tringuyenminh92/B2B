/********************************************************************
	Class file: 
    Author: Nguyen Minh Tri
    Date Created: 24/08/2014
	Last Updated: 24/08/2014
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
using B2B.View;
using log4net;
using B2B.Presenter;

namespace B2B.Forms
{
    public partial class KhoDetailForm : DevExpress.XtraEditors.XtraForm,IKhoDetailView
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        KhoDetailPresenter presenter;
        
        public KhoDetailForm()
        {
            InitializeComponent();
            presenter = new KhoDetailPresenter(this);
        }
       
        public KhoDetailForm(KhoModel value)
            : this()
        {
            Value = value;
            presenter.DisplayTinhthanh();
            if(value.TinhthanhId==null)
            {
                presenter.DisplayQuanhuyen();
            }
            else
            {
                presenter.DisplayQuanhuyenTheoTinhthanh();
            }
            khoModelBindingSource.DataSource = value;
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

        public TinhthanhModel TinhthanhCurrent
        {
            get { return tinhthanhModelBindingSource.Current as TinhthanhModel; }
        }
        
        public List<QuanhuyenModel> QuanhuyenItems
        {
            get
            {
                return quanhuyenModelBindingSource.DataSource as List<QuanhuyenModel>;
            }
            set
            {
                quanhuyenModelBindingSource.DataSource = value;
            }
        }

        KhoModel _value;
        public KhoModel Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }

        public void RefreshDataQuanhuyen()
        {
            quanhuyenIdTextEdit.RefreshEditValue();
        }

        public void RefreshData()
        {
            tinhthanhIdTextEdit.RefreshEditValue();
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

        private void khoModelBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            presenter.DisplayQuanhuyenTheoTinhthanh();
        }

        private void KhoDetailForm_KeyUp(object sender, KeyEventArgs e)
        {
            khoModelBindingSource.EndEdit();
        }
    }
}