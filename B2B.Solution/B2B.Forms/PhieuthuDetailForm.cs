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
    public partial class PhieuthuDetailForm : DevExpress.XtraEditors.XtraForm, IPhieuthuDetailView
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        PhieuthuDetailPresenter presenter;
        ThuchiModel valuePhieuthu;
        bool allowChange = true;

        public PhieuthuDetailForm()
        {
            InitializeComponent();
            presenter = new PhieuthuDetailPresenter(this);
            presenter.DisplayPhieuxuat();
            presenter.DisplayKhachhang();
            presenter.DisplayNhanvien();
            //presenter.DisplayThongtinPhieuthu();
        }

        public PhieuthuDetailForm(ThuchiModel value, bool allowChange)
            : this()
        {
            ValuePhieuthu = value;
            thuchiModelBindingSource.DataSource = value;
            this.allowChange = allowChange;
        }

        public List<PhieuxuatModel> PhieuxuatItems
        {
            get
            {
                return phieuxuatModelBindingSource.DataSource as List<PhieuxuatModel>;
            }
            set
            {
                phieuxuatModelBindingSource.DataSource = value;
            }
        }

        public void RefreshData()
        {
        }


        public ThuchiModel ValuePhieuthu
        {
            get
            {
                return valuePhieuthu;
            }
            set
            {
                valuePhieuthu = value;
            }
        }


        public PhieuxuatModel PhieuxuatCurrent
        {
            get { return phieuxuatModelBindingSource.Current as PhieuxuatModel; }
        }

        //public Guid? PhieuxuatCurrentId
        //{
        //    get
        //    {
        //        return phieuxuatIdTextEdit.EditValue as Guid?;
        //    }
        //    set
        //    {
        //        phieuxuatIdTextEdit.EditValue = value;
        //    }
        //}

        private void thuchiModelBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {

        }

        public List<NhanvienModel> NhanvienItems
        {
            get
            {
                return nhanvienModelBindingSource.DataSource as List<NhanvienModel>;
            }
            set
            {
                nhanvienModelBindingSource.DataSource = value;
            }
        }

        public List<KhachhangModel> KhachhangItems
        {
            get
            {
                return khachhangModelBindingSource.DataSource as List<KhachhangModel>;
            }
            set
            {
                khachhangModelBindingSource.DataSource = value;
            }
        }

        private void CancelSimpleButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void OKSimpleButton_Click(object sender, EventArgs e)
        {
            if (ValuePhieuthu.Tongtien <= 0 || ValuePhieuthu.Tongtien == null)
            {
                XtraMessageBox.Show("Số tiền không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ValuePhieuthu.PhieuxuatId.ToString() != "00000000-0000-0000-0000-000000000000" && ValuePhieuthu.NhannopTienId == null)
            {
                XtraMessageBox.Show("Xin vui lòng chọn khách hàng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //var kh = nhannopTienIdTextEdit.GetSelectedDataRow() as KhachhangModel;
                //if (kh != null)
                //{
                //    ValuePhieuthu.TenNhannopTien = kh.HotenKhachhang;
                //}
                if (ValuePhieuthu.NhannopTienId != null)
                {
                    presenter.GetTenNhannopTien();
                }
                
                if (ValuePhieuthu.PhieuxuatId.ToString() == "00000000-0000-0000-0000-000000000000")
                {
                    ValuePhieuthu.PhieuxuatId = null;
                }
                ValuePhieuthu.Step = 1;
                if (presenter.Save())
                {
                    XtraMessageBox.Show("Lưu phiếu thu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Lưu phiếu thu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void PhieuthuDetailForm_Load(object sender, EventArgs e)
        {
            phieuxuatIdTextEdit.Properties.ReadOnly = nhannopTienIdTextEdit.Properties.ReadOnly = !allowChange;
            phieuxuatIdTextEdit.BackColor = nhanvienIdTextEdit.BackColor = nhannopTienIdTextEdit.BackColor = Color.White;
        }

        private void nhannopTienIdTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            //var kh = nhannopTienIdTextEdit.GetSelectedDataRow() as KhachhangModel;
            //if (kh != null)
            //{
            //    ValuePhieuthu.TenNhannopTien = kh.HotenKhachhang;
            //}

        }

        public Guid? PhieuxuatCurrentId
        {
            get { return phieuxuatIdTextEdit.EditValue as Guid?; }
        }

        private void phieuxuatIdTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            presenter.DisplayKhachhang();
        }
    }
}