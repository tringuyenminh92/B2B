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
    public partial class PhieuthuReport : DevExpress.XtraReports.UI.XtraReport, IPhieuThuchiReportView
    {
        PhieuThuchiReportPresenter presenter;
        ThuchiModel _valuePhieuthu;
        ThuchiModel _valuePhieuchi;
        public PhieuthuReport()
        {
            InitializeComponent();
            presenter = new PhieuThuchiReportPresenter(this);
        }

        public PhieuthuReport (ThuchiModel valueThuChi) :this ()
        {
            if (valueThuChi == null)
            {
                return;
            }

            ValueThu = valueThuChi;
            presenter.DisplayThongtinThu();
            ThuchiModelBindingSource.DataSource = ValueThu;

        }

        public Model.ThuchiModel ValueThu
        {
            get { return _valuePhieuthu; }
            set { _valuePhieuthu = value; }
        }

        public Model.ThuchiModel ValueChi
        {
            get { return _valuePhieuchi; }
            set { _valuePhieuchi = value; }
        }

        public void RefreshData()
        {
            throw new NotImplementedException();
        }

        


    }
}
