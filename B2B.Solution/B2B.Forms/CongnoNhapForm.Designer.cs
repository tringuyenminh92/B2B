namespace B2B.Forms
{
    partial class CongnoNhapForm
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
            this.congnoNhapModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.congnoNhapModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.congnoNhapModelGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NoGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCongnoNhapId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaCungcapId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhanvienId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayGiaodich = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayHentra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoduTruocGiaodich = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSotienGiaodich = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhichu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNhaCungcap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNhanvien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.congnoNhapModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.congnoNhapModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.congnoNhapModelGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // congnoNhapModelBindingSource
            // 
            this.congnoNhapModelBindingSource.DataSource = typeof(B2B.Model.CongnoNhapModel);
            // 
            // congnoNhapModelGridControl
            // 
            this.congnoNhapModelGridControl.DataSource = this.congnoNhapModelBindingSource;
            this.congnoNhapModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.congnoNhapModelGridControl.Location = new System.Drawing.Point(0, 0);
            this.congnoNhapModelGridControl.MainView = this.congnoNhapModelGridView;
            this.congnoNhapModelGridControl.Name = "congnoNhapModelGridControl";
            this.congnoNhapModelGridControl.Size = new System.Drawing.Size(849, 378);
            this.congnoNhapModelGridControl.TabIndex = 6;
            this.congnoNhapModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.congnoNhapModelGridView});
            // 
            // congnoNhapModelGridView
            // 
            this.congnoNhapModelGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NoGridColumn,
            this.colCongnoNhapId,
            this.colNhaCungcapId,
            this.colNhanvienId,
            this.colStep,
            this.colNgayGiaodich,
            this.colNgayHentra,
            this.colSoduTruocGiaodich,
            this.colSotienGiaodich,
            this.colTongno,
            this.colVersion,
            this.colGhichu,
            this.colTenNhaCungcap,
            this.colTenNhanvien,
            this.colState});
            this.congnoNhapModelGridView.GridControl = this.congnoNhapModelGridControl;
            this.congnoNhapModelGridView.Name = "congnoNhapModelGridView";
            this.congnoNhapModelGridView.OptionsView.ShowAutoFilterRow = true;
            this.congnoNhapModelGridView.OptionsView.ShowFooter = true;
            this.congnoNhapModelGridView.OptionsView.ShowGroupPanel = false;
            this.congnoNhapModelGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTongno, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.congnoNhapModelGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.congnoNhapModelGridView_CustomColumnDisplayText);
            // 
            // NoGridColumn
            // 
            this.NoGridColumn.Caption = "STT";
            this.NoGridColumn.Name = "NoGridColumn";
            this.NoGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.NoGridColumn.Visible = true;
            this.NoGridColumn.VisibleIndex = 0;
            this.NoGridColumn.Width = 61;
            // 
            // colCongnoNhapId
            // 
            this.colCongnoNhapId.FieldName = "CongnoNhapId";
            this.colCongnoNhapId.Name = "colCongnoNhapId";
            // 
            // colNhaCungcapId
            // 
            this.colNhaCungcapId.FieldName = "NhaCungcapId";
            this.colNhaCungcapId.Name = "colNhaCungcapId";
            // 
            // colNhanvienId
            // 
            this.colNhanvienId.FieldName = "NhanvienId";
            this.colNhanvienId.Name = "colNhanvienId";
            // 
            // colStep
            // 
            this.colStep.FieldName = "Step";
            this.colStep.Name = "colStep";
            // 
            // colNgayGiaodich
            // 
            this.colNgayGiaodich.Caption = "Ngày giao dịch";
            this.colNgayGiaodich.FieldName = "NgayGiaodich";
            this.colNgayGiaodich.Name = "colNgayGiaodich";
            this.colNgayGiaodich.Visible = true;
            this.colNgayGiaodich.VisibleIndex = 1;
            this.colNgayGiaodich.Width = 110;
            // 
            // colNgayHentra
            // 
            this.colNgayHentra.Caption = "Ngày hẹn trả";
            this.colNgayHentra.FieldName = "NgayHentra";
            this.colNgayHentra.Name = "colNgayHentra";
            // 
            // colSoduTruocGiaodich
            // 
            this.colSoduTruocGiaodich.Caption = "Số dư trước giao dịch";
            this.colSoduTruocGiaodich.FieldName = "SoduTruocGiaodich";
            this.colSoduTruocGiaodich.Name = "colSoduTruocGiaodich";
            this.colSoduTruocGiaodich.Visible = true;
            this.colSoduTruocGiaodich.VisibleIndex = 4;
            this.colSoduTruocGiaodich.Width = 140;
            // 
            // colSotienGiaodich
            // 
            this.colSotienGiaodich.Caption = "Số tiền giao dịch";
            this.colSotienGiaodich.FieldName = "SotienGiaodich";
            this.colSotienGiaodich.Name = "colSotienGiaodich";
            this.colSotienGiaodich.Visible = true;
            this.colSotienGiaodich.VisibleIndex = 3;
            this.colSotienGiaodich.Width = 127;
            // 
            // colTongno
            // 
            this.colTongno.Caption = "Tổng nợ";
            this.colTongno.FieldName = "Tongno";
            this.colTongno.Name = "colTongno";
            this.colTongno.Visible = true;
            this.colTongno.VisibleIndex = 5;
            this.colTongno.Width = 134;
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
            this.colGhichu.VisibleIndex = 7;
            this.colGhichu.Width = 135;
            // 
            // colTenNhaCungcap
            // 
            this.colTenNhaCungcap.Caption = "Nhà cung cấp";
            this.colTenNhaCungcap.FieldName = "TenNhaCungcap";
            this.colTenNhaCungcap.Name = "colTenNhaCungcap";
            this.colTenNhaCungcap.Visible = true;
            this.colTenNhaCungcap.VisibleIndex = 2;
            this.colTenNhaCungcap.Width = 162;
            // 
            // colTenNhanvien
            // 
            this.colTenNhanvien.Caption = "Nhân viên";
            this.colTenNhanvien.FieldName = "TenNhanvien";
            this.colTenNhanvien.Name = "colTenNhanvien";
            this.colTenNhanvien.Visible = true;
            this.colTenNhanvien.VisibleIndex = 6;
            this.colTenNhanvien.Width = 175;
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.OptionsColumn.ReadOnly = true;
            // 
            // CongnoNhapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 378);
            this.Controls.Add(this.congnoNhapModelGridControl);
            this.Name = "CongnoNhapForm";
            this.Text = "Công nợ nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.congnoNhapModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.congnoNhapModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.congnoNhapModelGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource congnoNhapModelBindingSource;
        private DevExpress.XtraGrid.GridControl congnoNhapModelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView congnoNhapModelGridView;
        private DevExpress.XtraGrid.Columns.GridColumn NoGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn colCongnoNhapId;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaCungcapId;
        private DevExpress.XtraGrid.Columns.GridColumn colNhanvienId;
        private DevExpress.XtraGrid.Columns.GridColumn colStep;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayGiaodich;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayHentra;
        private DevExpress.XtraGrid.Columns.GridColumn colSoduTruocGiaodich;
        private DevExpress.XtraGrid.Columns.GridColumn colSotienGiaodich;
        private DevExpress.XtraGrid.Columns.GridColumn colTongno;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colGhichu;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNhaCungcap;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNhanvien;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
    }
}