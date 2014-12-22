/***********************************
Author: Lý Hoàng Tín
Date Created: 09/09/2014
Last Updated: 10/09/2014
Updated By: Lý Hoàng Tín
Update description: 
************************************/
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
using B2B.Model;
using B2B.View;
using B2B.Presenter;
using log4net;
using System.IO;

namespace B2B.Forms
{
    public partial class ThuoctinhHanghoaForm : DevExpress.XtraEditors.XtraForm, IThuoctinhHanghoaView
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;
        ThuoctinhHanghoaPresenter presenter;
        MemoryStream memStream;
        public ThuoctinhHanghoaForm()
        {
            InitializeComponent();
            presenter = new ThuoctinhHanghoaPresenter(this);
            memStream = new MemoryStream();
            thuoctinhHanghoaModelGridView.SaveLayoutToStream(memStream);
            memStream.Seek(0, SeekOrigin.Begin);
            presenter.DisplayHanghoa();
            presenter.DisplayThuoctinhHanghoaTheoHanghoa();
        }

        private void hanghoaModelGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "")
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void thuoctinhHanghoaGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "")
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void deleteThuoctinhHanghoaSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (thuoctinhHanghoaModelBindingSource.Count == 0)
                {
                    return;
                }
                presenter.Delete();
            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("None", ex);
                }
                return;
            }
            
        }

        private void exportThuoctinhHanghoaSimpleButton_Click(object sender, EventArgs e)
        {

        }

        private void addThuoctinhHanghoaSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var currentStream = new MemoryStream())
                {
                    thuoctinhHanghoaModelGridView.SaveLayoutToStream(currentStream);
                    currentStream.Seek(0, SeekOrigin.Begin);
                    thuoctinhHanghoaModelGridView.RestoreLayoutFromStream(memStream);
                    memStream.Seek(0, SeekOrigin.Begin);
                    if (presenter.Addnew())
                    {
                        using (var f = new ThuoctinhHanghoaDetailForm(ThuoctinhHanghoaCurrent as ThuoctinhHanghoaModel))
                        {
                            thuoctinhHanghoaModelGridView.MoveLast();
                            if (f.ShowDialog(this) == DialogResult.Cancel)
                            {
                                presenter.Delete();
                            }
                        }
                    }
                    thuoctinhHanghoaModelGridView.RestoreLayoutFromStream(currentStream);
                    currentStream.Seek(0, SeekOrigin.Begin);
                }
            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("None", ex);
                }
                return;
            }  
        }

        private void editThuoctinhHanghoaSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (thuoctinhHanghoaModelBindingSource.Count == 0)
                {
                    return;
                }
                using (var f = new ThuoctinhHanghoaDetailForm(ThuoctinhHanghoaCurrent as ThuoctinhHanghoaModel))
                {
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
                    logger.Error("None", ex);
                }
                return;
            }
        }

        private void saveThuoctinhHanghoaSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.Save();
        }

        private void reloadThuoctinhHanghoaSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.DisplayThuoctinhHanghoaTheoHanghoa();
        }

        public HanghoaModel HanghoaCurrent
        {
            get
            {
                return hanghoaModelBindingSource.Current as HanghoaModel;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public List<ThuoctinhHanghoaModel> ThuoctinhHanghoaItems
        {
            get
            {
                return thuoctinhHanghoaModelBindingSource.DataSource as List<ThuoctinhHanghoaModel>;
            }
            set
            {
                thuoctinhHanghoaModelBindingSource.DataSource = value;
            }
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

        public ThuoctinhHanghoaModel ThuoctinhHanghoaCurrent
        {
            get
            {
                return thuoctinhHanghoaModelBindingSource.Current as ThuoctinhHanghoaModel;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void RefreshData()
        {
            thuoctinhHanghoaModelGridControl.RefreshDataSource();
        }

        public Guid? HanghoaCurrentId
        {
            get { return hanghoaIdTextEdit.EditValue as Guid?; }
        }

        private void hanghoaIdTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            presenter.DisplayHanghoa();
        }
    }
}