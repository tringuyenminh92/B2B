namespace B2B.Forms
{
    partial class KhuvucTinhthanhForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhuvucTinhthanhForm));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.khuvucModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.khuvucModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khuvucModelGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKhuvucId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayCapnhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKhuvuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhichu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.noKhuvucGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RegionGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.exportRegionSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.addRegionSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.editRegionSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveRegionSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.deleteRegionSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.tinhthanhModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.tinhthanhModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tinhthanhModelGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTinhthanhId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhuvucId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStep1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayCapnhat1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenTinhthanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhichu1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colState1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.noTinhthanhGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProvinceGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.addProvinceSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.deleteProvinceSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.exportProvinceSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveProvinceSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.editProvinceSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khuvucModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khuvucModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khuvucModelGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegionGroupControl)).BeginInit();
            this.RegionGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tinhthanhModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhthanhModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhthanhModelGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProvinceGroupControl)).BeginInit();
            this.ProvinceGroupControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.khuvucModelGridControl);
            this.splitContainerControl1.Panel1.Controls.Add(this.RegionGroupControl);
            this.splitContainerControl1.Panel1.MinSize = 700;
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.tinhthanhModelGridControl);
            this.splitContainerControl1.Panel2.Controls.Add(this.ProvinceGroupControl);
            this.splitContainerControl1.Panel2.MinSize = 700;
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1978, 845);
            this.splitContainerControl1.SplitterPosition = 977;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // khuvucModelGridControl
            // 
            this.khuvucModelGridControl.DataSource = this.khuvucModelBindingSource;
            this.khuvucModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.khuvucModelGridControl.Location = new System.Drawing.Point(0, 0);
            this.khuvucModelGridControl.MainView = this.khuvucModelGridView;
            this.khuvucModelGridControl.Name = "khuvucModelGridControl";
            this.khuvucModelGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit2});
            this.khuvucModelGridControl.Size = new System.Drawing.Size(977, 706);
            this.khuvucModelGridControl.TabIndex = 12;
            this.khuvucModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.khuvucModelGridView});
            // 
            // khuvucModelBindingSource
            // 
            this.khuvucModelBindingSource.DataSource = typeof(B2B.Model.KhuvucModel);
            this.khuvucModelBindingSource.PositionChanged += new System.EventHandler(this.khuvucModelBindingSource_PositionChanged);
            // 
            // khuvucModelGridView
            // 
            this.khuvucModelGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKhuvucId,
            this.colStep,
            this.colNgayCapnhat,
            this.colActive,
            this.colVersion,
            this.colCode,
            this.colTenKhuvuc,
            this.colGhichu,
            this.colState,
            this.noKhuvucGridColumn});
            this.khuvucModelGridView.GridControl = this.khuvucModelGridControl;
            this.khuvucModelGridView.Name = "khuvucModelGridView";
            this.khuvucModelGridView.OptionsBehavior.Editable = false;
            this.khuvucModelGridView.OptionsView.ShowAutoFilterRow = true;
            this.khuvucModelGridView.OptionsView.ShowFooter = true;
            this.khuvucModelGridView.OptionsView.ShowGroupPanel = false;
            this.khuvucModelGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.khuvucModelGridView_CustomColumnDisplayText);
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
            this.colNgayCapnhat.OptionsColumn.AllowEdit = false;
            this.colNgayCapnhat.Visible = true;
            this.colNgayCapnhat.VisibleIndex = 4;
            this.colNgayCapnhat.Width = 126;
            // 
            // colActive
            // 
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 3;
            this.colActive.Width = 126;
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
            this.colCode.Width = 137;
            // 
            // colTenKhuvuc
            // 
            this.colTenKhuvuc.Caption = "Khu vực";
            this.colTenKhuvuc.FieldName = "TenKhuvuc";
            this.colTenKhuvuc.Name = "colTenKhuvuc";
            this.colTenKhuvuc.Visible = true;
            this.colTenKhuvuc.VisibleIndex = 2;
            this.colTenKhuvuc.Width = 181;
            // 
            // colGhichu
            // 
            this.colGhichu.Caption = "Ghi chú";
            this.colGhichu.ColumnEdit = this.repositoryItemMemoEdit2;
            this.colGhichu.FieldName = "Ghichu";
            this.colGhichu.Name = "colGhichu";
            this.colGhichu.Visible = true;
            this.colGhichu.VisibleIndex = 5;
            this.colGhichu.Width = 126;
            // 
            // repositoryItemMemoEdit2
            // 
            this.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2";
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.OptionsColumn.ReadOnly = true;
            this.colState.Visible = true;
            this.colState.VisibleIndex = 6;
            this.colState.Width = 126;
            // 
            // noKhuvucGridColumn
            // 
            this.noKhuvucGridColumn.Caption = "STT";
            this.noKhuvucGridColumn.Name = "noKhuvucGridColumn";
            this.noKhuvucGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.noKhuvucGridColumn.Visible = true;
            this.noKhuvucGridColumn.VisibleIndex = 0;
            this.noKhuvucGridColumn.Width = 137;
            // 
            // RegionGroupControl
            // 
            this.RegionGroupControl.Controls.Add(this.exportRegionSimpleButton);
            this.RegionGroupControl.Controls.Add(this.addRegionSimpleButton);
            this.RegionGroupControl.Controls.Add(this.editRegionSimpleButton);
            this.RegionGroupControl.Controls.Add(this.saveRegionSimpleButton);
            this.RegionGroupControl.Controls.Add(this.deleteRegionSimpleButton);
            this.RegionGroupControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RegionGroupControl.Location = new System.Drawing.Point(0, 706);
            this.RegionGroupControl.Name = "RegionGroupControl";
            this.RegionGroupControl.Size = new System.Drawing.Size(977, 139);
            this.RegionGroupControl.TabIndex = 12;
            this.RegionGroupControl.Text = "Thao tác Khu vực ";
            // 
            // exportRegionSimpleButton
            // 
            this.exportRegionSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.exportRegionSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("exportRegionSimpleButton.Image")));
            this.exportRegionSimpleButton.Location = new System.Drawing.Point(164, 55);
            this.exportRegionSimpleButton.Name = "exportRegionSimpleButton";
            this.exportRegionSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.exportRegionSimpleButton.TabIndex = 3;
            this.exportRegionSimpleButton.Text = "Excel";
            this.exportRegionSimpleButton.Click += new System.EventHandler(this.exportRegionSimpleButton_Click);
            // 
            // addRegionSimpleButton
            // 
            this.addRegionSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addRegionSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("addRegionSimpleButton.Image")));
            this.addRegionSimpleButton.Location = new System.Drawing.Point(313, 55);
            this.addRegionSimpleButton.Name = "addRegionSimpleButton";
            this.addRegionSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.addRegionSimpleButton.TabIndex = 4;
            this.addRegionSimpleButton.Text = "Thêm";
            this.addRegionSimpleButton.Click += new System.EventHandler(this.addRegionSimpleButton_Click);
            // 
            // editRegionSimpleButton
            // 
            this.editRegionSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.editRegionSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("editRegionSimpleButton.Image")));
            this.editRegionSimpleButton.Location = new System.Drawing.Point(657, 55);
            this.editRegionSimpleButton.Name = "editRegionSimpleButton";
            this.editRegionSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.editRegionSimpleButton.TabIndex = 2;
            this.editRegionSimpleButton.Text = "Sửa";
            this.editRegionSimpleButton.Click += new System.EventHandler(this.editRegionSimpleButton_Click);
            // 
            // saveRegionSimpleButton
            // 
            this.saveRegionSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.saveRegionSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("saveRegionSimpleButton.Image")));
            this.saveRegionSimpleButton.Location = new System.Drawing.Point(806, 55);
            this.saveRegionSimpleButton.Name = "saveRegionSimpleButton";
            this.saveRegionSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.saveRegionSimpleButton.TabIndex = 1;
            this.saveRegionSimpleButton.Text = "Lưu";
            this.saveRegionSimpleButton.Click += new System.EventHandler(this.saveRegionSimpleButton_Click);
            // 
            // deleteRegionSimpleButton
            // 
            this.deleteRegionSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deleteRegionSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteRegionSimpleButton.Image")));
            this.deleteRegionSimpleButton.Location = new System.Drawing.Point(15, 55);
            this.deleteRegionSimpleButton.Name = "deleteRegionSimpleButton";
            this.deleteRegionSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.deleteRegionSimpleButton.TabIndex = 5;
            this.deleteRegionSimpleButton.Text = "Xóa";
            this.deleteRegionSimpleButton.Click += new System.EventHandler(this.deleteRegionSimpleButton_Click);
            // 
            // tinhthanhModelGridControl
            // 
            this.tinhthanhModelGridControl.DataSource = this.tinhthanhModelBindingSource;
            this.tinhthanhModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tinhthanhModelGridControl.Location = new System.Drawing.Point(0, 0);
            this.tinhthanhModelGridControl.MainView = this.tinhthanhModelGridView;
            this.tinhthanhModelGridControl.Name = "tinhthanhModelGridControl";
            this.tinhthanhModelGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.tinhthanhModelGridControl.Size = new System.Drawing.Size(996, 706);
            this.tinhthanhModelGridControl.TabIndex = 6;
            this.tinhthanhModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tinhthanhModelGridView});
            // 
            // tinhthanhModelBindingSource
            // 
            this.tinhthanhModelBindingSource.DataSource = typeof(B2B.Model.TinhthanhModel);
            // 
            // tinhthanhModelGridView
            // 
            this.tinhthanhModelGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTinhthanhId,
            this.colKhuvucId1,
            this.colStep1,
            this.colNgayCapnhat1,
            this.colActive1,
            this.colVersion1,
            this.colCode1,
            this.colTenTinhthanh,
            this.colGhichu1,
            this.colState1,
            this.noTinhthanhGridColumn});
            this.tinhthanhModelGridView.GridControl = this.tinhthanhModelGridControl;
            this.tinhthanhModelGridView.Name = "tinhthanhModelGridView";
            this.tinhthanhModelGridView.OptionsBehavior.Editable = false;
            this.tinhthanhModelGridView.OptionsView.ShowAutoFilterRow = true;
            this.tinhthanhModelGridView.OptionsView.ShowFooter = true;
            this.tinhthanhModelGridView.OptionsView.ShowGroupPanel = false;
            this.tinhthanhModelGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.tinhthanhModelGridView_CustomColumnDisplayText);
            // 
            // colTinhthanhId
            // 
            this.colTinhthanhId.FieldName = "TinhthanhId";
            this.colTinhthanhId.Name = "colTinhthanhId";
            // 
            // colKhuvucId1
            // 
            this.colKhuvucId1.FieldName = "KhuvucId";
            this.colKhuvucId1.Name = "colKhuvucId1";
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
            this.colNgayCapnhat1.OptionsColumn.AllowEdit = false;
            this.colNgayCapnhat1.Visible = true;
            this.colNgayCapnhat1.VisibleIndex = 4;
            this.colNgayCapnhat1.Width = 128;
            // 
            // colActive1
            // 
            this.colActive1.FieldName = "Active";
            this.colActive1.Name = "colActive1";
            this.colActive1.Visible = true;
            this.colActive1.VisibleIndex = 3;
            this.colActive1.Width = 128;
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
            this.colCode1.Width = 139;
            // 
            // colTenTinhthanh
            // 
            this.colTenTinhthanh.Caption = "Tỉnh thành";
            this.colTenTinhthanh.FieldName = "TenTinhthanh";
            this.colTenTinhthanh.Name = "colTenTinhthanh";
            this.colTenTinhthanh.Visible = true;
            this.colTenTinhthanh.VisibleIndex = 2;
            this.colTenTinhthanh.Width = 180;
            // 
            // colGhichu1
            // 
            this.colGhichu1.Caption = "Ghi chú";
            this.colGhichu1.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colGhichu1.FieldName = "Ghichu";
            this.colGhichu1.Name = "colGhichu1";
            this.colGhichu1.Visible = true;
            this.colGhichu1.VisibleIndex = 5;
            this.colGhichu1.Width = 128;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // colState1
            // 
            this.colState1.FieldName = "State";
            this.colState1.Name = "colState1";
            this.colState1.OptionsColumn.ReadOnly = true;
            this.colState1.Visible = true;
            this.colState1.VisibleIndex = 6;
            this.colState1.Width = 136;
            // 
            // noTinhthanhGridColumn
            // 
            this.noTinhthanhGridColumn.Caption = "STT";
            this.noTinhthanhGridColumn.Name = "noTinhthanhGridColumn";
            this.noTinhthanhGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.noTinhthanhGridColumn.Visible = true;
            this.noTinhthanhGridColumn.VisibleIndex = 0;
            this.noTinhthanhGridColumn.Width = 139;
            // 
            // ProvinceGroupControl
            // 
            this.ProvinceGroupControl.Controls.Add(this.addProvinceSimpleButton);
            this.ProvinceGroupControl.Controls.Add(this.deleteProvinceSimpleButton);
            this.ProvinceGroupControl.Controls.Add(this.exportProvinceSimpleButton);
            this.ProvinceGroupControl.Controls.Add(this.saveProvinceSimpleButton);
            this.ProvinceGroupControl.Controls.Add(this.editProvinceSimpleButton);
            this.ProvinceGroupControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProvinceGroupControl.Location = new System.Drawing.Point(0, 706);
            this.ProvinceGroupControl.Name = "ProvinceGroupControl";
            this.ProvinceGroupControl.Size = new System.Drawing.Size(996, 139);
            this.ProvinceGroupControl.TabIndex = 6;
            this.ProvinceGroupControl.Text = "Thao tác Tỉnh thành";
            // 
            // addProvinceSimpleButton
            // 
            this.addProvinceSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addProvinceSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("addProvinceSimpleButton.Image")));
            this.addProvinceSimpleButton.Location = new System.Drawing.Point(337, 55);
            this.addProvinceSimpleButton.Name = "addProvinceSimpleButton";
            this.addProvinceSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.addProvinceSimpleButton.TabIndex = 10;
            this.addProvinceSimpleButton.Text = "Thêm";
            this.addProvinceSimpleButton.Click += new System.EventHandler(this.addProvinceSimpleButton_Click);
            // 
            // deleteProvinceSimpleButton
            // 
            this.deleteProvinceSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deleteProvinceSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteProvinceSimpleButton.Image")));
            this.deleteProvinceSimpleButton.Location = new System.Drawing.Point(39, 55);
            this.deleteProvinceSimpleButton.Name = "deleteProvinceSimpleButton";
            this.deleteProvinceSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.deleteProvinceSimpleButton.TabIndex = 11;
            this.deleteProvinceSimpleButton.Text = "Xóa";
            this.deleteProvinceSimpleButton.Click += new System.EventHandler(this.deleteProvinceSimpleButton_Click);
            // 
            // exportProvinceSimpleButton
            // 
            this.exportProvinceSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.exportProvinceSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("exportProvinceSimpleButton.Image")));
            this.exportProvinceSimpleButton.Location = new System.Drawing.Point(188, 55);
            this.exportProvinceSimpleButton.Name = "exportProvinceSimpleButton";
            this.exportProvinceSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.exportProvinceSimpleButton.TabIndex = 9;
            this.exportProvinceSimpleButton.Text = "Excel";
            this.exportProvinceSimpleButton.Click += new System.EventHandler(this.exportProvinceSimpleButton_Click);
            // 
            // saveProvinceSimpleButton
            // 
            this.saveProvinceSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.saveProvinceSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("saveProvinceSimpleButton.Image")));
            this.saveProvinceSimpleButton.Location = new System.Drawing.Point(830, 55);
            this.saveProvinceSimpleButton.Name = "saveProvinceSimpleButton";
            this.saveProvinceSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.saveProvinceSimpleButton.TabIndex = 7;
            this.saveProvinceSimpleButton.Text = "Lưu";
            this.saveProvinceSimpleButton.Click += new System.EventHandler(this.saveProvinceSimpleButton_Click);
            // 
            // editProvinceSimpleButton
            // 
            this.editProvinceSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.editProvinceSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("editProvinceSimpleButton.Image")));
            this.editProvinceSimpleButton.Location = new System.Drawing.Point(679, 55);
            this.editProvinceSimpleButton.Name = "editProvinceSimpleButton";
            this.editProvinceSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.editProvinceSimpleButton.TabIndex = 8;
            this.editProvinceSimpleButton.Text = "Sửa";
            this.editProvinceSimpleButton.Click += new System.EventHandler(this.editProvinceSimpleButton_Click);
            // 
            // KhuvucTinhthanhForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1978, 845);
            this.Controls.Add(this.splitContainerControl1);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1592, 916);
            this.Name = "KhuvucTinhthanhForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khu Vực - Tỉnh Thành";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.khuvucModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khuvucModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khuvucModelGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegionGroupControl)).EndInit();
            this.RegionGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tinhthanhModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhthanhModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhthanhModelGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProvinceGroupControl)).EndInit();
            this.ProvinceGroupControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton addProvinceSimpleButton;
        private DevExpress.XtraEditors.SimpleButton exportProvinceSimpleButton;
        private DevExpress.XtraEditors.SimpleButton editProvinceSimpleButton;
        private DevExpress.XtraEditors.SimpleButton deleteProvinceSimpleButton;
        private DevExpress.XtraEditors.SimpleButton saveProvinceSimpleButton;
        private DevExpress.XtraEditors.SimpleButton addRegionSimpleButton;
        private DevExpress.XtraEditors.SimpleButton exportRegionSimpleButton;
        private DevExpress.XtraEditors.SimpleButton editRegionSimpleButton;
        private DevExpress.XtraEditors.SimpleButton deleteRegionSimpleButton;
        private DevExpress.XtraEditors.SimpleButton saveRegionSimpleButton;
        private DevExpress.XtraEditors.GroupControl RegionGroupControl;
        private DevExpress.XtraEditors.GroupControl ProvinceGroupControl;
        private DevExpress.XtraGrid.GridControl khuvucModelGridControl;
        private System.Windows.Forms.BindingSource khuvucModelBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView khuvucModelGridView;
        private DevExpress.XtraGrid.GridControl tinhthanhModelGridControl;
        private System.Windows.Forms.BindingSource tinhthanhModelBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView tinhthanhModelGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colKhuvucId;
        private DevExpress.XtraGrid.Columns.GridColumn colStep;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayCapnhat;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKhuvuc;
        private DevExpress.XtraGrid.Columns.GridColumn colGhichu;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraGrid.Columns.GridColumn noKhuvucGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn colTinhthanhId;
        private DevExpress.XtraGrid.Columns.GridColumn colKhuvucId1;
        private DevExpress.XtraGrid.Columns.GridColumn colStep1;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayCapnhat1;
        private DevExpress.XtraGrid.Columns.GridColumn colActive1;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion1;
        private DevExpress.XtraGrid.Columns.GridColumn colCode1;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTinhthanh;
        private DevExpress.XtraGrid.Columns.GridColumn colGhichu1;
        private DevExpress.XtraGrid.Columns.GridColumn colState1;
        private DevExpress.XtraGrid.Columns.GridColumn noTinhthanhGridColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit2;
    }
}