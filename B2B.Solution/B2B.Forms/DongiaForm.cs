// ***********************************************************************
// Assembly         : B2B.Forms
// Author           : Lý Hoàng Tín
// Created          : 27-10-2014
//
// Last Modified By : Lý Hoàng Tín
// Last Modified On : 19-11-2014
// ***********************************************************************
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
    public partial class DongiaForm : XtraForm, IDongiaView
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;
        private readonly MemoryStream memStream;
        private readonly DongiaPresenter presenter;

        public DongiaForm()
        {
            InitializeComponent();
            presenter = new DongiaPresenter(this);
            memStream = new MemoryStream();
            dongiaModelGridView.SaveLayoutToStream(memStream);
            memStream.Seek(0, SeekOrigin.Begin);
            presenter.DisplayNhomKhachhang();
            presenter.DisplayHanghoa();
            presenter.DisplayDongiaTheoNhomKhachhang();
            //presenter.Display();
        }

        public List<DongiaModel> DongiaItems
        {
            get { return dongiaModelBindingSource.DataSource as List<DongiaModel>; }
            set { dongiaModelBindingSource.DataSource = value; }
        }

        public DongiaModel DongiaCurrent
        {
            get { return dongiaModelBindingSource.Current as DongiaModel; }
        }

        public List<NhomKhachhangModel> NhomKhachhangItems
        {
            get { return nhomKhachhangModelBindingSource.DataSource as List<NhomKhachhangModel>; }
            set { nhomKhachhangModelBindingSource.DataSource = value; }
        }

        public NhomKhachhangModel NhomKhachhangCurrent
        {
            get { return nhomKhachhangModelBindingSource.Current as NhomKhachhangModel; }
        }

        public List<HanghoaModel> HanghoaItems
        {
            get { return hanghoaModelBindingSource.DataSource as List<HanghoaModel>; }
            set { hanghoaModelBindingSource.DataSource = value; }
        }

        public HanghoaModel HangHoaCurrent
        {
            get { return hanghoaModelBindingSource.Current as HanghoaModel; }
        }

        public void RefreshDataNhomKhachhang()
        {
            nhomKhachhangModelBindingSource.ResetBindings(true);
        }

        public void RefreshDataHanghoa()
        {
            hanghoaModelBindingSource.ResetBindings(true);
        }

        public void RefreshData()
        {
            dongiaModelGridControl.RefreshDataSource();
        }

        Guid? IDongiaView.NhomKhachhangCurrentId
        {
            get { return nhomKhachhangIdTextEdit.SelectedValue as Guid?; }
            set { throw new NotImplementedException(); }
        }

        public Guid? HanghoaCurrentId
        {
            get { return hanghoaIdTextEdit.SelectedValue as Guid?; }
        }

        private void deletetDongiaSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dongiaModelBindingSource.Count == 0)
                {
                    return;
                }
                presenter.Delete();
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("None", ex);
                }
            }
        }

        private void exporttDongiaSimpleButton_Click(object sender, EventArgs e)
        {
        }

        private void addtDongiaSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var currentStream = new MemoryStream())
                {
                    dongiaModelGridView.SaveLayoutToStream(currentStream);
                    currentStream.Seek(0, SeekOrigin.Begin);
                    dongiaModelGridView.RestoreLayoutFromStream(memStream);
                    memStream.Seek(0, SeekOrigin.Begin);
                    if (presenter.Addnew())
                    {
                        dongiaModelGridView.MoveLast();
                        using (var f = new DongiaDetailForm(DongiaCurrent))
                        {
                            if (f.ShowDialog(this) == DialogResult.Cancel)
                            {
                                presenter.Delete();
                            }
                        }
                    }
                    dongiaModelGridView.RestoreLayoutFromStream(currentStream);
                    currentStream.Seek(0, SeekOrigin.Begin);
                }
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error(string.Format("Result Presenter.Addnew(): {0}", ""), ex);
                }
            }
        }

        private void reloadtDongiaSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.DisplayDongiaTheoNhomKhachhang();
        }

        private void savetDongiaSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.Save();
        }

        private void edittDongiaSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dongiaModelBindingSource.Count == 0)
                {
                    return;
                }
                using (var f = new DongiaDetailForm(DongiaCurrent))
                {
                    if (f.ShowDialog(this) == DialogResult.Cancel)
                    {
                        RefreshData();
                    }
                }
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("None", ex);
                }
            }
        }

        private void dongiaModelGridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "")
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void nhomKhachhangModelBindingSource_PositionChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(""+NhomKhachhangCurrent.NhomKhachhangId);
            presenter.DisplayDongiaTheoNhomKhachhang();
        }

        private void nhomKhachhangIdTextEdit_ValueMemberChanged(object sender, EventArgs e)
        {
            presenter.DisplayNhomKhachhang();
        }

    }
}