/********************************************************************
	Class file: 
    Author: Nguyen Minh Tri
    Date Created: 23/08/2014
	Last Updated: 19/10/2014
	Updated By: Nguyen Minh Tri
	Update Description: 
*********************************************************************/

using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using B2B.View;
using B2B.Presenter;
using B2B.Forms;

namespace B2B.Main
{
    public partial class MainForm : RibbonForm, IMainView
    {
        MainPresenter presenter;
        public MainForm()
        {
            InitializeComponent();
            InitSkinGallery();
            presenter = new MainPresenter(this);
        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }
        public void RefreshData()
        {
        }

        private void DonhangBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new DonhangForm())
            {
                f.ShowDialog(this);
            }
        }

        private void HanghoaBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new HanghoaForm())
            {
                f.ShowDialog(this);
            }
        }

        private void KhachhangBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new KhachhangForm())
            {
                f.ShowDialog(this);
            }
        }

        private void NhomKhachhangbarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new NhomKhachhangForm())
            {
                f.ShowDialog(this);
            }
        }

        private void NhacungcapBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new NhaCungcapForm())
            {
                f.ShowDialog(this);
            }
        }

        private void KhohangBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new KhoForm())
            {
                f.ShowDialog(this);
            }
        }

        private void NhomHanghoaBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new NhomHanghoaForm())
            {
                f.ShowDialog(this);
            }
        }

        private void DongiaBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new DongiaForm())
            {
                f.ShowDialog(this);
            }
        }

        private void DonviBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new DonviForm())
            {
                f.ShowDialog(this);
            }
        }

        private void ThuoctinhHanghoaBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new ThuoctinhHanghoaForm())
            {
                f.ShowDialog(this);
            }
        }

        private void TinhthanhBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new KhuvucTinhthanhForm())
            {
                f.ShowDialog(this);
            }
        }

        private void ThanhphoBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new TinhthanhQuanhuyenForm())
            {
                f.ShowDialog(this);
            }
        }

        private void PhongbanBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //using (var f = new PhongbanForm())
            //{
            //    f.ShowDialog(this);
            //}
        }

        private void NhanvienBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new NhanvienForm())
            {
                f.ShowDialog(this);
            }
        }

        private void UserBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new UserForm())
            {
                f.ShowDialog(this);
            }
        }

        private void BaogiaBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new BaogiaForm())
            {
                f.ShowDialog(this);
            }
        }

        private void NhaphangBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new PhieunhapForm())
            {
                f.ShowDialog(this);
            }
        }

        private void XuathangbarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new PhieuxuatForm())
            {
                f.ShowDialog(this);
            }
        }

        private void TinhtrangBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new TinhtrangForm())
            {
                f.ShowDialog(this);
            }
        }

        private void NguyennhanBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new NguyennhanForm())
            {
                f.ShowDialog(this);
            }
        }

        private void TonkhoBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var f = new TonkhoForm())
            {
                f.ShowDialog(this);
            }
        }
    }
}