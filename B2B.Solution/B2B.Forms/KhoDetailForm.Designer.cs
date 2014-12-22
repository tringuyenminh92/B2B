namespace B2B.Forms
{
    partial class KhoDetailForm
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
            System.Windows.Forms.Label activeLabel;
            System.Windows.Forms.Label codeLabel;
            System.Windows.Forms.Label diachiLabel;
            System.Windows.Forms.Label ghichuLabel;
            System.Windows.Forms.Label ngayCapnhatLabel;
            System.Windows.Forms.Label tenKhoLabel;
            System.Windows.Forms.Label tinhthanhIdLabel;
            System.Windows.Forms.Label quanhuyenIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhoDetailForm));
            this.khoModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InformationGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.activeCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.codeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.diachiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ngayCapnhatDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.tenKhoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ghichuTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.tinhthanhIdTextEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.tinhthanhModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.quanhuyenIdTextEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.quanhuyenModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colQuanhuyenId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTinhthanhId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStep1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayCapnhat1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenQuanhuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhichu1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenTinhthanh1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CancelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.OkSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            activeLabel = new System.Windows.Forms.Label();
            codeLabel = new System.Windows.Forms.Label();
            diachiLabel = new System.Windows.Forms.Label();
            ghichuLabel = new System.Windows.Forms.Label();
            ngayCapnhatLabel = new System.Windows.Forms.Label();
            tenKhoLabel = new System.Windows.Forms.Label();
            tinhthanhIdLabel = new System.Windows.Forms.Label();
            quanhuyenIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.khoModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InformationGroupControl)).BeginInit();
            this.InformationGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diachiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenKhoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghichuTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhthanhIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhthanhModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanhuyenIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanhuyenModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // activeLabel
            // 
            activeLabel.AutoSize = true;
            activeLabel.Location = new System.Drawing.Point(342, 59);
            activeLabel.Name = "activeLabel";
            activeLabel.Size = new System.Drawing.Size(75, 25);
            activeLabel.TabIndex = 24;
            activeLabel.Text = "Active:";
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(41, 63);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(66, 25);
            codeLabel.TabIndex = 26;
            codeLabel.Text = "Code:";
            // 
            // diachiLabel
            // 
            diachiLabel.AutoSize = true;
            diachiLabel.Location = new System.Drawing.Point(41, 170);
            diachiLabel.Name = "diachiLabel";
            diachiLabel.Size = new System.Drawing.Size(84, 25);
            diachiLabel.TabIndex = 28;
            diachiLabel.Text = "Địa chỉ:";
            // 
            // ghichuLabel
            // 
            ghichuLabel.AutoSize = true;
            ghichuLabel.Location = new System.Drawing.Point(44, 225);
            ghichuLabel.Name = "ghichuLabel";
            ghichuLabel.Size = new System.Drawing.Size(91, 25);
            ghichuLabel.TabIndex = 30;
            ghichuLabel.Text = "Ghi chú:";
            // 
            // ngayCapnhatLabel
            // 
            ngayCapnhatLabel.AutoSize = true;
            ngayCapnhatLabel.Location = new System.Drawing.Point(537, 59);
            ngayCapnhatLabel.Name = "ngayCapnhatLabel";
            ngayCapnhatLabel.Size = new System.Drawing.Size(155, 25);
            ngayCapnhatLabel.TabIndex = 34;
            ngayCapnhatLabel.Text = "Ngày cập nhật:";
            // 
            // tenKhoLabel
            // 
            tenKhoLabel.AutoSize = true;
            tenKhoLabel.Location = new System.Drawing.Point(41, 115);
            tenKhoLabel.Name = "tenKhoLabel";
            tenKhoLabel.Size = new System.Drawing.Size(94, 25);
            tenKhoLabel.TabIndex = 40;
            tenKhoLabel.Text = "Tên kho:";
            // 
            // tinhthanhIdLabel
            // 
            tinhthanhIdLabel.AutoSize = true;
            tinhthanhIdLabel.Location = new System.Drawing.Point(537, 111);
            tinhthanhIdLabel.Name = "tinhthanhIdLabel";
            tinhthanhIdLabel.Size = new System.Drawing.Size(121, 25);
            tinhthanhIdLabel.TabIndex = 46;
            tinhthanhIdLabel.Text = "Tỉnh thành:";
            // 
            // quanhuyenIdLabel
            // 
            quanhuyenIdLabel.AutoSize = true;
            quanhuyenIdLabel.Location = new System.Drawing.Point(537, 166);
            quanhuyenIdLabel.Name = "quanhuyenIdLabel";
            quanhuyenIdLabel.Size = new System.Drawing.Size(133, 25);
            quanhuyenIdLabel.TabIndex = 36;
            quanhuyenIdLabel.Text = "Quận huyện:";
            // 
            // khoModelBindingSource
            // 
            this.khoModelBindingSource.DataSource = typeof(B2B.Model.KhoModel);
            this.khoModelBindingSource.CurrentItemChanged += new System.EventHandler(this.khoModelBindingSource_CurrentItemChanged);
            // 
            // InformationGroupControl
            // 
            this.InformationGroupControl.Controls.Add(activeLabel);
            this.InformationGroupControl.Controls.Add(this.activeCheckEdit);
            this.InformationGroupControl.Controls.Add(codeLabel);
            this.InformationGroupControl.Controls.Add(this.codeTextEdit);
            this.InformationGroupControl.Controls.Add(diachiLabel);
            this.InformationGroupControl.Controls.Add(this.diachiTextEdit);
            this.InformationGroupControl.Controls.Add(ghichuLabel);
            this.InformationGroupControl.Controls.Add(ngayCapnhatLabel);
            this.InformationGroupControl.Controls.Add(this.ngayCapnhatDateEdit);
            this.InformationGroupControl.Controls.Add(quanhuyenIdLabel);
            this.InformationGroupControl.Controls.Add(tenKhoLabel);
            this.InformationGroupControl.Controls.Add(this.tenKhoTextEdit);
            this.InformationGroupControl.Controls.Add(tinhthanhIdLabel);
            this.InformationGroupControl.Controls.Add(this.ghichuTextEdit);
            this.InformationGroupControl.Controls.Add(this.tinhthanhIdTextEdit);
            this.InformationGroupControl.Controls.Add(this.quanhuyenIdTextEdit);
            this.InformationGroupControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.InformationGroupControl.Location = new System.Drawing.Point(0, 0);
            this.InformationGroupControl.Name = "InformationGroupControl";
            this.InformationGroupControl.Size = new System.Drawing.Size(1061, 670);
            this.InformationGroupControl.TabIndex = 24;
            this.InformationGroupControl.Text = "Thông tin";
            // 
            // activeCheckEdit
            // 
            this.activeCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khoModelBindingSource, "Active", true));
            this.activeCheckEdit.EditValue = true;
            this.activeCheckEdit.Location = new System.Drawing.Point(423, 57);
            this.activeCheckEdit.Name = "activeCheckEdit";
            this.activeCheckEdit.Properties.Caption = "";
            this.activeCheckEdit.Size = new System.Drawing.Size(42, 19);
            this.activeCheckEdit.TabIndex = 25;
            // 
            // codeTextEdit
            // 
            this.codeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khoModelBindingSource, "Code", true));
            this.codeTextEdit.Location = new System.Drawing.Point(179, 56);
            this.codeTextEdit.Name = "codeTextEdit";
            this.codeTextEdit.Size = new System.Drawing.Size(157, 32);
            this.codeTextEdit.TabIndex = 1;
            // 
            // diachiTextEdit
            // 
            this.diachiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khoModelBindingSource, "Diachi", true));
            this.diachiTextEdit.Location = new System.Drawing.Point(179, 163);
            this.diachiTextEdit.Name = "diachiTextEdit";
            this.diachiTextEdit.Size = new System.Drawing.Size(278, 32);
            this.diachiTextEdit.TabIndex = 3;
            // 
            // ngayCapnhatDateEdit
            // 
            this.ngayCapnhatDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khoModelBindingSource, "NgayCapnhat", true));
            this.ngayCapnhatDateEdit.EditValue = null;
            this.ngayCapnhatDateEdit.Enabled = false;
            this.ngayCapnhatDateEdit.Location = new System.Drawing.Point(734, 56);
            this.ngayCapnhatDateEdit.Name = "ngayCapnhatDateEdit";
            this.ngayCapnhatDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayCapnhatDateEdit.Size = new System.Drawing.Size(278, 32);
            this.ngayCapnhatDateEdit.TabIndex = 35;
            // 
            // tenKhoTextEdit
            // 
            this.tenKhoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khoModelBindingSource, "TenKho", true));
            this.tenKhoTextEdit.Location = new System.Drawing.Point(179, 108);
            this.tenKhoTextEdit.Name = "tenKhoTextEdit";
            this.tenKhoTextEdit.Size = new System.Drawing.Size(278, 32);
            this.tenKhoTextEdit.TabIndex = 2;
            // 
            // ghichuTextEdit
            // 
            this.ghichuTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khoModelBindingSource, "Ghichu", true));
            this.ghichuTextEdit.Location = new System.Drawing.Point(179, 223);
            this.ghichuTextEdit.Name = "ghichuTextEdit";
            this.ghichuTextEdit.Size = new System.Drawing.Size(833, 400);
            this.ghichuTextEdit.TabIndex = 6;
            this.ghichuTextEdit.UseOptimizedRendering = true;
            // 
            // tinhthanhIdTextEdit
            // 
            this.tinhthanhIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khoModelBindingSource, "TinhthanhId", true));
            this.tinhthanhIdTextEdit.Location = new System.Drawing.Point(734, 108);
            this.tinhthanhIdTextEdit.Name = "tinhthanhIdTextEdit";
            this.tinhthanhIdTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tinhthanhIdTextEdit.Properties.DataSource = this.tinhthanhModelBindingSource;
            this.tinhthanhIdTextEdit.Properties.DisplayMember = "TenTinhthanh";
            this.tinhthanhIdTextEdit.Properties.NullText = "";
            this.tinhthanhIdTextEdit.Properties.ValueMember = "TinhthanhId";
            this.tinhthanhIdTextEdit.Properties.View = this.searchLookUpEdit1View;
            this.tinhthanhIdTextEdit.Size = new System.Drawing.Size(278, 32);
            this.tinhthanhIdTextEdit.TabIndex = 4;
            // 
            // tinhthanhModelBindingSource
            // 
            this.tinhthanhModelBindingSource.DataSource = typeof(B2B.Model.TinhthanhModel);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.colState});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
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
            this.colNgayCapnhat.FieldName = "NgayCapnhat";
            this.colNgayCapnhat.Name = "colNgayCapnhat";
            // 
            // colActive
            // 
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
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
            // colTenTinhthanh
            // 
            this.colTenTinhthanh.Caption = "Tỉnh thành";
            this.colTenTinhthanh.FieldName = "TenTinhthanh";
            this.colTenTinhthanh.Name = "colTenTinhthanh";
            this.colTenTinhthanh.Visible = true;
            this.colTenTinhthanh.VisibleIndex = 0;
            // 
            // colGhichu
            // 
            this.colGhichu.FieldName = "Ghichu";
            this.colGhichu.Name = "colGhichu";
            // 
            // colTenKhuvuc
            // 
            this.colTenKhuvuc.FieldName = "TenKhuvuc";
            this.colTenKhuvuc.Name = "colTenKhuvuc";
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.OptionsColumn.ReadOnly = true;
            // 
            // quanhuyenIdTextEdit
            // 
            this.quanhuyenIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khoModelBindingSource, "QuanhuyenId", true));
            this.quanhuyenIdTextEdit.Location = new System.Drawing.Point(734, 163);
            this.quanhuyenIdTextEdit.Name = "quanhuyenIdTextEdit";
            this.quanhuyenIdTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.quanhuyenIdTextEdit.Properties.DataSource = this.quanhuyenModelBindingSource;
            this.quanhuyenIdTextEdit.Properties.DisplayMember = "TenQuanhuyen";
            this.quanhuyenIdTextEdit.Properties.NullText = "";
            this.quanhuyenIdTextEdit.Properties.ValueMember = "QuanhuyenId";
            this.quanhuyenIdTextEdit.Properties.View = this.gridView1;
            this.quanhuyenIdTextEdit.Size = new System.Drawing.Size(278, 32);
            this.quanhuyenIdTextEdit.TabIndex = 5;
            // 
            // quanhuyenModelBindingSource
            // 
            this.quanhuyenModelBindingSource.DataSource = typeof(B2B.Model.QuanhuyenModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colQuanhuyenId,
            this.colTinhthanhId1,
            this.colStep1,
            this.colNgayCapnhat1,
            this.colActive1,
            this.colVersion1,
            this.colCode1,
            this.colTenQuanhuyen,
            this.colGhichu1,
            this.colTenTinhthanh1,
            this.colState1});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            this.colNgayCapnhat1.FieldName = "NgayCapnhat";
            this.colNgayCapnhat1.Name = "colNgayCapnhat1";
            // 
            // colActive1
            // 
            this.colActive1.FieldName = "Active";
            this.colActive1.Name = "colActive1";
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
            // 
            // colTenQuanhuyen
            // 
            this.colTenQuanhuyen.FieldName = "TenQuanhuyen";
            this.colTenQuanhuyen.Name = "colTenQuanhuyen";
            this.colTenQuanhuyen.Visible = true;
            this.colTenQuanhuyen.VisibleIndex = 0;
            // 
            // colGhichu1
            // 
            this.colGhichu1.FieldName = "Ghichu";
            this.colGhichu1.Name = "colGhichu1";
            // 
            // colTenTinhthanh1
            // 
            this.colTenTinhthanh1.FieldName = "TenTinhthanh";
            this.colTenTinhthanh1.Name = "colTenTinhthanh1";
            // 
            // colState1
            // 
            this.colState1.FieldName = "State";
            this.colState1.Name = "colState1";
            this.colState1.OptionsColumn.ReadOnly = true;
            // 
            // CancelSimpleButton
            // 
            this.CancelSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelSimpleButton.Image")));
            this.CancelSimpleButton.Location = new System.Drawing.Point(873, 687);
            this.CancelSimpleButton.Name = "CancelSimpleButton";
            this.CancelSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.CancelSimpleButton.TabIndex = 8;
            this.CancelSimpleButton.Text = "Cancel";
            this.CancelSimpleButton.Click += new System.EventHandler(this.CancelSimpleButton_Click);
            // 
            // OkSimpleButton
            // 
            this.OkSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("OkSimpleButton.Image")));
            this.OkSimpleButton.Location = new System.Drawing.Point(710, 687);
            this.OkSimpleButton.Name = "OkSimpleButton";
            this.OkSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.OkSimpleButton.TabIndex = 7;
            this.OkSimpleButton.Text = "OK";
            this.OkSimpleButton.Click += new System.EventHandler(this.OkSimpleButton_Click);
            // 
            // KhoDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 765);
            this.Controls.Add(this.CancelSimpleButton);
            this.Controls.Add(this.OkSimpleButton);
            this.Controls.Add(this.InformationGroupControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1087, 836);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1022, 694);
            this.Name = "KhoDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin chi tiết Kho";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KhoDetailForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.khoModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InformationGroupControl)).EndInit();
            this.InformationGroupControl.ResumeLayout(false);
            this.InformationGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diachiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenKhoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghichuTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhthanhIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhthanhModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanhuyenIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanhuyenModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource khoModelBindingSource;
        private DevExpress.XtraEditors.GroupControl InformationGroupControl;
        private DevExpress.XtraEditors.CheckEdit activeCheckEdit;
        private DevExpress.XtraEditors.TextEdit codeTextEdit;
        private DevExpress.XtraEditors.TextEdit diachiTextEdit;
        private DevExpress.XtraEditors.DateEdit ngayCapnhatDateEdit;
        private DevExpress.XtraEditors.TextEdit tenKhoTextEdit;
        private DevExpress.XtraEditors.MemoEdit ghichuTextEdit;
        private DevExpress.XtraEditors.SimpleButton CancelSimpleButton;
        private DevExpress.XtraEditors.SimpleButton OkSimpleButton;
        private System.Windows.Forms.BindingSource tinhthanhModelBindingSource;
        private System.Windows.Forms.BindingSource quanhuyenModelBindingSource;
        private DevExpress.XtraEditors.SearchLookUpEdit tinhthanhIdTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colTinhthanhId;
        private DevExpress.XtraGrid.Columns.GridColumn colKhuvucId;
        private DevExpress.XtraGrid.Columns.GridColumn colStep;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayCapnhat;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTinhthanh;
        private DevExpress.XtraGrid.Columns.GridColumn colGhichu;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKhuvuc;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraEditors.SearchLookUpEdit quanhuyenIdTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colQuanhuyenId;
        private DevExpress.XtraGrid.Columns.GridColumn colTinhthanhId1;
        private DevExpress.XtraGrid.Columns.GridColumn colStep1;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayCapnhat1;
        private DevExpress.XtraGrid.Columns.GridColumn colActive1;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion1;
        private DevExpress.XtraGrid.Columns.GridColumn colCode1;
        private DevExpress.XtraGrid.Columns.GridColumn colTenQuanhuyen;
        private DevExpress.XtraGrid.Columns.GridColumn colGhichu1;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTinhthanh1;
        private DevExpress.XtraGrid.Columns.GridColumn colState1;

    }
}