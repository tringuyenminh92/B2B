// ***********************************************************************
// Assembly         : B2B.Forms
// Author           : Ga9286
// Created          : 27-10-2014
//
// Last Modified By : Ga9286
// Last Modified On : 09-11-2014
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using B2B.View;
using B2B.Model;
using B2B.Presenter;
using DevExpress.XtraEditors;
using log4net;
using System.Reflection;
using DevExpress.XtraGrid.Views.Base;
/// <summary>
/// The Forms namespace.
/// </summary>
namespace B2B.Forms
{
    /// <summary>
    /// Class DonhangDetailForm.
    /// </summary>
    public partial class DonhangDetailForm : DevExpress.XtraEditors.XtraForm, IDonhangDetailView
    {
        //Create instance of logger for using log4net methods
        /// <summary>
        /// The logger
        /// </summary>
        private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        //Flag to check if error level was enabled.
        /// <summary>
        /// The is error enabled
        /// </summary>
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        /// <summary>
        /// The presenter
        /// </summary>
        private DonhangDetailPresenter presenter;

        public bool isEnabled = true;

        public bool isEdit = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="DonhangDetailForm" /> class.
        /// </summary>
        public DonhangDetailForm()
        {
            InitializeComponent();
            presenter = new DonhangDetailPresenter(this);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DonhangDetailForm" /> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public DonhangDetailForm(DonhangModel value)
            : this()
        {
            Value = value; presenter.DisplayKhachhang();
            presenter.DisplayThongtinGiaohang();
            presenter.DisplayKho();
            presenter.DisplayTinhtrang();
            presenter.DisplayLoaiDonhang();
            donhangModelBindingSource.DataSource = value;
            presenter.DisplayChitietDonhang();
            chitietDonhangModelBindingSource.DataSource = value.ChitietDonhangItems;
            HideSoluongDagiaoDoivoiVansale();
        }

        private void HideSoluongDagiaoDoivoiVansale()
        {
            if (Value.LoaiDonhang == 1)
            {
                chitietDonhangModelGridView.Columns["SoluongGiao"].Visible = false;
                chitietDonhangModelGridView.Columns["SoluongConlai"].Visible = false;
            }
        }

        /// <summary>
        /// Handles the Click event of the SaveSimpleButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void SaveSimpleButton_Click(object sender, EventArgs e)
        {
            if (presenter.CapnhatKhachhangTongtienTenTinhtrangNgayCapnhat())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                presenter.RevertCurrentValue();
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }

        }
        /// <summary>
        /// Handles the Click event of the CancelSimpleButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void CancelSimpleButton_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        /// <summary>
        /// Handles the Click event of the addChitietDonhangSimpleButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void addChitietDonhangSimpleButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            presenter.Addnew();
            chitietDonhangModelGridView.MoveLast();
            //}
            //catch (Exception ex)
            //{
            //    //Check log flag and log error to file.
            //    if (isErrorEnabled)
            //    {
            //        logger.Error("", ex);
            //    }
            //}
        }

