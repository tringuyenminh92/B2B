/********************************************************************
	Class file: 
    Author: Nguyen Minh Tri
    Date Created: 29/08/2014
	Last Updated: 18/09/2014
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
using log4net;
using B2B.Presenter;
using B2B.View;
using B2B.Model;
using System.IO;

namespace B2B.Forms
{
    public partial class DonviForm : DevExpress.XtraEditors.XtraForm, IDonviView
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        DonviPresenter presenter;

        MemoryStream memStream;
        public DonviForm()
        {
            InitializeComponent();

            memStream = new MemoryStream();
            donviModelGridView.SaveLayoutToStream(memStream);
            memStream.Seek(0, System.IO.SeekOrigin.Begin);

            presenter = new DonviPresenter(this);
            presenter.Display();
        }

        public List<DonviModel> DonviItems
        {
            get
            {
                return donviModelBindingSource.DataSource as List<DonviModel>;
            }
            set
            {
                donviModelBindingSource.DataSource = value;
            }
        }

        public DonviModel DonviCurrent
        {
            get { return donviModelBindingSource.Current as DonviModel; }
        }

        public void RefreshData()
        {
            donviModelGridControl.RefreshDataSource();
        }

        private void reloadDonviSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.Display();
        }

        private void saveDonviSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.Save();
        }

        private void deleteDonviSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.Delete();
        }

        private void exportDonviSimpleButton_Click(object sender, EventArgs e)
        {

        }

        private void addDonviSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var currentStream = new MemoryStream())
                {
                    donviModelGridView.SaveLayoutToStream(currentStream);
                    currentStream.Seek(0, System.IO.SeekOrigin.Begin);

                    donviModelGridView.RestoreLayoutFromStream(memStream);
                    memStream.Seek(0, System.IO.SeekOrigin.Begin);

                    if (presenter.Addnew())
                    {
                        using (var f = new DonviDetailForm(DonviCurrent as DonviModel))
                        {
                            donviModelGridView.MoveLast();
                            if (f.ShowDialog(this) == DialogResult.Cancel)
                            {
                                presenter.Delete();
                            }
                        }
                    }

                    donviModelGridView.RestoreLayoutFromStream(currentStream);
                    currentStream.Seek(0, System.IO.SeekOrigin.Begin);
                }
            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("Addnew", ex);
                }
                return;
            }
        }

        private void editDonviSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (donviModelBindingSource.Count == 0)
                {
                    return;
                }
                using (var f = new DonviDetailForm(DonviCurrent as DonviModel))
                {
                    if (f.ShowDialog(this) == DialogResult)
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
                    logger.Error(string.Format("{0}", DonviCurrent.DonviId), ex);
                }
                return;
            }
        }

        private void donviModelGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "")
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
    }
}