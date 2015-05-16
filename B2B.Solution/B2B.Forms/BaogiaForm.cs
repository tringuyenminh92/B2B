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

        private void exportBaogiaSimpleButton_Click(object sender, EventArgs e)
        {
            exportFile("*.xlsx");
        }
        void exportFile(string fType)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog
                {
                    CheckPathExists = true,
                    InitialDirectory = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments),
                    OverwritePrompt = true,
                    Title = "Xuất dữ liệu thành tập tin định dạng " + fType,
                    Filter = fType + "|" + fType
                };
                DialogResult dr = sfd.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK || dr == System.Windows.Forms.DialogResult.Yes)
                {
                    hanghoaModelBindingSource.DataSource = (hanghoaModelBindingSource.DataSource as List<HanghoaModel>).Where(p=>p.ChonBaogia==true);
                    hanghoaModelGridControl.RefreshDataSource();
                    switch (fType)
                    {
                        case "*.html":
                            hanghoaModelGridControl.ExportToHtml(sfd.FileName);
                            break;
                        case "*.pdf":
                            hanghoaModelGridControl.ExportToPdf(sfd.FileName);
                            break;
                        case "*.txt":
                            hanghoaModelGridControl.ExportToText(sfd.FileName);
                            break;
                        case "*.xls":
                            hanghoaModelGridControl.ExportToXls(sfd.FileName);
                            break;
                        case "*.xlsx":
                            hanghoaModelGridControl.ExportToXlsx(sfd.FileName);
                            break;
                        case "*.rtf":
                            hanghoaModelGridControl.ExportToRtf(sfd.FileName);
                            break;
                        default:
                            break;
                    }
                    //
                    presenter.DisplayBaogiaTheoNhomKhachhang();
                    
                    dr = MessageBox.Show("Xuất dữ liệu thành công! Bạn có muốn mở tập tin vừa xuất ra không?", "Xác nhận mở tập tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (dr == System.Windows.Forms.DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(sfd.FileName);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Lỗi xuất dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}