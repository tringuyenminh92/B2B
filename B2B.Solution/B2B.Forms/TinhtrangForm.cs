// ***********************************************************************
// Assembly         : B2B.Forms
// Author           : Ga9286
// Created          : 04-11-2014
//
// Last Modified By : Ga9286
// Last Modified On : 22-11-2014
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using B2B.View;
using B2B.Model;
using B2B.Presenter;
using log4net;
using System.IO;

/// <summary>
/// The Forms namespace.
/// </summary>
namespace B2B.Forms
{
    /// <summary>
    /// Class TinhtrangForm.
    /// </summary>
    public partial class TinhtrangForm : DevExpress.XtraEditors.XtraForm, ITinhtrangView
    {
        //Create instance of logger for using log4net methods
        /// <summary>
        /// The logger
        /// </summary>
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        /// <summary>
        /// The is error enabled
        /// </summary>
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        /// <summary>
        /// The presenter
        /// </summary>
        private TinhtrangPresenter presenter;

        /// <summary>
        /// The memory stream
        /// </summary>
        MemoryStream memStream;

        /// <summary>
        /// Initializes a new instance of the <see cref="TinhtrangForm" /> class.
        /// </summary>
        public TinhtrangForm()
        {
            InitializeComponent();

            memStream = new MemoryStream();
            tinhtrangModelGridView.SaveLayoutToStream(memStream);
            memStream.Seek(0, System.IO.SeekOrigin.Begin);

            presenter = new TinhtrangPresenter(this);
            presenter.DisplayLoaiTinhtrang();
            presenter.DisplayTinhtrangTheoLoai();
        }

        /// <summary>
        /// Handles the CustomColumnDisplayText event of the tinhtrangModelGridView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs" /> instance containing the event data.</param>
        private void tinhtrangModelGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "")
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        /// <summary>
        /// Gets or sets the tinhtrang items.
        /// </summary>
        /// <value>The tinhtrang items.</value>
        public List<TinhtrangModel> TinhtrangItems
        {
            get { return tinhtrangModelBindingSource.DataSource as List<TinhtrangModel>; }
            set { tinhtrangModelBindingSource.DataSource = value; }
        }

        /// <summary>
        /// Gets the tinhtrang current.
        /// </summary>
        /// <value>The tinhtrang current.</value>
        public TinhtrangModel TinhtrangCurrent
        {
            get { return tinhtrangModelBindingSource.Current as TinhtrangModel; }
        }

        /// <summary>
        /// Gets or sets the loai tinhtrang items.
        /// </summary>
        /// <value>The loai tinhtrang items.</value>
        public List<LoaiTinhtrangModel> LoaiTinhtrangItems
        {
            get { return loaiTinhtrangBindingSource.DataSource as List<LoaiTinhtrangModel>; }
            set { loaiTinhtrangBindingSource.DataSource = value; }
        }

        /// <summary>
        /// Gets the loai tinhtrang current value.
        /// </summary>
        /// <value>The loai tinhtrang current value.</value>
        public int? LoaiTinhtrangCurrentValue
        {
            get { return loaiTinhtrangValueComboBox.SelectedValue as int?; }
        }

        /// <summary>
        /// Refreshes the data.
        /// </summary>
        public void RefreshData()
        {
            tinhtrangModelGridControl.RefreshDataSource();
        }

        /// <summary>
        /// Handles the Click event of the locTinhtrangSimpleButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void locTinhtrangSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.DisplayTinhtrangTheoLoai();
        }

        /// <summary>
        /// Handles the Click event of the addTinhtrangSimpleButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void addTinhtrangSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var currentStream = new MemoryStream())
                {
                    tinhtrangModelGridView.SaveLayoutToStream(currentStream);
                    currentStream.Seek(0, System.IO.SeekOrigin.Begin);

                    tinhtrangModelGridView.RestoreLayoutFromStream(memStream);
                    memStream.Seek(0, System.IO.SeekOrigin.Begin);

                    if (presenter.Addnew())
                    {
                        tinhtrangModelGridView.MoveLast();
                        using (var f = new TinhtrangDetailForm(TinhtrangCurrent as TinhtrangModel))
                        {
                            if (f.ShowDialog(this) == DialogResult.Cancel)
                            {
                                presenter.Delete();
                            }
                        }
                    }

                    tinhtrangModelGridView.RestoreLayoutFromStream(currentStream);
                    currentStream.Seek(0, System.IO.SeekOrigin.Begin);
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

        /// <summary>
        /// Handles the Click event of the saveTinhtrangSimpleButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void saveTinhtrangSimpleButton_Click(object sender, EventArgs e)
        {
            if (presenter.Save())
            {
                MessageBox.Show("Lưu Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lưu Không Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            presenter.DisplayTinhtrangTheoLoai();
        }

        /// <summary>
        /// Handles the Click event of the deleteTinhtrangSimpleButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void deleteTinhtrangSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.Delete();
        }

        /// <summary>
        /// Handles the CurrentItemChanged event of the loaiTinhtrangBindingSource control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void loaiTinhtrangBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            presenter.DisplayTinhtrangTheoLoai();
        }
    }
}