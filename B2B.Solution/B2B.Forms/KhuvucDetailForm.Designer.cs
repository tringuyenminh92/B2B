namespace B2B.Forms
{
    partial class KhuvucDetailForm
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
            System.Windows.Forms.Label ngayCapnhatLabel;
            System.Windows.Forms.Label tenKhuvucLabel;
            System.Windows.Forms.Label ghichuLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhuvucDetailForm));
            this.khuvucInformationGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.activeCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.khuvucModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ngayCapnhatDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.tenKhuvucTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ghichuTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.CancelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.OkSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            activeLabel = new System.Windows.Forms.Label();
            codeLabel = new System.Windows.Forms.Label();
            ngayCapnhatLabel = new System.Windows.Forms.Label();
            tenKhuvucLabel = new System.Windows.Forms.Label();
            ghichuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.khuvucInformationGroupControl)).BeginInit();
            this.khuvucInformationGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khuvucModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenKhuvucTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghichuTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // activeLabel
            // 
            activeLabel.AutoSize = true;
            activeLabel.Location = new System.Drawing.Point(547, 119);
            activeLabel.Name = "activeLabel";
            activeLabel.Size = new System.Drawing.Size(75, 25);
            activeLabel.TabIndex = 0;
            activeLabel.Text = "Active:";
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(44, 57);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(66, 25);
            codeLabel.TabIndex = 2;
            codeLabel.Text = "Code:";
            // 
            // ngayCapnhatLabel
            // 
            ngayCapnhatLabel.AutoSize = true;
            ngayCapnhatLabel.Location = new System.Drawing.Point(547, 57);
            ngayCapnhatLabel.Name = "ngayCapnhatLabel";
            ngayCapnhatLabel.Size = new System.Drawing.Size(155, 25);
            ngayCapnhatLabel.TabIndex = 8;
            ngayCapnhatLabel.Text = "Ngày cập nhật:";
            // 
            // tenKhuvucLabel
            // 
            tenKhuvucLabel.AutoSize = true;
            tenKhuvucLabel.Location = new System.Drawing.Point(44, 111);
            tenKhuvucLabel.Name = "tenKhuvucLabel";
            tenKhuvucLabel.Size = new System.Drawing.Size(95, 25);
            tenKhuvucLabel.TabIndex = 12;
            tenKhuvucLabel.Text = "Khu vực:";
            // 
            // ghichuLabel
            // 
            ghichuLabel.AutoSize = true;
            ghichuLabel.Location = new System.Drawing.Point(44, 176);
            ghichuLabel.Name = "ghichuLabel";
            ghichuLabel.Size = new System.Drawing.Size(91, 25);
            ghichuLabel.TabIndex = 13;
            ghichuLabel.Text = "Ghi chú:";
            // 
            // khuvucInformationGroupControl
            // 
            this.khuvucInformationGroupControl.Controls.Add(ghichuLabel);
            this.khuvucInformationGroupControl.Controls.Add(activeLabel);
            this.khuvucInformationGroupControl.Controls.Add(this.activeCheckEdit);
            this.khuvucInformationGroupControl.Controls.Add(codeLabel);
            this.khuvucInformationGroupControl.Controls.Add(this.codeTextEdit);
            this.khuvucInformationGroupControl.Controls.Add(ngayCapnhatLabel);
            this.khuvucInformationGroupControl.Controls.Add(this.ngayCapnhatDateEdit);
            this.khuvucInformationGroupControl.Controls.Add(tenKhuvucLabel);
            this.khuvucInformationGroupControl.Controls.Add(this.tenKhuvucTextEdit);
            this.khuvucInformationGroupControl.Controls.Add(this.ghichuTextEdit);
            this.khuvucInformationGroupControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.khuvucInformationGroupControl.Location = new System.Drawing.Point(0, 0);
            this.khuvucInformationGroupControl.Name = "khuvucInformationGroupControl";
            this.khuvucInformationGroupControl.Size = new System.Drawing.Size(1081, 521);
            this.khuvucInformationGroupControl.TabIndex = 0;
            this.khuvucInformationGroupControl.Text = "Thông tin";
            // 
            // activeCheckEdit
            // 
            this.activeCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khuvucModelBindingSource, "Active", true));
            this.activeCheckEdit.EditValue = true;
            this.activeCheckEdit.Location = new System.Drawing.Point(650, 117);
            this.activeCheckEdit.Name = "activeCheckEdit";
            this.activeCheckEdit.Properties.Caption = "";
            this.activeCheckEdit.Size = new System.Drawing.Size(100, 19);
            this.activeCheckEdit.TabIndex = 3;
            // 
            // khuvucModelBindingSource
            // 
            this.khuvucModelBindingSource.DataSource = typeof(B2B.Model.KhuvucModel);
            // 
            // codeTextEdit
            // 
            this.codeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khuvucModelBindingSource, "Code", true));
            this.codeTextEdit.Location = new System.Drawing.Point(201, 54);
            this.codeTextEdit.Name = "codeTextEdit";
            this.codeTextEdit.Size = new System.Drawing.Size(286, 32);
            this.codeTextEdit.TabIndex = 1;
            // 
            // ngayCapnhatDateEdit
            // 
            this.ngayCapnhatDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khuvucModelBindingSource, "NgayCapnhat", true));
            this.ngayCapnhatDateEdit.EditValue = null;
            this.ngayCapnhatDateEdit.Enabled = false;
            this.ngayCapnhatDateEdit.Location = new System.Drawing.Point(726, 54);
            this.ngayCapnhatDateEdit.Name = "ngayCapnhatDateEdit";
            this.ngayCapnhatDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayCapnhatDateEdit.Size = new System.Drawing.Size(286, 32);
            this.ngayCapnhatDateEdit.TabIndex = 13;
            // 
            // tenKhuvucTextEdit
            // 
            this.tenKhuvucTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khuvucModelBindingSource, "TenKhuvuc", true));
            this.tenKhuvucTextEdit.Location = new System.Drawing.Point(201, 108);
            this.tenKhuvucTextEdit.Name = "tenKhuvucTextEdit";
            this.tenKhuvucTextEdit.Size = new System.Drawing.Size(286, 32);
            this.tenKhuvucTextEdit.TabIndex = 2;
            // 
            // ghichuTextEdit
            // 
            this.ghichuTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khuvucModelBindingSource, "Ghichu", true));
            this.ghichuTextEdit.Location = new System.Drawing.Point(201, 173);
            this.ghichuTextEdit.Name = "ghichuTextEdit";
            this.ghichuTextEdit.Size = new System.Drawing.Size(811, 305);
            this.ghichuTextEdit.TabIndex = 4;
            this.ghichuTextEdit.UseOptimizedRendering = true;
            // 
            // CancelSimpleButton
            // 
            this.CancelSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelSimpleButton.Image")));
            this.CancelSimpleButton.Location = new System.Drawing.Point(873, 545);
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
            this.OkSimpleButton.Location = new System.Drawing.Point(710, 545);
            this.OkSimpleButton.Name = "OkSimpleButton";
            this.OkSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.OkSimpleButton.TabIndex = 5;
            this.OkSimpleButton.Text = "OK";
            this.OkSimpleButton.Click += new System.EventHandler(this.LoginSimpleButton_Click);
            // 
            // KhuvucDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 624);
            this.Controls.Add(this.CancelSimpleButton);
            this.Controls.Add(this.OkSimpleButton);
            this.Controls.Add(this.khuvucInformationGroupControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1107, 695);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1107, 695);
            this.Name = "KhuvucDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin chi tiết - Khu vực";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KhuvucDetailForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.khuvucInformationGroupControl)).EndInit();
            this.khuvucInformationGroupControl.ResumeLayout(false);
            this.khuvucInformationGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khuvucModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenKhuvucTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghichuTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl khuvucInformationGroupControl;
        private DevExpress.XtraEditors.SimpleButton CancelSimpleButton;
        private DevExpress.XtraEditors.SimpleButton OkSimpleButton;
        private DevExpress.XtraEditors.CheckEdit activeCheckEdit;
        private System.Windows.Forms.BindingSource khuvucModelBindingSource;
        private DevExpress.XtraEditors.TextEdit codeTextEdit;
        private DevExpress.XtraEditors.DateEdit ngayCapnhatDateEdit;
        private DevExpress.XtraEditors.TextEdit tenKhuvucTextEdit;
        private DevExpress.XtraEditors.MemoEdit ghichuTextEdit;
    }
}