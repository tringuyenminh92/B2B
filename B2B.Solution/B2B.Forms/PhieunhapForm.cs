/***********************************
Author: Lý Hoàng Tín
Date Created: 15/09/2014
Last Updated: 16/09/2014
Updated By: Lý Hoàng Tín
Update description: 
************************************/

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using B2B.Model;
using B2B.Presenter;
using B2B.View;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using log4net;

namespace B2B.Forms
{
    public partial class PhieunhapForm : XtraForm, IPhieunhapView
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;
        private readonly MemoryStream memStream;
        private readonly PhieunhapPresenter presenter;

        public PhieunhapForm()
        {
            InitializeComponent();
            presenter = new PhieunhapPresenter(this);
            memStream = new MemoryStream();
            phieunhapModelGridView.SaveLayoutToStream(memStream);
            memStream.Seek(0, SeekOrigin.Begin);
            thangNamDateEdit.DateTime = DateTime.Now;
            //presenter.DisplayKho();
            //presenter.DisplayNhacungcap();
            presenter.DisplayPhieunhap();
            presenter.DisplayNhanvienCapnhat();
        }

        //public Guid? KhoCurrentId
        //{
        //    get { return khoIdTextEdit.SelectedValue as Guid?; }
        //}

        public List<PhieunhapModel> PhieunhapItems
        {
            get { return phieunhapModelBindingSource.DataSource as List<PhieunhapModel>; }
            set { phieunhapModelBindingSource.DataSource = value;}
        }


        public void RefreshDataNhacungcap()
        {
            //nhacungcapIdTextEdit.RefreshEditValue();
            
        }

        public void RefreshDataKho()
        {
            //khoIdTextEdit.RefreshEditValue();
        }

        public PhieunhapModel PhieunhapCurrent
        {
            get { return phieunhapModelBindingSource.Current as PhieunhapModel; }
        }

        public DateTime filterValue
        {
            get { return thangNamDateEdit.DateTime; }
            set { thangNamDateEdit.DateTime = value; }
        }

        public void RefreshData()
        {
           phieunhapModelGridControl.RefreshDataSource();
        }

        private void addPhieunhapSimpleButton_Click(object sender, EventArgs e)
        {
            //try
            //{
                using (var currentStream = new MemoryStream())
                {
                    phieunhapModelGridView.SaveLayoutToStream(currentStream);
                    currentStream.Seek(0, SeekOrigin.Begin);
                    phieunhapModelGridView.RestoreLayoutFromStream(memStream);
                    memStream.Seek(0, SeekOrigin.Begin);
                    if (presenter.AddNew())
                    {
                        phieunhapModelGridView.MoveLast();
                        using (var f = new PhieunhapDetailForm(PhieunhapCurrent))
                        {
                            if (f.ShowDialog(this) == DialogResult.Cancel)
                            {
                                presenter.Delete();
                            }
                        }
                    }
                }
            //}
            //catch (Exception ex)
            //{
            //    //Check log flag and log error to file.
            //    if (isErrorEnabled)
            //    {
            //        logger.Error(string.Format("Result Presenter.Addnew(): {0}", ""), ex);
            //    }
            //}
        }

        private void deletePhieunhapSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.Delete();
        }

        private void exportPhieunhapSimpleButton_Click(object sender, EventArgs e)
        {
        }

        private void editPhieunhapSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
            
                using (var f = new PhieunhapDetailForm(PhieunhapCurrent))
                {
                    if (f.ShowDialog(this) == DialogResult.Cancel)
                    {
                        presenter.Delete();
                    }
                }
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error(string.Format("Result: {0}", ""), ex);
                }
            }

        }

        private void savePhieunhapSimpleButton_Click(object sender, EventArgs e)
        {
            if (presenter.Save())
            {
                XtraMessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Lưu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            presenter.DisplayPhieunhap();
        }

        private void reloaPhieunhapSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.DisplayPhieunhap();
        }


        NhanvienModel IPhieunhapView.NhanvienCapnhat
        {
            get
            {
                return nhanvienModelBindingSource[0] as NhanvienModel;
            }
            set
            {
                nhanvienModelBindingSource.DataSource = value;
                tenNhanvienTextEdit1.EditValue = value.NhanvienId;
                tenNhanvienTextEdit1.Text = value.HovatenNhanvien;
            }
        }

        private void phieunhapModelGridView_CustomColumnDisplayText_1(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "")
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
    }
}