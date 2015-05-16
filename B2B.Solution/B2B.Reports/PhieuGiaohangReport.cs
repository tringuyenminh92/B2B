using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using B2B.View;
using B2B.Presenter;
using B2B.Model;

namespace B2B.Reports
{
    public partial class PhieuGiaohangReport : DevExpress.XtraReports.UI.XtraReport, IPhieuGiaohangReportView
    {
        PhieuGiaohangReportPresenter presenter;
        PhieuxuatModel _valuePhieuxuat;
        public PhieuGiaohangReport()
        {
            InitializeComponent();
            presenter = new PhieuGiaohangReportPresenter(this);
            //xrRichText4.Text = DateTime.Now.ToShortDateString();


        }

        public PhieuGiaohangReport(PhieuxuatModel valuePhieuxuat)
            : this()
        {
            if (valuePhieuxuat == null)
            {
                return;
            }
            ValuePhieuxuat = valuePhieuxuat;

            presenter.DisplayThongtinKhachhang();
            presenter.DisplayChitietPhieuxuat();
            PhieuXuatModelBindingSource.DataSource = valuePhieuxuat;
            ChitietPhieuXuatModelBindingSource.DataSource = valuePhieuxuat.ChitietPhieuxuatItems;

            var t = 1;
        }

        public Model.PhieuxuatModel ValuePhieuxuat
        {
            get
            {
                return _valuePhieuxuat;
            }
            set
            {
                _valuePhieuxuat = value;
            }
        }

        public void RefreshData()
        {
            throw new NotImplementedException();
        }

    }
}
