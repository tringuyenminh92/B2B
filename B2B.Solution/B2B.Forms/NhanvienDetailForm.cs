/********************************************************************
	Class file: 
    Author: Nguyen Minh Tri
    Date Created: 30/08/2014
	Last Updated: 30/08/2014
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
using B2B.Presenter;
using log4net;

namespace B2B.Forms
{
    public partial class NhanvienDetailForm : DevExpress.XtraEditors.XtraForm, INhanvienDetailView
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        NhanvienDetailPresenter presenter;

        public NhanvienDetailForm()
        {
            InitializeComponent();
            try
            {
                presenter = new NhanvienDetailPresenter(this);
                presenter.DisplayPhongban();
            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("DisplayNhomNhanvien", ex);
                }
                return;
            }

        }

        public NhanvienDetailForm(NhanvienModel value)
            : this()
        {
            try
            {
                Value = value;
                presenter.DisplayTinhthanh();
                if (value.TinhthanhId != null)
                {
                    presenter.DisplayQuanhuyenTheoTinhthanh();
                }
                else
                {
                    presenter.DisplayQuanhuyen();
                }
                nhanvienModelBindingSource.DataSource = value;
            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("None", ex);
                }
                return;
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

        public QuanhuyenModel QuanhuyenCurrent
        {
            get { return quanhuyenModelBindingSource.Current as QuanhuyenModel; }
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

        public void RefreshData()
        {
        }

        public void RefreshDataPhongban()
        {
        }

        public void RefreshDataQuanhuyen()
        {
        }

        public void RefreshDataTinhthanh()
        {
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

        private void NhanvienDetailForm_KeyUp(object sender, KeyEventArgs e)
        {
            nhanvienModelBindingSource.EndEdit();
        }

        NhanvienModel _value;
        public NhanvienModel Value
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

        private void AnhMyPictureEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var pic = sender as MyPictureEdit;
                if (pic != null)
                {
                    if (!string.IsNullOrWhiteSpace(pic.FileName))
                    {
                        Value.Linkanh = pic.FileName;
                    }

                    if (pic.EditValue == null)
                    {
                        Value.Linkanh = null;
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
            }
        }

        private void nhanvienModelBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(Value.Linkanh))
                {
                    AnhMyPictureEdit.Image = Image.FromFile(Value.Linkanh);
                }
            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("nhanvienModelBindingSource_CurrentItemChanged", ex);
                }
            }
            presenter.DisplayQuanhuyenTheoTinhthanh();
        }


        public List<PhongbanModel> PhongbanItems
        {
            get
            {
                return phongbanModelBindingSource.DataSource as List<PhongbanModel>;
            }
            set
            {
                phongbanModelBindingSource.DataSource = value;
            }
        }
    }
}