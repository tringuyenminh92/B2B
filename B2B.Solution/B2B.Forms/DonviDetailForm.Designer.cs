namespace B2B.Forms
{
    partial class DonviDetailForm
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
            System.Windows.Forms.Label tenDonviLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonviDetailForm));
            this.InformationGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.activeCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.donviModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ngayCapnhatDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.tenDonviTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ghichuTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.CancelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.OkSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            activeLabel = new System.Windows.Forms.Label();
            codeLabel = new System.Windows.Forms.Label();
            ghichuLabel = new System.Windows.Forms.Label();
            ngayCapnhatLabel = new System.Windows.Forms.Label();
            tenDonviLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InformationGroupControl)).BeginInit();
            this.InformationGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donviModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenDonviTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghichuTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // activeLabel
            // 
            activeLabel.AutoSize = true;
            activeLabel.Location = new System.Drawing.Point(572, 57);
            activeLabel.Name = "activeLabel";
            activeLabel.Size = new System.Drawing.Size(75, 25);
            activeLabel.TabIndex = 0;
            activeLabel.Text = "Active:";
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(42, 57);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(66, 25);
            codeLabel.TabIndex = 2;
            codeLabel.Text = "Code:";
            // 
            // ghichuLabel
            // 
            ghichuLabel.AutoSize = true;
            ghichuLabel.Location = new System.Drawing.Point(42, 163);
            ghichuLabel.Name = "ghichuLabel";
            ghichuLabel.Size = new System.Drawing.Size(91, 25);
            ghichuLabel.TabIndex = 6;
            ghichuLabel.Text = "Ghi chú:";
            // 
            // ngayCapnhatLabel
            // 
            ngayCapnhatLabel.AutoSize = true;
            ngayCapnhatLabel.Location = new System.Drawing.Point(572, 110);
            ngayCapnhatLabel.Name = "ngayCapnhatLabel";
            ngayCapnhatLabel.Size = new System.Drawing.Size(155, 25);
            ngayCapnhatLabel.TabIndex = 8;
            ngayCapnhatLabel.Text = "Ngày cập nhật:";
            // 
            // tenDonviLabel
            // 
            tenDonviLabel.AutoSize = true;
            tenDonviLabel.Location = new System.Drawing.Point(42, 110);
            tenDonviLabel.Name = "tenDonviLabel";
            tenDonviLabel.Size = new System.Drawing.Size(80, 25);
            tenDonviLabel.TabIndex = 12;
            tenDonviLabel.Text = "Đơn vị:";
            // 
            // InformationGroupControl
            // 
            this.InformationGroupControl.Controls.Add(activeLabel);
            this.InformationGroupControl.Controls.Add(this.activeCheckEdit);
            this.InformationGroupControl.Controls.Add(codeLabel);
            this.InformationGroupControl.Controls.Add(this.codeTextEdit);
            this.InformationGroupControl.Controls.Add(ghichuLabel);
            this.InformationGroupControl.Controls.Add(ngayCapnhatLabel);
            this.InformationGroupControl.Controls.Add(this.ngayCapnhatDateEdit);
            this.InformationGroupControl.Controls.Add(tenDonviLabel);
            this.InformationGroupControl.Controls.Add(this.tenDonviTextEdit);
            this.InformationGroupControl.Controls.Add(this.ghichuTextEdit);
            this.InformationGroupControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.InformationGroupControl.Location = new System.Drawing.Point(0, 0);
            this.InformationGroupControl.Name = "InformationGroupControl";
            this.InformationGroupControl.Size = new System.Drawing.Size(1115, 595);
            this.InformationGroupControl.TabIndex = 0;
            this.InformationGroupControl.Text = "Thông tin";
            // 
            // activeCheckEdit
            // 
            this.activeCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.donviModelBindingSource, "Active", true));
            this.activeCheckEdit.EditValue = true;
            this.activeCheckEdit.Location = new System.Drawing.Point(662, 55);
            this.activeCheckEdit.Name = "activeCheckEdit";
            this.activeCheckEdit.Properties.Caption = "";
            this.activeCheckEdit.Size = new System.Drawing.Size(100, 19);
            this.activeCheckEdit.TabIndex = 2;
            // 
            // donviModelBindingSource
            // 
            this.donviModelBindingSource.DataSource = typeof(B2B.Model.DonviModel);
            // 
            // codeTextEdit
            // 
            this.codeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.donviModelBindingSource, "Code", true));
            this.codeTextEdit.EditValue = "";
            this.codeTextEdit.Location = new System.Drawing.Point(199, 54);
            this.codeTextEdit.Name = "codeTextEdit";
            this.codeTextEdit.Size = new System.Drawing.Size(285, 32);
            this.codeTextEdit.TabIndex = 0;
            // 
            // ngayCapnhatDateEdit
            // 
            this.ngayCapnhatDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.donviModelBindingSource, "NgayCapnhat", true));
            this.ngayCapnhatDateEdit.EditValue = null;
            this.ngayCapnhatDateEdit.Enabled = false;
            this.ngayCapnhatDateEdit.Location = new System.Drawing.Point(729, 107);
            this.ngayCapnhatDateEdit.Name = "ngayCapnhatDateEdit";
            this.ngayCapnhatDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayCapnhatDateEdit.Size = new System.Drawing.Size(285, 32);
            this.ngayCapnhatDateEdit.TabIndex = 9;
            // 
            // tenDonviTextEdit
            // 
            this.tenDonviTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.donviModelBindingSource, "TenDonvi", true));
            this.tenDonviTextEdit.Location = new System.Drawing.Point(199, 107);
            this.tenDonviTextEdit.Name = "tenDonviTextEdit";
            this.tenDonviTextEdit.Size = new System.Drawing.Size(285, 32);
            this.tenDonviTextEdit.TabIndex = 1;
            // 
            // ghichuTextEdit
            // 
            this.ghichuTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.donviModelBindingSource, "Ghichu", true));
            this.ghichuTextEdit.Location = new System.Drawing.Point(199, 160);
            this.ghichuTextEdit.Name = "ghichuTextEdit";
            this.ghichuTextEdit.Size = new System.Drawing.Size(815, 395);
            this.ghichuTextEdit.TabIndex = 3;
            this.ghichuTextEdit.UseOptimizedRendering = true;
            // 
            // CancelSimpleButton
            // 
            this.CancelSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelSimpleButton.Image")));
            this.CancelSimpleButton.Location = new System.Drawing.Point(875, 611);
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
            this.OkSimpleButton.Location = new System.Drawing.Point(712, 611);
            this.OkSimpleButton.Name = "OkSimpleButton";
            this.OkSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.OkSimpleButton.TabIndex = 4;
            this.OkSimpleButton.Text = "OK";
            this.OkSimpleButton.Click += new System.EventHandler(this.OkSimpleButton_Click);
            // 
            // DonviDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 689);
            this.Controls.Add(this.CancelSimpleButton);
            this.Controls.Add(this.OkSimpleButton);
            this.Controls.Add(this.InformationGroupControl);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1141, 760);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1141, 760);
            this.Name = "DonviDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin chi tiết Đơn vị";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DonviDetailForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.InformationGroupControl)).EndInit();
            this.InformationGroupControl.ResumeLayout(false);
            this.InformationGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donviModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenDonviTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghichuTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl InformationGroupControl;
        private DevExpress.XtraEditors.CheckEdit activeCheckEdit;
        private System.Windows.Forms.BindingSource donviModelBindingSource;
        private DevExpress.XtraEditors.TextEdit codeTextEdit;
        private DevExpress.XtraEditors.DateEdit ngayCapnhatDateEdit;
        private DevExpress.XtraEditors.TextEdit tenDonviTextEdit;
        private DevExpress.XtraEditors.MemoEdit ghichuTextEdit;
        private DevExpress.XtraEditors.SimpleButton CancelSimpleButton;
        private DevExpress.XtraEditors.SimpleButton OkSimpleButton;
    }
}