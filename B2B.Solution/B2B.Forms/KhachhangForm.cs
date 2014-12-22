/********************************************************************
	Class file: 
    Author: Nguyen Minh Tri
    Date Created: 14/09/2014
	Last Updated: 18/09/2014
	Updated By: Nguyen Minh Tri
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
using log4net;
using B2B.Presenter;
using System.IO;

namespace B2B.Forms
{
    public partial class KhachhangForm : DevExpress.XtraEditors.XtraForm, IKhachhangView
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        KhachhangPresenter presenter;

        MemoryStream memStream;
        public KhachhangForm()
        {
            InitializeComponent();

            memStream = new MemoryStream();
            khachhangModelGridView.SaveLayoutToStream(memStream);
            memStream.Seek(0, System.IO.SeekOrigin.Begin);

            presenter = new KhachhangPresenter(this);
            presenter.DisplayNhomKhachhang();
            presenter.DisplayKhachhangTheoNhom();
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

        public List<NhomKhachhangModel> NhomKhachhangItems
        {
            get
            {
                return nhomKhachhangModelBindingSource.DataSource as List<NhomKhachhangModel>;
            }
            set
            {
                nhomKhachhangModelBindingSource.DataSource = value;
            }
        }

        public Guid? NhomKhachhangCurrentId
        {
            get { return nhomKhachhangIdTextEdit.EditValue as Guid? ; }
        }

        public void RefreshDataNhomKhachhang()
        {
            //    nhomKhachhangModelGridControl.RefreshDataSource();
        }

        public void RefreshData()
        {
            khachhangModelGridControl.RefreshDataSource();
        }

        private void reloadKhachhangSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.DisplayKhachhangTheoNhom();
        }

        private void saveKhachhangSimpleButton_Click(object sender, EventArgs e)
        {
            if (presenter.Save())
            {
                XtraMessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Lưu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            presenter.DisplayKhachhangTheoNhom();
        }

        private void editKhachhangSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (khachhangModelBindingSource.Count == 0)
                {
                    return;
                }

                using (var f = new KhachhangDetailForm(KhachhangCurrent as KhachhangModel))
                {
                    khachhangModelGridView.MoveLast();
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
                    logger.Error("Edit", ex);
                }
                return;
            }
        }

        private void addKhachhangSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (nhomKhachhangModelBindingSource.Count == 0)
                {
                    return;
                }

                using (var currentStream = new MemoryStream())
                {
                    khachhangModelGridView.SaveLayoutToStream(currentStream);
                    currentStream.Seek(0, System.IO.SeekOrigin.Begin);

                    khachhangModelGridView.RestoreLayoutFromStream(memStream);
                    memStream.Seek(0, System.IO.SeekOrigin.Begin);


                    if (presenter.Addnew())
                    {
                        khachhangModelGridView.MoveLast();
                        using (var f = new KhachhangDetailForm(KhachhangCurrent as KhachhangModel))
                        {
                            if (f.ShowDialog(this) == DialogResult.Cancel)
                            {
                                presenter.Delete();
                            }
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Chưa chọn Nhóm Khách hàng hay Nhóm khách hàng chưa được Active !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    khachhangModelGridView.RestoreLayoutFromStream(currentStream);
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

        private void exportKhachhangSimpleButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteKhachhangSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.Delete();
        }

        private void khachhangModelGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "")
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void nhomKhachhangIdTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            presenter.DisplayKhachhangTheoNhom();
        }

        private void nhomKhachhangModelGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "")
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

    }
}