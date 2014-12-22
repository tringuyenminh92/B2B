// ***********************************************************************
// Assembly         : B2B.Forms
// Author           : Ga9286
// Created          : 15-12-2014
//
// Last Modified By : Ga9286
// Last Modified On : 15-12-2014
// ***********************************************************************

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
using log4net;

/// <summary>
/// The Forms namespace.
/// </summary>
namespace B2B.Forms
{
    /// <summary>
    /// Class TonkhoForm.
    /// </summary>
    public partial class TonkhoForm : DevExpress.XtraEditors.XtraForm, ITonkhoView
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        private TonkhoPresenter presenter;
        /// <summary>
        /// Initializes a new instance of the <see cref="TonkhoForm"/> class.
        /// </summary>
        public TonkhoForm()
        {
            InitializeComponent();
            presenter = new TonkhoPresenter(this);
            presenter.DisplayThangnamNhapxuat();
            presenter.DisplayTonkhoTheoThang();
        }



        /// <summary>
        /// Gets or sets the tonkho items.
        /// </summary>
        /// <value>The tonkho items.</value>
        /// <exception cref="System.NotImplementedException">
        /// </exception>
        public List<TonkhoTheoNgayModel> TonkhoItems
        {
            get { return tonkhoTheoNgayModelBindingSource.DataSource as List<TonkhoTheoNgayModel>; }
            set { tonkhoTheoNgayModelBindingSource.DataSource = value; }
        }

        /// <summary>
        /// Gets or sets the thangnam nhapxuat items.
        /// </summary>
        /// <value>The thangnam nhapxuat items.</value>
        public List<ThangnamNhapxuatModel> ThangnamNhapxuatItems
        {
            get { return thangnamNhapxuatModelBindingSource.DataSource as List<ThangnamNhapxuatModel>; }
            set { thangnamNhapxuatModelBindingSource.DataSource = value; }
        }

        /// <summary>
        /// Gets the ngay thangnam filter.
        /// </summary>
        /// <value>The ngay thangnam filter.</value>
        /// <exception cref="System.NotImplementedException"></exception>
        public DateTime NgayThangnamFilter
        {
            get
            {
                var thoigian = thangnamNhapxuatModelBindingSource.Current as ThangnamNhapxuatModel;
                if (thoigian != null && thoigian.onNgay.HasValue && thoigian.inMonth.HasValue && thoigian.inYear.HasValue)
                {
                    return new DateTime(thoigian.inYear.Value, thoigian.inMonth.Value, thoigian.onNgay.Value);
                }
                return DateTime.Now;
            }
        }

        /// <summary>
        /// Refreshes the data thangnam.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public void RefreshDataThangnam()
        {
            thangnamNhapxuatModelGridControl.RefreshDataSource();
        }

        /// <summary>
        /// Refreshes the data.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public void RefreshData()
        {
            tonkhoTheoNgayModelGridControl.RefreshDataSource();
        }

        private void tonkhoTheoNgayModelBandedGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "")
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void thangnamNhapxuatModelBandedGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "")
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void TonkhoForm_Load(object sender, EventArgs e)
        {
            SetCurrentDay();
        }

        private void SetCurrentDay()
        {
            var ymItems = thangnamNhapxuatModelBindingSource.DataSource as List<ThangnamNhapxuatModel>;
            var index = ymItems.FindIndex(p => p.inMonth == DateTime.Now.Month && p.inYear == DateTime.Now.Year && p.onNgay == DateTime.Now.Day);
            if (index != -1)
            {
                thangnamNhapxuatModelBandedGridView.MoveBy(thangnamNhapxuatModelBandedGridView.GetRowHandle(index) -
                                                      thangnamNhapxuatModelBandedGridView.FocusedRowHandle);
            }
            else
            {
                thangnamNhapxuatModelBandedGridView.MoveLast();
            }
        }

        private void thangnamNhapxuatModelBindingSource_PositionChanged(object sender, EventArgs e)
        {
            presenter.DisplayTonkhoTheoThang();
        }

    }
}