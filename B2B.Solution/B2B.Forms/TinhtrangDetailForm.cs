// ***********************************************************************
// Assembly         : B2B.Forms
// Author           : Ga9286
// Created          : 04-11-2014
//
// Last Modified By : Ga9286
// Last Modified On : 04-11-2014
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using log4net;
using B2B.Presenter;
using B2B.Model;
using B2B.View;

namespace B2B.Forms
{
    /// <summary>
    /// Class TinhtrangDetailForm.
    /// </summary>
    public partial class TinhtrangDetailForm : DevExpress.XtraEditors.XtraForm, ITinhtrangDetailView
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        private TinhtrangDetailPresenter presenter;

        /// <summary>
        /// Initializes a new instance of the <see cref="TinhtrangDetailForm"/> class.
        /// </summary>
        public TinhtrangDetailForm()
        {
            InitializeComponent();
            presenter = new TinhtrangDetailPresenter(this);
            presenter.DisplayLoaiTinhtrang();
        }

        public TinhtrangDetailForm(TinhtrangModel value)
            : this()
        {
            Value = value;
            tinhtrangModelBindingSource.DataSource = value;
        }

        public List<LoaiTinhtrangModel> LoaiTinhtrangItems
        {
            get { return loaiTinhtrangModelBindingSource.DataSource as List<LoaiTinhtrangModel>; }
            set { loaiTinhtrangModelBindingSource.DataSource = value; }
        }

        private TinhtrangModel _value;

        public TinhtrangModel Value
        {
            get { return _value; }
            set { _value = value; }
        }
        public void RefreshData()
        {
        }

        private void OkSimpleButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelSimpleButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void TinhtrangDetailForm_KeyUp(object sender, KeyEventArgs e)
        {
            tinhtrangModelBindingSource.EndEdit();
        }
    }
}