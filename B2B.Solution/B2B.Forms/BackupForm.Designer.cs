namespace B2B.Forms
{
    partial class BackupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupForm));
            this.SaoluuLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.TenTaptinLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TenTaptinTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DuongdanTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CancelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.OkSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.OpenPathSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.DuongdanFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.TenTaptinTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DuongdanTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // SaoluuLabelControl
            // 
            this.SaoluuLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SaoluuLabelControl.Location = new System.Drawing.Point(222, 35);
            this.SaoluuLabelControl.Name = "SaoluuLabelControl";
            this.SaoluuLabelControl.Size = new System.Drawing.Size(299, 33);
            this.SaoluuLabelControl.TabIndex = 0;
            this.SaoluuLabelControl.Text = "Sao lưu dự phòng dữ liệu";
            // 
            // TenTaptinLabelControl
            // 
            this.TenTaptinLabelControl.Location = new System.Drawing.Point(23, 108);
            this.TenTaptinLabelControl.Name = "TenTaptinLabelControl";
            this.TenTaptinLabelControl.Size = new System.Drawing.Size(110, 25);
            this.TenTaptinLabelControl.TabIndex = 1;
            this.TenTaptinLabelControl.Text = "Tên tập tin:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(23, 161);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(120, 25);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Đường dẫn: ";
            // 
            // TenTaptinTextEdit
            // 
            this.TenTaptinTextEdit.Location = new System.Drawing.Point(166, 101);
            this.TenTaptinTextEdit.Name = "TenTaptinTextEdit";
            this.TenTaptinTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.TenTaptinTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.TenTaptinTextEdit.Properties.ReadOnly = true;
            this.TenTaptinTextEdit.Size = new System.Drawing.Size(557, 32);
            this.TenTaptinTextEdit.TabIndex = 3;
            // 
            // DuongdanTextEdit
            // 
            this.DuongdanTextEdit.Location = new System.Drawing.Point(166, 154);
            this.DuongdanTextEdit.Name = "DuongdanTextEdit";
            this.DuongdanTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.DuongdanTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.DuongdanTextEdit.Properties.ReadOnly = true;
            this.DuongdanTextEdit.Size = new System.Drawing.Size(485, 32);
            this.DuongdanTextEdit.TabIndex = 4;
            // 
            // CancelSimpleButton
            // 
            this.CancelSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelSimpleButton.Image")));
            this.CancelSimpleButton.Location = new System.Drawing.Point(583, 222);
            this.CancelSimpleButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelSimpleButton.Name = "CancelSimpleButton";
            this.CancelSimpleButton.Size = new System.Drawing.Size(140, 52);
            this.CancelSimpleButton.TabIndex = 11;
            this.CancelSimpleButton.Text = "Đóng";
            this.CancelSimpleButton.Click += new System.EventHandler(this.CancelSimpleButton_Click);
            // 
            // OkSimpleButton
            // 
            this.OkSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("OkSimpleButton.Image")));
            this.OkSimpleButton.Location = new System.Drawing.Point(421, 222);
            this.OkSimpleButton.Margin = new System.Windows.Forms.Padding(4);
            this.OkSimpleButton.Name = "OkSimpleButton";
            this.OkSimpleButton.Size = new System.Drawing.Size(140, 52);
            this.OkSimpleButton.TabIndex = 10;
            this.OkSimpleButton.Text = "Thực hiện";
            this.OkSimpleButton.Click += new System.EventHandler(this.OkSimpleButton_Click);
            // 
            // OpenPathSimpleButton
            // 
            this.OpenPathSimpleButton.Appearance.BackColor = System.Drawing.Color.White;
            this.OpenPathSimpleButton.Appearance.BackColor2 = System.Drawing.Color.White;
            this.OpenPathSimpleButton.Appearance.BorderColor = System.Drawing.Color.White;
            this.OpenPathSimpleButton.Appearance.ForeColor = System.Drawing.Color.Black;
            this.OpenPathSimpleButton.Appearance.Options.UseBackColor = true;
            this.OpenPathSimpleButton.Appearance.Options.UseBorderColor = true;
            this.OpenPathSimpleButton.Appearance.Options.UseForeColor = true;
            this.OpenPathSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenPathSimpleButton.Image")));
            this.OpenPathSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.OpenPathSimpleButton.Location = new System.Drawing.Point(648, 154);
            this.OpenPathSimpleButton.Name = "OpenPathSimpleButton";
            this.OpenPathSimpleButton.Size = new System.Drawing.Size(75, 32);
            this.OpenPathSimpleButton.TabIndex = 12;
            this.OpenPathSimpleButton.Click += new System.EventHandler(this.OpenPathSimpleButton_Click);
            // 
            // DuongdanFolderBrowserDialog
            // 
            this.DuongdanFolderBrowserDialog.SelectedPath = "C:\\Users\\Ga9286\\Desktop";
            // 
            // BackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 301);
            this.Controls.Add(this.OpenPathSimpleButton);
            this.Controls.Add(this.CancelSimpleButton);
            this.Controls.Add(this.OkSimpleButton);
            this.Controls.Add(this.DuongdanTextEdit);
            this.Controls.Add(this.TenTaptinTextEdit);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.TenTaptinLabelControl);
            this.Controls.Add(this.SaoluuLabelControl);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(814, 372);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(814, 372);
            this.Name = "BackupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sao lưu dữ liệu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BackupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TenTaptinTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DuongdanTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl SaoluuLabelControl;
        private DevExpress.XtraEditors.LabelControl TenTaptinLabelControl;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TenTaptinTextEdit;
        private DevExpress.XtraEditors.TextEdit DuongdanTextEdit;
        private DevExpress.XtraEditors.SimpleButton CancelSimpleButton;
        private DevExpress.XtraEditors.SimpleButton OkSimpleButton;
        private DevExpress.XtraEditors.SimpleButton OpenPathSimpleButton;
        private System.Windows.Forms.FolderBrowserDialog DuongdanFolderBrowserDialog;
    }
}