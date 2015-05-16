/***********************************
Author: Lý Hoàng Tín 
Date Created: 13/01/2015
Last Updated: 16/01/2015
Updated By: Lý Hoàng Tín
Update description: 
************************************/

using System.Collections.Generic;
using System.Reflection;
using B2B.Model;
using B2B.Presenter;
using B2B.View;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using log4net;

namespace B2B.Forms
{
    public partial class CongnoNhapForm : XtraForm, ICongnoNhapView
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;
        private CongnoNhapPresenter presenter;

        public CongnoNhapForm()
        {
            InitializeComponent();
            presenter = new CongnoNhapPresenter(this);
            presenter.DisplayCongnoNhap();
        }

        public List<CongnoNhapModel> CongnoNhapItems
        {
            get { return congnoNhapModelBindingSource.DataSource as List<CongnoNhapModel>; }
            set { congnoNhapModelBindingSource.DataSource = value; }
        }

        public void RefreshData()
        {
            congnoNhapModelGridControl.RefreshDataSource();
        }

        private void congnoNhapModelGridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "")
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
    }
}