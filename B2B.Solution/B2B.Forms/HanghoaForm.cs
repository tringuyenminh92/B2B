/********************************************************************
	Class file: 
    Author: Tran Nguyen Hoang Khuyen
    Date Created: 13/09/2014
	Last Updated: 19/09/2014
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
using System.IO;

namespace B2B.Forms
{
    public partial class HanghoaForm : DevExpress.XtraEditors.XtraForm, IHanghoaView
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;
        HanghoaPresenter presenter;
        MemoryStream memStream;
        public HanghoaForm()
        {
            InitializeComponent();

            memStream = new MemoryStream();
            hanghoaModelGridView.SaveLayoutToStream(memStream);
            memStream.Seek(0, SeekOrigin.Begin);

            presenter = new HanghoaPresenter(this);
            presenter.DisplayNhomHanghoa();
            presenter.DisplayHanghoaTheoNhom();
        }

        

        private void deleteHanghoaSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.Delete();
        }

        public List<HanghoaModel> HanghoaItems
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

        public HanghoaModel HanghoaCurrent
        {
            get { 
                return hanghoaModelBindingSource.Current as HanghoaModel; 
            }
        }

        public void RefreshData()
        {
            hanghoaModelGridControl.RefreshDataSource();
        }

        private void addHanghoaSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var currentStream = new MemoryStream())
                {
                    hanghoaModelGridView.SaveLayoutToStream(currentStream);
                    currentStream.Seek(0, SeekOrigin.Begin);

                    hanghoaModelGridView.RestoreLayoutFromStream(memStream);
                    memStream.Seek(0, SeekOrigin.Begin);
                    if (presenter.Addnew())
                    {
                        hanghoaModelGridView.MoveLast();
                        using (var f = new HanghoaDetailForm(HanghoaCurrent as HanghoaModel))
                        {
                            if (f.ShowDialog(this) == DialogResult.Cancel)
                            {
                                presenter.Delete();
                            }
                        }
                    }

                    hanghoaModelGridView.RestoreLayoutFromStream(currentStream);
                    currentStream.Seek(0, SeekOrigin.Begin);
                }
            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error(string.Format("{0}", HanghoaCurrent.HanghoaId), ex);
                }
                return;
            }
        }

        private void editHanghoaSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (hanghoaModelBindingSource.Count == 0)
                {
                    return;
                }
                using (var f = new HanghoaDetailForm(HanghoaCurrent as HanghoaModel))
                {
                    if(f.ShowDialog(this) == DialogResult.Cancel)
                    {
                        presenter.DisplayNhomHanghoa();
                        presenter.DisplayHanghoaTheoNhom();
                    }
                }

            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error(string.Format("{0}", HanghoaCurrent.HanghoaId), ex);
                }
                return;
            }
        }

        private void nhomHanghoaModelBindingSource_PositionChanged(object sender, EventArgs e)
        {
            presenter.DisplayHanghoaTheoNhom();
        }
        public List<NhomHanghoaModel> NhomHanghoaItems
        {
            get
            {
                return nhomHanghoaModelBindingSource.DataSource as List<NhomHanghoaModel>;
            }
            set
            {
                nhomHanghoaModelBindingSource.DataSource = value;
            }
        }

        public void RefreshDataNhomHanghoa()
        {
            nhomHanghoaIdHienthiTextEdit.RefreshEditValue();
        }

        private void nhomHanghoaModelGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "")
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void exportHanghoaSimpleButton_Click(object sender, EventArgs e)
        {

        }


        public Guid? NhomHanghoaCurrentId
        {
            get { return nhomHanghoaIdHienthiTextEdit.EditValue as Guid?; }
        }

        private void nhomHanghoaIdTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            presenter.DisplayHanghoaTheoNhom();
        }

        private void saveHanghoaSimpleButton_Click(object sender, EventArgs e)
        {
            if(presenter.Save())
            {
                XtraMessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Lưu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void hanghoaModelGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "")
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void hanghoaModelBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(HanghoaCurrent.LinkHinhanh))
                {
                    AnhMyPictureEdit.Image = Image.FromFile(HanghoaCurrent.LinkHinhanh);
                }
                else
                {
                    AnhMyPictureEdit.Image = null;
                }
            }
            catch (System.Exception ex)
            {
                if (isErrorEnabled)
                {
                    logger.Error("Link hinh anh sai.", ex);
                }
                AnhMyPictureEdit.Image = null;
                return;
            }
        }
    }
}