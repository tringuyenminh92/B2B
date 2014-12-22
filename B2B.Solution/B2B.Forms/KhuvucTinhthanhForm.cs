/********************************************************************
	Class file: 
    Author: Nguyen Minh Tri
    Date Created: 23/08/2014
	Last Updated: 09/09/2014
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
using B2B.Presenter;
using log4net;
using System.IO;

namespace B2B.Forms
{
    public partial class KhuvucTinhthanhForm : DevExpress.XtraEditors.XtraForm, IKhuvucTinhthanhView
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        KhuvucTinhthanhPresenter presenter;

        MemoryStream memStreamKhuvuc;

        MemoryStream memStreamTinhthanh;
        public KhuvucTinhthanhForm()
        {
            InitializeComponent();

            memStreamKhuvuc = new MemoryStream();
            khuvucModelGridView.SaveLayoutToStream(memStreamKhuvuc);
            memStreamKhuvuc.Seek(0, System.IO.SeekOrigin.Begin);

            memStreamTinhthanh = new MemoryStream();
            tinhthanhModelGridView.SaveLayoutToStream(memStreamTinhthanh);
            memStreamTinhthanh.Seek(0, System.IO.SeekOrigin.Begin);

            presenter = new KhuvucTinhthanhPresenter(this);
            presenter.HienthiKhuvuc();
        }

        private void khuvucModelGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "")
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void tinhthanhModelGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "")
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void reloadRegionSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.HienthiKhuvuc();
        }

        public List<KhuvucModel> KhuvucItems
        {
            get
            {
                return khuvucModelBindingSource.DataSource as List<KhuvucModel>;
            }
            set
            {
                khuvucModelBindingSource.DataSource = value;
            }
        }

        public KhuvucModel KhuvucCurrent
        {
            get { return khuvucModelBindingSource.Current as KhuvucModel; }
        }

        public List<TinhthanhModel> TinhthanhItems
        {
            get
            {
                return tinhthanhModelBindingSource.DataSource as List<TinhthanhModel>;
            }
            set
            {
                tinhthanhModelBindingSource.DataSource = value;
            }
        }

        public TinhthanhModel TinhthanhCurrent
        {
            get { return tinhthanhModelBindingSource.Current as TinhthanhModel; }
        }

        public void RefreshData()
        { }
        public void RefreshDataKhuvuc()
        {
            khuvucModelGridControl.RefreshDataSource();
        }

        public void RefreshDataTinhthanh()
        {
            tinhthanhModelGridControl.RefreshDataSource();
        }

        private void khuvucModelBindingSource_PositionChanged(object sender, EventArgs e)
        {
            presenter.HienthiTinhthanhTheoKhuvuc();
        }

        private void reloadProvinceSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.HienthiTinhthanhTheoKhuvuc();
        }

        private void deleteRegionSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.DeleteKhuvuc();
        }

        private void saveRegionSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.SaveKhuvuc();
            presenter.HienthiKhuvuc();
        }

        private void addRegionSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var currentStream = new MemoryStream())
                {
                    khuvucModelGridView.SaveLayoutToStream(currentStream);
                    currentStream.Seek(0, System.IO.SeekOrigin.Begin);

                    khuvucModelGridView.RestoreLayoutFromStream(memStreamKhuvuc);
                    memStreamKhuvuc.Seek(0, System.IO.SeekOrigin.Begin);

                    if (presenter.AddnewKhuvuc())
                    {
                        using (var f = new KhuvucDetailForm(KhuvucCurrent as KhuvucModel))
                        {
                            khuvucModelGridView.MoveLast();
                            if (f.ShowDialog(this) == DialogResult.Cancel)
                            {
                                presenter.DeleteKhuvuc();
                            }
                        }
                    }

                    khuvucModelGridView.RestoreLayoutFromStream(currentStream);
                    currentStream.Seek(0, System.IO.SeekOrigin.Begin);
                }
            }
            catch (Exception ex)
            {
                if (isErrorEnabled)
                {
                    logger.Error(string.Format("Number of items: {0}", khuvucModelBindingSource.Count), ex);
                }
                return;
            }
        }

        private void exportRegionSimpleButton_Click(object sender, EventArgs e)
        {

        }

        private void saveProvinceSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.SaveTinhthanh();
            presenter.HienthiTinhthanhTheoKhuvuc();
        }

        private void addProvinceSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (khuvucModelBindingSource.Count == 0)
                {
                    return;
                }

                using (var currentStream = new MemoryStream())
                {
                    tinhthanhModelGridView.SaveLayoutToStream(currentStream);
                    currentStream.Seek(0, System.IO.SeekOrigin.Begin);

                    tinhthanhModelGridView.RestoreLayoutFromStream(memStreamTinhthanh);
                    memStreamTinhthanh.Seek(0, System.IO.SeekOrigin.Begin);

                    if (presenter.AddnewTinhthanh())
                    {
                        using (var f = new TinhthanhDetailForm(TinhthanhCurrent as TinhthanhModel))
                        {
                            tinhthanhModelGridView.MoveLast();
                            if (f.ShowDialog(this) == DialogResult.Cancel)
                            {
                                presenter.DeleteTinhthanh();
                            }
                        }
                    }

                    tinhthanhModelGridView.RestoreLayoutFromStream(currentStream);
                    currentStream.Seek(0, System.IO.SeekOrigin.Begin);
                }

            }
            catch (Exception ex)
            {
                if (isErrorEnabled)
                {
                    logger.Error(string.Format("Number of items: {0}", khuvucModelBindingSource.Count), ex);
                }
                return;
            }
        }

        private void exportProvinceSimpleButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteProvinceSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.DeleteTinhthanh();
        }

        private void editRegionSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (khuvucModelBindingSource.Count == 0)
                {
                    return;
                }
                using (var f = new KhuvucDetailForm(KhuvucCurrent as KhuvucModel))
                {
                    f.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                if (isErrorEnabled)
                {
                    logger.Error(string.Format("Number of items: {0}", khuvucModelBindingSource.Count), ex);
                }
                return;
            }

        }

        private void editProvinceSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (tinhthanhModelBindingSource.Count == 0)
                {
                    return;
                }
                using (var f = new TinhthanhDetailForm(TinhthanhCurrent as TinhthanhModel))
                {
                    f.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                if (isErrorEnabled)
                {
                    logger.Error(string.Format("Number of items: {0}", tinhthanhModelBindingSource.Count), ex);
                }
                return;
            }
        }

    }
}