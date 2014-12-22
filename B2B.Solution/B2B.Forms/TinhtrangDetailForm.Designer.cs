namespace B2B.Forms
{
    partial class TinhtrangDetailForm
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
            System.Windows.Forms.Label tenTinhtrangLabel;
            System.Windows.Forms.Label codeLabel;
            System.Windows.Forms.Label ghichuLabel;
            System.Windows.Forms.Label stepLabel;
            System.Windows.Forms.Label ngayCapnhatLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TinhtrangDetailForm));
            this.tinhtrangModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loaiTinhtrangModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CancelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.OkSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ThongtinGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.ngayCapnhatDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.activeCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.tenTinhtrangTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.codeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ghichuTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.NhomComboBox = new System.Windows.Forms.ComboBox();
            activeLabel = new System.Windows.Forms.Label();
            tenTinhtrangLabel = new System.Windows.Forms.Label();
            codeLabel = new System.Windows.Forms.Label();
            ghichuLabel = new System.Windows.Forms.Label();
            stepLabel = new System.Windows.Forms.Label();
            ngayCapnhatLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tinhtrangModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiTinhtrangModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongtinGroupControl)).BeginInit();
            this.ThongtinGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenTinhtrangTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghichuTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // activeLabel
            // 
            activeLabel.AutoSize = true;
            activeLabel.Location = new System.Drawing.Point(352, 58);
            activeLabel.Name = "activeLabel";
            activeLabel.Size = new System.Drawing.Size(75, 25);
            activeLabel.TabIndex = 36;
            activeLabel.Text = "Active:";
            // 
            // tenTinhtrangLabel
            // 
            tenTinhtrangLabel.AutoSize = true;
            tenTinhtrangLabel.Location = new System.Drawing.Point(44, 110);
            tenTinhtrangLabel.Name = "tenTinhtrangLabel";
            tenTinhtrangLabel.Size = new System.Drawing.Size(117, 25);
            tenTinhtrangLabel.TabIndex = 45;
            tenTinhtrangLabel.Text = "Tình trạng:";
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(44, 54);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(66, 25);
            codeLabel.TabIndex = 40;
            codeLabel.Text = "Code:";
            // 
            // ghichuLabel
            // 
            ghichuLabel.AutoSize = true;
            ghichuLabel.Location = new System.Drawing.Point(44, 171);
            ghichuLabel.Name = "ghichuLabel";
            ghichuLabel.Size = new System.Drawing.Size(91, 25);
            ghichuLabel.TabIndex = 42;
            ghichuLabel.Text = "Ghi chú:";
            // 
            // stepLabel
            // 
            stepLabel.AutoSize = true;
            stepLabel.Location = new System.Drawing.Point(476, 110);
            stepLabel.Name = "stepLabel";
            stepLabel.Size = new System.Drawing.Size(161, 25);
            stepLabel.TabIndex = 44;
            stepLabel.Text = "Loại Tình trạng:";
            // 
            // ngayCapnhatLabel
            // 
            ngayCapnhatLabel.AutoSize = true;
            ngayCapnhatLabel.Location = new System.Drawing.Point(476, 54);
            ngayCapnhatLabel.Name = "ngayCapnhatLabel";
            ngayCapnhatLabel.Size = new System.Drawing.Size(155, 25);
            ngayCapnhatLabel.TabIndex = 43;
            ngayCapnhatLabel.Text = "Ngày cập nhật:";
            // 
            // tinhtrangModelBindingSource
            // 
            this.tinhtrangModelBindingSource.DataSource = typeof(B2B.Model.TinhtrangModel);
            // 
            // loaiTinhtrangModelBindingSource
            // 
            this.loaiTinhtrangModelBindingSource.DataSource = typeof(B2B.Model.LoaiTinhtrangModel);
            // 
            // CancelSimpleButton
            // 
            this.CancelSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelSimpleButton.Image")));
            this.CancelSimpleButton.Location = new System.Drawing.Point(769, 549);
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
            this.OkSimpleButton.Location = new System.Drawing.Point(606, 549);
            this.OkSimpleButton.Name = "OkSimpleButton";
            this.OkSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.OkSimpleButton.TabIndex = 5;
            this.OkSimpleButton.Text = "OK";
            this.OkSimpleButton.Click += new System.EventHandler(this.OkSimpleButton_Click);
            // 
            // ThongtinGroupControl
            // 
            this.ThongtinGroupControl.Controls.Add(this.NhomComboBox);
            this.ThongtinGroupControl.Controls.Add(this.ngayCapnhatDateEdit);
            this.ThongtinGroupControl.Controls.Add(activeLabel);
            this.ThongtinGroupControl.Controls.Add(tenTinhtrangLabel);
            this.ThongtinGroupControl.Controls.Add(this.activeCheckEdit);
            this.ThongtinGroupControl.Controls.Add(this.tenTinhtrangTextEdit);
            this.ThongtinGroupControl.Controls.Add(codeLabel);
            this.ThongtinGroupControl.Controls.Add(this.codeTextEdit);
            this.ThongtinGroupControl.Controls.Add(ghichuLabel);
            this.ThongtinGroupControl.Controls.Add(stepLabel);
            this.ThongtinGroupControl.Controls.Add(ngayCapnhatLabel);
            this.ThongtinGroupControl.Controls.Add(this.ghichuTextEdit);
            this.ThongtinGroupControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ThongtinGroupControl.Location = new System.Drawing.Point(0, 0);
            this.ThongtinGroupControl.Name = "ThongtinGroupControl";
            this.ThongtinGroupControl.Size = new System.Drawing.Size(953, 525);
            this.ThongtinGroupControl.TabIndex = 7;
            this.ThongtinGroupControl.Text = "Thông tin";
            // 
            // ngayCapnhatDateEdit
            // 
            this.ngayCapnhatDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tinhtrangModelBindingSource, "NgayCapnhat", true));
            this.ngayCapnhatDateEdit.EditValue = null;
            this.ngayCapnhatDateEdit.Location = new System.Drawing.Point(636, 51);
            this.ngayCapnhatDateEdit.Name = "ngayCapnhatDateEdit";
            this.ngayCapnhatDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayCapnhatDateEdit.Size = new System.Drawing.Size(273, 32);
            this.ngayCapnhatDateEdit.TabIndex = 46;
            // 
            // activeCheckEdit
            // 
            this.activeCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tinhtrangModelBindingSource, "Active", true));
            this.activeCheckEdit.EditValue = true;
            this.activeCheckEdit.Location = new System.Drawing.Point(433, 56);
            this.activeCheckEdit.Name = "activeCheckEdit";
            this.activeCheckEdit.Properties.Caption = "";
            this.activeCheckEdit.Size = new System.Drawing.Size(34, 19);
            this.activeCheckEdit.TabIndex = 37;
            // 
            // tenTinhtrangTextEdit
            // 
            this.tenTinhtrangTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tinhtrangModelBindingSource, "TenTinhtrang", true));
            this.tenTinhtrangTextEdit.Location = new System.Drawing.Point(179, 107);
            this.tenTinhtrangTextEdit.Name = "tenTinhtrangTextEdit";
            this.tenTinhtrangTextEdit.Size = new System.Drawing.Size(273, 32);
            this.tenTinhtrangTextEdit.TabIndex = 38;
            // 
            // codeTextEdit
            // 
            this.codeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tinhtrangModelBindingSource, "Code", true));
            this.codeTextEdit.Location = new System.Drawing.Point(179, 51);
            this.codeTextEdit.Name = "codeTextEdit";
            this.codeTextEdit.Size = new System.Drawing.Size(150, 32);
            this.codeTextEdit.TabIndex = 35;
            // 
            // ghichuTextEdit
            // 
            this.ghichuTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tinhtrangModelBindingSource, "Ghichu", true));
            this.ghichuTextEdit.Location = new System.Drawing.Point(179, 168);
            this.ghichuTextEdit.Name = "ghichuTextEdit";
            this.ghichuTextEdit.Size = new System.Drawing.Size(730, 306);
            this.ghichuTextEdit.TabIndex = 41;
            this.ghichuTextEdit.UseOptimizedRendering = true;
            // 
            // NhomComboBox
            // 
            this.NhomComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tinhtrangModelBindingSource, "Step", true));
            this.NhomComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.tinhtrangModelBindingSource, "Step", true));
            this.NhomComboBox.DataSource = this.loaiTinhtrangModelBindingSource;
            this.NhomComboBox.DisplayMember = "TenloaiTinhtrang";
            this.NhomComboBox.FormattingEnabled = true;
            this.NhomComboBox.Location = new System.Drawing.Point(636, 107);
            this.NhomComboBox.Name = "NhomComboBox";
            this.NhomComboBox.Size = new System.Drawing.Size(273, 33);
            this.NhomComboBox.TabIndex = 47;
            this.NhomComboBox.ValueMember = "LoaiTinhtrangValue";
            // 
            // TinhtrangDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(953, 639);
            this.Controls.Add(this.ThongtinGroupControl);
            this.Controls.Add(this.CancelSimpleButton);
            this.Controls.Add(this.OkSimpleButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(979, 710);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(979, 710);
            this.Name = "TinhtrangDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết Tình trạng";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TinhtrangDetailForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.tinhtrangModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiTinhtrangModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongtinGroupControl)).EndInit();
            this.ThongtinGroupControl.ResumeLayout(false);
            this.ThongtinGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenTinhtrangTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghichuTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource tinhtrangModelBindingSource;
        private System.Windows.Forms.BindingSource loaiTinhtrangModelBindingSource;
        private DevExpress.XtraEditors.SimpleButton CancelSimpleButton;
        private DevExpress.XtraEditors.SimpleButton OkSimpleButton;
        private DevExpress.XtraEditors.GroupControl ThongtinGroupControl;
        private DevExpress.XtraEditors.CheckEdit activeCheckEdit;
        private DevExpress.XtraEditors.TextEdit tenTinhtrangTextEdit;
        private DevExpress.XtraEditors.TextEdit codeTextEdit;
        private DevExpress.XtraEditors.MemoEdit ghichuTextEdit;
        private DevExpress.XtraEditors.DateEdit ngayCapnhatDateEdit;
        private System.Windows.Forms.ComboBox NhomComboBox;
    }
}