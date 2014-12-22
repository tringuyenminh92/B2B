namespace B2B.Forms
{
    partial class TinhthanhQuanhuyenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TinhthanhQuanhuyenForm));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.tinhthanhModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.tinhthanhModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tinhthanhModelGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTinhthanhId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhuvucId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayCapnhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenTinhthanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhichu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKhuvuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.quanhuyenModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.quanhuyenModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanhuyenModelGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colQuanhuyenId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTinhthanhId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStep1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayCapnhat1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenQuanhuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhichu1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Stt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QuanhuyenGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.quanhuyenAddSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.deleteQuanhuyenSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.quanhuyenEditSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.exportQuanhuyenSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.quanhuyenSaveSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tinhthanhModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhthanhModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhthanhModelGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanhuyenModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanhuyenModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanhuyenModelGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanhuyenGroupControl)).BeginInit();
            this.QuanhuyenGroupControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.tinhthanhModelGridControl);
            this.splitContainerControl1.Panel1.MinSize = 700;
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.quanhuyenModelGridControl);
            this.splitContainerControl1.Panel2.Controls.Add(this.QuanhuyenGroupControl);
            this.splitContainerControl1.Panel2.MinSize = 700;
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1975, 812);
            this.splitContainerControl1.SplitterPosition = 700;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // tinhthanhModelGridControl
            // 
            this.tinhthanhModelGridControl.DataSource = this.tinhthanhModelBindingSource;
            this.tinhthanhModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tinhthanhModelGridControl.Location = new System.Drawing.Point(0, 0);
            this.tinhthanhModelGridControl.MainView = this.tinhthanhModelGridView;
            this.tinhthanhModelGridControl.Name = "tinhthanhModelGridControl";
            this.tinhthanhModelGridControl.Size = new System.Drawing.Size(700, 812);
            this.tinhthanhModelGridControl.TabIndex = 0;
            this.tinhthanhModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tinhthanhModelGridView});
            // 
            // tinhthanhModelBindingSource
            // 
            this.tinhthanhModelBindingSource.DataSource = typeof(B2B.Model.TinhthanhModel);
            this.tinhthanhModelBindingSource.PositionChanged += new System.EventHandler(this.tinhthanhModelBindingSource_PositionChanged);
            // 
            // tinhthanhModelGridView
            // 
            this.tinhthanhModelGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTinhthanhId,
            this.colKhuvucId,
            this.colStep,
            this.colNgayCapnhat,
            this.colActive,
            this.colVersion,
            this.colCode,
            this.colTenTinhthanh,
            this.colGhichu,
            this.colTenKhuvuc,
            this.colState,
            this.NoGridColumn});
            this.tinhthanhModelGridView.GridControl = this.tinhthanhModelGridControl;
            this.tinhthanhModelGridView.GroupCount = 1;
            this.tinhthanhModelGridView.Name = "tinhthanhModelGridView";
            this.tinhthanhModelGridView.OptionsView.ShowAutoFilterRow = true;
            this.tinhthanhModelGridView.OptionsView.ShowFooter = true;
            this.tinhthanhModelGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTenKhuvuc, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.tinhthanhModelGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.tinhthanhModelGridView_CustomColumnDisplayText);
            // 
            // colTinhthanhId
            // 
            this.colTinhthanhId.FieldName = "TinhthanhId";
            this.colTinhthanhId.Name = "colTinhthanhId";
            // 
            // colKhuvucId
            // 
            this.colKhuvucId.FieldName = "KhuvucId";
            this.colKhuvucId.Name = "colKhuvucId";
            // 
            // colStep
            // 
            this.colStep.FieldName = "Step";
            this.colStep.Name = "colStep";
            // 
            // colNgayCapnhat
            // 
            this.colNgayCapnhat.Caption = "Ngày cập nhật";
            this.colNgayCapnhat.FieldName = "NgayCapnhat";
            this.colNgayCapnhat.Name = "colNgayCapnhat";
            this.colNgayCapnhat.Visible = true;
            this.colNgayCapnhat.VisibleIndex = 4;
            this.colNgayCapnhat.Width = 112;
            // 
            // colActive
            // 
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 3;
            this.colActive.Width = 105;
            // 
            // colVersion
            // 
            this.colVersion.FieldName = "Version";
            this.colVersion.Name = "colVersion";
            // 
            // colCode
            // 
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 1;
            this.colCode.Width = 146;
            // 
            // colTenTinhthanh
            // 
            this.colTenTinhthanh.Caption = "Tỉnh thành";
            this.colTenTinhthanh.FieldName = "TenTinhthanh";
            this.colTenTinhthanh.Name = "colTenTinhthanh";
            this.colTenTinhthanh.Visible = true;
            this.colTenTinhthanh.VisibleIndex = 2;
            this.colTenTinhthanh.Width = 229;
            // 
            // colGhichu
            // 
            this.colGhichu.FieldName = "Ghichu";
            this.colGhichu.Name = "colGhichu";
            // 
            // colTenKhuvuc
            // 
            this.colTenKhuvuc.Caption = "Khu vực";
            this.colTenKhuvuc.FieldName = "TenKhuvuc";
            this.colTenKhuvuc.Name = "colTenKhuvuc";
            this.colTenKhuvuc.Visible = true;
            this.colTenKhuvuc.VisibleIndex = 6;
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
            this.NoGridColumn.Width = 90;
            // 
            // quanhuyenModelGridControl
            // 
            this.quanhuyenModelGridControl.DataSource = this.quanhuyenModelBindingSource;
            this.quanhuyenModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quanhuyenModelGridControl.Location = new System.Drawing.Point(0, 0);
            this.quanhuyenModelGridControl.MainView = this.quanhuyenModelGridView;
            this.quanhuyenModelGridControl.Name = "quanhuyenModelGridControl";
            this.quanhuyenModelGridControl.Size = new System.Drawing.Size(1269, 676);
            this.quanhuyenModelGridControl.TabIndex = 1;
            this.quanhuyenModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.quanhuyenModelGridView});
            // 
            // quanhuyenModelBindingSource
            // 
            this.quanhuyenModelBindingSource.DataSource = typeof(B2B.Model.QuanhuyenModel);
            // 
            // quanhuyenModelGridView
            // 
            this.quanhuyenModelGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colQuanhuyenId,
            this.colTinhthanhId1,
            this.colStep1,
            this.colNgayCapnhat1,
            this.colActive1,
            this.colVersion1,
            this.colCode1,
            this.colTenQuanhuyen,
            this.colGhichu1,
            this.colState1,
            this.Stt});
            this.quanhuyenModelGridView.GridControl = this.quanhuyenModelGridControl;
            this.quanhuyenModelGridView.Name = "quanhuyenModelGridView";
            this.quanhuyenModelGridView.OptionsBehavior.Editable = false;
            this.quanhuyenModelGridView.OptionsView.ShowAutoFilterRow = true;
            this.quanhuyenModelGridView.OptionsView.ShowFooter = true;
            this.quanhuyenModelGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.quanhuyenModelGridView_CustomColumnDisplayText);
            // 
            // colQuanhuyenId
            // 
            this.colQuanhuyenId.FieldName = "QuanhuyenId";
            this.colQuanhuyenId.Name = "colQuanhuyenId";
            // 
            // colTinhthanhId1
            // 
            this.colTinhthanhId1.FieldName = "TinhthanhId";
            this.colTinhthanhId1.Name = "colTinhthanhId1";
            // 
            // colStep1
            // 
            this.colStep1.FieldName = "Step";
            this.colStep1.Name = "colStep1";
            // 
            // colNgayCapnhat1
            // 
            this.colNgayCapnhat1.Caption = "Ngày cập nhật";
            this.colNgayCapnhat1.FieldName = "NgayCapnhat";
            this.colNgayCapnhat1.Name = "colNgayCapnhat1";
            this.colNgayCapnhat1.Visible = true;
            this.colNgayCapnhat1.VisibleIndex = 5;
            this.colNgayCapnhat1.Width = 159;
            // 
            // colActive1
            // 
            this.colActive1.FieldName = "Active";
            this.colActive1.Name = "colActive1";
            this.colActive1.Visible = true;
            this.colActive1.VisibleIndex = 3;
            this.colActive1.Width = 159;
            // 
            // colVersion1
            // 
            this.colVersion1.FieldName = "Version";
            this.colVersion1.Name = "colVersion1";
            // 
            // colCode1
            // 
            this.colCode1.FieldName = "Code";
            this.colCode1.Name = "colCode1";
            this.colCode1.Visible = true;
            this.colCode1.VisibleIndex = 1;
            this.colCode1.Width = 191;
            // 
            // colTenQuanhuyen
            // 
            this.colTenQuanhuyen.Caption = "Quận huyện";
            this.colTenQuanhuyen.FieldName = "TenQuanhuyen";
            this.colTenQuanhuyen.Name = "colTenQuanhuyen";
            this.colTenQuanhuyen.Visible = true;
            this.colTenQuanhuyen.VisibleIndex = 2;
            this.colTenQuanhuyen.Width = 314;
            // 
            // colGhichu1
            // 
            this.colGhichu1.Caption = "Ghi chú";
            this.colGhichu1.FieldName = "Ghichu";
            this.colGhichu1.Name = "colGhichu1";
            this.colGhichu1.Visible = true;
            this.colGhichu1.VisibleIndex = 4;
            this.colGhichu1.Width = 159;
            // 
            // colState1
            // 
            this.colState1.FieldName = "State";
            this.colState1.Name = "colState1";
            this.colState1.OptionsColumn.ReadOnly = true;
            this.colState1.Visible = true;
            this.colState1.VisibleIndex = 6;
            this.colState1.Width = 171;
            // 
            // Stt
            // 
            this.Stt.Caption = "STT";
            this.Stt.Name = "Stt";
            this.Stt.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.Stt.Visible = true;
            this.Stt.VisibleIndex = 0;
            this.Stt.Width = 99;
            // 
            // QuanhuyenGroupControl
            // 
            this.QuanhuyenGroupControl.Controls.Add(this.quanhuyenAddSimpleButton);
            this.QuanhuyenGroupControl.Controls.Add(this.deleteQuanhuyenSimpleButton);
            this.QuanhuyenGroupControl.Controls.Add(this.quanhuyenEditSimpleButton);
            this.QuanhuyenGroupControl.Controls.Add(this.exportQuanhuyenSimpleButton);
            this.QuanhuyenGroupControl.Controls.Add(this.quanhuyenSaveSimpleButton);
            this.QuanhuyenGroupControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.QuanhuyenGroupControl.Location = new System.Drawing.Point(0, 676);
            this.QuanhuyenGroupControl.Name = "QuanhuyenGroupControl";
            this.QuanhuyenGroupControl.Size = new System.Drawing.Size(1269, 136);
            this.QuanhuyenGroupControl.TabIndex = 0;
            this.QuanhuyenGroupControl.Text = "Thao tác Quận huyện";
            // 
            // quanhuyenAddSimpleButton
            // 
            this.quanhuyenAddSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.quanhuyenAddSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("quanhuyenAddSimpleButton.Image")));
            this.quanhuyenAddSimpleButton.Location = new System.Drawing.Point(328, 52);
            this.quanhuyenAddSimpleButton.Name = "quanhuyenAddSimpleButton";
            this.quanhuyenAddSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.quanhuyenAddSimpleButton.TabIndex = 22;
            this.quanhuyenAddSimpleButton.Text = "Thêm";
            this.quanhuyenAddSimpleButton.Click += new System.EventHandler(this.quanhuyenAddSimpleButton_Click);
            // 
            // deleteQuanhuyenSimpleButton
            // 
            this.deleteQuanhuyenSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deleteQuanhuyenSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteQuanhuyenSimpleButton.Image")));
            this.deleteQuanhuyenSimpleButton.Location = new System.Drawing.Point(30, 52);
            this.deleteQuanhuyenSimpleButton.Name = "deleteQuanhuyenSimpleButton";
            this.deleteQuanhuyenSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.deleteQuanhuyenSimpleButton.TabIndex = 23;
            this.deleteQuanhuyenSimpleButton.Text = "Xóa";
            this.deleteQuanhuyenSimpleButton.Click += new System.EventHandler(this.deleteQuanhuyenSimpleButton_Click);
            // 
            // quanhuyenEditSimpleButton
            // 
            this.quanhuyenEditSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.quanhuyenEditSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("quanhuyenEditSimpleButton.Image")));
            this.quanhuyenEditSimpleButton.Location = new System.Drawing.Point(952, 52);
            this.quanhuyenEditSimpleButton.Name = "quanhuyenEditSimpleButton";
            this.quanhuyenEditSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.quanhuyenEditSimpleButton.TabIndex = 20;
            this.quanhuyenEditSimpleButton.Text = "Sửa";
            this.quanhuyenEditSimpleButton.Click += new System.EventHandler(this.quanhuyenEditSimpleButton_Click);
            // 
            // exportQuanhuyenSimpleButton
            // 
            this.exportQuanhuyenSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.exportQuanhuyenSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("exportQuanhuyenSimpleButton.Image")));
            this.exportQuanhuyenSimpleButton.Location = new System.Drawing.Point(179, 52);
            this.exportQuanhuyenSimpleButton.Name = "exportQuanhuyenSimpleButton";
            this.exportQuanhuyenSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.exportQuanhuyenSimpleButton.TabIndex = 21;
            this.exportQuanhuyenSimpleButton.Text = "Excel";
            this.exportQuanhuyenSimpleButton.Click += new System.EventHandler(this.exportQuanhuyenSimpleButton_Click);
            // 
            // quanhuyenSaveSimpleButton
            // 
            this.quanhuyenSaveSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.quanhuyenSaveSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("quanhuyenSaveSimpleButton.Image")));
            this.quanhuyenSaveSimpleButton.Location = new System.Drawing.Point(1097, 52);
            this.quanhuyenSaveSimpleButton.Name = "quanhuyenSaveSimpleButton";
            this.quanhuyenSaveSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.quanhuyenSaveSimpleButton.TabIndex = 19;
            this.quanhuyenSaveSimpleButton.Text = "Lưu";
            this.quanhuyenSaveSimpleButton.Click += new System.EventHandler(this.quanhuyenSaveSimpleButton_Click);
            // 
            // TinhthanhQuanhuyenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1975, 812);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "TinhthanhQuanhuyenForm";
            this.Text = "Tỉnh thành - Quận Huyện";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tinhthanhModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhthanhModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhthanhModelGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanhuyenModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanhuyenModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanhuyenModelGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanhuyenGroupControl)).EndInit();
            this.QuanhuyenGroupControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl QuanhuyenGroupControl;
        private DevExpress.XtraEditors.SimpleButton quanhuyenAddSimpleButton;
        private DevExpress.XtraEditors.SimpleButton deleteQuanhuyenSimpleButton;
        private DevExpress.XtraEditors.SimpleButton quanhuyenEditSimpleButton;
        private DevExpress.XtraEditors.SimpleButton exportQuanhuyenSimpleButton;
        private DevExpress.XtraEditors.SimpleButton quanhuyenSaveSimpleButton;
        private DevExpress.XtraGrid.GridControl tinhthanhModelGridControl;
        private System.Windows.Forms.BindingSource tinhthanhModelBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView tinhthanhModelGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colTinhthanhId;
        private DevExpress.XtraGrid.Columns.GridColumn colKhuvucId;
        private DevExpress.XtraGrid.Columns.GridColumn colStep;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayCapnhat;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTinhthanh;
        private DevExpress.XtraGrid.Columns.GridColumn colGhichu;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraGrid.GridControl quanhuyenModelGridControl;
        private System.Windows.Forms.BindingSource quanhuyenModelBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView quanhuyenModelGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKhuvuc;
        private DevExpress.XtraGrid.Columns.GridColumn NoGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn colQuanhuyenId;
        private DevExpress.XtraGrid.Columns.GridColumn colTinhthanhId1;
        private DevExpress.XtraGrid.Columns.GridColumn colStep1;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayCapnhat1;
        private DevExpress.XtraGrid.Columns.GridColumn colActive1;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion1;
        private DevExpress.XtraGrid.Columns.GridColumn colCode1;
        private DevExpress.XtraGrid.Columns.GridColumn colTenQuanhuyen;
        private DevExpress.XtraGrid.Columns.GridColumn colGhichu1;
        private DevExpress.XtraGrid.Columns.GridColumn colState1;
        private DevExpress.XtraGrid.Columns.GridColumn Stt;
    }
}