        /// <summary>
        /// Handles the Click event of the deleteChitietDonhangSimpleButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void deleteChitietDonhangSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.Delete();
            chitietDonhangModelGridView.MoveLast();
        }

        /// <summary>
        /// Gets or sets the khachhang items.
        /// </summary>
        /// <value>The khachhang items.</value>
        public List<KhachhangModel> KhachhangItems
        {
            get
            {
                return khachhangModelBindingSource.DataSource as List<KhachhangModel>;
            }
            set
            {
                khachhangModelBindingSource.DataSource = value;
            }
        }

        /// <summary>
        /// Gets the khachhang current identifier.
        /// </summary>
        /// <value>The khachhang current identifier.</value>
        public Guid? KhachhangCurrentId
        {
            get
            {
                return khachhangIdTextEdit.EditValue as Guid?;
            }
            set
            {
                khachhangIdTextEdit.EditValue = value;
            }
        }

        /// <summary>
        /// Gets or sets the kho items.
        /// </summary>
        /// <value>The kho items.</value>
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

        /// <summary>
        /// Gets the kho current identifier.
        /// </summary>
        /// <value>The kho current identifier.</value>
        public Guid? KhoCurrentId
        {
            get { return khoIdComboBox.SelectedValue as Guid?; }
        }

        /// <summary>
        /// Gets or sets the loai donhang items.
        /// </summary>
        /// <value>The loai donhang items.</value>
        public List<LoaiDonhangModel> LoaiDonhangItems
        {
            get
            {
                return loaiDonhangModelBindingSource.DataSource as List<LoaiDonhangModel>;
            }
            set
            {
                loaiDonhangModelBindingSource.DataSource = value;
            }
        }

        /// <summary>
        /// Gets the loai donhang current value.
        /// </summary>
        /// <value>The loai donhang current value.</value>
        public int LoaiDonhangCurrentValue
        {
            get { return int.Parse(loaiDonhangComboBox.SelectedValue.ToString()); }
        }

        /// <summary>
        /// Gets or sets the tinhtrang items.
        /// </summary>
        /// <value>The tinhtrang items.</value>
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

        /// <summary>
        /// Gets the tinhtrang current identifier.
        /// </summary>
        /// <value>The tinhtrang current identifier.</value>
        public Guid? TinhtrangCurrentId
        {
            get { return tinhtrangIdComboBox.SelectedValue as Guid?; }
        }

        /// <summary>
        /// Gets or sets the hanghoa items.
        /// </summary>
        /// <value>The hanghoa items.</value>
        public List<HanghoaModel> HanghoaItems
        {
            get
            {
                return danhsachHanghoaModelBindingSource.DataSource as List<HanghoaModel>;
            }
            set
            {
                danhsachHanghoaModelBindingSource.DataSource = value;
            }
        }

        /// <summary>
        /// Gets the hanghoa current identifier.
        /// </summary>
        /// <value>The hanghoa current identifier.</value>
        public Guid? HanghoaCurrentId
        {
            get { return hanghoaIdTextEdit.EditValue as Guid?; }
        }

        /// <summary>
        /// Gets or sets the chitiet donhang items.
        /// </summary>
        /// <value>The chitiet donhang items.</value>
        public List<ChitietDonhangModel> ChitietDonhangItems
        {
            get
            {
                return chitietDonhangModelBindingSource.DataSource as List<ChitietDonhangModel>;
            }
            set
            {
                chitietDonhangModelBindingSource.DataSource = value;
            }
        }

        /// <summary>
        /// Gets the chitiet donhang current.
        /// </summary>
        /// <value>The chitiet donhang current.</value>
        public ChitietDonhangModel ChitietDonhangCurrent
        {
            get { return chitietDonhangModelBindingSource.Current as ChitietDonhangModel; }
        }

        /// <summary>
        /// The _value
        /// </summary>
        private DonhangModel _value;
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        public DonhangModel Value
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

        /// <summary>
        /// Refreshes the data.
        /// </summary>
        public void RefreshData()
        {
            chitietDonhangModelGridControl.RefreshDataSource();
        }

        /// <summary>
        /// Handles the CustomColumnDisplayText event of the chitietDonhangModelGridView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="CustomColumnDisplayTextEventArgs" /> instance containing the event data.</param>
        private void chitietDonhangModelGridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "")
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        /// <summary>
        /// Gets or sets the hanghoa current.
        /// </summary>
        /// <value>The hanghoa current.</value>
        public HanghoaModel HanghoaCurrent
        {
            get
            {
                return hanghoaModelBindingSource.Current as HanghoaModel;
            }
            set
            {
                hanghoaModelBindingSource.DataSource = value;
            }
        }


        /// <summary>
        /// Handles the KeyUp event of the DonhangDetailForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyEventArgs" /> instance containing the event data.</param>
        private void DonhangDetailForm_KeyUp(object sender, KeyEventArgs e)
        {
            donhangModelBindingSource.EndEdit();
            chitietDonhangModelBindingSource.EndEdit();
        }
        /// <summary>
        /// Handles the CurrentItemChanged event of the donhangModelBindingSource control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void donhangModelBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            presenter.DisplayThongtinGiaohang();
            presenter.DisplayHanghoaTheoKhachhang();
        }

        /// <summary>
        /// Handles the EditValueChanged event of the hanghoaIdTextEdit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void hanghoaIdTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            presenter.SetHanghoaCurrent();
        }

        /// <summary>
        /// Handles the EditValueChanged event of the ngaygiaoDateEdit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void ngaygiaoDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            //Handle GUI to update HanGiaohang base on Ngaygiao
            if (ngaygiaoDateEdit.EditValue != null)
            {
                if (ngaygiaoDateEdit.DateTime.ToString("dd/MM/yyyy") == "01/01/0001")
                {
                    ngaygiaoDateEdit.Properties.MinValue = DateTime.Now;
                }
                ngaygiaoDateEdit.Properties.MinValue = ngaygiaoDateEdit.DateTime;
                hanDonhangDateEdit.DateTime = ngaygiaoDateEdit.DateTime.AddDays(7);
                hanDonhangDateEdit.Properties.MinValue = hanDonhangDateEdit.DateTime;
                donhangModelBindingSource.EndEdit();
            }
        }

        private void HuySimpleButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn hủy", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                presenter.HuyDonhang();
                this.DialogResult = DialogResult.Ignore;
            }
            this.Close();
        }

        private void DonhangDetailForm_Load(object sender, EventArgs e)
        {
            if (!isEnabled)
            {

                ThongtinKhachhangGroupControl.Enabled = false;
                SystemInformationGroupControl.Enabled = false;
                ThaotacGroupControl.Enabled = false;
            }
            if (isEdit)
            {
                khoIdComboBox.Enabled = false;
                loaiDonhangComboBox.Enabled = false;
            }
        }

        private void ChotSimpleButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn chốt", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                presenter.ChotDonhang();
                this.DialogResult = DialogResult.Ignore;
            }
            this.Close();
        }


        public bool IsCongdon
        {
            get
            {
                return bool.Parse(congdonCheckEdit.EditValue.ToString());
            }
            set
            {
                congdonCheckEdit.EditValue = value;
            }
        }

        private void congdonCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            var obj = sender as CheckEdit;
            if (obj != null)
            {
                if (bool.Parse(obj.EditValue.ToString()))
                {
                    phantramGiamSpinEdit.Enabled = false;
                    phantramVATSpinEdit.Enabled = false;
                    tiengiamHienthiSpinEdit.Enabled = false;
                    congdonCheckEdit.Enabled = false;
                    presenter.CongdonChitietItemsCurrent();
                }
            }

        }


    }
}