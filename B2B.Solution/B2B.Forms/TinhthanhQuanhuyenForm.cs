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
using B2B.Presenter;
using B2B.Model;
using log4net;
using System.IO;

namespace B2B.Forms
{
    public partial class TinhthanhQuanhuyenForm : DevExpress.XtraEditors.XtraForm, ITinhthanhQuanhuyenView
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        TinhthanhQuanhuyenPresenter presenter;

        MemoryStream memStream;
        public TinhthanhQuanhuyenForm()
        {
            InitializeComponent();

            memStream = new MemoryStream();
            quanhuyenModelGridView.SaveLayoutToStream(memStream);
            memStream.Seek(0, System.IO.SeekOrigin.Begin);

            presenter = new TinhthanhQuanhuyenPresenter(this);
            presenter.DisplayTinhthanh();
            presenter.DisplayQuanhuyenByTinhthanh();
        }

        private void tinhthanhModelGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "")
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void quanhuyenModelGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "")
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void quanhuyenReloadSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.DisplayQuanhuyenByTinhthanh();
        }

        private void quanhuyenSaveSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.SaveQuanhuyen();
            presenter.DisplayQuanhuyenByTinhthanh();
        }

        private void quanhuyenEditSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (quanhuyenModelBindingSource.Count == 0)
                {
                    return;
                }
                using (var f = new QuanhuyenDetailForm(QuanhuyenCurrent as QuanhuyenModel))
                {
                    if (f.ShowDialog(this) == DialogResult.Cancel)
                    {
                        this.RefreshDataQuanhuyen();
                    }
                }
            }
            catch (Exception ex)
            {
                if (isErrorEnabled)
                {
                    logger.Error(string.Format("Number of items: {0}", quanhuyenModelBindingSource.Count), ex);
                }
                return;
            }
        }

        private void quanhuyenAddSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (tinhthanhModelBindingSource.Count == 0)
                {
                    return;
                }

                using (var currentStream = new MemoryStream())
                {
                	quanhuyenModelGridView.SaveLayoutToStream(currentStream);
                	currentStream.Seek(0, System.IO.SeekOrigin.Begin);
                
                	quanhuyenModelGridView.RestoreLayoutFromStream(memStream);
                	memStream.Seek(0, System.IO.SeekOrigin.Begin);
                
                	if (presenter.AddnewQuanhuyen())
                	{
                		using (var f = new  QuanhuyenDetailForm(QuanhuyenCurrent as QuanhuyenModel) )
                		{
                			quanhuyenModelGridView.MoveLast();
                			if (f.ShowDialog(this) == DialogResult.Cancel)
                			{
                				presenter.DeleteQuanhuyen();
                            }
                        }
                    }
                
                    quanhuyenModelGridView.RestoreLayoutFromStream(currentStream);
                    currentStream.Seek(0, System.IO.SeekOrigin.Begin);
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

        private void exportQuanhuyenSimpleButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteQuanhuyenSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.DeleteQuanhuyen();
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
            get
            {
                return tinhthanhModelBindingSource.Current as TinhthanhModel;
            }
        }

        public List<QuanhuyenModel> QuanhuyenItems
        {
            get
            {
                return quanhuyenModelBindingSource.DataSource as List<QuanhuyenModel>;
            }
            set
            {
                quanhuyenModelBindingSource.DataSource = value;
            }
        }

        public QuanhuyenModel QuanhuyenCurrent
        {
            get
            {
                return quanhuyenModelBindingSource.Current as QuanhuyenModel;
            }
        }

        public void RefreshDataTinhthanh()
        {
            tinhthanhModelGridControl.RefreshDataSource();
        }

        public void RefreshDataQuanhuyen()
        {
            quanhuyenModelGridControl.RefreshDataSource();
        }

        public void RefreshData()
        {

        }

        private void tinhthanhModelBindingSource_PositionChanged(object sender, EventArgs e)
        {
            presenter.DisplayQuanhuyenByTinhthanh();
        }
    }
}