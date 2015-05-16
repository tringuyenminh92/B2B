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
using log4net;
using B2B.Presenter;
using B2B.Model;

namespace B2B.Forms
{
    public partial class ThuchiForm : DevExpress.XtraEditors.XtraForm, IThuchiView
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        ThuchiPresenter presenter;
        public ThuchiForm()
        {
            InitializeComponent();
            presenter = new ThuchiPresenter(this);
            presenter.DisplayThuchi();
            presenter.DisplayNhanvienCapnhat();
        }

        private void addPhieuthuSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (presenter.AddnewPhieuthu())
                {
                    thuchiModelGridView.MoveLast();
                    using (var f = new PhieuthuDetailForm(ThuchiCurent as ThuchiModel, true))
                    {
                        
                        if (f.ShowDialog(this) == DialogResult.Cancel)
                        {
                            presenter.Delete();
                        }
                    }
                    RefreshData();
                }

            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("Add new Phieu thu", ex);
                }
            }
        }

        public List<ThuchiModel> ThuchiItems
        {
            get
            {
                return thuchiModelBindingSource.DataSource as List<ThuchiModel>;
            }
            set
            {
                thuchiModelBindingSource.DataSource = value;
            }
        }

        public void RefreshData()
        {
            thuchiModelGridControl.RefreshDataSource();
        }


        public ThuchiModel ThuchiCurent
        {
            get
            {
                return thuchiModelBindingSource.Current as ThuchiModel;
            }
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

        private void thuchiModelGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "")
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void addPhieuchiSimpleButton_Click(object sender, EventArgs e)
        {
            //try
            //{
                if(presenter.AddnewPhieuchi())
                {
                    thuchiModelGridView.MoveLast();
                    using(var f=new PhieuchiDetailForm(ThuchiCurent as ThuchiModel))
                    {
                        if(f.ShowDialog(this)==DialogResult.Cancel)
                        {
                            presenter.Delete();
                        }
                    }
                    RefreshData();
                }
            //}
            //catch (System.Exception ex)
            //{
            //    //Check log flag and log error to file.
            //    if (isErrorEnabled)
            //    {
            //        logger.Error("Add new Phieu chi", ex);
            //    }
            //}
        }
    }
}