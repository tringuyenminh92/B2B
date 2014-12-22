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
using System.Windows.Forms;
using B2B.Model;
using B2B.View;
using B2B.Presenter;
using log4net;

namespace B2B.Forms
{
    public partial class NhaCungcapDetailForm : DevExpress.XtraEditors.XtraForm, INhaCungcapDetailView
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        NhaCungcapDetailPresenter presenter;
        public NhaCungcapDetailForm()
        {
            InitializeComponent();
            presenter = new NhaCungcapDetailPresenter(this);
        }
        public NhaCungcapDetailForm(NhaCungcapModel nhaCungcapCurrent)
            : this()
        {
            NhaCungcapCurrent = nhaCungcapCurrent;
            presenter.DisplayTinhthanh();
            if (nhaCungcapCurrent.TinhthanhId != null)
            {
                presenter.DisplayQuanhuyenTheoTinhthanh();
            }
            else
            {
                presenter.DisplayQuanhuyen();
            }
            nhaCungcapModelBindingSource.DataSource = nhaCungcapCurrent;
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

        public void RefreshData()
        {
        }

        public void RefreshDataQuanhuyen()
        {
        }

        public TinhthanhModel TinhthanhCurrent
        {
            get { return tinhthanhModelBindingSource.Current as TinhthanhModel; }
        }

        private void nhaCungcapModelBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
             presenter.DisplayQuanhuyenTheoTinhthanh();
        }

        private void NhaCungcapDetailForm_KeyUp(object sender, KeyEventArgs e)
        {
            nhaCungcapModelBindingSource.EndEdit();
        }

        NhaCungcapModel _nhaCungcapCurrent;
        public NhaCungcapModel NhaCungcapCurrent
        {
            get
            {
                return _nhaCungcapCurrent;
            }
            set
            {
                _nhaCungcapCurrent = value;
            }
        }
    }
}