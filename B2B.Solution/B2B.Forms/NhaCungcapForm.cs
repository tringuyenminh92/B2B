/********************************************************************
	Class file: 
    Author: Nguyen Minh Tri
    Date Created: 23/08/2014
	Last Updated: 19/09/2014
	Updated By: Nguyen Minh Tri
	Update Description: 
*********************************************************************/

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using B2B.Model;
using B2B.View;
using log4net;
using B2B.Presenter;
using System.IO;
using DevExpress.XtraEditors;

namespace B2B.Forms
{
    public partial class NhaCungcapForm : DevExpress.XtraEditors.XtraForm, INhaCungcapView
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        NhaCungcapPresenter presenter;

        MemoryStream memStream;

        public NhaCungcapForm()
        {
            InitializeComponent();
            try
            {
                memStream = new MemoryStream();
                nhaCungcapModelGridView.SaveLayoutToStream(memStream);
                memStream.Seek(0, System.IO.SeekOrigin.Begin);

                presenter = new NhaCungcapPresenter(this);
                presenter.Display();
            }
            catch (System.Exception ex)
            {
                if (isErrorEnabled)
                {
                    logger.Error("new NhaCungcapPresenter(this) - presenter.Display()", ex);
                }
            }
        }


        public List<NhaCungcapModel> NhaCungcapItems
        {
            get
            {
                return nhaCungcapModelBindingSource.DataSource as List<NhaCungcapModel>;
            }
            set
            {
                nhaCungcapModelBindingSource.DataSource = value;
            }
        }

        public NhaCungcapModel NhaCungcapCurrent
        {
            get { return nhaCungcapModelBindingSource.Current as NhaCungcapModel; }
        }

        public void RefreshData()
        {
            nhaCungcapModelGridControl.RefreshDataSource();
        }

        private void reloadNhaCungcapSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.Display();
        }
        private void saveNhaCungcapSimpleButton_Click(object sender, EventArgs e)
        {
            if (presenter.Save())
            {
                XtraMessageBox.Show("Lưu Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                presenter.Display();
            }
            else
            {
                XtraMessageBox.Show("Lưu Thất Bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void editNhaCungcapSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (nhaCungcapModelBindingSource.Count == 0)
                {
                    return;
                }
                using (var f = new NhaCungcapDetailForm(NhaCungcapCurrent as NhaCungcapModel))
                {
                    if (f.ShowDialog(this) == DialogResult.Cancel)
                    {
                        this.RefreshData();
                    }

                }
            }
            catch (System.Exception ex)
            {
                if (isErrorEnabled)
                {
                    logger.Error(string.Format("Number of items: {0}", nhaCungcapModelBindingSource.Count), ex);
                }
                return;
            }
        }

        private void addNhaCungcapSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var currentStream = new MemoryStream())
                {
                    nhaCungcapModelGridView.SaveLayoutToStream(currentStream);
                    currentStream.Seek(0, System.IO.SeekOrigin.Begin);

                    nhaCungcapModelGridView.RestoreLayoutFromStream(memStream);
                    memStream.Seek(0, System.IO.SeekOrigin.Begin);

                    if (presenter.Addnew())
                    {
                        nhaCungcapModelGridView.MoveLast();
                        using (var f = new NhaCungcapDetailForm(NhaCungcapCurrent as NhaCungcapModel))
                        {
                            if (f.ShowDialog(this) == DialogResult.Cancel)
                            {
                                presenter.Delete();
                            }
                        }
                    }
                    nhaCungcapModelGridView.RestoreLayoutFromStream(currentStream);
                    currentStream.Seek(0, System.IO.SeekOrigin.Begin);
                }
            }
            catch (System.Exception ex)
            {
                if (isErrorEnabled)
                {
                    logger.Error(string.Format("Number of items: {0}", nhaCungcapModelBindingSource.Count), ex);
                }
            }
        }

        private void deleteNhaCungcapSimpleButton_Click(object sender, EventArgs e)
        {
            if (presenter.Delete())
            {
                XtraMessageBox.Show("Xóa Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Handle tình huống xóa có tham chíu
                XtraMessageBox.Show("Xóa Thất Bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void nhaCungcapModelGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "")
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
    }
}