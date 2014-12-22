/********************************************************************
	Class file: 
    Author: Tran Nguyen Hoang Khuyen
    Date Created: 31/08/2014
	Last Updated: 31/08/2014
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
using B2B.Model;
using B2B.View;
using log4net;
using B2B.Presenter;
using System.IO;
namespace B2B.Forms
{
    public partial class NhomKhachhangForm : DevExpress.XtraEditors.XtraForm, INhomKhachhangView
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        NhomKhachhangPresenter presenter;

        MemoryStream memStream;
        public NhomKhachhangForm()
        {
            InitializeComponent();
            try
            {
                memStream = new MemoryStream();
                nhomKhachhangModelGridView.SaveLayoutToStream(memStream);
                memStream.Seek(0, System.IO.SeekOrigin.Begin);

                presenter = new NhomKhachhangPresenter(this);
                presenter.Display();
            }
            catch (System.Exception ex)
            {
                if (isErrorEnabled)
                {
                    logger.Error("new NhomKhachhangPresenter(this) - presenter.Display()", ex);
                }
            }
        }

        private void nhomKhachhangModelGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "")
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
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

        public NhomKhachhangModel NhomKhachhangCurrent
        {
            get { return nhomKhachhangModelBindingSource.Current as NhomKhachhangModel; }
        }

        public void RefreshData()
        {
            nhomKhachhangModelGridControl.RefreshDataSource();
        }

        private void exportNhaCungcapSimpleButton_Click(object sender, EventArgs e)
        {

        }

        private void saveNhaCungcapSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.Save();
        }

        private void reloadNhomKhachhangSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.Display();
        }

        private void deleteNhomKhachhangSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.Delete();
        }

        private void addNhomKhachhangSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var currentStream = new MemoryStream())
                {
                    nhomKhachhangModelGridView.SaveLayoutToStream(currentStream);
                    currentStream.Seek(0, System.IO.SeekOrigin.Begin);

                    nhomKhachhangModelGridView.RestoreLayoutFromStream(memStream);
                    memStream.Seek(0, System.IO.SeekOrigin.Begin);
                    
                    if (presenter.Addnew())
                    {
                        nhomKhachhangModelGridView.MoveLast();
                        using (var f = new NhomKhachhangDetailForm(NhomKhachhangCurrent as NhomKhachhangModel))
                        {
                            if (f.ShowDialog(this) == DialogResult.Cancel)
                            {
                                presenter.Delete();
                            }
                        }
                        //this.RefreshData();
                    }

                    nhomKhachhangModelGridView.RestoreLayoutFromStream(currentStream);
                    currentStream.Seek(0, System.IO.SeekOrigin.Begin);
                }
            }
            catch (System.Exception ex)
            {
                if (isErrorEnabled)
                {
                    logger.Error(string.Format("Number of items: {0}", nhomKhachhangModelBindingSource.Count), ex);
                }
            }
        }

        private void editNhomKhachhangSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (nhomKhachhangModelBindingSource.Count == 0)
                {
                    return;
                }
                using (var f = new NhomKhachhangDetailForm(NhomKhachhangCurrent as NhomKhachhangModel))
                {
                    f.ShowDialog(this);

                }
            }
            catch (System.Exception ex)
            {
                if (isErrorEnabled)
                {
                    logger.Error(string.Format("Number of items: {0}", nhomKhachhangModelBindingSource.Count), ex);
                }
                return;
            }
        }
    }
}