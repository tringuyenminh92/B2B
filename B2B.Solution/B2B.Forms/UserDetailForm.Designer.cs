namespace B2B.Forms
{
    partial class UserDetailForm
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
            System.Windows.Forms.Label _PasswordLabel;
            System.Windows.Forms.Label _UsernameLabel;
            System.Windows.Forms.Label tenNhanvienLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDetailForm));
            this.InformationGroupControl = new DevExpress.XtraEditors.GroupControl();
            this._PasswordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.userModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._UsernameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tenNhanvienTextEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.nhanvienModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.NoGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.CancelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.OkSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            _PasswordLabel = new System.Windows.Forms.Label();
            _UsernameLabel = new System.Windows.Forms.Label();
            tenNhanvienLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InformationGroupControl)).BeginInit();
            this.InformationGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._PasswordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._UsernameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenNhanvienTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // _PasswordLabel
            // 
            _PasswordLabel.AutoSize = true;
            _PasswordLabel.Location = new System.Drawing.Point(421, 71);
            _PasswordLabel.Name = "_PasswordLabel";
            _PasswordLabel.Size = new System.Drawing.Size(114, 25);
            _PasswordLabel.TabIndex = 0;
            _PasswordLabel.Text = " Password:";
            // 
            // _UsernameLabel
            // 
            _UsernameLabel.AutoSize = true;
            _UsernameLabel.Location = new System.Drawing.Point(41, 71);
            _UsernameLabel.Name = "_UsernameLabel";
            _UsernameLabel.Size = new System.Drawing.Size(120, 25);
            _UsernameLabel.TabIndex = 2;
            _UsernameLabel.Text = " Username:";
            // 
            // tenNhanvienLabel
            // 
            tenNhanvienLabel.AutoSize = true;
            tenNhanvienLabel.Location = new System.Drawing.Point(48, 128);
            tenNhanvienLabel.Name = "tenNhanvienLabel";
            tenNhanvienLabel.Size = new System.Drawing.Size(113, 25);
            tenNhanvienLabel.TabIndex = 10;
            tenNhanvienLabel.Text = "Nhân viên:";
            // 
            // InformationGroupControl
            // 
            this.InformationGroupControl.Controls.Add(_PasswordLabel);
            this.InformationGroupControl.Controls.Add(this._PasswordTextEdit);
            this.InformationGroupControl.Controls.Add(_UsernameLabel);
            this.InformationGroupControl.Controls.Add(this._UsernameTextEdit);
            this.InformationGroupControl.Controls.Add(tenNhanvienLabel);
            this.InformationGroupControl.Controls.Add(this.tenNhanvienTextEdit);
            this.InformationGroupControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.InformationGroupControl.Location = new System.Drawing.Point(0, 0);
            this.InformationGroupControl.Name = "InformationGroupControl";
            this.InformationGroupControl.Size = new System.Drawing.Size(836, 194);
            this.InformationGroupControl.TabIndex = 0;
            this.InformationGroupControl.Text = "Thông tin User";
            // 
            // _PasswordTextEdit
            // 
            this._PasswordTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userModelBindingSource, "_Password", true));
            this._PasswordTextEdit.Location = new System.Drawing.Point(578, 68);
            this._PasswordTextEdit.Name = "_PasswordTextEdit";
            this._PasswordTextEdit.Properties.MaxLength = 31;
            this._PasswordTextEdit.Properties.PasswordChar = '*';
            this._PasswordTextEdit.Properties.UseSystemPasswordChar = true;
            this._PasswordTextEdit.Size = new System.Drawing.Size(207, 32);
            this._PasswordTextEdit.TabIndex = 1;
            // 
            // userModelBindingSource
            // 
            this.userModelBindingSource.DataSource = typeof(B2B.Model.UserModel);
            // 
            // _UsernameTextEdit
            // 
            this._UsernameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userModelBindingSource, "_Username", true));
            this._UsernameTextEdit.Location = new System.Drawing.Point(198, 68);
            this._UsernameTextEdit.Name = "_UsernameTextEdit";
            this._UsernameTextEdit.Properties.MaxLength = 31;
            this._UsernameTextEdit.Properties.PasswordChar = '*';
            this._UsernameTextEdit.Properties.UseSystemPasswordChar = true;
            this._UsernameTextEdit.Size = new System.Drawing.Size(207, 32);
            this._UsernameTextEdit.TabIndex = 0;
            // 
            // tenNhanvienTextEdit
            // 
            this.tenNhanvienTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userModelBindingSource, "NhanvienId", true));
            this.tenNhanvienTextEdit.Location = new System.Drawing.Point(198, 125);
            this.tenNhanvienTextEdit.Name = "tenNhanvienTextEdit";
            this.tenNhanvienTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tenNhanvienTextEdit.Properties.DataSource = this.nhanvienModelBindingSource;
            this.tenNhanvienTextEdit.Properties.DisplayMember = "TenNhanvien";
            this.tenNhanvienTextEdit.Properties.NullText = "";
            this.tenNhanvienTextEdit.Properties.ValueMember = "NhanvienId";
            this.tenNhanvienTextEdit.Properties.View = this.searchLookUpEdit1View;
            this.tenNhanvienTextEdit.Size = new System.Drawing.Size(587, 32);
            this.tenNhanvienTextEdit.TabIndex = 2;
            // 
            // nhanvienModelBindingSource
            // 
            this.nhanvienModelBindingSource.DataSource = typeof(B2B.Model.NhanvienModel);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.NoGridColumn,
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
            this.colState});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.searchLookUpEdit1View.OptionsView.ShowFooter = true;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
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
            this.colNgaysinh.FieldName = "Ngaysinh";
            this.colNgaysinh.Name = "colNgaysinh";
            // 
            // colNgayBatdau
            // 
            this.colNgayBatdau.FieldName = "NgayBatdau";
            this.colNgayBatdau.Name = "colNgayBatdau";
            // 
            // colNgayKetthuc
            // 
            this.colNgayKetthuc.FieldName = "NgayKetthuc";
            this.colNgayKetthuc.Name = "colNgayKetthuc";
            // 
            // colNgayCapnhat
            // 
            this.colNgayCapnhat.FieldName = "NgayCapnhat";
            this.colNgayCapnhat.Name = "colNgayCapnhat";
            // 
            // colGioitinh
            // 
            this.colGioitinh.FieldName = "Gioitinh";
            this.colGioitinh.Name = "colGioitinh";
            // 
            // colActive
            // 
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            // 
            // NoGridColumn
            // 
            this.NoGridColumn.Caption = "STT";
            this.NoGridColumn.Name = "NoGridColumn";
            this.NoGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.NoGridColumn.Visible = true;
            this.NoGridColumn.VisibleIndex = 0;
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
            this.colHovatenNhanvien.Caption = "Họ Và Tên";
            this.colHovatenNhanvien.FieldName = "HovatenNhanvien";
            this.colHovatenNhanvien.Name = "colHovatenNhanvien";
            this.colHovatenNhanvien.Visible = true;
            this.colHovatenNhanvien.VisibleIndex = 2;
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
            // 
            // colTel
            // 
            this.colTel.FieldName = "Tel";
            this.colTel.Name = "colTel";
            // 
            // colMobile
            // 
            this.colMobile.FieldName = "Mobile";
            this.colMobile.Name = "colMobile";
            // 
            // colDiachi
            // 
            this.colDiachi.FieldName = "Diachi";
            this.colDiachi.Name = "colDiachi";
            // 
            // colGhichu
            // 
            this.colGhichu.FieldName = "Ghichu";
            this.colGhichu.Name = "colGhichu";
            // 
            // colLinkanh
            // 
            this.colLinkanh.FieldName = "Linkanh";
            this.colLinkanh.Name = "colLinkanh";
            // 
            // colTenTinhthanh
            // 
            this.colTenTinhthanh.FieldName = "TenTinhthanh";
            this.colTenTinhthanh.Name = "colTenTinhthanh";
            // 
            // colTenQuanhuyen
            // 
            this.colTenQuanhuyen.FieldName = "TenQuanhuyen";
            this.colTenQuanhuyen.Name = "colTenQuanhuyen";
            // 
            // colTenNhomNhanvien
            // 
            this.colTenNhomNhanvien.FieldName = "TenNhomNhanvien";
            this.colTenNhomNhanvien.Name = "colTenNhomNhanvien";
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.OptionsColumn.ReadOnly = true;
            // 
            // CancelSimpleButton
            // 
            this.CancelSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelSimpleButton.Image")));
            this.CancelSimpleButton.Location = new System.Drawing.Point(644, 217);
            this.CancelSimpleButton.Name = "CancelSimpleButton";
            this.CancelSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.CancelSimpleButton.TabIndex = 4;
            this.CancelSimpleButton.Text = "Cancel";
            this.CancelSimpleButton.Click += new System.EventHandler(this.CancelSimpleButton_Click);
            // 
            // OkSimpleButton
            // 
            this.OkSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("OkSimpleButton.Image")));
            this.OkSimpleButton.Location = new System.Drawing.Point(481, 217);
            this.OkSimpleButton.Name = "OkSimpleButton";
            this.OkSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.OkSimpleButton.TabIndex = 3;
            this.OkSimpleButton.Text = "OK";
            this.OkSimpleButton.Click += new System.EventHandler(this.OkSimpleButton_Click);
            // 
            // UserDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 297);
            this.Controls.Add(this.CancelSimpleButton);
            this.Controls.Add(this.OkSimpleButton);
            this.Controls.Add(this.InformationGroupControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(862, 368);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(862, 368);
            this.Name = "UserDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserDetailForm";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UserDetailForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.InformationGroupControl)).EndInit();
            this.InformationGroupControl.ResumeLayout(false);
            this.InformationGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._PasswordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._UsernameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenNhanvienTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl InformationGroupControl;
        private DevExpress.XtraEditors.TextEdit _PasswordTextEdit;
        private System.Windows.Forms.BindingSource userModelBindingSource;
        private DevExpress.XtraEditors.TextEdit _UsernameTextEdit;
        private DevExpress.XtraEditors.SimpleButton CancelSimpleButton;
        private DevExpress.XtraEditors.SimpleButton OkSimpleButton;
        private DevExpress.XtraEditors.SearchLookUpEdit tenNhanvienTextEdit;
        private System.Windows.Forms.BindingSource nhanvienModelBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
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
    }
}