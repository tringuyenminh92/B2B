namespace B2B.Forms
{
    partial class ThuchiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThuchiForm));
            this.thuchiModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.thuchiModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thuchiModelGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colThuchiId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhanvienId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhieunhapId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhieuxuatId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhannopTienId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVaoluc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongtien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhichu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNhannopTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNhanvien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVaolucGio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiThuchi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BaogiaActionGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.exportPhieuthuchiSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.addPhieuchiSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.addPhieuthuSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.thuchiModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuchiModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuchiModelGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaogiaActionGroupControl)).BeginInit();
            this.BaogiaActionGroupControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // thuchiModelGridControl
            // 
            this.thuchiModelGridControl.DataSource = this.thuchiModelBindingSource;
            this.thuchiModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thuchiModelGridControl.Location = new System.Drawing.Point(0, 0);
            this.thuchiModelGridControl.MainView = this.thuchiModelGridView;
            this.thuchiModelGridControl.Name = "thuchiModelGridControl";
            this.thuchiModelGridControl.Size = new System.Drawing.Size(1187, 580);
            this.thuchiModelGridControl.TabIndex = 3;
            this.thuchiModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.thuchiModelGridView});
            // 
            // thuchiModelBindingSource
            // 
            this.thuchiModelBindingSource.DataSource = typeof(B2B.Model.ThuchiModel);
            // 
            // thuchiModelGridView
            // 
            this.thuchiModelGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colThuchiId,
            this.colNhanvienId,
            this.colPhieunhapId,
            this.colPhieuxuatId,
            this.colNhannopTienId,
            this.colVaoluc,
            this.colNgay,
            this.colThang,
            this.colNam,
            this.colStep,
            this.colTongtien,
            this.colVersion,
            this.colGhichu,
            this.colTenNhannopTien,
            this.colTenNhanvien,
            this.colState,
            this.NoGridColumn,
            this.colVaolucGio,
            this.colLoaiThuchi});
            this.thuchiModelGridView.GridControl = this.thuchiModelGridControl;
            this.thuchiModelGridView.Name = "thuchiModelGridView";
            this.thuchiModelGridView.OptionsBehavior.ReadOnly = true;
            this.thuchiModelGridView.OptionsView.ShowAutoFilterRow = true;
            this.thuchiModelGridView.OptionsView.ShowFooter = true;
            this.thuchiModelGridView.OptionsView.ShowGroupPanel = false;
            this.thuchiModelGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.thuchiModelGridView_CustomColumnDisplayText);
            // 
            // colThuchiId
            // 
            this.colThuchiId.FieldName = "ThuchiId";
            this.colThuchiId.Name = "colThuchiId";
            // 
            // colNhanvienId
            // 
            this.colNhanvienId.FieldName = "NhanvienId";
            this.colNhanvienId.Name = "colNhanvienId";
            // 
            // colPhieunhapId
            // 
            this.colPhieunhapId.FieldName = "PhieunhapId";
            this.colPhieunhapId.Name = "colPhieunhapId";
            // 
            // colPhieuxuatId
            // 
            this.colPhieuxuatId.FieldName = "PhieuxuatId";
            this.colPhieuxuatId.Name = "colPhieuxuatId";
            // 
            // colNhannopTienId
            // 
            this.colNhannopTienId.FieldName = "NhannopTienId";
            this.colNhannopTienId.Name = "colNhannopTienId";
            // 
            // colVaoluc
            // 
            this.colVaoluc.Caption = "Thời gian";
            this.colVaoluc.FieldName = "Vaoluc";
            this.colVaoluc.Name = "colVaoluc";
            this.colVaoluc.Width = 136;
            // 
            // colNgay
            // 
            this.colNgay.Caption = "Ngày";
            this.colNgay.FieldName = "Ngay";
            this.colNgay.Name = "colNgay";
            this.colNgay.Visible = true;
            this.colNgay.VisibleIndex = 4;
            this.colNgay.Width = 44;
            // 
            // colThang
            // 
            this.colThang.Caption = "Tháng";
            this.colThang.FieldName = "Thang";
            this.colThang.Name = "colThang";
            this.colThang.Visible = true;
            this.colThang.VisibleIndex = 5;
            this.colThang.Width = 44;
            // 
            // colNam
            // 
            this.colNam.Caption = "Năm";
            this.colNam.FieldName = "Nam";
            this.colNam.Name = "colNam";
            this.colNam.Visible = true;
            this.colNam.VisibleIndex = 6;
            this.colNam.Width = 61;
            // 
            // colStep
            // 
            this.colStep.FieldName = "Step";
            this.colStep.Name = "colStep";
            // 
            // colTongtien
            // 
            this.colTongtien.Caption = "Số tiền thu/chi";
            this.colTongtien.DisplayFormat.FormatString = "{0:n0}";
            this.colTongtien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colTongtien.FieldName = "Tongtien";
            this.colTongtien.Name = "colTongtien";
            this.colTongtien.Visible = true;
            this.colTongtien.VisibleIndex = 2;
            this.colTongtien.Width = 127;
            // 
            // colVersion
            // 
            this.colVersion.FieldName = "Version";
            this.colVersion.Name = "colVersion";
            // 
            // colGhichu
            // 
            this.colGhichu.Caption = "Ghi chú";
            this.colGhichu.FieldName = "Ghichu";
            this.colGhichu.Name = "colGhichu";
            this.colGhichu.Visible = true;
            this.colGhichu.VisibleIndex = 8;
            this.colGhichu.Width = 166;
            // 
            // colTenNhannopTien
            // 
            this.colTenNhannopTien.Caption = "Người nộp/nhận tiền";
            this.colTenNhannopTien.FieldName = "TenNhannopTien";
            this.colTenNhannopTien.Name = "colTenNhannopTien";
            this.colTenNhannopTien.Visible = true;
            this.colTenNhannopTien.VisibleIndex = 1;
            this.colTenNhannopTien.Width = 224;
            // 
            // colTenNhanvien
            // 
            this.colTenNhanvien.Caption = "Người lập phiếu";
            this.colTenNhanvien.FieldName = "TenNhanvien";
            this.colTenNhanvien.Name = "colTenNhanvien";
            this.colTenNhanvien.Visible = true;
            this.colTenNhanvien.VisibleIndex = 7;
            this.colTenNhanvien.Width = 217;
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.OptionsColumn.ReadOnly = true;
            // 
            // NoGridColumn
            // 
            this.NoGridColumn.Caption = "STT";
            this.NoGridColumn.Name = "NoGridColumn";
            this.NoGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.NoGridColumn.Visible = true;
            this.NoGridColumn.VisibleIndex = 0;
            this.NoGridColumn.Width = 53;
            // 
            // colVaolucGio
            // 
            this.colVaolucGio.Caption = "Vào lúc";
            this.colVaolucGio.FieldName = "VaolucGio";
            this.colVaolucGio.Name = "colVaolucGio";
            this.colVaolucGio.Visible = true;
            this.colVaolucGio.VisibleIndex = 3;
            this.colVaolucGio.Width = 133;
            // 
            // colLoaiThuchi
            // 
            this.colLoaiThuchi.Caption = "Loại";
            this.colLoaiThuchi.FieldName = "LoaiThuchi";
            this.colLoaiThuchi.Name = "colLoaiThuchi";
            this.colLoaiThuchi.Visible = true;
            this.colLoaiThuchi.VisibleIndex = 9;
            this.colLoaiThuchi.Width = 100;
            // 
            // BaogiaActionGroupControl
            // 
            this.BaogiaActionGroupControl.Controls.Add(this.exportPhieuthuchiSimpleButton);
            this.BaogiaActionGroupControl.Controls.Add(this.addPhieuchiSimpleButton);
            this.BaogiaActionGroupControl.Controls.Add(this.addPhieuthuSimpleButton);
            this.BaogiaActionGroupControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BaogiaActionGroupControl.Location = new System.Drawing.Point(0, 580);
            this.BaogiaActionGroupControl.Name = "BaogiaActionGroupControl";
            this.BaogiaActionGroupControl.Size = new System.Drawing.Size(1187, 81);
            this.BaogiaActionGroupControl.TabIndex = 4;
            this.BaogiaActionGroupControl.Text = "Thao tác Thu chi";
            // 
            // exportPhieuthuchiSimpleButton
            // 
            this.exportPhieuthuchiSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.exportPhieuthuchiSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("exportPhieuthuchiSimpleButton.Image")));
            this.exportPhieuthuchiSimpleButton.Location = new System.Drawing.Point(1080, 34);
            this.exportPhieuthuchiSimpleButton.Margin = new System.Windows.Forms.Padding(2);
            this.exportPhieuthuchiSimpleButton.Name = "exportPhieuthuchiSimpleButton";
            this.exportPhieuthuchiSimpleButton.Size = new System.Drawing.Size(70, 32);
            this.exportPhieuthuchiSimpleButton.TabIndex = 7;
            this.exportPhieuthuchiSimpleButton.Text = "Review";
            // 
            // addPhieuchiSimpleButton
            // 
            this.addPhieuchiSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addPhieuchiSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("addPhieuchiSimpleButton.Image")));
            this.addPhieuchiSimpleButton.Location = new System.Drawing.Point(964, 34);
            this.addPhieuchiSimpleButton.Margin = new System.Windows.Forms.Padding(2);
            this.addPhieuchiSimpleButton.Name = "addPhieuchiSimpleButton";
            this.addPhieuchiSimpleButton.Size = new System.Drawing.Size(100, 32);
            this.addPhieuchiSimpleButton.TabIndex = 6;
            this.addPhieuchiSimpleButton.Text = "Lập phiếu chi";
            this.addPhieuchiSimpleButton.Click += new System.EventHandler(this.addPhieuchiSimpleButton_Click);
            // 
            // addPhieuthuSimpleButton
            // 
            this.addPhieuthuSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addPhieuthuSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("addPhieuthuSimpleButton.Image")));
            this.addPhieuthuSimpleButton.ImeMode = System.Windows.Forms.ImeMode.On;
            this.addPhieuthuSimpleButton.Location = new System.Drawing.Point(848, 34);
            this.addPhieuthuSimpleButton.Margin = new System.Windows.Forms.Padding(2);
            this.addPhieuthuSimpleButton.Name = "addPhieuthuSimpleButton";
            this.addPhieuthuSimpleButton.Size = new System.Drawing.Size(100, 32);
            this.addPhieuthuSimpleButton.TabIndex = 5;
            this.addPhieuthuSimpleButton.Text = "Lập phiếu thu";
            this.addPhieuthuSimpleButton.Click += new System.EventHandler(this.addPhieuthuSimpleButton_Click);
            // 
            // ThuchiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 661);
            this.Controls.Add(this.thuchiModelGridControl);
            this.Controls.Add(this.BaogiaActionGroupControl);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1203, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1203, 700);
            this.Name = "ThuchiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thu Chi";
            ((System.ComponentModel.ISupportInitialize)(this.thuchiModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuchiModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuchiModelGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaogiaActionGroupControl)).EndInit();
            this.BaogiaActionGroupControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl thuchiModelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView thuchiModelGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colThuchiId;
        private DevExpress.XtraGrid.Columns.GridColumn colNhanvienId;
        private DevExpress.XtraGrid.Columns.GridColumn colPhieunhapId;
        private DevExpress.XtraGrid.Columns.GridColumn colPhieuxuatId;
        private DevExpress.XtraGrid.Columns.GridColumn colNhannopTienId;
        private DevExpress.XtraGrid.Columns.GridColumn colVaoluc;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay;
        private DevExpress.XtraGrid.Columns.GridColumn colThang;
        private DevExpress.XtraGrid.Columns.GridColumn colNam;
        private DevExpress.XtraGrid.Columns.GridColumn colStep;
        private DevExpress.XtraGrid.Columns.GridColumn colTongtien;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colGhichu;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNhannopTien;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNhanvien;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraEditors.GroupControl BaogiaActionGroupControl;
        private DevExpress.XtraEditors.SimpleButton exportPhieuthuchiSimpleButton;
        private DevExpress.XtraEditors.SimpleButton addPhieuchiSimpleButton;
        private DevExpress.XtraEditors.SimpleButton addPhieuthuSimpleButton;
        private System.Windows.Forms.BindingSource thuchiModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn NoGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn colVaolucGio;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiThuchi;
    }
}