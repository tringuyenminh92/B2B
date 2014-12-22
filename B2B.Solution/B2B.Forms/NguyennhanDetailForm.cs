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
using B2B.View;
using B2B.Model;
using log4net;
using B2B.Presenter;

/// <summary>
/// The Forms namespace.
/// </summary>
namespace B2B.Forms
{
    /// <summary>
    /// Class NguyennhanDetailForm.
    /// </summary>
    public partial class NguyennhanDetailForm : DevExpress.XtraEditors.XtraForm, INguyennhanDetailView
    {

        private NguyennhanDetailPresenter presenter;

        /// <summary>
        /// Initializes a new instance of the <see cref="NguyennhanDetailForm"/> class.
        /// </summary>
        public NguyennhanDetailForm()
        {
            InitializeComponent();
            presenter = new NguyennhanDetailPresenter(this);
            presenter.DisplayLoaiNguyennhan();
        }

        public NguyennhanDetailForm(NguyennhanLydoModel value)
            : this()
        {
            Value = Value;
            nguyennhanLydoModelBindingSource.DataSource = value;
        }
        /// <summary>
        /// Handles the Click event of the CancelSimpleButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CancelSimpleButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the OkSimpleButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OkSimpleButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Gets or sets the loai nguyennhan items.
        /// </summary>
        /// <value>The loai nguyennhan items.</value>
        public List<LoaiNguyennhanModel> LoaiNguyennhanItems
        {
            get { return loaiNguyennhanModelBindingSource.DataSource as List<LoaiNguyennhanModel>; }
            set { loaiNguyennhanModelBindingSource.DataSource = value; }
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        public NguyennhanLydoModel Value { get; set; }

        /// <summary>
        /// Refreshes the data.
        /// </summary>
        public void RefreshData()
        {
        }

        private void NguyennhanDetailForm_KeyUp(object sender, KeyEventArgs e)
        {
            nguyennhanLydoModelBindingSource.EndEdit();
        }
    }
}