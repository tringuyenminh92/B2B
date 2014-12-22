// ***********************************************************************
// Assembly         : B2B.Forms
// Author           : Ga9286
// Created          : 24-08-2014
//
// Last Modified By : Ga9286
// Last Modified On : 10-11-2014
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
using log4net;
using B2B.Presenter;
using System.IO;

/// <summary>
/// The Forms namespace.
/// </summary>
namespace B2B.Forms
{
    /// <summary>
    /// Class KhoForm.
    /// </summary>
    public partial class KhoForm : DevExpress.XtraEditors.XtraForm, IKhoView
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
        KhoPresenter presenter;

        /// <summary>
        /// The memory stream
        /// </summary>
        MemoryStream memStream;
        /// <summary>
        /// Initializes a new instance of the <see cref="KhoForm"/> class.
        /// </summary>
        public KhoForm()
        {
            InitializeComponent();

            memStream = new MemoryStream();
            khoModelGridView.SaveLayoutToStream(memStream);
            memStream.Seek(0, System.IO.SeekOrigin.Begin);

            presenter = new KhoPresenter(this);
            presenter.Display();
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
        /// Gets the kho current.
        /// </summary>
        /// <value>The kho current.</value>
        public KhoModel KhoCurrent
        {
            get { return khoModelBindingSource.Current as KhoModel; }
        }

        /// <summary>
        /// Refreshes the data.
        /// </summary>
        public void RefreshData()
        {
            khoModelGridControl.RefreshDataSource();
        }

        /// <summary>
        /// Handles the CustomColumnDisplayText event of the khoModelGridView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs"/> instance containing the event data.</param>
        private void khoModelGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "")
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        /// <summary>
        /// Handles the Click event of the saveKhoSimpleButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void saveKhoSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.Save();
            presenter.Display();
        }
        /// <summary>
        /// Handles the Click event of the editKhoSimpleButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void editKhoSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (khoModelBindingSource.Count == 0)
                {
                    return;
                }
                using (var f = new KhoDetailForm(KhoCurrent as KhoModel))
                {
                    if (f.ShowDialog(this) == DialogResult.Cancel)
                    {
                        this.RefreshData();
                    }
                }

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

        /// <summary>
        /// Handles the Click event of the addKhoSimpleButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void addKhoSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var currentStream = new MemoryStream())
                {
                    khoModelGridView.SaveLayoutToStream(currentStream);
                    currentStream.Seek(0, System.IO.SeekOrigin.Begin);

                    khoModelGridView.RestoreLayoutFromStream(memStream);
                    memStream.Seek(0, System.IO.SeekOrigin.Begin);

                    if (presenter.Addnew())
                    {
                        khoModelGridView.MoveLast();
                        using (var f = new KhoDetailForm(KhoCurrent as KhoModel))
                        {
                            if (f.ShowDialog(this) == DialogResult.Cancel)
                            {
                                presenter.Delete();
                            }
                        }
                    }

                    khoModelGridView.RestoreLayoutFromStream(currentStream);
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
        /// Handles the Click event of the exportKhoSimpleButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void exportKhoSimpleButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the deleteKhoSimpleButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void deleteKhoSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (khoModelBindingSource.Count == 0)
                {
                    return;
                }
                presenter.Delete();
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
    }
}