/********************************************************************
	Class file: 
    Author: Pham Xuan Vinh
    Date Created: 23/09/2014
	Last Updated: 13/11/2014
	Updated By: Pham Xuan Vinh
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
using log4net;
using B2B.Presenter;
using B2B.Model;

namespace B2B.Forms
{
    public partial class PhieuxuatDetailForm : DevExpress.XtraEditors.XtraForm, IPhieuxuatDetailView
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        PhieuxuatDetailPresenter presenter;
        PhieuxuatModel _valuePhieuxuat;
        public bool isEdit;

        public PhieuxuatDetailForm()
        {
            InitializeComponent();

            presenter = new PhieuxuatDetailPresenter(this);
            presenter.DisplayKho();
            presenter.DisplayTinhtrang();
            presenter.DisplayNhanvienGiaohang();
            presenter.DisplayNguyennhanLydo();
            
        }
        public PhieuxuatDetailForm(PhieuxuatModel valuePhieuxuat) : this()
        {
            ValuePhieuxuat = valuePhieuxuat;
            if(ValuePhieuxuat.Donhang == null)
            {
                presenter.DisplayDonhang();
            }
            presenter.DisplayChitietDonhang();
            presenter.DisplayChitietPhieuxuat();
            phieuxuatModelBindingSource.DataSource = valuePhieuxuat;
            chitietPhieuxuatModelBindingSource.DataSource = valuePhieuxuat.ChitietPhieuxuatItems;
            //tinhtrangPhieuxuatModelBindingSource.DataSource = TinhtrangPhieuxuatMoinhat;
        }

        private void OKSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.CapnhatChitietDonhang();
            presenter.CapnhatChitietPhieuxuat();
            //var tinhtrang = tinhtrangPhieuxuatCurrentIdTextEdit.GetSelectedDataRow() as TinhtrangModel;
            //ValuePhieuxuat.TenTinhtrangPhieuxuat = tinhtrang.TenTinhtrang;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.ResetCurrent();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public List<Model.ChitietDonhangModel> ChitietDonhangItems
        {
            get
            {
                return chitietPhieuxuatModelBindingSource.DataSource as List<ChitietDonhangModel>;
            }
            set
            {
                chitietPhieuxuatModelBindingSource.DataSource = value;
            }
        }

        public void RefeshDataChitietDonhang()
        {
            chitietPhieuxuatModelGridControl.RefreshDataSource();
        }

        public List<NhanvienModel> NhanvienGiaohangItems
        {
            get
            {
                return nhanvienModelBindingSource.DataSource as List<NhanvienModel>;
            }
            set
            {
                nhanvienModelBindingSource.DataSource = value;
            }
        }

        public NhanvienModel NhanvienGiaohangCurrent
        {
            get { return nhanvienModelBindingSource.Current as NhanvienModel; }
        }

        public List<TinhtrangModel> TinhtrangItems
        {
            get
            {
                return tinhtrangModelBindingSource.DataSource as List<TinhtrangModel>;
            }
            set
            {
                tinhtrangModelBindingSource.DataSource = value;
            }
        }

        public TinhtrangModel TinhtrangCurrent
        {
            get { return tinhtrangModelBindingSource.Current as TinhtrangModel; }
        }

        private void PhieuxuatDetailForm_KeyUp(object sender, KeyEventArgs e)
        {
            phieuxuatModelBindingSource.EndEdit();
        }

        public List<KhoModel> KhoItems
        {
            get
            {
                return khoModelBindingSource.DataSource as List<KhoModel>;
            }
            set
            {
                khoModelBindingSource.DataSource = value;
            }
        }

        public KhoModel KhoCurent
        {
            get { return khoModelBindingSource.Current as KhoModel; }
        }

        public void RefreshData()
        {
        }

        public PhieuxuatModel ValuePhieuxuat
        {
            get
            {
                return _valuePhieuxuat;
            }
            set
            {
                _valuePhieuxuat = value;
            }
        }

        private void chitietPhieuxuatgridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "")
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }


        //public List<int?> LstSoluongXuatBandau
        //{
        //    get
        //    {
        //        return _lstsoLuongXuatBandau;
        //    }
        //    set
        //    {
        //        _lstsoLuongXuatBandau = value;
        //    }
        //}

        //public Guid? TinhtrangIdBandau
        //{
        //    get
        //    {
        //        return _tinhtrangIdBandau;
        //    }
        //    set
        //    {
        //        _tinhtrangIdBandau = value;
        //    }
        //}

        public List<NguyennhanLydoModel> NguyennhanLydoItems
        {
            get
            {
                return nguyennhanLydoModelBindingSource.DataSource as List<NguyennhanLydoModel>;
            }
            set
            {
                nguyennhanLydoModelBindingSource.DataSource = value;
            }
        }

        public NguyennhanLydoModel NguyennhanLydoCurrent
        {
            get { return nguyennhanLydoModelBindingSource.Current as NguyennhanLydoModel; }
        }

        private void PhieuxuatDetailForm_Load(object sender, EventArgs e)
        {
            if (isEdit)
            {
                chitietPhieuxuatgridView.OptionsBehavior.ReadOnly = true;
                khoIdTextEdit.Enabled = false;
                khoIdTextEdit.BackColor = Color.White;
            }
        }

        private void tinhtrangPhieuxuatCurrentIdTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void nguyennhanLydoTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}