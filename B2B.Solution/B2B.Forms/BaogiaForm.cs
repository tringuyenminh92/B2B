/********************************************************************
	Class file: 
    Author: Tran Nguyen Hoang Khuyen
    Date Created: 28/09/2014
	Last Updated: 28/09/2014
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
using log4net;
using B2B.Presenter;
using B2B.Model;

namespace B2B.Forms
{
    public partial class BaogiaForm : DevExpress.XtraEditors.XtraForm, IBaogiaView
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        BaogiaPresenter presenter;

        public BaogiaForm()
        {
            InitializeComponent();

            presenter = new BaogiaPresenter(this);
            presenter.DisplayKhachhang();
            presenter.DisplayBaogiaTheoNhomKhachhang();
        }

        public List<HanghoaModel> BaogiaItems
        {
            get
            {
                return hanghoaModelBindingSource.DataSource as List<HanghoaModel>;
            }
            set
            {
                hanghoaModelBindingSource.DataSource = value;
            }
        }

        public List<KhachhangModel> KhachhangItems
        {
            get
            {
                return khachhangModelBindingSource.DataSource as List<KhachhangModel>;
            }
            set
            {
                khachhangModelBindingSource.DataSource = value;
            }
        }

        public KhachhangModel KhachhangCurrent
        {
            get { return khachhangModelBindingSource.Current as KhachhangModel; }
        }

        public void RefreshDataKhachhang()
        {
            khachhangModelGridControl.RefreshDataSource();
        }

        public void RefreshData()
        {
            hanghoaModelGridControl.RefreshDataSource();
        }

        private void baogiaModelGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "")
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void khachhangModelBindingSource_PositionChanged(object sender, EventArgs e)
        {
            presenter.DisplayBaogiaTheoNhomKhachhang();
        }
    }
}