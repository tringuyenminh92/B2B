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
    public partial class PhieuchiDetailForm : DevExpress.XtraEditors.XtraForm, IPhieuchiDetailView
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        PhieuchiDetailPresenter presenter;
        ThuchiModel valuePhieuchi;

        public PhieuchiDetailForm()
        {
            InitializeComponent();
            presenter = new PhieuchiDetailPresenter(this);
            presenter.DisplayPhieunhap();
            presenter.DisplayNhaCungcap();
            presenter.DisplayNhanvien();
        }

        public PhieuchiDetailForm(ThuchiModel value)
            : this()
        {
            ValuePhieuchi = value;
            thuchiModelBindingSource.DataSource = value;
        }

        private void CancelSimpleButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void OKSimpleButton_Click(object sender, EventArgs e)
        {
            if (ValuePhieuchi.Tongtien <= 0 || ValuePhieuchi.Tongtien == null)
            {
                XtraMessageBox.Show("Số tiền không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ValuePhieuchi.PhieunhapId.ToString() != "00000000-0000-0000-0000-000000000000" && ValuePhieuchi.NhannopTienId == null)
            {
                XtraMessageBox.Show("Xin vui lòng chọn nhà cung cấp", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //var kh = nhannopTienIdTextEdit.GetSelectedDataRow() as KhachhangModel;
                //if (kh != null)
                //{
                //    ValuePhieuthu.TenNhannopTien = kh.HotenKhachhang;
                //}
                if (ValuePhieuchi.NhannopTienId != null)
                {
                    presenter.GetTenNhannopTien();
                }
                
                if (ValuePhieuchi.PhieunhapId.ToString() == "00000000-0000-0000-0000-000000000000")
                {
                    ValuePhieuchi.PhieunhapId = null;
                }
                ValuePhieuchi.Step = 2;
                if (presenter.Save())
                {
                    XtraMessageBox.Show("Lưu phiếu chi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Lưu phiếu chi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void nhannopTienIdTextEdit_EditValueChanged(object sender, EventArgs e)
        {
        }

        public Guid? PhieuxuatCurrentId
        {
            get { return phieunhapIdTextEdit.EditValue as Guid?; }
        }

        public List<PhieunhapModel> PhieunhapItems
        {
            get
            {
                return phieunhapModelBindingSource.DataSource as List<PhieunhapModel>;
            }
            set
            {
                phieunhapModelBindingSource.DataSource = value;
            }
        }

        public PhieunhapModel PhieunhapCurrent
        {
            get { return phieunhapModelBindingSource.Current as PhieunhapModel; }
        }

        public ThuchiModel ValuePhieuchi
        {
            get
            {
                return valuePhieuchi;
            }
            set
            {
                valuePhieuchi = value;
            }
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

        public Guid? PhieunhapCurrentId
        {
            get { return phieunhapIdTextEdit.EditValue as Guid?; }
        }

        public void RefreshData()
        {
        }

        private void phieunhapIdTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            presenter.DisplayNhaCungcap();
        }
    }
}