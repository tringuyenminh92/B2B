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
using B2B.View;
using log4net;
using B2B.Presenter;
using B2B.Model;
using System.IO;
using System.Windows.Forms;

/// <summary>
/// The Forms namespace.
/// </summary>
namespace B2B.Forms
{
    /// <summary>
    /// Class DonhangForm.
    /// </summary>
    public partial class DonhangForm : DevExpress.XtraEditors.XtraForm, IDonhangView
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
        /// The is error enabled
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        /// <summary>
        /// The presenter
        /// </summary>
        /// The presenter
        DonhangPresenter presenter;

        /// <summary>
        /// The memory stream
        /// </summary>
        /// The memory stream
        MemoryStream memStream;

        /// <summary>
        /// Initializes a new instance of the <see cref="DonhangForm" /> class.
        /// </summary>
        public DonhangForm()
        {
            InitializeComponent();

            memStream = new MemoryStream();
            donhangModelGridView.SaveLayoutToStream(memStream);
            memStream.Seek(0, System.IO.SeekOrigin.Begin);

            thangNamDateEdit.DateTime = DateTime.Now;
            presenter = new DonhangPresenter(this);
            presenter.DisplayLoaiDonhang();
            presenter.Display();
        }
        /// <summary>
        /// Handles the CustomColumnDisplayText event of the donhangModelGridView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs" /> instance containing the event data.</param>
        private void donhangModelGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == string.Empty)
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        /// <summary>
        /// Handles the Click event of the reloadDonhangSimpleButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void reloadDonhangSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.Display();
        }

        /// <summary>
        /// Handles the Click event of the saveDonhangSimpleButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void saveDonhangSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.Save();
            presenter.Display();
        }

        /// <summary>
        /// Handles the Click event of the editDonhangSimpleButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void editDonhangSimpleButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            if (DonhangCurrent == null)
            {
                return;
            }
            using (var f = new DonhangDetailForm(DonhangCurrent as DonhangModel))
            {
                f.isEdit = true;
                if (presenter.DaChot() || presenter.DaHuy())
                {
                    f.isEnabled = false;
                }
                var rs = f.ShowDialog(this);
                if (rs == DialogResult.OK)
                {
                    presenter.Save();
                }
            }
            presenter.Display();
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
        /// Handles the Click event of the addDonhangSimpleButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void addDonhangSimpleButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            using (var currentStream = new MemoryStream())
            {
                donhangModelGridView.SaveLayoutToStream(currentStream);
                currentStream.Seek(0, SeekOrigin.Begin);

                donhangModelGridView.RestoreLayoutFromStream(memStream);
                memStream.Seek(0, SeekOrigin.Begin);
                if (presenter.Addnew())
                {
                    donhangModelGridView.MoveLast();
                    using (var f = new DonhangDetailForm(DonhangCurrent as DonhangModel))
                    {
                        if (f.ShowDialog(this) == DialogResult.Cancel)
                        {
                            presenter.Delete();
                        }
                    }
                }
                presenter.Save();

                donhangModelGridView.RestoreLayoutFromStream(currentStream);
                currentStream.Seek(0, SeekOrigin.Begin);
            }
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
        /// Handles the Click event of the exportDonhangSimpleButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void exportDonhangSimpleButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the deleteDonhangSimpleButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void deleteDonhangSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.Delete();
        }

        /// <summary>
        /// Gets or sets the donhang items.
        /// </summary>
        /// <value>The donhang items.</value>
        public List<DonhangModel> DonhangItems
        {
            get
            {
                return donhangModelBindingSource.DataSource as List<DonhangModel>;
            }
            set
            {
                donhangModelBindingSource.DataSource = value;
            }
        }

        /// <summary>
        /// Gets the donhang current.
        /// </summary>
        /// <value>The donhang current.</value>
        public DonhangModel DonhangCurrent
        {
            get { return donhangModelBindingSource.Current as DonhangModel; }
        }

        /// <summary>
        /// Refreshes the data.
        /// </summary>
        public void RefreshData()
        {
            donhangModelGridControl.RefreshDataSource();
        }

        /// <summary>
        /// Gets or sets the filter value.
        /// </summary>
        /// <value>The filter value.</value>
        public DateTime filterValue
        {
            get
            {
                return thangNamDateEdit.DateTime;
            }
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
        /// Gets or sets the loai donhang current value.
        /// </summary>
        /// <value>The loai donhang current value.</value>
        public int? LoaiDonhangCurrentValue
        {
            get
            {
                return loaiDonhangValueComboBox.SelectedValue as int?;
            }
            set
            {
                loaiDonhangValueComboBox.SelectedValue = value;
            }
        }

    }
}