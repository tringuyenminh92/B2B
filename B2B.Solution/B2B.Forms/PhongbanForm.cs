// ***********************************************************************
// Assembly         : B2B.Forms
// Author           : Ga9286
// Created          : 20-09-2014
//
// Last Modified By : Ga9286
// Last Modified On : 10-11-2014
// ***********************************************************************
/********************************************************************
	Class file: 
    Author: Nguyen Minh Tri
    Date Created: 20/09/2014
	Last Updated: 20/09/2014
	Updated By: Nguyen Minh Tri
	Update Description: 
*********************************************************************/

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using log4net;
using B2B.Presenter;
using B2B.View;
using B2B.Model;
using System.IO;

/// <summary>
/// The Forms namespace.
/// </summary>
namespace B2B.Forms
{
    /// <summary>
    /// Class PhongbanForm.
    /// </summary>
    public partial class PhongbanForm : DevExpress.XtraEditors.XtraForm, IPhongbanView
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
        PhongbanPresenter presenter;

        /// <summary>
        /// The memory stream
        /// </summary>
        MemoryStream memStream;
        /// <summary>
        /// Initializes a new instance of the <see cref="PhongbanForm"/> class.
        /// </summary>
        public PhongbanForm()
        {
            InitializeComponent();

            memStream = new MemoryStream();
            phongbanModelGridView.SaveLayoutToStream(memStream);
            memStream.Seek(0, System.IO.SeekOrigin.Begin);

            presenter = new PhongbanPresenter(this);
            presenter.Display();
        }

        /// <summary>
        /// Handles the CustomColumnDisplayText event of the phongbanModelGridView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs"/> instance containing the event data.</param>
        private void phongbanModelGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "")
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        /// <summary>
        /// Handles the Click event of the savePhongbanSimpleButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void savePhongbanSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.Save();
            presenter.Display();
        }

        /// <summary>
        /// Handles the Click event of the editPhongbanSimpleButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void editPhongbanSimpleButton_Click(object sender, EventArgs e)
        {
            if (phongbanModelBindingSource.Count == 0)
            {
                return;
            }

            using (var f = new PhongbanDetailForm(PhongbanCurrent as PhongbanModel))
            {
                if (f.ShowDialog(this) == DialogResult.Cancel)
                {
                    presenter.Display();
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the addPhongbanSimpleButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void addPhongbanSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var currentStream = new MemoryStream())
                {
                    phongbanModelGridView.SaveLayoutToStream(currentStream);
                    currentStream.Seek(0, System.IO.SeekOrigin.Begin);

                    phongbanModelGridView.RestoreLayoutFromStream(memStream);
                    memStream.Seek(0, System.IO.SeekOrigin.Begin);

                    if (presenter.Addnew())
                    {
                        phongbanModelGridView.MoveLast();
                        using (var f = new PhongbanDetailForm(PhongbanCurrent as PhongbanModel))
                        {
                            if (f.ShowDialog(this) == DialogResult.Cancel)
                            {
                                presenter.Delete();
                            }
                        }
                    }

                    phongbanModelGridView.RestoreLayoutFromStream(currentStream);
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
        /// Handles the Click event of the exportPhongbanSimpleButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void exportPhongbanSimpleButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the deletePhongbanSimpleButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void deletePhongbanSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.Delete();
        }

        /// <summary>
        /// Gets or sets the phongban items.
        /// </summary>
        /// <value>The phongban items.</value>
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

        /// <summary>
        /// Gets the phongban current.
        /// </summary>
        /// <value>The phongban current.</value>
        public PhongbanModel PhongbanCurrent
        {
            get { return phongbanModelBindingSource.Current as PhongbanModel; }
        }

        /// <summary>
        /// Refreshes the data.
        /// </summary>
        public void RefreshData()
        {
            phongbanModelGridControl.RefreshDataSource();
        }
    }
}