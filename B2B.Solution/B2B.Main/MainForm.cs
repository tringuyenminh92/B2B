// ***********************************************************************
// Assembly         : B2B.Main
// Author           : MinhTri
// Created          : 23-08-2014
//
// Last Modified By : MinhTri
// Last Modified On : 28-12-2014
// ***********************************************************************

using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using B2B.View;
using B2B.Presenter;
using B2B.Forms;

/// <summary>
/// The Main namespace.
/// </summary>
namespace B2B.Main
{
    /// <summary>
    /// Class MainForm.
    /// </summary>
    public partial class MainForm : RibbonForm, IMainView
    {
        /// <summary>
        /// The presenter
        /// </summary>
        MainPresenter presenter;
        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitSkinGallery();
            presenter = new MainPresenter(this);
        }
        /// <summary>
        /// Initializes the skin gallery.
        /// </summary>
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }
        /// <summary>
        /// Refreshes the data.
        /// </summary>
        public void RefreshData()
        {
        }

        /// <summary>
        /// Handles the ItemClick event of the DonhangBarButtonItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        private void DonhangBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new DonhangForm())
            {
                f.ShowDialog(this);
            }
        }

        /// <summary>
        /// Handles the ItemClick event of the HanghoaBarButtonItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        private void HanghoaBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new HanghoaForm())
            {
                f.ShowDialog(this);
            }
        }

        /// <summary>
        /// Handles the ItemClick event of the KhachhangBarButtonItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        private void KhachhangBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new KhachhangForm())
            {
                f.ShowDialog(this);
            }
        }

        /// <summary>
        /// Handles the ItemClick event of the NhomKhachhangbarButtonItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        private void NhomKhachhangbarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new NhomKhachhangForm())
            {
                f.ShowDialog(this);
            }
        }

        /// <summary>
        /// Handles the ItemClick event of the NhacungcapBarButtonItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        private void NhacungcapBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new NhaCungcapForm())
            {
                f.ShowDialog(this);
            }
        }

        /// <summary>
        /// Handles the ItemClick event of the KhohangBarButtonItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        private void KhohangBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new KhoForm())
            {
                f.ShowDialog(this);
            }
        }

        /// <summary>
        /// Handles the ItemClick event of the NhomHanghoaBarButtonItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        private void NhomHanghoaBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new NhomHanghoaForm())
            {
                f.ShowDialog(this);
            }
        }

        /// <summary>
        /// Handles the ItemClick event of the DongiaBarButtonItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        private void DongiaBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new DongiaForm())
            {
                f.ShowDialog(this);
            }
        }

        /// <summary>
        /// Handles the ItemClick event of the DonviBarButtonItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        private void DonviBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new DonviForm())
            {
                f.ShowDialog(this);
            }
        }

        /// <summary>
        /// Handles the ItemClick event of the ThuoctinhHanghoaBarButtonItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        private void ThuoctinhHanghoaBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new ThuoctinhHanghoaForm())
            {
                f.ShowDialog(this);
            }
        }

        /// <summary>
        /// Handles the ItemClick event of the TinhthanhBarButtonItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        private void TinhthanhBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new KhuvucTinhthanhForm())
            {
                f.ShowDialog(this);
            }
        }

        /// <summary>
        /// Handles the ItemClick event of the ThanhphoBarButtonItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        private void ThanhphoBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new TinhthanhQuanhuyenForm())
            {
                f.ShowDialog(this);
            }
        }

        /// <summary>
        /// Handles the ItemClick event of the PhongbanBarButtonItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        private void PhongbanBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //using (var f = new PhongbanForm())
            //{
            //    f.ShowDialog(this);
            //}
        }

        /// <summary>
        /// Handles the ItemClick event of the NhanvienBarButtonItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        private void NhanvienBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new NhanvienForm())
            {
                f.ShowDialog(this);
            }
        }

        /// <summary>
        /// Handles the ItemClick event of the UserBarButtonItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        private void UserBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new UserForm())
            {
                f.ShowDialog(this);
            }
        }

        /// <summary>
        /// Handles the ItemClick event of the BaogiaBarButtonItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        private void BaogiaBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new BaogiaForm())
            {
                f.ShowDialog(this);
            }
        }

        /// <summary>
        /// Handles the ItemClick event of the NhaphangBarButtonItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        private void NhaphangBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new PhieunhapForm())
            {
                f.ShowDialog(this);
            }
        }

        /// <summary>
        /// Handles the ItemClick event of the XuathangbarButtonItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        private void XuathangbarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new PhieuxuatForm())
            {
                f.ShowDialog(this);
            }
        }

        /// <summary>
        /// Handles the ItemClick event of the TinhtrangBarButtonItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        private void TinhtrangBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new TinhtrangForm())
            {
                f.ShowDialog(this);
            }
        }

        /// <summary>
        /// Handles the ItemClick event of the NguyennhanBarButtonItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        private void NguyennhanBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new NguyennhanForm())
            {
                f.ShowDialog(this);
            }
        }

        /// <summary>
        /// Handles the ItemClick event of the TonkhoBarButtonItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        private void TonkhoBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new TonkhoForm())
            {
                f.ShowDialog(this);
            }
        }

        /// <summary>
        /// Handles the ItemClick event of the KiemkeBarButtonItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        private void KiemkeBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new KiemkeForm())
            {
                f.ShowDialog(this);
            }
        }

        /// <summary>
        /// Handles the ItemClick event of the SaoluuBarButtonItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraBars.ItemClickEventArgs"/> instance containing the event data.</param>
        private void SaoluuBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using(var f=new BackupForm())
            {
                f.ShowDialog();
            }
        }

        private void PhuchoiBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new RestoreForm())
            {
                f.ShowDialog();
            }
        }

        private void TratienBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using(var f=new CongnoNhapForm())
            {
                f.ShowDialog();
            }
        }

        private void ThutienBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new CongnoXuatForm())
            {
                f.ShowDialog();
            }
        }

        private void btnThuChi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new ThuchiForm())
            {
                f.ShowDialog();
            }
        }
    }
}