namespace B2B.Forms
{
    partial class NhanvienForm
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
            System.Windows.Forms.Label ghichuLabel;
            System.Windows.Forms.Label hovatenNhanvienLabel;
            System.Windows.Forms.Label tinhthanhIdLabel;
            System.Windows.Forms.Label activeLabel;
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label codeLabel;
            System.Windows.Forms.Label diachiLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label gioitinhLabel;
            System.Windows.Forms.Label mobileLabel;
            System.Windows.Forms.Label ngaysinhLabel;
            System.Windows.Forms.Label quanhuyenIdLabel;
            System.Windows.Forms.Label telLabel;
            System.Windows.Forms.Label tenNhomNhanvienLabel;
            System.Windows.Forms.Label ngayBatdauLabel;
            System.Windows.Forms.Label ngayCapnhatLabel;
            System.Windows.Forms.Label ngayKetthucLabel;
            System.Windows.Forms.Label phongbanIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanvienForm));
            this.nhanvienModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phongbanModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LeftPanelControl = new DevExpress.XtraEditors.PanelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.VieclamGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.AnhMyPictureEdit = new B2B.Forms.MyPictureEdit();
            this.ngayBatdauDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ngayCapnhatDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ngayKetthucDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.CobanGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.tenTinhthanhTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tenQuanhuyenTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tenPhongbanTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hovatenNhanvienTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.activeCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.cMNDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.codeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.diachiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.emailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.gioitinhCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.mobileTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ngaysinhDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.telTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.linkanhTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ghichuTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.RightPanelControl = new DevExpress.XtraEditors.PanelControl();
            this.nhanvienModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.nhanvienModelGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNhanvienId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuanhuyenId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTinhthanhId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaysinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayBatdau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayKetthuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayCapnhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioitinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNhanvien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoNhanvien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHovatenNhanvien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiachi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhichu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLinkanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenTinhthanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenQuanhuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNhomNhanvien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.NhanvienActionGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.addNhanvienSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.editNhanvienSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.deleteNhanvienSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveNhanvienSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.exportNhanvienSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.reloadNhanvienSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.phongbanIdTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            ghichuLabel = new System.Windows.Forms.Label();
            hovatenNhanvienLabel = new System.Windows.Forms.Label();
            tinhthanhIdLabel = new System.Windows.Forms.Label();
            activeLabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            codeLabel = new System.Windows.Forms.Label();
            diachiLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            gioitinhLabel = new System.Windows.Forms.Label();
            mobileLabel = new System.Windows.Forms.Label();
            ngaysinhLabel = new System.Windows.Forms.Label();
            quanhuyenIdLabel = new System.Windows.Forms.Label();
            telLabel = new System.Windows.Forms.Label();
            tenNhomNhanvienLabel = new System.Windows.Forms.Label();
            ngayBatdauLabel = new System.Windows.Forms.Label();
            ngayCapnhatLabel = new System.Windows.Forms.Label();
            ngayKetthucLabel = new System.Windows.Forms.Label();
            phongbanIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongbanModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPanelControl)).BeginInit();
            this.LeftPanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VieclamGroupControl)).BeginInit();
            this.VieclamGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnhMyPictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayBatdauDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayBatdauDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayKetthucDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayKetthucDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CobanGroupControl)).BeginInit();
            this.CobanGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tenTinhthanhTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenQuanhuyenTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenPhongbanTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hovatenNhanvienTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMNDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diachiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gioitinhCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaysinhDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaysinhDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkanhTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghichuTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightPanelControl)).BeginInit();
            this.RightPanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienModelGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanvienActionGroupControl)).BeginInit();
            this.NhanvienActionGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phongbanIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // ghichuLabel
            // 
            ghichuLabel.AutoSize = true;
            ghichuLabel.Location = new System.Drawing.Point(45, 840);
            ghichuLabel.Name = "ghichuLabel";
            ghichuLabel.Size = new System.Drawing.Size(91, 25);
            ghichuLabel.TabIndex = 97;
            ghichuLabel.Text = "Ghi chú:";
            // 
            // hovatenNhanvienLabel
            // 
            hovatenNhanvienLabel.AutoSize = true;
            hovatenNhanvienLabel.Location = new System.Drawing.Point(45, 113);
            hovatenNhanvienLabel.Name = "hovatenNhanvienLabel";
            hovatenNhanvienLabel.Size = new System.Drawing.Size(117, 25);
            hovatenNhanvienLabel.TabIndex = 143;
            hovatenNhanvienLabel.Text = "Họ Và Tên:";
            // 
            // tinhthanhIdLabel
            // 
            tinhthanhIdLabel.AutoSize = true;
            tinhthanhIdLabel.Location = new System.Drawing.Point(548, 260);
            tinhthanhIdLabel.Name = "tinhthanhIdLabel";
            tinhthanhIdLabel.Size = new System.Drawing.Size(121, 25);
            tinhthanhIdLabel.TabIndex = 142;
            tinhthanhIdLabel.Text = "Tỉnh thành:";
            // 
            // activeLabel
            // 
            activeLabel.AutoSize = true;
            activeLabel.Location = new System.Drawing.Point(327, 163);
            activeLabel.Name = "activeLabel";
            activeLabel.Size = new System.Drawing.Size(75, 25);
            activeLabel.TabIndex = 119;
            activeLabel.Text = "Active:";
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Location = new System.Drawing.Point(44, 258);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(76, 25);
            cMNDLabel.TabIndex = 121;
            cMNDLabel.Text = "CMND:";
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(45, 62);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(66, 25);
            codeLabel.TabIndex = 124;
            codeLabel.Text = "Code:";
            // 
            // diachiLabel
            // 
            diachiLabel.AutoSize = true;
            diachiLabel.Location = new System.Drawing.Point(548, 162);
            diachiLabel.Name = "diachiLabel";
            diachiLabel.Size = new System.Drawing.Size(84, 25);
            diachiLabel.TabIndex = 127;
            diachiLabel.Text = "Địa chỉ:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(548, 309);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(70, 25);
            emailLabel.TabIndex = 129;
            emailLabel.Text = "Email:";
            // 
            // gioitinhLabel
            // 
            gioitinhLabel.AutoSize = true;
            gioitinhLabel.Location = new System.Drawing.Point(45, 163);
            gioitinhLabel.Name = "gioitinhLabel";
            gioitinhLabel.Size = new System.Drawing.Size(98, 25);
            gioitinhLabel.TabIndex = 134;
            gioitinhLabel.Text = "Giới tính:";
            // 
            // mobileLabel
            // 
            mobileLabel.AutoSize = true;
            mobileLabel.Location = new System.Drawing.Point(548, 113);
            mobileLabel.Name = "mobileLabel";
            mobileLabel.Size = new System.Drawing.Size(79, 25);
            mobileLabel.TabIndex = 137;
            mobileLabel.Text = "Mobile:";
            // 
            // ngaysinhLabel
            // 
            ngaysinhLabel.AutoSize = true;
            ngaysinhLabel.Location = new System.Drawing.Point(45, 206);
            ngaysinhLabel.Name = "ngaysinhLabel";
            ngaysinhLabel.Size = new System.Drawing.Size(111, 25);
            ngaysinhLabel.TabIndex = 138;
            ngaysinhLabel.Text = "Ngày sinh:";
            // 
            // quanhuyenIdLabel
            // 
            quanhuyenIdLabel.AutoSize = true;
            quanhuyenIdLabel.Location = new System.Drawing.Point(548, 211);
            quanhuyenIdLabel.Name = "quanhuyenIdLabel";
            quanhuyenIdLabel.Size = new System.Drawing.Size(133, 25);
            quanhuyenIdLabel.TabIndex = 139;
            quanhuyenIdLabel.Text = "Quận huyện:";
            // 
            // telLabel
            // 
            telLabel.AutoSize = true;
            telLabel.Location = new System.Drawing.Point(548, 64);
            telLabel.Name = "telLabel";
            telLabel.Size = new System.Drawing.Size(47, 25);
            telLabel.TabIndex = 140;
            telLabel.Text = "Tel:";
            // 
            // tenNhomNhanvienLabel
            // 
            tenNhomNhanvienLabel.AutoSize = true;
            tenNhomNhanvienLabel.Location = new System.Drawing.Point(45, 310);
            tenNhomNhanvienLabel.Name = "tenNhomNhanvienLabel";
            tenNhomNhanvienLabel.Size = new System.Drawing.Size(120, 25);
            tenNhomNhanvienLabel.TabIndex = 141;
            tenNhomNhanvienLabel.Text = "Phòng ban:";
            // 
            // ngayBatdauLabel
            // 
            ngayBatdauLabel.AutoSize = true;
            ngayBatdauLabel.Location = new System.Drawing.Point(45, 67);
            ngayBatdauLabel.Name = "ngayBatdauLabel";
            ngayBatdauLabel.Size = new System.Drawing.Size(145, 25);
            ngayBatdauLabel.TabIndex = 118;
            ngayBatdauLabel.Text = "Ngày bắt đầu:";
            // 
            // ngayCapnhatLabel
            // 
            ngayCapnhatLabel.AutoSize = true;
            ngayCapnhatLabel.Location = new System.Drawing.Point(45, 160);
            ngayCapnhatLabel.Name = "ngayCapnhatLabel";
            ngayCapnhatLabel.Size = new System.Drawing.Size(155, 25);
            ngayCapnhatLabel.TabIndex = 119;
            ngayCapnhatLabel.Text = "Ngày cập nhật:";
            // 
            // ngayKetthucLabel
            // 
            ngayKetthucLabel.AutoSize = true;
            ngayKetthucLabel.Location = new System.Drawing.Point(43, 112);
            ngayKetthucLabel.Name = "ngayKetthucLabel";
            ngayKetthucLabel.Size = new System.Drawing.Size(149, 25);
            ngayKetthucLabel.TabIndex = 121;
            ngayKetthucLabel.Text = "Ngày kết thúc:";
            // 
            // phongbanIdLabel
            // 
            phongbanIdLabel.AutoSize = true;
            phongbanIdLabel.Location = new System.Drawing.Point(35, 35);
            phongbanIdLabel.Name = "phongbanIdLabel";
            phongbanIdLabel.Size = new System.Drawing.Size(175, 25);
            phongbanIdLabel.TabIndex = 0;
            phongbanIdLabel.Text = "Chọn phòng ban:";
            // 
            // nhanvienModelBindingSource
            // 
            this.nhanvienModelBindingSource.DataSource = typeof(B2B.Model.NhanvienModel);
            this.nhanvienModelBindingSource.CurrentItemChanged += new System.EventHandler(this.nhanvienModelBindingSource_CurrentItemChanged);
            // 
            // phongbanModelBindingSource
            // 
            this.phongbanModelBindingSource.DataSource = typeof(B2B.Model.PhongbanModel);
            // 
            // LeftPanelControl
            // 
            this.LeftPanelControl.Controls.Add(this.xtraTabControl1);
            this.LeftPanelControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanelControl.Location = new System.Drawing.Point(0, 0);
            this.LeftPanelControl.Name = "LeftPanelControl";
            this.LeftPanelControl.Size = new System.Drawing.Size(1039, 1162);
            this.LeftPanelControl.TabIndex = 2;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(2, 2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1035, 1158);
            this.xtraTabControl1.TabIndex = 83;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.VieclamGroupControl);
            this.xtraTabPage1.Controls.Add(this.CobanGroupControl);
            this.xtraTabPage1.Controls.Add(this.linkanhTextEdit);
            this.xtraTabPage1.Controls.Add(ghichuLabel);
            this.xtraTabPage1.Controls.Add(this.ghichuTextEdit);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1029, 1118);
            this.xtraTabPage1.Text = "Thông tin";
            // 
            // VieclamGroupControl
            // 
            this.VieclamGroupControl.Controls.Add(this.AnhMyPictureEdit);
            this.VieclamGroupControl.Controls.Add(ngayBatdauLabel);
            this.VieclamGroupControl.Controls.Add(this.ngayBatdauDateEdit);
            this.VieclamGroupControl.Controls.Add(ngayCapnhatLabel);
            this.VieclamGroupControl.Controls.Add(this.ngayCapnhatDateEdit);
            this.VieclamGroupControl.Controls.Add(ngayKetthucLabel);
            this.VieclamGroupControl.Controls.Add(this.ngayKetthucDateEdit);
            this.VieclamGroupControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.VieclamGroupControl.Location = new System.Drawing.Point(0, 381);
            this.VieclamGroupControl.Name = "VieclamGroupControl";
            this.VieclamGroupControl.Size = new System.Drawing.Size(1029, 420);
            this.VieclamGroupControl.TabIndex = 120;
            this.VieclamGroupControl.Text = "Việc làm";
            // 
            // AnhMyPictureEdit
            // 
            this.AnhMyPictureEdit.FileName = null;
            this.AnhMyPictureEdit.Location = new System.Drawing.Point(553, 59);
            this.AnhMyPictureEdit.Name = "AnhMyPictureEdit";
            this.AnhMyPictureEdit.Properties.InitialImage = null;
            this.AnhMyPictureEdit.Properties.ReadOnly = true;
            this.AnhMyPictureEdit.Size = new System.Drawing.Size(408, 335);
            this.AnhMyPictureEdit.TabIndex = 122;
            // 
            // ngayBatdauDateEdit
            // 
            this.ngayBatdauDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanvienModelBindingSource, "NgayBatdau", true));
            this.ngayBatdauDateEdit.EditValue = null;
            this.ngayBatdauDateEdit.Location = new System.Drawing.Point(216, 60);
            this.ngayBatdauDateEdit.Name = "ngayBatdauDateEdit";
            this.ngayBatdauDateEdit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.ngayBatdauDateEdit.Properties.Appearance.Options.UseBackColor = true;
            this.ngayBatdauDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayBatdauDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayBatdauDateEdit.Properties.ReadOnly = true;
            this.ngayBatdauDateEdit.Size = new System.Drawing.Size(267, 32);
            this.ngayBatdauDateEdit.TabIndex = 116;
            // 
            // ngayCapnhatDateEdit
            // 
            this.ngayCapnhatDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanvienModelBindingSource, "NgayCapnhat", true));
            this.ngayCapnhatDateEdit.EditValue = null;
            this.ngayCapnhatDateEdit.Location = new System.Drawing.Point(216, 153);
            this.ngayCapnhatDateEdit.Name = "ngayCapnhatDateEdit";
            this.ngayCapnhatDateEdit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.ngayCapnhatDateEdit.Properties.Appearance.Options.UseBackColor = true;
            this.ngayCapnhatDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayCapnhatDateEdit.Properties.ReadOnly = true;
            this.ngayCapnhatDateEdit.Size = new System.Drawing.Size(267, 32);
            this.ngayCapnhatDateEdit.TabIndex = 120;
            // 
            // ngayKetthucDateEdit
            // 
            this.ngayKetthucDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanvienModelBindingSource, "NgayKetthuc", true));
            this.ngayKetthucDateEdit.EditValue = null;
            this.ngayKetthucDateEdit.Location = new System.Drawing.Point(216, 105);
            this.ngayKetthucDateEdit.Name = "ngayKetthucDateEdit";
            this.ngayKetthucDateEdit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.ngayKetthucDateEdit.Properties.Appearance.Options.UseBackColor = true;
            this.ngayKetthucDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayKetthucDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayKetthucDateEdit.Properties.ReadOnly = true;
            this.ngayKetthucDateEdit.Size = new System.Drawing.Size(267, 32);
            this.ngayKetthucDateEdit.TabIndex = 117;
            // 
            // CobanGroupControl
            // 
            this.CobanGroupControl.Controls.Add(this.tenTinhthanhTextEdit);
            this.CobanGroupControl.Controls.Add(this.tenQuanhuyenTextEdit);
            this.CobanGroupControl.Controls.Add(this.tenPhongbanTextEdit);
            this.CobanGroupControl.Controls.Add(hovatenNhanvienLabel);
            this.CobanGroupControl.Controls.Add(this.hovatenNhanvienTextEdit);
            this.CobanGroupControl.Controls.Add(tinhthanhIdLabel);
            this.CobanGroupControl.Controls.Add(activeLabel);
            this.CobanGroupControl.Controls.Add(this.activeCheckEdit);
            this.CobanGroupControl.Controls.Add(cMNDLabel);
            this.CobanGroupControl.Controls.Add(this.cMNDTextEdit);
            this.CobanGroupControl.Controls.Add(codeLabel);
            this.CobanGroupControl.Controls.Add(this.codeTextEdit);
            this.CobanGroupControl.Controls.Add(diachiLabel);
            this.CobanGroupControl.Controls.Add(this.diachiTextEdit);
            this.CobanGroupControl.Controls.Add(emailLabel);
            this.CobanGroupControl.Controls.Add(this.emailTextEdit);
            this.CobanGroupControl.Controls.Add(gioitinhLabel);
            this.CobanGroupControl.Controls.Add(this.gioitinhCheckEdit);
            this.CobanGroupControl.Controls.Add(mobileLabel);
            this.CobanGroupControl.Controls.Add(this.mobileTextEdit);
            this.CobanGroupControl.Controls.Add(ngaysinhLabel);
            this.CobanGroupControl.Controls.Add(this.ngaysinhDateEdit);
            this.CobanGroupControl.Controls.Add(quanhuyenIdLabel);
            this.CobanGroupControl.Controls.Add(telLabel);
            this.CobanGroupControl.Controls.Add(this.telTextEdit);
            this.CobanGroupControl.Controls.Add(tenNhomNhanvienLabel);
            this.CobanGroupControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.CobanGroupControl.Location = new System.Drawing.Point(0, 0);
            this.CobanGroupControl.Name = "CobanGroupControl";
            this.CobanGroupControl.Size = new System.Drawing.Size(1029, 381);
            this.CobanGroupControl.TabIndex = 119;
            this.CobanGroupControl.Text = "Cơ bản";
            // 
            // tenTinhthanhTextEdit
            // 
            this.tenTinhthanhTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanvienModelBindingSource, "TenTinhthanh", true));
            this.tenTinhthanhTextEdit.Location = new System.Drawing.Point(694, 255);
            this.tenTinhthanhTextEdit.Name = "tenTinhthanhTextEdit";
            this.tenTinhthanhTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.tenTinhthanhTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.tenTinhthanhTextEdit.Properties.ReadOnly = true;
            this.tenTinhthanhTextEdit.Size = new System.Drawing.Size(267, 32);
            this.tenTinhthanhTextEdit.TabIndex = 147;
            // 
            // tenQuanhuyenTextEdit
            // 
            this.tenQuanhuyenTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanvienModelBindingSource, "TenQuanhuyen", true));
            this.tenQuanhuyenTextEdit.Location = new System.Drawing.Point(694, 208);
            this.tenQuanhuyenTextEdit.Name = "tenQuanhuyenTextEdit";
            this.tenQuanhuyenTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.tenQuanhuyenTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.tenQuanhuyenTextEdit.Properties.ReadOnly = true;
            this.tenQuanhuyenTextEdit.Size = new System.Drawing.Size(267, 32);
            this.tenQuanhuyenTextEdit.TabIndex = 146;
            // 
            // tenPhongbanTextEdit
            // 
            this.tenPhongbanTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanvienModelBindingSource, "TenPhongban", true));
            this.tenPhongbanTextEdit.Location = new System.Drawing.Point(216, 302);
            this.tenPhongbanTextEdit.Name = "tenPhongbanTextEdit";
            this.tenPhongbanTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.tenPhongbanTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.tenPhongbanTextEdit.Properties.ReadOnly = true;
            this.tenPhongbanTextEdit.Size = new System.Drawing.Size(267, 32);
            this.tenPhongbanTextEdit.TabIndex = 145;
            // 
            // hovatenNhanvienTextEdit
            // 
            this.hovatenNhanvienTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanvienModelBindingSource, "HovatenNhanvien", true));
            this.hovatenNhanvienTextEdit.Location = new System.Drawing.Point(216, 110);
            this.hovatenNhanvienTextEdit.Name = "hovatenNhanvienTextEdit";
            this.hovatenNhanvienTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.hovatenNhanvienTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.hovatenNhanvienTextEdit.Properties.ReadOnly = true;
            this.hovatenNhanvienTextEdit.Size = new System.Drawing.Size(267, 32);
            this.hovatenNhanvienTextEdit.TabIndex = 144;
            // 
            // activeCheckEdit
            // 
            this.activeCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanvienModelBindingSource, "Active", true));
            this.activeCheckEdit.EditValue = true;
            this.activeCheckEdit.Location = new System.Drawing.Point(458, 161);
            this.activeCheckEdit.Name = "activeCheckEdit";
            this.activeCheckEdit.Properties.Caption = "";
            this.activeCheckEdit.Properties.ReadOnly = true;
            this.activeCheckEdit.Size = new System.Drawing.Size(36, 19);
            this.activeCheckEdit.TabIndex = 131;
            // 
            // cMNDTextEdit
            // 
            this.cMNDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanvienModelBindingSource, "CMND", true));
            this.cMNDTextEdit.Location = new System.Drawing.Point(216, 251);
            this.cMNDTextEdit.Name = "cMNDTextEdit";
            this.cMNDTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cMNDTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.cMNDTextEdit.Properties.ReadOnly = true;
            this.cMNDTextEdit.Size = new System.Drawing.Size(267, 32);
            this.cMNDTextEdit.TabIndex = 128;
            // 
            // codeTextEdit
            // 
            this.codeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanvienModelBindingSource, "Code", true));
            this.codeTextEdit.Location = new System.Drawing.Point(216, 55);
            this.codeTextEdit.Name = "codeTextEdit";
            this.codeTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.codeTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.codeTextEdit.Properties.ReadOnly = true;
            this.codeTextEdit.Size = new System.Drawing.Size(267, 32);
            this.codeTextEdit.TabIndex = 120;
            // 
            // diachiTextEdit
            // 
            this.diachiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanvienModelBindingSource, "Diachi", true));
            this.diachiTextEdit.Location = new System.Drawing.Point(694, 159);
            this.diachiTextEdit.Name = "diachiTextEdit";
            this.diachiTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.diachiTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.diachiTextEdit.Properties.ReadOnly = true;
            this.diachiTextEdit.Size = new System.Drawing.Size(267, 32);
            this.diachiTextEdit.TabIndex = 123;
            // 
            // emailTextEdit
            // 
            this.emailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanvienModelBindingSource, "Email", true));
            this.emailTextEdit.Location = new System.Drawing.Point(694, 306);
            this.emailTextEdit.Name = "emailTextEdit";
            this.emailTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.emailTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.emailTextEdit.Properties.ReadOnly = true;
            this.emailTextEdit.Size = new System.Drawing.Size(267, 32);
            this.emailTextEdit.TabIndex = 136;
            // 
            // gioitinhCheckEdit
            // 
            this.gioitinhCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanvienModelBindingSource, "Gioitinh", true));
            this.gioitinhCheckEdit.EditValue = true;
            this.gioitinhCheckEdit.Location = new System.Drawing.Point(214, 161);
            this.gioitinhCheckEdit.Name = "gioitinhCheckEdit";
            this.gioitinhCheckEdit.Properties.Caption = "";
            this.gioitinhCheckEdit.Properties.ReadOnly = true;
            this.gioitinhCheckEdit.Size = new System.Drawing.Size(98, 19);
            this.gioitinhCheckEdit.TabIndex = 130;
            // 
            // mobileTextEdit
            // 
            this.mobileTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanvienModelBindingSource, "Mobile", true));
            this.mobileTextEdit.Location = new System.Drawing.Point(694, 110);
            this.mobileTextEdit.Name = "mobileTextEdit";
            this.mobileTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.mobileTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.mobileTextEdit.Properties.ReadOnly = true;
            this.mobileTextEdit.Size = new System.Drawing.Size(267, 32);
            this.mobileTextEdit.TabIndex = 135;
            // 
            // ngaysinhDateEdit
            // 
            this.ngaysinhDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanvienModelBindingSource, "Ngaysinh", true));
            this.ngaysinhDateEdit.EditValue = null;
            this.ngaysinhDateEdit.Location = new System.Drawing.Point(216, 199);
            this.ngaysinhDateEdit.Name = "ngaysinhDateEdit";
            this.ngaysinhDateEdit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.ngaysinhDateEdit.Properties.Appearance.Options.UseBackColor = true;
            this.ngaysinhDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngaysinhDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngaysinhDateEdit.Properties.ReadOnly = true;
            this.ngaysinhDateEdit.Size = new System.Drawing.Size(267, 32);
            this.ngaysinhDateEdit.TabIndex = 132;
            // 
            // telTextEdit
            // 
            this.telTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanvienModelBindingSource, "Tel", true));
            this.telTextEdit.Location = new System.Drawing.Point(694, 61);
            this.telTextEdit.Name = "telTextEdit";
            this.telTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.telTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.telTextEdit.Properties.ReadOnly = true;
            this.telTextEdit.Size = new System.Drawing.Size(267, 32);
            this.telTextEdit.TabIndex = 133;
            // 
            // linkanhTextEdit
            // 
            this.linkanhTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanvienModelBindingSource, "Linkanh", true));
            this.linkanhTextEdit.Location = new System.Drawing.Point(48, 946);
            this.linkanhTextEdit.Name = "linkanhTextEdit";
            this.linkanhTextEdit.Size = new System.Drawing.Size(100, 32);
            this.linkanhTextEdit.TabIndex = 116;
            this.linkanhTextEdit.Visible = false;
            // 
            // ghichuTextEdit
            // 
            this.ghichuTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ghichuTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanvienModelBindingSource, "Ghichu", true));
            this.ghichuTextEdit.Location = new System.Drawing.Point(216, 837);
            this.ghichuTextEdit.Name = "ghichuTextEdit";
            this.ghichuTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.ghichuTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.ghichuTextEdit.Properties.ReadOnly = true;
            this.ghichuTextEdit.Size = new System.Drawing.Size(745, 229);
            this.ghichuTextEdit.TabIndex = 104;
            this.ghichuTextEdit.UseOptimizedRendering = true;
            // 
            // RightPanelControl
            // 
            this.RightPanelControl.Controls.Add(this.nhanvienModelGridControl);
            this.RightPanelControl.Controls.Add(this.NhanvienActionGroupControl);
            this.RightPanelControl.Controls.Add(this.panelControl1);
            this.RightPanelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightPanelControl.Location = new System.Drawing.Point(1039, 0);
            this.RightPanelControl.Name = "RightPanelControl";
            this.RightPanelControl.Size = new System.Drawing.Size(932, 1162);
            this.RightPanelControl.TabIndex = 3;
            // 
            // nhanvienModelGridControl
            // 
            this.nhanvienModelGridControl.DataSource = this.nhanvienModelBindingSource;
            this.nhanvienModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nhanvienModelGridControl.Location = new System.Drawing.Point(2, 98);
            this.nhanvienModelGridControl.MainView = this.nhanvienModelGridView;
            this.nhanvienModelGridControl.Name = "nhanvienModelGridControl";
            this.nhanvienModelGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.nhanvienModelGridControl.Size = new System.Drawing.Size(928, 926);
            this.nhanvienModelGridControl.TabIndex = 4;
            this.nhanvienModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.nhanvienModelGridView});
            // 
            // nhanvienModelGridView
            // 
            this.nhanvienModelGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNhanvienId,
            this.colQuanhuyenId,
            this.colTinhthanhId,
            this.colStep,
            this.colNgaysinh,
            this.colNgayBatdau,
            this.colNgayKetthuc,
            this.colNgayCapnhat,
            this.colGioitinh,
            this.colActive,
            this.colVersion,
            this.colCode,
            this.colTenNhanvien,
            this.colHoNhanvien,
            this.colHovatenNhanvien,
            this.colCMND,
            this.colEmail,
            this.colTel,
            this.colMobile,
            this.colDiachi,
            this.colGhichu,
            this.colLinkanh,
            this.colTenTinhthanh,
            this.colTenQuanhuyen,
            this.colTenNhomNhanvien,
            this.colState,
            this.NoGridColumn});
            this.nhanvienModelGridView.GridControl = this.nhanvienModelGridControl;
            this.nhanvienModelGridView.Name = "nhanvienModelGridView";
            this.nhanvienModelGridView.OptionsBehavior.Editable = false;
            this.nhanvienModelGridView.OptionsView.ShowAutoFilterRow = true;
            this.nhanvienModelGridView.OptionsView.ShowFooter = true;
            this.nhanvienModelGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colNhanvienId
            // 
            this.colNhanvienId.FieldName = "NhanvienId";
            this.colNhanvienId.Name = "colNhanvienId";
            // 
            // colQuanhuyenId
            // 
            this.colQuanhuyenId.FieldName = "QuanhuyenId";
            this.colQuanhuyenId.Name = "colQuanhuyenId";
            // 
            // colTinhthanhId
            // 
            this.colTinhthanhId.FieldName = "TinhthanhId";
            this.colTinhthanhId.Name = "colTinhthanhId";
            // 
            // colStep
            // 
            this.colStep.FieldName = "Step";
            this.colStep.Name = "colStep";
            // 
            // colNgaysinh
            // 
            this.colNgaysinh.Caption = "Ngày sinh";
            this.colNgaysinh.FieldName = "Ngaysinh";
            this.colNgaysinh.Name = "colNgaysinh";
            // 
            // colNgayBatdau
            // 
            this.colNgayBatdau.Caption = "Ngày bắt đầu";
            this.colNgayBatdau.FieldName = "NgayBatdau";
            this.colNgayBatdau.Name = "colNgayBatdau";
            // 
            // colNgayKetthuc
            // 
            this.colNgayKetthuc.Caption = "Ngày kết thúc";
            this.colNgayKetthuc.FieldName = "NgayKetthuc";
            this.colNgayKetthuc.Name = "colNgayKetthuc";
            // 
            // colNgayCapnhat
            // 
            this.colNgayCapnhat.Caption = "Ngày cập nhật";
            this.colNgayCapnhat.FieldName = "NgayCapnhat";
            this.colNgayCapnhat.Name = "colNgayCapnhat";
            this.colNgayCapnhat.Visible = true;
            this.colNgayCapnhat.VisibleIndex = 6;
            this.colNgayCapnhat.Width = 92;
            // 
            // colGioitinh
            // 
            this.colGioitinh.Caption = "Giới Tính";
            this.colGioitinh.FieldName = "Gioitinh";
            this.colGioitinh.Name = "colGioitinh";
            // 
            // colActive
            // 
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 5;
            this.colActive.Width = 92;
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
            this.colCode.Width = 198;
            // 
            // colTenNhanvien
            // 
            this.colTenNhanvien.FieldName = "TenNhanvien";
            this.colTenNhanvien.Name = "colTenNhanvien";
            // 
            // colHoNhanvien
            // 
            this.colHoNhanvien.FieldName = "HoNhanvien";
            this.colHoNhanvien.Name = "colHoNhanvien";
            // 
            // colHovatenNhanvien
            // 
            this.colHovatenNhanvien.Caption = "Họ và Tên";
            this.colHovatenNhanvien.FieldName = "HovatenNhanvien";
            this.colHovatenNhanvien.Name = "colHovatenNhanvien";
            this.colHovatenNhanvien.Visible = true;
            this.colHovatenNhanvien.VisibleIndex = 2;
            this.colHovatenNhanvien.Width = 324;
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.Name = "colCMND";
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 4;
            this.colEmail.Width = 92;
            // 
            // colTel
            // 
            this.colTel.FieldName = "Tel";
            this.colTel.Name = "colTel";
            this.colTel.Visible = true;
            this.colTel.VisibleIndex = 3;
            this.colTel.Width = 123;
            // 
            // colMobile
            // 
            this.colMobile.FieldName = "Mobile";
            this.colMobile.Name = "colMobile";
            this.colMobile.Width = 127;
            // 
            // colDiachi
            // 
            this.colDiachi.Caption = "Địa chỉ";
            this.colDiachi.FieldName = "Diachi";
            this.colDiachi.Name = "colDiachi";
            // 
            // colGhichu
            // 
            this.colGhichu.Caption = "Ghi chú";
            this.colGhichu.FieldName = "Ghichu";
            this.colGhichu.Name = "colGhichu";
            // 
            // colLinkanh
            // 
            this.colLinkanh.Caption = "Hình ảnh";
            this.colLinkanh.FieldName = "Linkanh";
            this.colLinkanh.Name = "colLinkanh";
            // 
            // colTenTinhthanh
            // 
            this.colTenTinhthanh.Caption = "Tỉnh thành";
            this.colTenTinhthanh.FieldName = "TenTinhthanh";
            this.colTenTinhthanh.Name = "colTenTinhthanh";
            // 
            // colTenQuanhuyen
            // 
            this.colTenQuanhuyen.Caption = "Quận huyện";
            this.colTenQuanhuyen.FieldName = "TenQuanhuyen";
            this.colTenQuanhuyen.Name = "colTenQuanhuyen";
            // 
            // colTenNhomNhanvien
            // 
            this.colTenNhomNhanvien.Caption = "Nhóm";
            this.colTenNhomNhanvien.FieldName = "TenNhomNhanvien";
            this.colTenNhomNhanvien.Name = "colTenNhomNhanvien";
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.OptionsColumn.ReadOnly = true;
            this.colState.Visible = true;
            this.colState.VisibleIndex = 7;
            this.colState.Width = 110;
            // 
            // NoGridColumn
            // 
            this.NoGridColumn.Caption = "STT";
            this.NoGridColumn.Name = "NoGridColumn";
            this.NoGridColumn.Visible = true;
            this.NoGridColumn.VisibleIndex = 0;
            this.NoGridColumn.Width = 98;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // NhanvienActionGroupControl
            // 
            this.NhanvienActionGroupControl.Controls.Add(this.addNhanvienSimpleButton);
            this.NhanvienActionGroupControl.Controls.Add(this.editNhanvienSimpleButton);
            this.NhanvienActionGroupControl.Controls.Add(this.deleteNhanvienSimpleButton);
            this.NhanvienActionGroupControl.Controls.Add(this.saveNhanvienSimpleButton);
            this.NhanvienActionGroupControl.Controls.Add(this.exportNhanvienSimpleButton);
            this.NhanvienActionGroupControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NhanvienActionGroupControl.Location = new System.Drawing.Point(2, 1024);
            this.NhanvienActionGroupControl.Name = "NhanvienActionGroupControl";
            this.NhanvienActionGroupControl.Size = new System.Drawing.Size(928, 136);
            this.NhanvienActionGroupControl.TabIndex = 2;
            this.NhanvienActionGroupControl.Text = "Thao tác Nhân viên";
            // 
            // addNhanvienSimpleButton
            // 
            this.addNhanvienSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addNhanvienSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("addNhanvienSimpleButton.Image")));
            this.addNhanvienSimpleButton.Location = new System.Drawing.Point(316, 51);
            this.addNhanvienSimpleButton.Name = "addNhanvienSimpleButton";
            this.addNhanvienSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.addNhanvienSimpleButton.TabIndex = 4;
            this.addNhanvienSimpleButton.Text = "Thêm";
            this.addNhanvienSimpleButton.Click += new System.EventHandler(this.addNhanvienSimpleButton_Click);
            // 
            // editNhanvienSimpleButton
            // 
            this.editNhanvienSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.editNhanvienSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("editNhanvienSimpleButton.Image")));
            this.editNhanvienSimpleButton.Location = new System.Drawing.Point(605, 51);
            this.editNhanvienSimpleButton.Name = "editNhanvienSimpleButton";
            this.editNhanvienSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.editNhanvienSimpleButton.TabIndex = 3;
            this.editNhanvienSimpleButton.Text = "Sửa";
            this.editNhanvienSimpleButton.Click += new System.EventHandler(this.editNhanvienSimpleButton_Click);
            // 
            // deleteNhanvienSimpleButton
            // 
            this.deleteNhanvienSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deleteNhanvienSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteNhanvienSimpleButton.Image")));
            this.deleteNhanvienSimpleButton.Location = new System.Drawing.Point(18, 51);
            this.deleteNhanvienSimpleButton.Name = "deleteNhanvienSimpleButton";
            this.deleteNhanvienSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.deleteNhanvienSimpleButton.TabIndex = 6;
            this.deleteNhanvienSimpleButton.Text = "Xóa";
            this.deleteNhanvienSimpleButton.Click += new System.EventHandler(this.deleteNhanvienSimpleButton_Click);
            // 
            // saveNhanvienSimpleButton
            // 
            this.saveNhanvienSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.saveNhanvienSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("saveNhanvienSimpleButton.Image")));
            this.saveNhanvienSimpleButton.Location = new System.Drawing.Point(756, 51);
            this.saveNhanvienSimpleButton.Name = "saveNhanvienSimpleButton";
            this.saveNhanvienSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.saveNhanvienSimpleButton.TabIndex = 2;
            this.saveNhanvienSimpleButton.Text = "Lưu";
            this.saveNhanvienSimpleButton.Click += new System.EventHandler(this.saveNhanvienSimpleButton_Click);
            // 
            // exportNhanvienSimpleButton
            // 
            this.exportNhanvienSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.exportNhanvienSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("exportNhanvienSimpleButton.Image")));
            this.exportNhanvienSimpleButton.Location = new System.Drawing.Point(167, 51);
            this.exportNhanvienSimpleButton.Name = "exportNhanvienSimpleButton";
            this.exportNhanvienSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.exportNhanvienSimpleButton.TabIndex = 5;
            this.exportNhanvienSimpleButton.Text = "Excel";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(phongbanIdLabel);
            this.panelControl1.Controls.Add(this.reloadNhanvienSimpleButton);
            this.panelControl1.Controls.Add(this.phongbanIdTextEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(928, 96);
            this.panelControl1.TabIndex = 3;
            // 
            // reloadNhanvienSimpleButton
            // 
            this.reloadNhanvienSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("reloadNhanvienSimpleButton.Image")));
            this.reloadNhanvienSimpleButton.Location = new System.Drawing.Point(497, 32);
            this.reloadNhanvienSimpleButton.Name = "reloadNhanvienSimpleButton";
            this.reloadNhanvienSimpleButton.Size = new System.Drawing.Size(139, 32);
            this.reloadNhanvienSimpleButton.TabIndex = 1;
            this.reloadNhanvienSimpleButton.Text = "Lọc";
            this.reloadNhanvienSimpleButton.Click += new System.EventHandler(this.reloadNhanvienSimpleButton_Click);
            // 
            // phongbanIdTextEdit
            // 
            this.phongbanIdTextEdit.Location = new System.Drawing.Point(214, 32);
            this.phongbanIdTextEdit.Name = "phongbanIdTextEdit";
            this.phongbanIdTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.phongbanIdTextEdit.Properties.DataSource = this.phongbanModelBindingSource;
            this.phongbanIdTextEdit.Properties.DisplayMember = "TenPhongban";
            this.phongbanIdTextEdit.Properties.NullText = "";
            this.phongbanIdTextEdit.Properties.ValueMember = "PhongbanId";
            this.phongbanIdTextEdit.Properties.View = this.gridLookUpEdit1View;
            this.phongbanIdTextEdit.Size = new System.Drawing.Size(267, 32);
            this.phongbanIdTextEdit.TabIndex = 1;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "PhongbanId";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "Step";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "NgayCapnhat";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "Active";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "Version";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "Code";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Phòng ban";
            this.gridColumn7.FieldName = "TenPhongban";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            // 
            // gridColumn8
            // 
            this.gridColumn8.FieldName = "Ghichu";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // gridColumn9
            // 
            this.gridColumn9.FieldName = "State";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.ReadOnly = true;
            // 
            // NhanvienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1971, 1162);
            this.Controls.Add(this.RightPanelControl);
            this.Controls.Add(this.LeftPanelControl);
            this.Name = "NhanvienForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongbanModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPanelControl)).EndInit();
            this.LeftPanelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VieclamGroupControl)).EndInit();
            this.VieclamGroupControl.ResumeLayout(false);
            this.VieclamGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnhMyPictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayBatdauDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayBatdauDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayKetthucDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayKetthucDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CobanGroupControl)).EndInit();
            this.CobanGroupControl.ResumeLayout(false);
            this.CobanGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tenTinhthanhTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenQuanhuyenTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenPhongbanTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hovatenNhanvienTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMNDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diachiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gioitinhCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaysinhDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaysinhDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkanhTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghichuTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightPanelControl)).EndInit();
            this.RightPanelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienModelGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanvienActionGroupControl)).EndInit();
            this.NhanvienActionGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phongbanIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource nhanvienModelBindingSource;
        private System.Windows.Forms.BindingSource phongbanModelBindingSource;
        private DevExpress.XtraEditors.PanelControl LeftPanelControl;
        private DevExpress.XtraEditors.PanelControl RightPanelControl;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.GroupControl CobanGroupControl;
        private DevExpress.XtraEditors.TextEdit hovatenNhanvienTextEdit;
        private DevExpress.XtraEditors.CheckEdit activeCheckEdit;
        private DevExpress.XtraEditors.TextEdit cMNDTextEdit;
        private DevExpress.XtraEditors.TextEdit codeTextEdit;
        private DevExpress.XtraEditors.TextEdit diachiTextEdit;
        private DevExpress.XtraEditors.TextEdit emailTextEdit;
        private DevExpress.XtraEditors.CheckEdit gioitinhCheckEdit;
        private DevExpress.XtraEditors.TextEdit mobileTextEdit;
        private DevExpress.XtraEditors.DateEdit ngaysinhDateEdit;
        private DevExpress.XtraEditors.TextEdit telTextEdit;
        private DevExpress.XtraEditors.TextEdit linkanhTextEdit;
        private DevExpress.XtraEditors.MemoEdit ghichuTextEdit;
        private DevExpress.XtraEditors.GroupControl VieclamGroupControl;
        private MyPictureEdit AnhMyPictureEdit;
        private DevExpress.XtraEditors.DateEdit ngayBatdauDateEdit;
        private DevExpress.XtraEditors.DateEdit ngayCapnhatDateEdit;
        private DevExpress.XtraEditors.DateEdit ngayKetthucDateEdit;
        private DevExpress.XtraEditors.TextEdit tenTinhthanhTextEdit;
        private DevExpress.XtraEditors.TextEdit tenQuanhuyenTextEdit;
        private DevExpress.XtraEditors.TextEdit tenPhongbanTextEdit;
        private DevExpress.XtraGrid.GridControl nhanvienModelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView nhanvienModelGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colNhanvienId;
        private DevExpress.XtraGrid.Columns.GridColumn colQuanhuyenId;
        private DevExpress.XtraGrid.Columns.GridColumn colTinhthanhId;
        private DevExpress.XtraGrid.Columns.GridColumn colStep;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaysinh;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayBatdau;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayKetthuc;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayCapnhat;
        private DevExpress.XtraGrid.Columns.GridColumn colGioitinh;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNhanvien;
        private DevExpress.XtraGrid.Columns.GridColumn colHoNhanvien;
        private DevExpress.XtraGrid.Columns.GridColumn colHovatenNhanvien;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colTel;
        private DevExpress.XtraGrid.Columns.GridColumn colMobile;
        private DevExpress.XtraGrid.Columns.GridColumn colDiachi;
        private DevExpress.XtraGrid.Columns.GridColumn colGhichu;
        private DevExpress.XtraGrid.Columns.GridColumn colLinkanh;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTinhthanh;
        private DevExpress.XtraGrid.Columns.GridColumn colTenQuanhuyen;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNhomNhanvien;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraGrid.Columns.GridColumn NoGridColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.GroupControl NhanvienActionGroupControl;
        private DevExpress.XtraEditors.SimpleButton addNhanvienSimpleButton;
        private DevExpress.XtraEditors.SimpleButton editNhanvienSimpleButton;
        private DevExpress.XtraEditors.SimpleButton deleteNhanvienSimpleButton;
        private DevExpress.XtraEditors.SimpleButton saveNhanvienSimpleButton;
        private DevExpress.XtraEditors.SimpleButton reloadNhanvienSimpleButton;
        private DevExpress.XtraEditors.SimpleButton exportNhanvienSimpleButton;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GridLookUpEdit phongbanIdTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
    }
}