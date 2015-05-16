namespace B2B.Forms
{
    partial class CongnoXuatForm
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CongnoXuatForm));
            this.congnoXuatModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.congnoXuatModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.congnoXuatModelBandedGridView = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.NoGridColumn = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCongnoXuatId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colKhachhangId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colHotenKhachhang = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colDienthoai = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colDiachi = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colNgayGiaodich = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSoduTruocGiaodich = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSotienGiaodich = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTongno = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colNhanvienId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colStep = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colNgayhenTra = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colHovatenNhanvien = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colGhichu = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colVersion = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colState = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.HanghoaActionGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.detailCongnoXuatSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.congnoXuatModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.congnoXuatModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.congnoXuatModelBandedGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HanghoaActionGroupControl)).BeginInit();
            this.HanghoaActionGroupControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // congnoXuatModelBindingSource
            // 
            this.congnoXuatModelBindingSource.DataSource = typeof(B2B.Model.CongnoXuatModel);
            // 
            // congnoXuatModelGridControl
            // 
            this.congnoXuatModelGridControl.DataSource = this.congnoXuatModelBindingSource;
            this.congnoXuatModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.congnoXuatModelGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.congnoXuatModelGridControl.Location = new System.Drawing.Point(0, 0);
            this.congnoXuatModelGridControl.MainView = this.congnoXuatModelBandedGridView;
            this.congnoXuatModelGridControl.Name = "congnoXuatModelGridControl";
            this.congnoXuatModelGridControl.Size = new System.Drawing.Size(1268, 661);
            this.congnoXuatModelGridControl.TabIndex = 1;
            this.congnoXuatModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.congnoXuatModelBandedGridView});
            // 
            // congnoXuatModelBandedGridView
            // 
            this.congnoXuatModelBandedGridView.Appearance.OddRow.BackColor = System.Drawing.Color.LightCyan;
            this.congnoXuatModelBandedGridView.Appearance.OddRow.Options.UseBackColor = true;
            this.congnoXuatModelBandedGridView.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3});
            this.congnoXuatModelBandedGridView.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colCongnoXuatId,
            this.colKhachhangId,
            this.colDienthoai,
            this.colDiachi,
            this.colNgayGiaodich,
            this.colSoduTruocGiaodich,
            this.colSotienGiaodich,
            this.colTongno,
            this.colNgayhenTra,
            this.colNhanvienId,
            this.colGhichu,
            this.colStep,
            this.colVersion,
            this.colHotenKhachhang,
            this.colHovatenNhanvien,
            this.colState,
            this.NoGridColumn});
            this.congnoXuatModelBandedGridView.GridControl = this.congnoXuatModelGridControl;
            this.congnoXuatModelBandedGridView.Name = "congnoXuatModelBandedGridView";
            this.congnoXuatModelBandedGridView.OptionsBehavior.ReadOnly = true;
            this.congnoXuatModelBandedGridView.OptionsView.EnableAppearanceOddRow = true;
            this.congnoXuatModelBandedGridView.OptionsView.ShowAutoFilterRow = true;
            this.congnoXuatModelBandedGridView.OptionsView.ShowFooter = true;
            this.congnoXuatModelBandedGridView.OptionsView.ShowGroupPanel = false;
            this.congnoXuatModelBandedGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.congnoXuatModelBandedGridView_CustomColumnDisplayText);
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Thông tin khách hàng";
            this.gridBand1.Columns.Add(this.NoGridColumn);
            this.gridBand1.Columns.Add(this.colCongnoXuatId);
            this.gridBand1.Columns.Add(this.colKhachhangId);
            this.gridBand1.Columns.Add(this.colHotenKhachhang);
            this.gridBand1.Columns.Add(this.colDienthoai);
            this.gridBand1.Columns.Add(this.colDiachi);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 458;
            // 
            // NoGridColumn
            // 
            this.NoGridColumn.Caption = "STT";
            this.NoGridColumn.Name = "NoGridColumn";
            this.NoGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.NoGridColumn.Visible = true;
            this.NoGridColumn.Width = 38;
            // 
            // colCongnoXuatId
            // 
            this.colCongnoXuatId.FieldName = "CongnoXuatId";
            this.colCongnoXuatId.Name = "colCongnoXuatId";
            this.colCongnoXuatId.Width = 20;
            // 
            // colKhachhangId
            // 
            this.colKhachhangId.FieldName = "KhachhangId";
            this.colKhachhangId.Name = "colKhachhangId";
            this.colKhachhangId.Width = 20;
            // 
            // colHotenKhachhang
            // 
            this.colHotenKhachhang.Caption = "Khách hàng";
            this.colHotenKhachhang.FieldName = "TenKhachhang";
            this.colHotenKhachhang.Name = "colHotenKhachhang";
            this.colHotenKhachhang.Visible = true;
            this.colHotenKhachhang.Width = 188;
            // 
            // colDienthoai
            // 
            this.colDienthoai.Caption = "Điện thoại";
            this.colDienthoai.FieldName = "Dienthoai";
            this.colDienthoai.Name = "colDienthoai";
            this.colDienthoai.Visible = true;
            this.colDienthoai.Width = 106;
            // 
            // colDiachi
            // 
            this.colDiachi.Caption = "Địa chỉ";
            this.colDiachi.FieldName = "Diachi";
            this.colDiachi.Name = "colDiachi";
            this.colDiachi.Visible = true;
            this.colDiachi.Width = 126;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Thông tin công nợ";
            this.gridBand2.Columns.Add(this.colNgayGiaodich);
            this.gridBand2.Columns.Add(this.colSoduTruocGiaodich);
            this.gridBand2.Columns.Add(this.colSotienGiaodich);
            this.gridBand2.Columns.Add(this.colTongno);
            this.gridBand2.Columns.Add(this.colNhanvienId);
            this.gridBand2.Columns.Add(this.colStep);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 383;
            // 
            // colNgayGiaodich
            // 
            this.colNgayGiaodich.Caption = "Ngày giao dịch";
            this.colNgayGiaodich.FieldName = "NgayGiaodich";
            this.colNgayGiaodich.Name = "colNgayGiaodich";
            this.colNgayGiaodich.Visible = true;
            this.colNgayGiaodich.Width = 82;
            // 
            // colSoduTruocGiaodich
            // 
            this.colSoduTruocGiaodich.Caption = "Dư trước giao dịch";
            this.colSoduTruocGiaodich.FieldName = "SoduTruocGiaodich";
            this.colSoduTruocGiaodich.Name = "colSoduTruocGiaodich";
            this.colSoduTruocGiaodich.Visible = true;
            this.colSoduTruocGiaodich.Width = 101;
            // 
            // colSotienGiaodich
            // 
            this.colSotienGiaodich.Caption = "Số tiền giao dịch";
            this.colSotienGiaodich.FieldName = "SotienGiaodich";
            this.colSotienGiaodich.Name = "colSotienGiaodich";
            this.colSotienGiaodich.Visible = true;
            this.colSotienGiaodich.Width = 89;
            // 
            // colTongno
            // 
            this.colTongno.Caption = "Tổng nợ";
            this.colTongno.FieldName = "Tongno";
            this.colTongno.Name = "colTongno";
            this.colTongno.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tongno", "{0:n0}")});
            this.colTongno.Visible = true;
            this.colTongno.Width = 111;
            // 
            // colNhanvienId
            // 
            this.colNhanvienId.FieldName = "NhanvienId";
            this.colNhanvienId.Name = "colNhanvienId";
            this.colNhanvienId.Width = 20;
            // 
            // colStep
            // 
            this.colStep.FieldName = "Step";
            this.colStep.Name = "colStep";
            this.colStep.Width = 20;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Thông tin";
            this.gridBand3.Columns.Add(this.colNgayhenTra);
            this.gridBand3.Columns.Add(this.colHovatenNhanvien);
            this.gridBand3.Columns.Add(this.colGhichu);
            this.gridBand3.Columns.Add(this.colVersion);
            this.gridBand3.Columns.Add(this.colState);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 407;
            // 
            // colNgayhenTra
            // 
            this.colNgayhenTra.Caption = "Ngày hẹn trả";
            this.colNgayhenTra.FieldName = "NgayhenTra";
            this.colNgayhenTra.Name = "colNgayhenTra";
            this.colNgayhenTra.Visible = true;
            this.colNgayhenTra.Width = 73;
            // 
            // colHovatenNhanvien
            // 
            this.colHovatenNhanvien.Caption = "Nhân viên";
            this.colHovatenNhanvien.FieldName = "TenNhanvien";
            this.colHovatenNhanvien.Name = "colHovatenNhanvien";
            this.colHovatenNhanvien.Visible = true;
            this.colHovatenNhanvien.Width = 191;
            // 
            // colGhichu
            // 
            this.colGhichu.Caption = "Ghi chú";
            this.colGhichu.FieldName = "Ghichu";
            this.colGhichu.Name = "colGhichu";
            this.colGhichu.Visible = true;
            this.colGhichu.Width = 143;
            // 
            // colVersion
            // 
            this.colVersion.FieldName = "Version";
            this.colVersion.Name = "colVersion";
            this.colVersion.Width = 20;
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.OptionsColumn.ReadOnly = true;
            this.colState.Width = 20;
            // 
            // HanghoaActionGroupControl
            // 
            this.HanghoaActionGroupControl.Controls.Add(this.detailCongnoXuatSimpleButton);
            this.HanghoaActionGroupControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HanghoaActionGroupControl.Location = new System.Drawing.Point(0, 661);
            this.HanghoaActionGroupControl.Margin = new System.Windows.Forms.Padding(2);
            this.HanghoaActionGroupControl.Name = "HanghoaActionGroupControl";
            this.HanghoaActionGroupControl.Size = new System.Drawing.Size(1268, 72);
            this.HanghoaActionGroupControl.TabIndex = 4;
            this.HanghoaActionGroupControl.Text = "Thao tác Phiếu xuất";
            // 
            // detailCongnoXuatSimpleButton
            // 
            this.detailCongnoXuatSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.detailCongnoXuatSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("detailCongnoXuatSimpleButton.Image")));
            this.detailCongnoXuatSimpleButton.Location = new System.Drawing.Point(1112, 27);
            this.detailCongnoXuatSimpleButton.Margin = new System.Windows.Forms.Padding(2);
            this.detailCongnoXuatSimpleButton.Name = "detailCongnoXuatSimpleButton";
            this.detailCongnoXuatSimpleButton.Size = new System.Drawing.Size(70, 32);
            this.detailCongnoXuatSimpleButton.TabIndex = 4;
            this.detailCongnoXuatSimpleButton.Text = "Chi tiết";
            // 
            // CongnoXuatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 733);
            this.Controls.Add(this.congnoXuatModelGridControl);
            this.Controls.Add(this.HanghoaActionGroupControl);
            this.Name = "CongnoXuatForm";
            this.Text = "Công nợ xuất";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.congnoXuatModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.congnoXuatModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.congnoXuatModelBandedGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HanghoaActionGroupControl)).EndInit();
            this.HanghoaActionGroupControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource congnoXuatModelBindingSource;
        private DevExpress.XtraGrid.GridControl congnoXuatModelGridControl;
        private DevExpress.XtraEditors.GroupControl HanghoaActionGroupControl;
        private DevExpress.XtraEditors.SimpleButton detailCongnoXuatSimpleButton;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView congnoXuatModelBandedGridView;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn NoGridColumn;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCongnoXuatId;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colKhachhangId;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colHotenKhachhang;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDienthoai;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDiachi;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNgayGiaodich;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSoduTruocGiaodich;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSotienGiaodich;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTongno;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNhanvienId;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colStep;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNgayhenTra;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colHovatenNhanvien;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colGhichu;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colVersion;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colState;
    }
}