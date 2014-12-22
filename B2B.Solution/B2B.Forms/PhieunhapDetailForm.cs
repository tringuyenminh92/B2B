/***********************************
Author: Lý Hoàng Tín
Date Created: 20/20/2014
Last Updated: 20/20/2014
Updated By: Lý Hoàng Tín
Update description: 
************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using B2B.Model;
using B2B.Presenter;
using B2B.View;
using BusinessObject;
using DevExpress.XtraEditors;
using log4net;

namespace B2B.Forms
{
    public partial class PhieunhapDetailForm : XtraForm, IPhieunhapDetailView
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;
        private readonly PhieunhapDetailPresenter presenter;

        public PhieunhapDetailForm()
        {
            InitializeComponent();
            presenter = new PhieunhapDetailPresenter(this);
            
        }

        public PhieunhapDetailForm(PhieunhapModel value)
            : this()
        {
            CurrentPhieunhap = value;
            phieunhapModelBindingSource.DataSource = value;
            //value.ListChitietPhieuNhap = new List<ChitietPhieunhapModel>();
            chitietPhieunhapModelBindingSource.DataSource = value.ListChitietPhieuNhap;                      
            //presenter.DisplayChitietPhieunhap();        
            presenter.DisplayHanghoa();
            presenter.DisplayTinhTrang();
            presenter.DisplayKho();
            presenter.DisplayNhacungcap();
            var tinhtrangHuy = TinhtrangItems.FirstOrDefault(p => p.Code == "TTPN03").TinhtrangId;
            var tinhtrangChot = TinhtrangItems.FirstOrDefault(p => p.Code == "TTPN02").TinhtrangId;
            if (value.TinhtrangPhieunhapCurrentId == tinhtrangHuy || value.TinhtrangPhieunhapCurrentId == tinhtrangChot)
            {
                OkSimpleButton.Enabled = false;
            }
            hSDDateEdit.Properties.MinValue = DateTime.Now;
        }

        public PhieunhapModel CurrentPhieunhap { get; set; }

        public ChitietPhieunhapModel ChitietPhieunhapCurrent
        {
            get { return chitietPhieunhapModelBindingSource.Current as ChitietPhieunhapModel; }
        }

        public void RefreshData(){
            chitietPhieunhapModelGridControl.RefreshDataSource();
        }

        private void addChitietPhieunhapSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (presenter.AddNew())
                {
                    ChitietPhieunhapModelGridView.MoveLast();
                }
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error(string.Format("Result Presenter.Addnew(): {0}", ""), ex);
                }
            }
            //gianhapSpinEdit.EditValue = 0;
        }

        private void CancelSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.ResetCurrent();
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OkSimpleButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            presenter.CapnhatTongtien();
            Close();
        }

        private void PhieunhapDetailForm_KeyUp(object sender, KeyEventArgs e)
        {
            phieunhapModelBindingSource.EndEdit();
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

        public void RefreshDataHanghoa()
        {
            //comboBox1.RefreshEditValue();
        }


        public Guid? CurrentHanghoaId
        {
            get { return hanghoaIdTextEdit.EditValue as Guid?; }
        }


        public DateTime HansudungValue
        {
            get { return hSDDateEdit.DateTime; }
        }

        public string GhichuValue
        {
            get { return ghichuTextEdit.Text.Trim(); }
        }

        public int SoluongValue
        {
            get { return (int)soluongSpinEdit.Value; }
        }

        private void clearChitietPhieunhapSimpleButton_Click(object sender, EventArgs e)
        {
            
        }

        private void ChitietPhieunhapModelGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "")
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void deleteChitietPhieunhapSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.Delete();
        }


        public double GianhapValue
        {
            get { return (double)gianhapSpinEdit.Value; }
        }


        public List<TinhtrangModel> TinhtrangItems
        {
            get
            {
                return tinhtrangModelBindingSource.DataSource as List<TinhtrangModel>;
            }
            set
            {
                tinhtrangModelBindingSource.DataSource=value;
            }
        }


        public List<NhaCungcapModel> NhacungcapItems
        {
            get
            {
                return nhacungcapIdTextEdit.DataSource as List<NhaCungcapModel>;
            }
            set
            {
                nhacungcapIdTextEdit.DataSource = value;
            }
        }

        public List<KhoModel> KhoItems
        {
            get
            {
                return khoIdTextEdit.DataSource as List<KhoModel>;
            }
            set
            {
                khoIdTextEdit.DataSource = value;
            }
        }


        public void RefreshDataNhacungcap()
        {
            throw new NotImplementedException();
        }

        public void RefreshDataKho()
        {
            throw new NotImplementedException();
        }
    }
}