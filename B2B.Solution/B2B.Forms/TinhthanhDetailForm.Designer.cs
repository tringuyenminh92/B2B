namespace B2B.Forms
{
    partial class TinhthanhDetailForm
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
            System.Windows.Forms.Label khuvucIdLabel;
            System.Windows.Forms.Label ngayCapnhatLabel;
            System.Windows.Forms.Label tenTinhthanhLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TinhthanhDetailForm));
            this.tinhthanhInformationGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.activeCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.tinhthanhModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ngayCapnhatDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.tenTinhthanhTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ghichuTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.khuvucIdTextEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.khuvucModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKhuvucId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayCapnhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKhuvuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhichu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CancelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.OkSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            activeLabel = new System.Windows.Forms.Label();
            codeLabel = new System.Windows.Forms.Label();
            ghichuLabel = new System.Windows.Forms.Label();
            khuvucIdLabel = new System.Windows.Forms.Label();
            ngayCapnhatLabel = new System.Windows.Forms.Label();
            tenTinhthanhLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tinhthanhInformationGroupControl)).BeginInit();
            this.tinhthanhInformationGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhthanhModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenTinhthanhTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghichuTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khuvucIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khuvucModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // activeLabel
            // 
            activeLabel.AutoSize = true;
            activeLabel.Location = new System.Drawing.Point(499, 76);
            activeLabel.Name = "activeLabel";
            activeLabel.Size = new System.Drawing.Size(75, 25);
            activeLabel.TabIndex = 0;
            activeLabel.Text = "Active:";
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(45, 76);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(66, 25);
            codeLabel.TabIndex = 2;
            codeLabel.Text = "Code:";
            // 
            // ghichuLabel
            // 
            ghichuLabel.AutoSize = true;
            ghichuLabel.Location = new System.Drawing.Point(45, 173);
            ghichuLabel.Name = "ghichuLabel";
            ghichuLabel.Size = new System.Drawing.Size(84, 25);
            ghichuLabel.TabIndex = 4;
            ghichuLabel.Text = "Ghi chú";
            // 
            // khuvucIdLabel
            // 
            khuvucIdLabel.AutoSize = true;
            khuvucIdLabel.Location = new System.Drawing.Point(673, 123);
            khuvucIdLabel.Name = "khuvucIdLabel";
            khuvucIdLabel.Size = new System.Drawing.Size(95, 25);
            khuvucIdLabel.TabIndex = 6;
            khuvucIdLabel.Text = "Khu vực:";
            // 
            // ngayCapnhatLabel
            // 
            ngayCapnhatLabel.AutoSize = true;
            ngayCapnhatLabel.Location = new System.Drawing.Point(673, 76);
            ngayCapnhatLabel.Name = "ngayCapnhatLabel";
            ngayCapnhatLabel.Size = new System.Drawing.Size(155, 25);
            ngayCapnhatLabel.TabIndex = 8;
            ngayCapnhatLabel.Text = "Ngày cập nhật:";
            // 
            // tenTinhthanhLabel
            // 
            tenTinhthanhLabel.AutoSize = true;
            tenTinhthanhLabel.Location = new System.Drawing.Point(45, 123);
            tenTinhthanhLabel.Name = "tenTinhthanhLabel";
            tenTinhthanhLabel.Size = new System.Drawing.Size(114, 25);
            tenTinhthanhLabel.TabIndex = 12;
            tenTinhthanhLabel.Text = "Tỉnh thành";
            // 
            // tinhthanhInformationGroupControl
            // 
            this.tinhthanhInformationGroupControl.Controls.Add(activeLabel);
            this.tinhthanhInformationGroupControl.Controls.Add(this.activeCheckEdit);
            this.tinhthanhInformationGroupControl.Controls.Add(codeLabel);
            this.tinhthanhInformationGroupControl.Controls.Add(this.codeTextEdit);
            this.tinhthanhInformationGroupControl.Controls.Add(ghichuLabel);
            this.tinhthanhInformationGroupControl.Controls.Add(khuvucIdLabel);
            this.tinhthanhInformationGroupControl.Controls.Add(ngayCapnhatLabel);
            this.tinhthanhInformationGroupControl.Controls.Add(this.ngayCapnhatDateEdit);
            this.tinhthanhInformationGroupControl.Controls.Add(tenTinhthanhLabel);
            this.tinhthanhInformationGroupControl.Controls.Add(this.tenTinhthanhTextEdit);
            this.tinhthanhInformationGroupControl.Controls.Add(this.ghichuTextEdit);
            this.tinhthanhInformationGroupControl.Controls.Add(this.khuvucIdTextEdit);
            this.tinhthanhInformationGroupControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tinhthanhInformationGroupControl.Location = new System.Drawing.Point(0, 0);
            this.tinhthanhInformationGroupControl.Name = "tinhthanhInformationGroupControl";
            this.tinhthanhInformationGroupControl.Size = new System.Drawing.Size(1149, 547);
            this.tinhthanhInformationGroupControl.TabIndex = 0;
            this.tinhthanhInformationGroupControl.Text = "Thông tin";
            // 
            // activeCheckEdit
            // 
            this.activeCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tinhthanhModelBindingSource, "Active", true));
            this.activeCheckEdit.EditValue = true;
            this.activeCheckEdit.Location = new System.Drawing.Point(580, 74);
            this.activeCheckEdit.Name = "activeCheckEdit";
            this.activeCheckEdit.Properties.Caption = "";
            this.activeCheckEdit.Size = new System.Drawing.Size(41, 19);
            this.activeCheckEdit.TabIndex = 1;
            // 
            // tinhthanhModelBindingSource
            // 
            this.tinhthanhModelBindingSource.DataSource = typeof(B2B.Model.TinhthanhModel);
            // 
            // codeTextEdit
            // 
            this.codeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tinhthanhModelBindingSource, "Code", true));
            this.codeTextEdit.Location = new System.Drawing.Point(207, 69);
            this.codeTextEdit.Name = "codeTextEdit";
            this.codeTextEdit.Size = new System.Drawing.Size(257, 32);
            this.codeTextEdit.TabIndex = 0;
            // 
            // ngayCapnhatDateEdit
            // 
            this.ngayCapnhatDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tinhthanhModelBindingSource, "NgayCapnhat", true));
            this.ngayCapnhatDateEdit.EditValue = null;
            this.ngayCapnhatDateEdit.Enabled = false;
            this.ngayCapnhatDateEdit.Location = new System.Drawing.Point(835, 69);
            this.ngayCapnhatDateEdit.Name = "ngayCapnhatDateEdit";
            this.ngayCapnhatDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayCapnhatDateEdit.Size = new System.Drawing.Size(235, 32);
            this.ngayCapnhatDateEdit.TabIndex = 9;
            // 
            // tenTinhthanhTextEdit
            // 
            this.tenTinhthanhTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tinhthanhModelBindingSource, "TenTinhthanh", true));
            this.tenTinhthanhTextEdit.Location = new System.Drawing.Point(207, 120);
            this.tenTinhthanhTextEdit.Name = "tenTinhthanhTextEdit";
            this.tenTinhthanhTextEdit.Size = new System.Drawing.Size(445, 32);
            this.tenTinhthanhTextEdit.TabIndex = 2;
            // 
            // ghichuTextEdit
            // 
            this.ghichuTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tinhthanhModelBindingSource, "Ghichu", true));
            this.ghichuTextEdit.Location = new System.Drawing.Point(207, 170);
            this.ghichuTextEdit.Name = "ghichuTextEdit";
            this.ghichuTextEdit.Size = new System.Drawing.Size(863, 333);
            this.ghichuTextEdit.TabIndex = 3;
            this.ghichuTextEdit.UseOptimizedRendering = true;
            // 
            // khuvucIdTextEdit
            // 
            this.khuvucIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tinhthanhModelBindingSource, "KhuvucId", true));
            this.khuvucIdTextEdit.Location = new System.Drawing.Point(835, 120);
            this.khuvucIdTextEdit.Name = "khuvucIdTextEdit";
            this.khuvucIdTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.khuvucIdTextEdit.Properties.DataSource = this.khuvucModelBindingSource;
            this.khuvucIdTextEdit.Properties.DisplayMember = "TenKhuvuc";
            this.khuvucIdTextEdit.Properties.NullText = "";
            this.khuvucIdTextEdit.Properties.ValueMember = "KhuvucId";
            this.khuvucIdTextEdit.Properties.View = this.searchLookUpEdit1View;
            this.khuvucIdTextEdit.Size = new System.Drawing.Size(235, 32);
            this.khuvucIdTextEdit.TabIndex = 1;
            this.khuvucIdTextEdit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.khuvucIdTextEdit_KeyUp);
            // 
            // khuvucModelBindingSource
            // 
            this.khuvucModelBindingSource.DataSource = typeof(B2B.Model.KhuvucModel);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKhuvucId,
            this.colStep,
            this.colNgayCapnhat,
            this.colActive,
            this.colVersion,
            this.colCode,
            this.colTenKhuvuc,
            this.colGhichu,
            this.colState});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
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
            this.colCode.VisibleIndex = 0;
            // 
            // colTenKhuvuc
            // 
            this.colTenKhuvuc.FieldName = "TenKhuvuc";
            this.colTenKhuvuc.Name = "colTenKhuvuc";
            this.colTenKhuvuc.Visible = true;
            this.colTenKhuvuc.VisibleIndex = 1;
            // 
            // colGhichu
            // 
            this.colGhichu.FieldName = "Ghichu";
            this.colGhichu.Name = "colGhichu";
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
            this.CancelSimpleButton.Location = new System.Drawing.Point(931, 576);
            this.CancelSimpleButton.Name = "CancelSimpleButton";
            this.CancelSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.CancelSimpleButton.TabIndex = 5;
            this.CancelSimpleButton.Text = "Cancel";
            this.CancelSimpleButton.Click += new System.EventHandler(this.CancelSimpleButton_Click);
            // 
            // OkSimpleButton
            // 
            this.OkSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("OkSimpleButton.Image")));
            this.OkSimpleButton.Location = new System.Drawing.Point(768, 576);
            this.OkSimpleButton.Name = "OkSimpleButton";
            this.OkSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.OkSimpleButton.TabIndex = 4;
            this.OkSimpleButton.Text = "OK";
            this.OkSimpleButton.Click += new System.EventHandler(this.OkSimpleButton_Click);
            // 
            // TinhthanhDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 660);
            this.Controls.Add(this.CancelSimpleButton);
            this.Controls.Add(this.OkSimpleButton);
            this.Controls.Add(this.tinhthanhInformationGroupControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1175, 731);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1175, 731);
            this.Name = "TinhthanhDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin chi tiết - Tỉnh thành";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TinhthanhDetailForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.tinhthanhInformationGroupControl)).EndInit();
            this.tinhthanhInformationGroupControl.ResumeLayout(false);
            this.tinhthanhInformationGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhthanhModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenTinhthanhTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghichuTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khuvucIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khuvucModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl tinhthanhInformationGroupControl;
        private DevExpress.XtraEditors.SimpleButton CancelSimpleButton;
        private DevExpress.XtraEditors.SimpleButton OkSimpleButton;
        private DevExpress.XtraEditors.CheckEdit activeCheckEdit;
        private System.Windows.Forms.BindingSource tinhthanhModelBindingSource;
        private DevExpress.XtraEditors.TextEdit codeTextEdit;
        private DevExpress.XtraEditors.DateEdit ngayCapnhatDateEdit;
        private DevExpress.XtraEditors.TextEdit tenTinhthanhTextEdit;
        private DevExpress.XtraEditors.MemoEdit ghichuTextEdit;
        private System.Windows.Forms.BindingSource khuvucModelBindingSource;
        private DevExpress.XtraEditors.SearchLookUpEdit khuvucIdTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colKhuvucId;
        private DevExpress.XtraGrid.Columns.GridColumn colStep;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayCapnhat;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKhuvuc;
        private DevExpress.XtraGrid.Columns.GridColumn colGhichu;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
    }
}