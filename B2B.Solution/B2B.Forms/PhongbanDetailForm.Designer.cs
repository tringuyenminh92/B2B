namespace B2B.Forms
{
    partial class PhongbanDetailForm
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
            System.Windows.Forms.Label tenPhongbanLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhongbanDetailForm));
            this.phongbanModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activeCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.codeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ngayCapnhatDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.tenPhongbanTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ThongtinGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.ghichuTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.CancelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.OkSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            activeLabel = new System.Windows.Forms.Label();
            codeLabel = new System.Windows.Forms.Label();
            ghichuLabel = new System.Windows.Forms.Label();
            ngayCapnhatLabel = new System.Windows.Forms.Label();
            tenPhongbanLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.phongbanModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenPhongbanTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongtinGroupControl)).BeginInit();
            this.ThongtinGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ghichuTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // activeLabel
            // 
            activeLabel.AutoSize = true;
            activeLabel.Location = new System.Drawing.Point(466, 78);
            activeLabel.Name = "activeLabel";
            activeLabel.Size = new System.Drawing.Size(75, 25);
            activeLabel.TabIndex = 1;
            activeLabel.Text = "Active:";
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(45, 74);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(66, 25);
            codeLabel.TabIndex = 3;
            codeLabel.Text = "Code:";
            // 
            // ghichuLabel
            // 
            ghichuLabel.AutoSize = true;
            ghichuLabel.Location = new System.Drawing.Point(45, 258);
            ghichuLabel.Name = "ghichuLabel";
            ghichuLabel.Size = new System.Drawing.Size(91, 25);
            ghichuLabel.TabIndex = 5;
            ghichuLabel.Text = "Ghi chú:";
            // 
            // ngayCapnhatLabel
            // 
            ngayCapnhatLabel.AutoSize = true;
            ngayCapnhatLabel.Location = new System.Drawing.Point(45, 192);
            ngayCapnhatLabel.Name = "ngayCapnhatLabel";
            ngayCapnhatLabel.Size = new System.Drawing.Size(155, 25);
            ngayCapnhatLabel.TabIndex = 7;
            ngayCapnhatLabel.Text = "Ngày cập nhật:";
            // 
            // tenPhongbanLabel
            // 
            tenPhongbanLabel.AutoSize = true;
            tenPhongbanLabel.Location = new System.Drawing.Point(45, 130);
            tenPhongbanLabel.Name = "tenPhongbanLabel";
            tenPhongbanLabel.Size = new System.Drawing.Size(127, 25);
            tenPhongbanLabel.TabIndex = 13;
            tenPhongbanLabel.Text = "Phòng ban: ";
            // 
            // phongbanModelBindingSource
            // 
            this.phongbanModelBindingSource.DataSource = typeof(B2B.Model.PhongbanModel);
            // 
            // activeCheckEdit
            // 
            this.activeCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phongbanModelBindingSource, "Active", true));
            this.activeCheckEdit.EditValue = true;
            this.activeCheckEdit.Location = new System.Drawing.Point(566, 76);
            this.activeCheckEdit.Name = "activeCheckEdit";
            this.activeCheckEdit.Properties.Caption = "";
            this.activeCheckEdit.Size = new System.Drawing.Size(30, 19);
            this.activeCheckEdit.TabIndex = 1;
            // 
            // codeTextEdit
            // 
            this.codeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phongbanModelBindingSource, "Code", true));
            this.codeTextEdit.Location = new System.Drawing.Point(206, 71);
            this.codeTextEdit.Name = "codeTextEdit";
            this.codeTextEdit.Size = new System.Drawing.Size(225, 32);
            this.codeTextEdit.TabIndex = 0;
            // 
            // ngayCapnhatDateEdit
            // 
            this.ngayCapnhatDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phongbanModelBindingSource, "NgayCapnhat", true));
            this.ngayCapnhatDateEdit.EditValue = null;
            this.ngayCapnhatDateEdit.Location = new System.Drawing.Point(206, 189);
            this.ngayCapnhatDateEdit.Name = "ngayCapnhatDateEdit";
            this.ngayCapnhatDateEdit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.ngayCapnhatDateEdit.Properties.Appearance.Options.UseBackColor = true;
            this.ngayCapnhatDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayCapnhatDateEdit.Properties.ReadOnly = true;
            this.ngayCapnhatDateEdit.Size = new System.Drawing.Size(390, 32);
            this.ngayCapnhatDateEdit.TabIndex = 3;
            // 
            // tenPhongbanTextEdit
            // 
            this.tenPhongbanTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phongbanModelBindingSource, "TenPhongban", true));
            this.tenPhongbanTextEdit.Location = new System.Drawing.Point(206, 127);
            this.tenPhongbanTextEdit.Name = "tenPhongbanTextEdit";
            this.tenPhongbanTextEdit.Size = new System.Drawing.Size(390, 32);
            this.tenPhongbanTextEdit.TabIndex = 2;
            // 
            // ThongtinGroupControl
            // 
            this.ThongtinGroupControl.Controls.Add(activeLabel);
            this.ThongtinGroupControl.Controls.Add(this.activeCheckEdit);
            this.ThongtinGroupControl.Controls.Add(codeLabel);
            this.ThongtinGroupControl.Controls.Add(this.codeTextEdit);
            this.ThongtinGroupControl.Controls.Add(ghichuLabel);
            this.ThongtinGroupControl.Controls.Add(ngayCapnhatLabel);
            this.ThongtinGroupControl.Controls.Add(this.ngayCapnhatDateEdit);
            this.ThongtinGroupControl.Controls.Add(tenPhongbanLabel);
            this.ThongtinGroupControl.Controls.Add(this.tenPhongbanTextEdit);
            this.ThongtinGroupControl.Controls.Add(this.ghichuTextEdit);
            this.ThongtinGroupControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ThongtinGroupControl.Location = new System.Drawing.Point(0, 0);
            this.ThongtinGroupControl.Name = "ThongtinGroupControl";
            this.ThongtinGroupControl.Size = new System.Drawing.Size(707, 495);
            this.ThongtinGroupControl.TabIndex = 15;
            this.ThongtinGroupControl.Text = "Thông tin";
            // 
            // ghichuTextEdit
            // 
            this.ghichuTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phongbanModelBindingSource, "Ghichu", true));
            this.ghichuTextEdit.Location = new System.Drawing.Point(206, 255);
            this.ghichuTextEdit.Name = "ghichuTextEdit";
            this.ghichuTextEdit.Size = new System.Drawing.Size(390, 207);
            this.ghichuTextEdit.TabIndex = 4;
            this.ghichuTextEdit.UseOptimizedRendering = true;
            // 
            // CancelSimpleButton
            // 
            this.CancelSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelSimpleButton.Image")));
            this.CancelSimpleButton.Location = new System.Drawing.Point(457, 536);
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
            this.OkSimpleButton.Location = new System.Drawing.Point(294, 536);
            this.OkSimpleButton.Name = "OkSimpleButton";
            this.OkSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.OkSimpleButton.TabIndex = 5;
            this.OkSimpleButton.Text = "OK";
            this.OkSimpleButton.Click += new System.EventHandler(this.OkSimpleButton_Click);
            // 
            // PhongbanDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 623);
            this.Controls.Add(this.CancelSimpleButton);
            this.Controls.Add(this.OkSimpleButton);
            this.Controls.Add(this.ThongtinGroupControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(733, 694);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(733, 694);
            this.Name = "PhongbanDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin chi tiết Phòng ban";
            ((System.ComponentModel.ISupportInitialize)(this.phongbanModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenPhongbanTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongtinGroupControl)).EndInit();
            this.ThongtinGroupControl.ResumeLayout(false);
            this.ThongtinGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ghichuTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource phongbanModelBindingSource;
        private DevExpress.XtraEditors.CheckEdit activeCheckEdit;
        private DevExpress.XtraEditors.TextEdit codeTextEdit;
        private DevExpress.XtraEditors.DateEdit ngayCapnhatDateEdit;
        private DevExpress.XtraEditors.TextEdit tenPhongbanTextEdit;
        private DevExpress.XtraEditors.GroupControl ThongtinGroupControl;
        private DevExpress.XtraEditors.MemoEdit ghichuTextEdit;
        private DevExpress.XtraEditors.SimpleButton CancelSimpleButton;
        private DevExpress.XtraEditors.SimpleButton OkSimpleButton;
    }
}