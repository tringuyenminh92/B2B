namespace B2B.Forms
{
    partial class PhieunhapForm
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
            System.Windows.Forms.Label tenNhanvienLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieunhapForm));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.phieunhapModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.phieunhapModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieunhapModelGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPhieunhapId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhanvienId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhacungcapId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNguyennhanLydo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTinhtrangPhieunhapCurrentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaylap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongtien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhichu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNhanvien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNhaCungcap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenTinhtrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoidung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ThangNamLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.thangNamDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.tenNhanvienTextEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.reloaPhieunhapSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.InformationGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.addPhieunhapSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.deletePhieunhapSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.editPhieunhapSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.exportPhieunhapSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.savePhieunhapSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.khoModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhaCungcapModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tinhtrangModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanvienModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            tenNhanvienLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phieunhapModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieunhapModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieunhapModelGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thangNamDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thangNamDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenNhanvienTextEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InformationGroupControl)).BeginInit();
            this.InformationGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khoModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungcapModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhtrangModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tenNhanvienLabel1
            // 
            tenNhanvienLabel1.AutoSize = true;
            tenNhanvienLabel1.Location = new System.Drawing.Point(33, 29);
            tenNhanvienLabel1.Name = "tenNhanvienLabel1";
            tenNhanvienLabel1.Size = new System.Drawing.Size(49, 13);
            tenNhanvienLabel1.TabIndex = 4;
            tenNhanvienLabel1.Text = "Thủ kho:";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.phieunhapModelGridControl);
            this.panelControl2.Controls.Add(this.groupControl1);
            this.panelControl2.Controls.Add(this.InformationGroupControl);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1264, 721);
            this.panelControl2.TabIndex = 1;
            // 
            // phieunhapModelGridControl
            // 
            this.phieunhapModelGridControl.DataSource = this.phieunhapModelBindingSource;
            this.phieunhapModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phieunhapModelGridControl.Location = new System.Drawing.Point(2, 55);
            this.phieunhapModelGridControl.MainView = this.phieunhapModelGridView;
            this.phieunhapModelGridControl.Name = "phieunhapModelGridControl";
            this.phieunhapModelGridControl.Size = new System.Drawing.Size(1260, 610);
            this.phieunhapModelGridControl.TabIndex = 2;
            this.phieunhapModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.phieunhapModelGridView});
            // 
            // phieunhapModelBindingSource
            // 
            this.phieunhapModelBindingSource.DataSource = typeof(B2B.Model.PhieunhapModel);
            // 
            // phieunhapModelGridView
            // 
            this.phieunhapModelGridView.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.phieunhapModelGridView.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.phieunhapModelGridView.Appearance.OddRow.Options.UseBackColor = true;
            this.phieunhapModelGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPhieunhapId,
            this.colNhanvienId,
            this.colKhoId,
            this.colNhacungcapId,
            this.colNguyennhanLydo,
            this.colTinhtrangPhieunhapCurrentId,
            this.colStep,
            this.colNgaylap,
            this.colTongtien,
            this.colVersion,
            this.colCode,
            this.colGhichu,
            this.colTenNhanvien,
            this.colTenKho,
            this.colTenNhaCungcap,
            this.colTenTinhtrang,
            this.colNoidung,
            this.colState,
            this.NoGridColumn});
            this.phieunhapModelGridView.GridControl = this.phieunhapModelGridControl;
            this.phieunhapModelGridView.Name = "phieunhapModelGridView";
            this.phieunhapModelGridView.OptionsBehavior.Editable = false;
            this.phieunhapModelGridView.OptionsView.EnableAppearanceOddRow = true;
            this.phieunhapModelGridView.OptionsView.ShowAutoFilterRow = true;
            this.phieunhapModelGridView.OptionsView.ShowFooter = true;
            this.phieunhapModelGridView.OptionsView.ShowGroupPanel = false;
            this.phieunhapModelGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.phieunhapModelGridView_CustomColumnDisplayText_1);
            // 
            // colPhieunhapId
            // 
            this.colPhieunhapId.FieldName = "PhieunhapId";
            this.colPhieunhapId.Name = "colPhieunhapId";
            // 
            // colNhanvienId
            // 
            this.colNhanvienId.FieldName = "NhanvienId";
            this.colNhanvienId.Name = "colNhanvienId";
            // 
            // colKhoId
            // 
            this.colKhoId.FieldName = "KhoId";
            this.colKhoId.Name = "colKhoId";
            // 
            // colNhacungcapId
            // 
            this.colNhacungcapId.FieldName = "NhacungcapId";
            this.colNhacungcapId.Name = "colNhacungcapId";
            // 
            // colNguyennhanLydo
            // 
            this.colNguyennhanLydo.FieldName = "NguyennhanLydo";
            this.colNguyennhanLydo.Name = "colNguyennhanLydo";
            // 
            // colTinhtrangPhieunhapCurrentId
            // 
            this.colTinhtrangPhieunhapCurrentId.FieldName = "TinhtrangPhieunhapCurrentId";
            this.colTinhtrangPhieunhapCurrentId.Name = "colTinhtrangPhieunhapCurrentId";
            // 
            // colStep
            // 
            this.colStep.FieldName = "Step";
            this.colStep.Name = "colStep";
            // 
            // colNgaylap
            // 
            this.colNgaylap.Caption = "Ngày lập";
            this.colNgaylap.FieldName = "Ngaylap";
            this.colNgaylap.Name = "colNgaylap";
            this.colNgaylap.Visible = true;
            this.colNgaylap.VisibleIndex = 2;
            this.colNgaylap.Width = 82;
            // 
            // colTongtien
            // 
            this.colTongtien.Caption = "Tổng tiền";
            this.colTongtien.DisplayFormat.FormatString = "{0:n0}";
            this.colTongtien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colTongtien.FieldName = "Tongtien";
            this.colTongtien.Name = "colTongtien";
            this.colTongtien.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tongtien", "{0:n0}")});
            this.colTongtien.Visible = true;
            this.colTongtien.VisibleIndex = 3;
            this.colTongtien.Width = 91;
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
            this.colCode.Width = 71;
            // 
            // colGhichu
            // 
            this.colGhichu.Caption = "Ghi chú";
            this.colGhichu.FieldName = "Ghichu";
            this.colGhichu.Name = "colGhichu";
            this.colGhichu.Visible = true;
            this.colGhichu.VisibleIndex = 9;
            this.colGhichu.Width = 89;
            // 
            // colTenNhanvien
            // 
            this.colTenNhanvien.Caption = "Nhân viên";
            this.colTenNhanvien.FieldName = "TenNhanvien";
            this.colTenNhanvien.Name = "colTenNhanvien";
            this.colTenNhanvien.Visible = true;
            this.colTenNhanvien.VisibleIndex = 8;
            this.colTenNhanvien.Width = 105;
            // 
            // colTenKho
            // 
            this.colTenKho.Caption = "Kho";
            this.colTenKho.FieldName = "TenKho";
            this.colTenKho.Name = "colTenKho";
            this.colTenKho.Visible = true;
            this.colTenKho.VisibleIndex = 5;
            this.colTenKho.Width = 115;
            // 
            // colTenNhaCungcap
            // 
            this.colTenNhaCungcap.Caption = "Nhà cung cấp";
            this.colTenNhaCungcap.FieldName = "TenNhaCungcap";
            this.colTenNhaCungcap.Name = "colTenNhaCungcap";
            this.colTenNhaCungcap.Visible = true;
            this.colTenNhaCungcap.VisibleIndex = 6;
            this.colTenNhaCungcap.Width = 122;
            // 
            // colTenTinhtrang
            // 
            this.colTenTinhtrang.Caption = "Tình trạng";
            this.colTenTinhtrang.FieldName = "TenTinhtrang";
            this.colTenTinhtrang.Name = "colTenTinhtrang";
            this.colTenTinhtrang.Visible = true;
            this.colTenTinhtrang.VisibleIndex = 4;
            this.colTenTinhtrang.Width = 128;
            // 
            // colNoidung
            // 
            this.colNoidung.Caption = "Nguyên nhân";
            this.colNoidung.FieldName = "Noidung";
            this.colNoidung.Name = "colNoidung";
            this.colNoidung.Visible = true;
            this.colNoidung.VisibleIndex = 7;
            this.colNoidung.Width = 110;
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.OptionsColumn.ReadOnly = true;
            this.colState.Visible = true;
            this.colState.VisibleIndex = 10;
            this.colState.Width = 77;
            // 
            // NoGridColumn
            // 
            this.NoGridColumn.Caption = "STT";
            this.NoGridColumn.Name = "NoGridColumn";
            this.NoGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.NoGridColumn.Visible = true;
            this.NoGridColumn.VisibleIndex = 0;
            this.NoGridColumn.Width = 54;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.ThangNamLabelControl);
            this.groupControl1.Controls.Add(this.thangNamDateEdit);
            this.groupControl1.Controls.Add(this.tenNhanvienTextEdit1);
            this.groupControl1.Controls.Add(tenNhanvienLabel1);
            this.groupControl1.Controls.Add(this.reloaPhieunhapSimpleButton);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1260, 53);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Thộng tin chung";
            // 
            // ThangNamLabelControl
            // 
            this.ThangNamLabelControl.Location = new System.Drawing.Point(245, 29);
            this.ThangNamLabelControl.Margin = new System.Windows.Forms.Padding(2);
            this.ThangNamLabelControl.Name = "ThangNamLabelControl";
            this.ThangNamLabelControl.Size = new System.Drawing.Size(58, 13);
            this.ThangNamLabelControl.TabIndex = 31;
            this.ThangNamLabelControl.Text = "Tháng/năm:";
            // 
            // thangNamDateEdit
            // 
            this.thangNamDateEdit.EditValue = new System.DateTime(2014, 9, 16, 11, 47, 49, 71);
            this.thangNamDateEdit.Location = new System.Drawing.Point(325, 26);
            this.thangNamDateEdit.Margin = new System.Windows.Forms.Padding(2);
            this.thangNamDateEdit.Name = "thangNamDateEdit";
            this.thangNamDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.thangNamDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.thangNamDateEdit.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.thangNamDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.thangNamDateEdit.Properties.EditFormat.FormatString = "MM/yyyy";
            this.thangNamDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.thangNamDateEdit.Properties.Mask.EditMask = "MM/yyyy";
            this.thangNamDateEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.thangNamDateEdit.Properties.VistaCalendarViewStyle = ((DevExpress.XtraEditors.VistaCalendarViewStyle)((DevExpress.XtraEditors.VistaCalendarViewStyle.YearView | DevExpress.XtraEditors.VistaCalendarViewStyle.CenturyView)));
            this.thangNamDateEdit.Size = new System.Drawing.Size(111, 20);
            this.thangNamDateEdit.TabIndex = 30;
            // 
            // tenNhanvienTextEdit1
            // 
            this.tenNhanvienTextEdit1.Location = new System.Drawing.Point(100, 26);
            this.tenNhanvienTextEdit1.Name = "tenNhanvienTextEdit1";
            this.tenNhanvienTextEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.tenNhanvienTextEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.tenNhanvienTextEdit1.Properties.ReadOnly = true;
            this.tenNhanvienTextEdit1.Size = new System.Drawing.Size(111, 20);
            this.tenNhanvienTextEdit1.TabIndex = 5;
            // 
            // reloaPhieunhapSimpleButton
            // 
            this.reloaPhieunhapSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("reloaPhieunhapSimpleButton.Image")));
            this.reloaPhieunhapSimpleButton.Location = new System.Drawing.Point(459, 26);
            this.reloaPhieunhapSimpleButton.Margin = new System.Windows.Forms.Padding(2);
            this.reloaPhieunhapSimpleButton.Name = "reloaPhieunhapSimpleButton";
            this.reloaPhieunhapSimpleButton.Size = new System.Drawing.Size(70, 20);
            this.reloaPhieunhapSimpleButton.TabIndex = 24;
            this.reloaPhieunhapSimpleButton.Text = "Lọc";
            this.reloaPhieunhapSimpleButton.Click += new System.EventHandler(this.reloaPhieunhapSimpleButton_Click);
            // 
            // InformationGroupControl
            // 
            this.InformationGroupControl.Controls.Add(this.addPhieunhapSimpleButton);
            this.InformationGroupControl.Controls.Add(this.deletePhieunhapSimpleButton);
            this.InformationGroupControl.Controls.Add(this.editPhieunhapSimpleButton);
            this.InformationGroupControl.Controls.Add(this.exportPhieunhapSimpleButton);
            this.InformationGroupControl.Controls.Add(this.savePhieunhapSimpleButton);
            this.InformationGroupControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InformationGroupControl.Location = new System.Drawing.Point(2, 665);
            this.InformationGroupControl.Margin = new System.Windows.Forms.Padding(2);
            this.InformationGroupControl.Name = "InformationGroupControl";
            this.InformationGroupControl.Size = new System.Drawing.Size(1260, 54);
            this.InformationGroupControl.TabIndex = 1;
            this.InformationGroupControl.Text = "Thao tác Nhóm khách hàng";
            // 
            // addPhieunhapSimpleButton
            // 
            this.addPhieunhapSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addPhieunhapSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("addPhieunhapSimpleButton.Image")));
            this.addPhieunhapSimpleButton.Location = new System.Drawing.Point(161, 28);
            this.addPhieunhapSimpleButton.Margin = new System.Windows.Forms.Padding(2);
            this.addPhieunhapSimpleButton.Name = "addPhieunhapSimpleButton";
            this.addPhieunhapSimpleButton.Size = new System.Drawing.Size(70, 20);
            this.addPhieunhapSimpleButton.TabIndex = 28;
            this.addPhieunhapSimpleButton.Text = "Thêm";
            this.addPhieunhapSimpleButton.Click += new System.EventHandler(this.addPhieunhapSimpleButton_Click);
            // 
            // deletePhieunhapSimpleButton
            // 
            this.deletePhieunhapSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deletePhieunhapSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("deletePhieunhapSimpleButton.Image")));
            this.deletePhieunhapSimpleButton.Location = new System.Drawing.Point(12, 28);
            this.deletePhieunhapSimpleButton.Margin = new System.Windows.Forms.Padding(2);
            this.deletePhieunhapSimpleButton.Name = "deletePhieunhapSimpleButton";
            this.deletePhieunhapSimpleButton.Size = new System.Drawing.Size(70, 20);
            this.deletePhieunhapSimpleButton.TabIndex = 29;
            this.deletePhieunhapSimpleButton.Text = "Xóa";
            this.deletePhieunhapSimpleButton.Click += new System.EventHandler(this.deletePhieunhapSimpleButton_Click);
            // 
            // editPhieunhapSimpleButton
            // 
            this.editPhieunhapSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.editPhieunhapSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("editPhieunhapSimpleButton.Image")));
            this.editPhieunhapSimpleButton.Location = new System.Drawing.Point(1104, 28);
            this.editPhieunhapSimpleButton.Margin = new System.Windows.Forms.Padding(2);
            this.editPhieunhapSimpleButton.Name = "editPhieunhapSimpleButton";
            this.editPhieunhapSimpleButton.Size = new System.Drawing.Size(70, 20);
            this.editPhieunhapSimpleButton.TabIndex = 26;
            this.editPhieunhapSimpleButton.Text = "Sửa";
            this.editPhieunhapSimpleButton.Click += new System.EventHandler(this.editPhieunhapSimpleButton_Click);
            // 
            // exportPhieunhapSimpleButton
            // 
            this.exportPhieunhapSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.exportPhieunhapSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("exportPhieunhapSimpleButton.Image")));
            this.exportPhieunhapSimpleButton.Location = new System.Drawing.Point(87, 28);
            this.exportPhieunhapSimpleButton.Margin = new System.Windows.Forms.Padding(2);
            this.exportPhieunhapSimpleButton.Name = "exportPhieunhapSimpleButton";
            this.exportPhieunhapSimpleButton.Size = new System.Drawing.Size(70, 20);
            this.exportPhieunhapSimpleButton.TabIndex = 27;
            this.exportPhieunhapSimpleButton.Text = "Export";
            this.exportPhieunhapSimpleButton.Click += new System.EventHandler(this.exportPhieunhapSimpleButton_Click);
            // 
            // savePhieunhapSimpleButton
            // 
            this.savePhieunhapSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.savePhieunhapSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("savePhieunhapSimpleButton.Image")));
            this.savePhieunhapSimpleButton.Location = new System.Drawing.Point(1178, 27);
            this.savePhieunhapSimpleButton.Margin = new System.Windows.Forms.Padding(2);
            this.savePhieunhapSimpleButton.Name = "savePhieunhapSimpleButton";
            this.savePhieunhapSimpleButton.Size = new System.Drawing.Size(70, 20);
            this.savePhieunhapSimpleButton.TabIndex = 25;
            this.savePhieunhapSimpleButton.Text = "Lưu";
            this.savePhieunhapSimpleButton.Click += new System.EventHandler(this.savePhieunhapSimpleButton_Click);
            // 
            // khoModelBindingSource
            // 
            this.khoModelBindingSource.DataSource = typeof(B2B.Model.KhoModel);
            // 
            // nhaCungcapModelBindingSource
            // 
            this.nhaCungcapModelBindingSource.DataSource = typeof(B2B.Model.NhaCungcapModel);
            // 
            // tinhtrangModelBindingSource
            // 
            this.tinhtrangModelBindingSource.DataSource = typeof(B2B.Model.TinhtrangModel);
            // 
            // nhanvienModelBindingSource
            // 
            this.nhanvienModelBindingSource.DataSource = typeof(B2B.Model.NhanvienModel);
            // 
            // PhieunhapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1264, 721);
            this.Controls.Add(this.panelControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "PhieunhapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.phieunhapModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieunhapModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieunhapModelGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thangNamDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thangNamDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenNhanvienTextEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InformationGroupControl)).EndInit();
            this.InformationGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.khoModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungcapModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhtrangModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.GroupControl InformationGroupControl;
        private DevExpress.XtraEditors.SimpleButton addPhieunhapSimpleButton;
        private DevExpress.XtraEditors.SimpleButton deletePhieunhapSimpleButton;
        private DevExpress.XtraEditors.SimpleButton editPhieunhapSimpleButton;
        private DevExpress.XtraEditors.SimpleButton exportPhieunhapSimpleButton;
        private DevExpress.XtraEditors.SimpleButton savePhieunhapSimpleButton;
        private System.Windows.Forms.BindingSource nhaCungcapModelBindingSource;
        private System.Windows.Forms.BindingSource khoModelBindingSource;
        private System.Windows.Forms.BindingSource nhanvienModelBindingSource;
        private System.Windows.Forms.BindingSource tinhtrangModelBindingSource;
        private System.Windows.Forms.BindingSource phieunhapModelBindingSource;
        private DevExpress.XtraGrid.GridControl phieunhapModelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView phieunhapModelGridView;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl ThangNamLabelControl;
        private DevExpress.XtraEditors.DateEdit thangNamDateEdit;
        private DevExpress.XtraEditors.TextEdit tenNhanvienTextEdit1;
        private DevExpress.XtraEditors.SimpleButton reloaPhieunhapSimpleButton;
        private DevExpress.XtraGrid.Columns.GridColumn colPhieunhapId;
        private DevExpress.XtraGrid.Columns.GridColumn colNhanvienId;
        private DevExpress.XtraGrid.Columns.GridColumn colKhoId;
        private DevExpress.XtraGrid.Columns.GridColumn colNhacungcapId;
        private DevExpress.XtraGrid.Columns.GridColumn colNguyennhanLydo;
        private DevExpress.XtraGrid.Columns.GridColumn colTinhtrangPhieunhapCurrentId;
        private DevExpress.XtraGrid.Columns.GridColumn colStep;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaylap;
        private DevExpress.XtraGrid.Columns.GridColumn colTongtien;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colGhichu;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNhanvien;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKho;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNhaCungcap;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTinhtrang;
        private DevExpress.XtraGrid.Columns.GridColumn colNoidung;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraGrid.Columns.GridColumn NoGridColumn;
    }
}