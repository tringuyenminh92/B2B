// ***********************************************************************
// Assembly         : B2B.Forms
// Author           : Ga9286
// Created          : 08-11-2014
//
// Last Modified By : Ga9286
// Last Modified On : 08-11-2014
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
using log4net;
using System.IO;
using B2B.Presenter;
using B2B.View;
using B2B.Model;

/// <summary>
/// The Forms namespace.
/// </summary>
namespace B2B.Forms
{
    /// <summary>
    /// Class NguyennhanForm.
    /// </summary>
    public partial class NguyennhanForm : DevExpress.XtraEditors.XtraForm, INguyennhanView
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        private MemoryStream memStream;

        private NguyennhanPresenter presenter;

        /// <summary>
        /// Initializes a new instance of the <see cref="NguyennhanForm"/> class.
        /// </summary>
        public NguyennhanForm()
        {
            InitializeComponent();

            memStream = new MemoryStream();
            nguyennhanLydoModelGridView.SaveLayoutToStream(memStream);
            memStream.Seek(0, SeekOrigin.Begin);

            presenter = new NguyennhanPresenter(this);
            presenter.DisplayLoaiNguyennhan();
            presenter.DisplayNguyenhanTheoLoai();
        }

        /// <summary>
        /// Handles the CustomColumnDisplayText event of the nguyennhanLydoModelGridView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs"/> instance containing the event data.</param>
        private void nguyennhanLydoModelGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "")
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        /// <summary>
        /// Handles the Click event of the saveNguyennhanSimpleButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void saveNguyennhanSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.Save();
            presenter.DisplayNguyenhanTheoLoai();
        }

        /// <summary>
        /// Handles the Click event of the editNguyennhanSimpleButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void editNguyennhanSimpleButton_Click(object sender, EventArgs e)
        {
            if (nguyennhanLydoModelBindingSource.Count == 0)
            {
                return;
            }

            using (var f = new NguyennhanDetailForm(NguyennhanCurrent as NguyennhanLydoModel))
            {
                if (f.ShowDialog(this) == DialogResult.Cancel)
                {
                    presenter.DisplayNguyenhanTheoLoai();
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the addNguyennhanSimpleButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void addNguyennhanSimpleButton_Click(object sender, EventArgs e)
        {
            using (var currentStream = new MemoryStream())
            {
                nguyennhanLydoModelGridView.SaveLayoutToStream(currentStream);
                currentStream.Seek(0, SeekOrigin.Begin);

                nguyennhanLydoModelGridView.RestoreLayoutFromStream(memStream);
                memStream.Seek(0, SeekOrigin.Begin);

                if (presenter.Addnew())
                {
                    nguyennhanLydoModelGridView.MoveLast();
                    using (var f = new NguyennhanDetailForm(NguyennhanCurrent as NguyennhanLydoModel))
                    {
                        if (f.ShowDialog(this) == DialogResult.Cancel)
                        {
                            presenter.Delete();
                        }
                    }
                }

                nguyennhanLydoModelGridView.RestoreLayoutFromStream(currentStream);
                currentStream.Seek(0, SeekOrigin.Begin);
            }
        }

        /// <summary>
        /// Handles the Click event of the deleteNguyennhanSimpleButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void deleteNguyennhanSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.Delete();
        }

        public List<NguyennhanLydoModel> NguyennhanItems
        {
            get { return nguyennhanLydoModelBindingSource.DataSource as List<NguyennhanLydoModel>; }
            set { nguyennhanLydoModelBindingSource.DataSource = value; }
        }

        public NguyennhanLydoModel NguyennhanCurrent
        {
            get { return nguyennhanLydoModelBindingSource.Current as NguyennhanLydoModel; }
        }

        public List<LoaiNguyennhanModel> LoaiNguyennhanItems
        {
            get { return loaiNguyennhanModelBindingSource.DataSource as List<LoaiNguyennhanModel>; }
            set { loaiNguyennhanModelBindingSource.DataSource = value; }
        }

        public int? LoaiNguyennhanCurrentValue
        {
            get { return LoaiNguennhanComboBox.SelectedValue as int?; }
        }

        public void RefreshData()
        {
            nguyennhanLydoModelGridControl.RefreshDataSource();
        }

        private void loaiNguyennhanModelBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            presenter.DisplayNguyenhanTheoLoai();
        }
    }
}