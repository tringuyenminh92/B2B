// ***********************************************************************
// Assembly         : B2B.Forms
// Author           : Ga9286
// Created          : 30-08-2014
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
using B2B.Presenter;
using log4net;
using B2B.Model;
using System.IO;

/// <summary>
/// The Forms namespace.
/// </summary>
namespace B2B.Forms
{
    /// <summary>
    /// Class NhanvienForm.
    /// </summary>
    public partial class NhanvienForm : DevExpress.XtraEditors.XtraForm, INhanvienView
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
        NhanvienPresenter presenter;

        /// <summary>
        /// The memory stream
        /// </summary>
        MemoryStream memStream;
        /// <summary>
        /// Initializes a new instance of the <see cref="NhanvienForm"/> class.
        /// </summary>
        public NhanvienForm()
        {
            InitializeComponent();

            memStream = new MemoryStream();
            nhanvienModelGridView.SaveLayoutToStream(memStream);
            memStream.Seek(0, System.IO.SeekOrigin.Begin);

            presenter = new NhanvienPresenter(this);
            presenter.DisplayPhongban();
            presenter.DisplayNhanvienTheoPhongban();
        }
        /// <summary>
        /// Gets or sets the nhanvien items.
        /// </summary>
        /// <value>The nhanvien items.</value>
        public List<NhanvienModel> NhanvienItems
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

        /// <summary>
        /// Gets the nhanvien current.
        /// </summary>
        /// <value>The nhanvien current.</value>
        public NhanvienModel NhanvienCurrent
        {
            get { return nhanvienModelBindingSource.Current as NhanvienModel; }
        }

        /// <summary>
        /// Refreshes the data.
        /// </summary>
        public void RefreshData()
        {
            nhanvienModelGridControl.RefreshDataSource();
        }


        /// <summary>
        /// Handles the CustomColumnDisplayText event of the nhomNhanvienModelGridView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs"/> instance containing the event data.</param>
        private void nhomNhanvienModelGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "")
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
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
        /// Gets the phongban current identifier.
        /// </summary>
        /// <value>The phongban current identifier.</value>
        public Guid? PhongbanCurrentId
        {
            get { return phongbanIdTextEdit.EditValue as Guid?; }
        }

        /// <summary>
        /// Refreshes the data phongban.
        /// </summary>
        public void RefreshDataPhongban()
        {
            phongbanIdTextEdit.RefreshEditValue();
        }

        /// <summary>
        /// Handles the 1 event of the nhomNhanvienModelGridView_CustomColumnDisplayText control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs"/> instance containing the event data.</param>
        private void nhomNhanvienModelGridView_CustomColumnDisplayText_1(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "")
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        /// <summary>
        /// Handles the EditValueChanged event of the phongbanIdTextEdit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void phongbanIdTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            presenter.DisplayNhanvienTheoPhongban();
        }

        /// <summary>
        /// Handles the Click event of the addNhanvienSimpleButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void addNhanvienSimpleButton_Click(object sender, EventArgs e)
        {
            //try
            //{
                using (var currentStream = new MemoryStream())
                {
                    nhanvienModelGridView.SaveLayoutToStream(currentStream);
                    currentStream.Seek(0, System.IO.SeekOrigin.Begin);

                    nhanvienModelGridView.RestoreLayoutFromStream(memStream);
                    memStream.Seek(0, System.IO.SeekOrigin.Begin);

                    if (presenter.Addnew())
                    {
                        nhanvienModelGridView.MoveLast();
                        using (var f = new NhanvienDetailForm(NhanvienCurrent as NhanvienModel))
                        {
                           
                            if (f.ShowDialog(this) == DialogResult.Cancel)
                            {
                                presenter.Delete();
                            }
                        }
                    }

                    nhanvienModelGridView.RestoreLayoutFromStream(currentStream);
                    currentStream.Seek(0, System.IO.SeekOrigin.Begin);
                }
            //}
            //catch (System.Exception ex)
            //{
            //    //Check log flag and log error to file.
            //    if (isErrorEnabled)
            //    {
            //        logger.Error("", ex);
            //    }
            //    return;
            //}
        }

        /// <summary>
        /// Handles the Click event of the editNhanvienSimpleButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void editNhanvienSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (nhanvienModelBindingSource.Count == 0)
                {
                    return;
                }
                using (var f = new NhanvienDetailForm(NhanvienCurrent as NhanvienModel))
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
                    logger.Error(string.Format("{0}", NhanvienCurrent.NhanvienId), ex);
                }
                return;
            }
        }

        /// <summary>
        /// Handles the Click event of the saveNhanvienSimpleButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void saveNhanvienSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.Save();
        }

        /// <summary>
        /// Handles the Click event of the deleteNhanvienSimpleButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void deleteNhanvienSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.Delete();
        }

        /// <summary>
        /// Handles the Click event of the reloadNhanvienSimpleButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void reloadNhanvienSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.DisplayNhanvienTheoPhongban();
        }

        /// <summary>
        /// Handles the CurrentItemChanged event of the nhanvienModelBindingSource control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void nhanvienModelBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(NhanvienCurrent.Linkanh))
                {
                    AnhMyPictureEdit.Image = Image.FromFile(NhanvienCurrent.Linkanh);
                }
                else
                {
                    AnhMyPictureEdit.Image = null;
                }
            }
            catch (System.Exception ex)
            {
                if (isErrorEnabled)
                {
                    logger.Error("Link hinh anh sai.", ex);
                }
                AnhMyPictureEdit.Image = null;
            }
        }

    }
}