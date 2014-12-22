/********************************************************************
	Class file: 
    Author: Tran Nguyen Hoang Khuyen
    Date Created: 13/09/2014
	Last Updated: 13/09/2014
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
using B2B;
using B2B.View;
using log4net;
using B2B.Presenter;
using B2B.Model;

namespace B2B.Forms
{
    public partial class HanghoaDetailForm : DevExpress.XtraEditors.XtraForm, IHanghoaDetailView
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        HanghoaDetailPresenter presenter;

        public HanghoaDetailForm()
        {
            InitializeComponent();
            try
            {
                presenter = new HanghoaDetailPresenter(this);
                presenter.DisplayNhomHanghoa();
                presenter.DislpayDonvi();
            }
            catch (System.Exception ex)
            {
            	//Check log flag and log error to file.
            	if (isErrorEnabled)
            	{
                    logger.Error("DisplayNhomHanghoa+DislpayDonvi", ex);
            	}
            	return;
            }
            
        }

        HanghoaModel _value;
        public HanghoaModel Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public HanghoaDetailForm(HanghoaModel value)
            : this()
        {
            try
            {
                Value = value;
                
                hanghoaModelBindingSource.DataSource = value;
            }
            catch (System.Exception ex)
            {
            	//Check log flag and log error to file.
            	if (isErrorEnabled)
            	{
            		logger.Error("none", ex);
            	}
            	return;
            }
        }

        public List<NhomHanghoaModel> NhomHanghoaItems
        {
            get
            {
                return nhomHanghoaModelBindingSource.DataSource as List<NhomHanghoaModel>;
            }
            set
            {
                nhomHanghoaModelBindingSource.DataSource = value;
            }
        }

        public NhomHanghoaModel NhomHanghoaCurrent
        {
            get { return nhomHanghoaModelBindingSource.Current as NhomHanghoaModel; }
        }

        public List<DonviModel> DonviItems
        {
            get
            {
                return donviModelBindingSource.DataSource as List<DonviModel>;
            }
            set
            {
                donviModelBindingSource.DataSource = value;
            }
        }

        public DonviModel DonviCurrent
        {
            get { return donviModelBindingSource.Current as DonviModel; }
        }

        public void RefreshDataNhomHanghoa()
        {
            
        }

        public void RefreshDataDonvi()
        {
            
        }

        public void RefreshData()
        {
            
        }


      
     

        private void HanghoaDetailForm_KeyUp(object sender, KeyEventArgs e)
        {
            hanghoaModelBindingSource.EndEdit();
        }

        private void AnhMyPictureEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var pic = sender as MyPictureEdit;
                if(pic!=null)
                {
                    if(!string.IsNullOrWhiteSpace(pic.FileName))
                    {
                        Value.LinkHinhanh = pic.FileName;
                    }
                    if(pic.EditValue == null)
                    {
                        Value.LinkHinhanh = null;
                    }
                }
                
            }
            catch (System.Exception ex)
            {
            	//Check log flag and log error to file.
            	if (isErrorEnabled)
            	{
                    logger.Error("AnhMyPictureEdit_EditValueChanged", ex);
            	}
            	return;
            }
        }

        private void hanghoaModelBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(Value.LinkHinhanh))
                {
                    AnhMyPictureEdit.Image = Image.FromFile(Value.LinkHinhanh);
                }
            }
            catch (System.Exception ex)
            {
            	//Check log flag and log error to file.
            	if (isErrorEnabled)
            	{
                    logger.Error("hanghoaModelBindingSource_CurrentItemChanged", ex);
            	}
            	return;
            }
        }

        private void OKSimpleButton_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelSimpleButton_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void donviIdTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            var dv = donviIdTextEdit.GetSelectedDataRow() as DonviModel;
            if (dv != null)
            {
                Value.TenDonVi = dv.TenDonvi;
            }
        }

        private void nhomHanghoaIdTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            var nhh = nhomHanghoaIdTextEdit.GetSelectedDataRow() as NhomHanghoaModel;
            Value.TenNhomhanghoa = nhh.TenNhomHanghoa;
        }

    }
}