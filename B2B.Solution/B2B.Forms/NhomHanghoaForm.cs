/********************************************************************
	Class file: 
    Author: Tran Nguyen Hoang Khuyen
    Date Created: 04/09/2014
	Last Updated: 04/09/2014
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
using B2B.View;
using B2B.Presenter;
using B2B.Model;
using System.IO;

namespace B2B.Forms
{
    public partial class NhomHanghoaForm : DevExpress.XtraEditors.XtraForm, INhomHanghoaView
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        NhomHanghoaPresenter presenter;
        MemoryStream memStream;

        public NhomHanghoaForm()
        {
            InitializeComponent();

            memStream = new MemoryStream();
            nhomHanghoaModelGridView.SaveLayoutToStream(memStream);
            memStream.Seek(0, System.IO.SeekOrigin.Begin);
            try
            {
                presenter = new NhomHanghoaPresenter(this);
                presenter.Display();
            }
            catch (System.Exception ex)
            {
            	//Check log flag and log error to file.
            	if (isErrorEnabled)
            	{
                    logger.Error("new NhomHanghoaPresenter(this) - presenter.Display()", ex);
            	}
            	return;
            }
        }

        private void nhomHanghoaModelGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if(e.Column.FieldName == String.Empty)
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }



        public List<Model.NhomHanghoaModel> NhomHanghoaItems
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

        public Model.NhomHanghoaModel NhomHanghoaCurrent
        {
            get { return nhomHanghoaModelBindingSource.Current as NhomHanghoaModel; }
        }

        public void RefreshData()
        {
            nhomHangHoaModelGridControl.RefreshDataSource();
        }

        private void exportNhomHanghoaSimpleButton_Click(object sender, EventArgs e)
        {

        }

        private void saveNhomHanghoaSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.Save();
        }

        private void reloadNhomHanghoaSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.Display();
        }

        private void deleteNhomHanghoaSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.Delete();
        }

        private void addNhomHanghoaSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var currentStream = new MemoryStream())
                {
                    nhomHanghoaModelGridView.SaveLayoutToStream(currentStream);
                    currentStream.Seek(0, System.IO.SeekOrigin.Begin);

                    nhomHanghoaModelGridView.RestoreLayoutFromStream(memStream);
                    memStream.Seek(0, System.IO.SeekOrigin.Begin);

                    if(presenter.Addnew())
                    {
                        nhomHanghoaModelGridView.MoveLast();
                        using (var f = new NhomHanghoaDetailForm(NhomHanghoaCurrent as NhomHanghoaModel))
                        {
                            if (f.ShowDialog(this) == DialogResult.Cancel)
                            {
                                presenter.Delete();
                            }
                            
                        }
                    }
                    nhomHanghoaModelGridView.RestoreLayoutFromStream(currentStream);
                    currentStream.Seek(0, System.IO.SeekOrigin.Begin);
                }
            }
            catch (System.Exception ex)
            {
            	//Check log flag and log error to file.
            	if (isErrorEnabled)
            	{
                    logger.Error(string.Format("Number of items: {0}", nhomHanghoaModelBindingSource.Count), ex);
            	}
            	return;
            }
        }

        private void editNhomHanghoaSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(nhomHanghoaModelBindingSource.Count == 0)
                {
                    return;
                }
                using (var f = new NhomHanghoaDetailForm(NhomHanghoaCurrent as NhomHanghoaModel))
                {
                    if (f.ShowDialog(this) == DialogResult.Cancel)
                    {
                        presenter.Display();
                    }
                }
            }
            catch (System.Exception ex)
            {
            	//Check log flag and log error to file.
            	if (isErrorEnabled)
            	{
            		logger.Error(string.Format("Number of items: {0}", nhomHanghoaModelBindingSource.Count), ex);
            	}
            	return;
            }
        }

        private void InformationGroupControl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ghichuLabel_Click(object sender, EventArgs e)
        {

        }



    }
}