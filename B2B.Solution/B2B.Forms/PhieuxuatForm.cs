﻿/********************************************************************
	Class file: 
    Author: Tran Nguyen Hoang Khuyen
    Date Created: 23/09/2014
	Last Updated: 08/11/2014
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
using log4net;
using B2B.Presenter;
using System.IO;
using B2B.View;
using B2B.Model;
using DevExpress.XtraReports.UI;
using B2B.Reports;

namespace B2B.Forms
{
    public partial class PhieuxuatForm : DevExpress.XtraEditors.XtraForm, IPhieuxuatView
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        PhieuxuatPresenter presenter;
        MemoryStream memStream;

        public PhieuxuatForm()
        {
            InitializeComponent();
            memStream = new MemoryStream();
            phieuxuatModelGridView.SaveLayoutToStream(memStream);
            memStream.Seek(0, SeekOrigin.Begin);

            presenter = new PhieuxuatPresenter(this);
            thangNamDateEdit.DateTime = DateTime.Now;
            presenter.DisplayDonhang();
            presenter.DisplayPhieuxuatTheoDonhang();
            presenter.DisplayNhanvienCapnhat();
        }


        private void deletePhieuxuatSimpleButton_Click(object sender, EventArgs e)
        {
            //presenter.Delete();
            presenter.HuyPhieuxuat();
        }

        public List<PhieuxuatModel> PhieuxuatItems
        {
            get
            {
                return phieuxuatModelBindingSource.DataSource as List<PhieuxuatModel>;
            }
            set
            {
                phieuxuatModelBindingSource.DataSource = value;
            }
        }

        public PhieuxuatModel PhieuxuatCurrent
        {
            get { return phieuxuatModelBindingSource.Current as PhieuxuatModel; }
        }

        public List<DonhangModel> DonhangItems
        {
            get
            {
                return donhangModelBindingSource.DataSource as List<DonhangModel>;
            }
            set
            {
                donhangModelBindingSource.DataSource = value;
            }
        }

        public DonhangModel DonhangCurrent
        {
            get { return donhangModelBindingSource.Current as DonhangModel; }
        }

        public void RefreshDataDonhang()
        {
            donhangModelGridControl.RefreshDataSource();
        }

        public void RefreshData()
        {
            phieuxuatModelGridControl.RefreshDataSource();
        }

        private void addPhieuxuatSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var currentStream = new MemoryStream())
                {
                  //  phieuxuatModelGridView.SaveLayoutToStream(currentStream);
                   // currentStream.Seek(0, SeekOrigin.Begin);

                    //phieuxuatModelGridView.RestoreLayoutFromStream(memStream);
                 //   memStream.Seek(0, SeekOrigin.Begin);
                    if (presenter.Addnew())
                    {
                        phieuxuatModelGridView.MoveLast();
                        using (var f = new PhieuxuatDetailForm(PhieuxuatCurrent as PhieuxuatModel))
                        {
                            f.isEdit = false;
                            var result = f.ShowDialog(this);
                            if (result == DialogResult.Cancel)
                            {
                                presenter.Delete();
                            }
                            else if (result == DialogResult.OK)
                            {
                                presenter.Save();
                            }
                            presenter.DisplayPhieuxuatTheoDonhang();
                            addPhieuthuSimpleButton.Enabled = presenter.LapPhieuthuButtonDisable();
                        }
                    }
                   // phieuxuatModelGridView.RestoreLayoutFromStream(currentStream);
                    // currentStream.Seek(0, SeekOrigin.Begin);
                }
            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("", ex);
                }
            }
        }

        private void editPhieuxuatSimpleButton_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (phieuxuatModelBindingSource.Count == 0)
                {
                    return;
                }
                using (var f = new PhieuxuatDetailForm(PhieuxuatCurrent as PhieuxuatModel))
                {
                    if (presenter.CheckTinhtrangPhieuxuatChotHoacHuy()) { f.isChotOrHuy = true; }
                    f.isEdit = true;
                    var result = f.ShowDialog(this);
                    if (result == DialogResult.Cancel)
                    {
                        //presenter.DisplayPhieuxuatTheoDonhang();
                    }
                    else if (result == DialogResult.OK)
                    {
                        presenter.Save();
                    }
                    presenter.DisplayPhieuxuatTheoDonhang();
                    addPhieuthuSimpleButton.Enabled = presenter.LapPhieuthuButtonDisable();
                }
                
            //}
            //catch (System.Exception ex)
            //{
            //    //Check log flag and log error to file.
            //    if (isErrorEnabled)
            //    {
            //        logger.Error(string.Format("{0}", PhieuxuatCurrent.PhieuxuatId), ex);
            //    }
            //    return;
            //}
        }

        private void donhangModelBindingSource_PositionChanged(object sender, EventArgs e)
        {
            presenter.DisplayPhieuxuatTheoDonhang();
            addPhieuthuSimpleButton.Enabled = presenter.LapPhieuthuButtonDisable();
        }

        private void phieuxuatModelGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "")
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void donhangModelGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "")
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void savePhieuxuatSimpleButton_Click(object sender, EventArgs e)
        {
            if (presenter.Save())
            {
                XtraMessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Lưu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            presenter.DisplayPhieuxuatTheoDonhang();
            addPhieuthuSimpleButton.Enabled = presenter.LapPhieuthuButtonDisable();
        }

        public NhanvienModel _nhanvienCapnhat;

        public NhanvienModel NhanvienCapNhat
        {
            get
            {
                return _nhanvienCapnhat;
            }
            set
            {
                _nhanvienCapnhat = value;
            }
        }

        public DateTime filterValue
        {
            get
            {
                return thangNamDateEdit.DateTime;
            }
        }

        private void reloadDonhangSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.DisplayDonhang();
        }

        private void btnPhieuGiaohang_Click(object sender, EventArgs e)
        {
            if (PhieuxuatCurrent == null)
            {
                return;
            }
            //PhieuGiaohang f = new PhieuGiaohang(PhieuxuatCurrent);
            //PGH f = new PGH(PhieuxuatCurrent);
            //f.ShowPreviewDialog();
            PhieuGiaohangReport f = new PhieuGiaohangReport(PhieuxuatCurrent);
            using (ReportPrintTool toot = new ReportPrintTool(f))
            {
                toot.ShowPreviewDialog();
            }
            

        }

        private void addPhieuthuSimpleButton_Click(object sender, EventArgs e)
        {
            ThuchiModel pt = new ThuchiModel();

            presenter.AddPhieuthu(pt);
            using (var f = new PhieuthuDetailForm(pt, false))
            {
                f.ShowDialog(this);
            }
        }

        private void phieuxuatModelBindingSource_PositionChanged(object sender, EventArgs e)
        {
            addPhieuthuSimpleButton.Enabled = presenter.LapPhieuthuButtonDisable();
        }
    }
}