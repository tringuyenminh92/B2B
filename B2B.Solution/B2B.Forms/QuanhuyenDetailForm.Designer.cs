namespace B2B.Forms
{
    partial class QuanhuyenDetailForm
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
            System.Windows.Forms.Label ghichuLabel;
            System.Windows.Forms.Label ngayCapnhatLabel;
            System.Windows.Forms.Label tenQuanhuyenLabel;
            System.Windows.Forms.Label tenTinhthanhLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanhuyenDetailForm));
            this.InformationGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.activeCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.quanhuyenModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ngayCapnhatDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.tenQuanhuyenTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ghichuTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.tenTinhthanhTextEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
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
            this.CancelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.OkSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            activeLabel = new System.Windows.Forms.Label();
            codeLabel = new System.Windows.Forms.Label();
            ghichuLabel = new System.Windows.Forms.Label();
            ngayCapnhatLabel = new System.Windows.Forms.Label();
            tenQuanhuyenLabel = new System.Windows.Forms.Label();
            tenTinhthanhLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InformationGroupControl)).BeginInit();
            this.InformationGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanhuyenModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenQuanhuyenTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghichuTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenTinhthanhTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhthanhModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // activeLabel
            // 
            activeLabel.AutoSize = true;
            activeLabel.Location = new System.Drawing.Point(927, 116);
            activeLabel.Name = "activeLabel";
            activeLabel.Size = new System.Drawing.Size(75, 25);
            activeLabel.TabIndex = 0;
            activeLabel.Text = "Active:";
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(44, 66);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(66, 25);
            codeLabel.TabIndex = 2;
            codeLabel.Text = "Code:";
            // 
            // ghichuLabel
            // 
            ghichuLabel.AutoSize = true;
            ghichuLabel.Location = new System.Drawing.Point(44, 175);
            ghichuLabel.Name = "ghichuLabel";
            ghichuLabel.Size = new System.Drawing.Size(91, 25);
            ghichuLabel.TabIndex = 4;
            ghichuLabel.Text = "Ghi chú:";
            // 
            // ngayCapnhatLabel
            // 
            ngayCapnhatLabel.AutoSize = true;
            ngayCapnhatLabel.Location = new System.Drawing.Point(558, 116);
            ngayCapnhatLabel.Name = "ngayCapnhatLabel";
            ngayCapnhatLabel.Size = new System.Drawing.Size(155, 25);
            ngayCapnhatLabel.TabIndex = 6;
            ngayCapnhatLabel.Text = "Ngày cập nhật:";
            // 
            // tenQuanhuyenLabel
            // 
            tenQuanhuyenLabel.AutoSize = true;
            tenQuanhuyenLabel.Location = new System.Drawing.Point(44, 116);
            tenQuanhuyenLabel.Name = "tenQuanhuyenLabel";
            tenQuanhuyenLabel.Size = new System.Drawing.Size(133, 25);
            tenQuanhuyenLabel.TabIndex = 12;
            tenQuanhuyenLabel.Text = "Quận huyện:";
            // 
            // tenTinhthanhLabel
            // 
            tenTinhthanhLabel.AutoSize = true;
            tenTinhthanhLabel.Location = new System.Drawing.Point(553, 66);
            tenTinhthanhLabel.Name = "tenTinhthanhLabel";
            tenTinhthanhLabel.Size = new System.Drawing.Size(121, 25);
            tenTinhthanhLabel.TabIndex = 13;
            tenTinhthanhLabel.Text = "Tinh thành:";
            // 
            // InformationGroupControl
            // 
            this.InformationGroupControl.Controls.Add(tenTinhthanhLabel);
            this.InformationGroupControl.Controls.Add(activeLabel);
            this.InformationGroupControl.Controls.Add(this.activeCheckEdit);
            this.InformationGroupControl.Controls.Add(codeLabel);
            this.InformationGroupControl.Controls.Add(this.codeTextEdit);
            this.InformationGroupControl.Controls.Add(ghichuLabel);
            this.InformationGroupControl.Controls.Add(ngayCapnhatLabel);
            this.InformationGroupControl.Controls.Add(this.ngayCapnhatDateEdit);
            this.InformationGroupControl.Controls.Add(tenQuanhuyenLabel);
            this.InformationGroupControl.Controls.Add(this.tenQuanhuyenTextEdit);
            this.InformationGroupControl.Controls.Add(this.ghichuTextEdit);
            this.InformationGroupControl.Controls.Add(this.tenTinhthanhTextEdit);
            this.InformationGroupControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.InformationGroupControl.Location = new System.Drawing.Point(0, 0);
            this.InformationGroupControl.Name = "InformationGroupControl";
            this.InformationGroupControl.Size = new System.Drawing.Size(1090, 577);
            this.InformationGroupControl.TabIndex = 0;
            this.InformationGroupControl.Text = "Thông tin";
            // 
            // activeCheckEdit
            // 
            this.activeCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.quanhuyenModelBindingSource, "Active", true));
            this.activeCheckEdit.EditValue = true;
            this.activeCheckEdit.Location = new System.Drawing.Point(1008, 114);
            this.activeCheckEdit.Name = "activeCheckEdit";
            this.activeCheckEdit.Properties.Caption = "";
            this.activeCheckEdit.Size = new System.Drawing.Size(100, 19);
            this.activeCheckEdit.TabIndex = 3;
            // 
            // quanhuyenModelBindingSource
            // 
            this.quanhuyenModelBindingSource.DataSource = typeof(B2B.Model.QuanhuyenModel);
            // 
            // codeTextEdit
            // 
            this.codeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.quanhuyenModelBindingSource, "Code", true));
            this.codeTextEdit.Location = new System.Drawing.Point(218, 63);
            this.codeTextEdit.Name = "codeTextEdit";
            this.codeTextEdit.Size = new System.Drawing.Size(300, 32);
            this.codeTextEdit.TabIndex = 0;
            // 
            // ngayCapnhatDateEdit
            // 
            this.ngayCapnhatDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.quanhuyenModelBindingSource, "NgayCapnhat", true));
            this.ngayCapnhatDateEdit.EditValue = null;
            this.ngayCapnhatDateEdit.Enabled = false;
            this.ngayCapnhatDateEdit.Location = new System.Drawing.Point(724, 113);
            this.ngayCapnhatDateEdit.Name = "ngayCapnhatDateEdit";
            this.ngayCapnhatDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayCapnhatDateEdit.Size = new System.Drawing.Size(187, 32);
            this.ngayCapnhatDateEdit.TabIndex = 7;
            // 
            // tenQuanhuyenTextEdit
            // 
            this.tenQuanhuyenTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.quanhuyenModelBindingSource, "TenQuanhuyen", true));
            this.tenQuanhuyenTextEdit.Location = new System.Drawing.Point(218, 113);
            this.tenQuanhuyenTextEdit.Name = "tenQuanhuyenTextEdit";
            this.tenQuanhuyenTextEdit.Size = new System.Drawing.Size(300, 32);
            this.tenQuanhuyenTextEdit.TabIndex = 2;
            // 
            // ghichuTextEdit
            // 
            this.ghichuTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.quanhuyenModelBindingSource, "Ghichu", true));
            this.ghichuTextEdit.Location = new System.Drawing.Point(218, 172);
            this.ghichuTextEdit.Name = "ghichuTextEdit";
            this.ghichuTextEdit.Size = new System.Drawing.Size(806, 371);
            this.ghichuTextEdit.TabIndex = 4;
            this.ghichuTextEdit.UseOptimizedRendering = true;
            // 
            // tenTinhthanhTextEdit
            // 
            this.tenTinhthanhTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.quanhuyenModelBindingSource, "TinhthanhId", true));
            this.tenTinhthanhTextEdit.Location = new System.Drawing.Point(724, 63);
            this.tenTinhthanhTextEdit.Name = "tenTinhthanhTextEdit";
            this.tenTinhthanhTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tenTinhthanhTextEdit.Properties.DataSource = this.tinhthanhModelBindingSource;
            this.tenTinhthanhTextEdit.Properties.DisplayMember = "TenTinhthanh";
            this.tenTinhthanhTextEdit.Properties.NullText = "";
            this.tenTinhthanhTextEdit.Properties.ValueMember = "TinhthanhId";
            this.tenTinhthanhTextEdit.Properties.View = this.searchLookUpEdit1View;
            this.tenTinhthanhTextEdit.Size = new System.Drawing.Size(300, 32);
            this.tenTinhthanhTextEdit.TabIndex = 1;
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
            this.searchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
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
            // CancelSimpleButton
            // 
            this.CancelSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelSimpleButton.Image")));
            this.CancelSimpleButton.Location = new System.Drawing.Point(885, 600);
            this.CancelSimpleButton.Name = "CancelSimpleButton";
            this.CancelSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.CancelSimpleButton.TabIndex = 6;
            this.CancelSimpleButton.Text = "Cancel";
            this.CancelSimpleButton.Click += new System.EventHandler(this.CancelSimpleButton_Click);
            // 
            // OkSimpleButton
            // 
            this.OkSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("OkSimpleButton.Image")));
            this.OkSimpleButton.Location = new System.Drawing.Point(722, 600);
            this.OkSimpleButton.Name = "OkSimpleButton";
            this.OkSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.OkSimpleButton.TabIndex = 5;
            this.OkSimpleButton.Text = "OK";
            this.OkSimpleButton.Click += new System.EventHandler(this.OkSimpleButton_Click);
            // 
            // QuanhuyenDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 682);
            this.Controls.Add(this.CancelSimpleButton);
            this.Controls.Add(this.OkSimpleButton);
            this.Controls.Add(this.InformationGroupControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1116, 753);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1116, 753);
            this.Name = "QuanhuyenDetailForm";
            this.Text = "Thông tin Chi tiết Quận huyện ";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.QuanhuyenDetailForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.InformationGroupControl)).EndInit();
            this.InformationGroupControl.ResumeLayout(false);
            this.InformationGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanhuyenModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenQuanhuyenTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghichuTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenTinhthanhTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhthanhModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource quanhuyenModelBindingSource;
        private DevExpress.XtraEditors.GroupControl InformationGroupControl;
        private DevExpress.XtraEditors.CheckEdit activeCheckEdit;
        private DevExpress.XtraEditors.TextEdit codeTextEdit;
        private DevExpress.XtraEditors.DateEdit ngayCapnhatDateEdit;
        private DevExpress.XtraEditors.TextEdit tenQuanhuyenTextEdit;
        private DevExpress.XtraEditors.MemoEdit ghichuTextEdit;
        private DevExpress.XtraEditors.SimpleButton CancelSimpleButton;
        private DevExpress.XtraEditors.SimpleButton OkSimpleButton;
        private DevExpress.XtraEditors.SearchLookUpEdit tenTinhthanhTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.BindingSource tinhthanhModelBindingSource;
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
    }
}