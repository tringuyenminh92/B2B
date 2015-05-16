/***********************************
Author: Lý Hoàng Tín 
Date Created: 13/01/2015
Last Updated: 16/01/2015
Updated By: Lý Hoàng Tín
Update description: 
************************************/

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using B2B.Model;
using B2B.Presenter;
using B2B.View;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using log4net;
using System.Windows.Forms;

namespace B2B.Forms
{
    public partial class KiemkeForm : XtraForm, IKiemkeView
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;
        private readonly MemoryStream memStream;
        private readonly KiemkePresenter presenter;

        public KiemkeForm()
        {
            InitializeComponent();
            presenter = new KiemkePresenter(this);
            memStream = new MemoryStream();
            kiemkeModelGridView.SaveLayoutToStream(memStream);
            memStream.Seek(0, SeekOrigin.Begin);
            presenter.DisplayKho();
            presenter.DisplayKiemkeTheoKho();
            //presenter.DisplayNhanvienCapnhat();
            presenter.DisplayHanghoaTheoKho();
            presenter.DisplayChitietKiemke();
            //presenter.DisplaySoluongton();
        }

        public void RefreshKiemke()
        {
            kiemkeModelGridControl.RefreshDataSource();
        }

        public List<KiemkeModel> KiemkeItems
        {
            get { return kiemkeModelBindingSource.DataSource as List<KiemkeModel>; }
            set
            {
                kiemkeModelBindingSource.DataSource = value;
            }
        }

        public KiemkeModel KiemkeCurrent
        {
            get
            {

                return kiemkeModelBindingSource.Current as KiemkeModel;
            }
        }

        public List<ChitietKiemkeModel> ChitietKiemkeItems
        {
            get { return chitietKiemkeModelBindingSource.DataSource as List<ChitietKiemkeModel>; }
            set { chitietKiemkeModelBindingSource.DataSource = value; }
        }

        public ChitietKiemkeModel ChitietKiemkeCurrent
        {
            get { return chitietKiemkeModelBindingSource.Current as ChitietKiemkeModel; }
        }

        public List<HanghoaModel> HanghoaItems
        {
            get { return hanghoaModelBindingSource.DataSource as List<HanghoaModel>; }
            set { hanghoaModelBindingSource.DataSource = value; }
        }

        public void RefreshHanghoa()
        {
            //throw new NotImplementedException();
        }

        public Guid? KhoCurrentId
        {
            get { return khoTextEdit.SelectedValue as Guid?; }
        }

        public Guid? HanghoaCurrentId
        {
            get { return hanghoaTextEdit.SelectedValue as Guid?; }
        }

        public void RefreshChitietKiemke()
        {
            chitietKiemkeModelGridControl.RefreshDataSource();
        }

        public void RefreshData()
        {
            //throw new NotImplementedException();
        }

        public List<KhoModel> Khoitems
        {
            get { return khoModelBindingSource.DataSource as List<KhoModel>; }
            set { khoModelBindingSource.DataSource = value; }
        }

        public void RefreshKho()
        {
            //throw new NotImplementedException();
        }

        private void deletePhieunhapSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.Delete();
        }

        private void exportKiemkeSimpleButton_Click(object sender, EventArgs e)
        {
        }

        private void addKiemkeSimpleButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            using (var currentStream = new MemoryStream())
            {
                kiemkeModelGridView.SaveLayoutToStream(currentStream);
                currentStream.Seek(0, SeekOrigin.Begin);
                kiemkeModelGridView.RestoreLayoutFromStream(memStream);
                memStream.Seek(0, SeekOrigin.Begin);
                if (presenter.Addnew())
                {
                    kiemkeModelGridView.MoveLast();
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

        private void addChitietKiemkeSimpleButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            if (presenter.AddnewDetail())
            {
                chitietKiemkeModelGridView.MoveLast();
            }
            //}
            //catch (Exception ex)
            //{
            //    //Check log flag and log error to file.
            //    if (isErrorEnabled)
            //    {
            //        logger.Error(string.Format("Result Presenter.AddnewDetail(): {0}", ""), ex);
            //    }
            //}
        }

        private void deleteChitietKiemkeSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.DeleteDetail();
        }


        private void khoModelBindingSource_PositionChanged(object sender, EventArgs e)
        {
            presenter.DisplayHanghoaTheoKho();
            presenter.DisplayKiemkeTheoKho();
        }

        private void kiemkeModelBindingSource_PositionChanged(object sender, EventArgs e)
        {
            presenter.DisplayChitietKiemke();
        }


        private void saveKiemkeSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.Save();
        }

        private void kiemkeModelGridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "")
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void chitietKiemkeModelGridView_CustomColumnDisplayText(object sender,
            CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "")
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void InformationGroupControl_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void saveKiemkeSimpleButton_Click_1(object sender, EventArgs e)
        {
            if (presenter.Save())
            {
                XtraMessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Lưu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //bien tam
    }
}