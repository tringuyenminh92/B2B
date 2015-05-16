/********************************************************************
	Class file: 
    Author: Tran Nguyen Hoang Khuyen
    Date Created: 22/12/2014
	Last Updated: 08/01/2014
	Updated By: Tran Nguyen Hoang Khuyen
	Update Description:
*********************************************************************/
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


namespace B2B.Forms
{
    public partial class CongnoXuatForm : DevExpress.XtraEditors.XtraForm, ICongnoXuatView
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        CongnoXuatPresenter presenter;

        public CongnoXuatForm()
        {
            InitializeComponent();
            presenter = new CongnoXuatPresenter(this);
            presenter.DisplayCongnoXuat();
        }

        public List<CongnoXuatModel> CongnoXuatItems
        {
            get
            {
                return congnoXuatModelBindingSource.DataSource as List<CongnoXuatModel>;
            }
            set
            {
                congnoXuatModelBindingSource.DataSource = value;
            }
        }

        public void RefreshData()
        {
        }

        private void congnoXuatModelBandedGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "")
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
    }
}