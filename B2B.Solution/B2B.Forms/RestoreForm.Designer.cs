namespace B2B.Forms
{
    partial class RestoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestoreForm));
            this.OpenPathSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.CancelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.OkSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.DuongdanTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TenTaptinTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TenTaptinLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.KhoiphucLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.backupOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DuongdanTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenTaptinTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.OpenPathSimpleButton.Location = new System.Drawing.Point(664, 151);
            this.OpenPathSimpleButton.Name = "OpenPathSimpleButton";
            this.OpenPathSimpleButton.Size = new System.Drawing.Size(75, 32);
            this.OpenPathSimpleButton.TabIndex = 20;
            this.OpenPathSimpleButton.Click += new System.EventHandler(this.OpenPathSimpleButton_Click);
            // 
            // CancelSimpleButton
            // 
            this.CancelSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelSimpleButton.Image")));
            this.CancelSimpleButton.Location = new System.Drawing.Point(599, 210);
            this.CancelSimpleButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelSimpleButton.Name = "CancelSimpleButton";
            this.CancelSimpleButton.Size = new System.Drawing.Size(140, 52);
            this.CancelSimpleButton.TabIndex = 19;
            this.CancelSimpleButton.Text = "Đóng";
            this.CancelSimpleButton.Click += new System.EventHandler(this.CancelSimpleButton_Click);
            // 
            // OkSimpleButton
            // 
            this.OkSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("OkSimpleButton.Image")));
            this.OkSimpleButton.Location = new System.Drawing.Point(448, 210);
            this.OkSimpleButton.Margin = new System.Windows.Forms.Padding(4);
            this.OkSimpleButton.Name = "OkSimpleButton";
            this.OkSimpleButton.Size = new System.Drawing.Size(140, 52);
            this.OkSimpleButton.TabIndex = 18;
            this.OkSimpleButton.Text = "Thực hiện";
            this.OkSimpleButton.Click += new System.EventHandler(this.OkSimpleButton_Click);
            // 
            // DuongdanTextEdit
            // 
            this.DuongdanTextEdit.Location = new System.Drawing.Point(182, 151);
            this.DuongdanTextEdit.Name = "DuongdanTextEdit";
            this.DuongdanTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.DuongdanTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.DuongdanTextEdit.Properties.ReadOnly = true;
            this.DuongdanTextEdit.Size = new System.Drawing.Size(485, 32);
            this.DuongdanTextEdit.TabIndex = 17;
            // 
            // TenTaptinTextEdit
            // 
            this.TenTaptinTextEdit.Location = new System.Drawing.Point(182, 98);
            this.TenTaptinTextEdit.Name = "TenTaptinTextEdit";
            this.TenTaptinTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.TenTaptinTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.TenTaptinTextEdit.Properties.ReadOnly = true;
            this.TenTaptinTextEdit.Size = new System.Drawing.Size(557, 32);
            this.TenTaptinTextEdit.TabIndex = 16;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(39, 158);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(120, 25);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "Đường dẫn: ";
            // 
            // TenTaptinLabelControl
            // 
            this.TenTaptinLabelControl.Location = new System.Drawing.Point(39, 105);
            this.TenTaptinLabelControl.Name = "TenTaptinLabelControl";
            this.TenTaptinLabelControl.Size = new System.Drawing.Size(110, 25);
            this.TenTaptinLabelControl.TabIndex = 14;
            this.TenTaptinLabelControl.Text = "Tên tập tin:";
            // 
            // KhoiphucLabelControl
            // 
            this.KhoiphucLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.KhoiphucLabelControl.Location = new System.Drawing.Point(238, 32);
            this.KhoiphucLabelControl.Name = "KhoiphucLabelControl";
            this.KhoiphucLabelControl.Size = new System.Drawing.Size(327, 33);
            this.KhoiphucLabelControl.TabIndex = 13;
            this.KhoiphucLabelControl.Text = "Khôi phục dữ liệu dự phòng";
            // 
            // RestoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 296);
            this.Controls.Add(this.OpenPathSimpleButton);
            this.Controls.Add(this.CancelSimpleButton);
            this.Controls.Add(this.OkSimpleButton);
            this.Controls.Add(this.DuongdanTextEdit);
            this.Controls.Add(this.TenTaptinTextEdit);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.TenTaptinLabelControl);
            this.Controls.Add(this.KhoiphucLabelControl);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(822, 367);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(822, 367);
            this.Name = "RestoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Khôi phục dữ liệu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DuongdanTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenTaptinTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton OpenPathSimpleButton;
        private DevExpress.XtraEditors.SimpleButton CancelSimpleButton;
        private DevExpress.XtraEditors.SimpleButton OkSimpleButton;
        private DevExpress.XtraEditors.TextEdit DuongdanTextEdit;
        private DevExpress.XtraEditors.TextEdit TenTaptinTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl TenTaptinLabelControl;
        private DevExpress.XtraEditors.LabelControl KhoiphucLabelControl;
        private System.Windows.Forms.OpenFileDialog backupOpenFileDialog;
    }
}