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
using log4net;
using B2B.View;
using B2B.Presenter;

namespace B2B.Forms
{
    public partial class KhachhangDetailForm : DevExpress.XtraEditors.XtraForm, IKhachhangDetailView
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        KhachhangDetailPresenter presenter;

        public KhachhangDetailForm()
        {
            InitializeComponent();
            presenter = new KhachhangDetailPresenter(this);
            presenter.DisplayNhomKhachhang();
        }

        public KhachhangDetailForm(KhachhangModel value)
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
                khachhangModelBindingSource.DataSource = value;
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
                    logger.Error("", ex);
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

        public List<NhomKhachhangModel> NhomKhachhangItems
        {
            get
            {
                return nhomKhachhangModelBindingSource.DataSource as List<NhomKhachhangModel>;
            }
            set
            {
                nhomKhachhangModelBindingSource.DataSource = value;
            }
        }

        public void RefreshDataNhomKhachhang()
        {
        }

        public void RefreshDataQuanhuyen()
        {
        }

        public void RefreshDataTinhthanh()
        {
        }

        KhachhangModel _value;

        public KhachhangModel Value
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

        public void RefreshData()
        {
        }

        private void OKSimpleButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelSimpleButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void KhachhangDetailForm_KeyUp(object sender, KeyEventArgs e)
        {
            khachhangModelBindingSource.EndEdit();
        }

        private void khachhangModelBindingSource_CurrentItemChanged(object sender, EventArgs e)
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
                    logger.Error("", ex);
                }
                return;
            }
            presenter.DisplayQuanhuyenTheoTinhthanh();
        }
    }
}