namespace B2B.Forms
{
    partial class NhomKhachhangDetailForm
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
            System.Windows.Forms.Label ghichuLabel;
            System.Windows.Forms.Label codeLabel;
            System.Windows.Forms.Label activeLabel;
            System.Windows.Forms.Label tenNhomKhachhangLabel;
            System.Windows.Forms.Label ngayCapnhatLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhomKhachhangDetailForm));
            this.nhomKhachhangModelBindingSource = new System.Windows.Forms.BindingSource();
            this.ghichuTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.codeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.activeCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.tenNhomKhachhangTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ngayCapnhatDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.InformationGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.CancelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.OKSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            ghichuLabel = new System.Windows.Forms.Label();
            codeLabel = new System.Windows.Forms.Label();
            activeLabel = new System.Windows.Forms.Label();
            tenNhomKhachhangLabel = new System.Windows.Forms.Label();
            ngayCapnhatLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nhomKhachhangModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghichuTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenNhomKhachhangTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InformationGroupControl)).BeginInit();
            this.InformationGroupControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ghichuLabel
            // 
            ghichuLabel.AutoSize = true;
            ghichuLabel.Location = new System.Drawing.Point(23, 106);
            ghichuLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            ghichuLabel.Name = "ghichuLabel";
            ghichuLabel.Size = new System.Drawing.Size(43, 13);
            ghichuLabel.TabIndex = 10;
            ghichuLabel.Text = "Ghichu:";
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(23, 38);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(36, 13);
            codeLabel.TabIndex = 14;
            codeLabel.Text = "Code:";
            // 
            // activeLabel
            // 
            activeLabel.AutoSize = true;
            activeLabel.Location = new System.Drawing.Point(231, 38);
            activeLabel.Name = "activeLabel";
            activeLabel.Size = new System.Drawing.Size(41, 13);
            activeLabel.TabIndex = 15;
            activeLabel.Text = "Active:";
            // 
            // tenNhomKhachhangLabel
            // 
            tenNhomKhachhangLabel.AutoSize = true;
            tenNhomKhachhangLabel.Location = new System.Drawing.Point(23, 72);
            tenNhomKhachhangLabel.Name = "tenNhomKhachhangLabel";
            tenNhomKhachhangLabel.Size = new System.Drawing.Size(96, 13);
            tenNhomKhachhangLabel.TabIndex = 16;
            tenNhomKhachhangLabel.Text = "Nhóm khách hàng:";
            // 
            // ngayCapnhatLabel
            // 
            ngayCapnhatLabel.AutoSize = true;
            ngayCapnhatLabel.Location = new System.Drawing.Point(324, 38);
            ngayCapnhatLabel.Name = "ngayCapnhatLabel";
            ngayCapnhatLabel.Size = new System.Drawing.Size(81, 13);
            ngayCapnhatLabel.TabIndex = 17;
            ngayCapnhatLabel.Text = "Ngày cập nhật:";
            // 
            // nhomKhachhangModelBindingSource
            // 
            this.nhomKhachhangModelBindingSource.DataSource = typeof(B2B.Model.NhomKhachhangModel);
            // 
            // ghichuTextEdit
            // 
            this.ghichuTextEdit.Location = new System.Drawing.Point(125, 103);
            this.ghichuTextEdit.Margin = new System.Windows.Forms.Padding(2);
            this.ghichuTextEdit.Name = "ghichuTextEdit";
            this.ghichuTextEdit.Size = new System.Drawing.Size(458, 236);
            this.ghichuTextEdit.TabIndex = 4;
            this.ghichuTextEdit.UseOptimizedRendering = true;
            // 
            // codeTextEdit
            // 
            this.codeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhomKhachhangModelBindingSource, "Code", true));
            this.codeTextEdit.Location = new System.Drawing.Point(125, 35);
            this.codeTextEdit.Name = "codeTextEdit";
            this.codeTextEdit.Size = new System.Drawing.Size(100, 20);
            this.codeTextEdit.TabIndex = 0;
            // 
            // activeCheckEdit
            // 
            this.activeCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhomKhachhangModelBindingSource, "Active", true));
            this.activeCheckEdit.Location = new System.Drawing.Point(278, 35);
            this.activeCheckEdit.Name = "activeCheckEdit";
            this.activeCheckEdit.Properties.Caption = "";
            this.activeCheckEdit.Size = new System.Drawing.Size(19, 19);
            this.activeCheckEdit.TabIndex = 2;
            // 
            // tenNhomKhachhangTextEdit
            // 
            this.tenNhomKhachhangTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhomKhachhangModelBindingSource, "TenNhomKhachhang", true));
            this.tenNhomKhachhangTextEdit.Location = new System.Drawing.Point(125, 69);
            this.tenNhomKhachhangTextEdit.Name = "tenNhomKhachhangTextEdit";
            this.tenNhomKhachhangTextEdit.Size = new System.Drawing.Size(172, 20);
            this.tenNhomKhachhangTextEdit.TabIndex = 3;
            // 
            // ngayCapnhatDateEdit
            // 
            this.ngayCapnhatDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhomKhachhangModelBindingSource, "NgayCapnhat", true));
            this.ngayCapnhatDateEdit.EditValue = null;
            this.ngayCapnhatDateEdit.Enabled = false;
            this.ngayCapnhatDateEdit.Location = new System.Drawing.Point(411, 35);
            this.ngayCapnhatDateEdit.Name = "ngayCapnhatDateEdit";
            this.ngayCapnhatDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayCapnhatDateEdit.Size = new System.Drawing.Size(172, 20);
            this.ngayCapnhatDateEdit.TabIndex = 18;
            // 
            // InformationGroupControl
            // 
            this.InformationGroupControl.Controls.Add(ngayCapnhatLabel);
            this.InformationGroupControl.Controls.Add(this.ngayCapnhatDateEdit);
            this.InformationGroupControl.Controls.Add(tenNhomKhachhangLabel);
            this.InformationGroupControl.Controls.Add(this.tenNhomKhachhangTextEdit);
            this.InformationGroupControl.Controls.Add(activeLabel);
            this.InformationGroupControl.Controls.Add(this.activeCheckEdit);
            this.InformationGroupControl.Controls.Add(codeLabel);
            this.InformationGroupControl.Controls.Add(this.codeTextEdit);
            this.InformationGroupControl.Controls.Add(ghichuLabel);
            this.InformationGroupControl.Controls.Add(this.ghichuTextEdit);
            this.InformationGroupControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.InformationGroupControl.Location = new System.Drawing.Point(0, 0);
            this.InformationGroupControl.Margin = new System.Windows.Forms.Padding(2);
            this.InformationGroupControl.Name = "InformationGroupControl";
            this.InformationGroupControl.Size = new System.Drawing.Size(622, 359);
            this.InformationGroupControl.TabIndex = 1;
            this.InformationGroupControl.Text = "Thông tin";
            // 
            // CancelSimpleButton
            // 
            this.CancelSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelSimpleButton.Image")));
            this.CancelSimpleButton.Location = new System.Drawing.Point(524, 411);
            this.CancelSimpleButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelSimpleButton.Name = "CancelSimpleButton";
            this.CancelSimpleButton.Size = new System.Drawing.Size(70, 27);
            this.CancelSimpleButton.TabIndex = 5;
            this.CancelSimpleButton.Text = "Cancel";
            this.CancelSimpleButton.Click += new System.EventHandler(this.CancelSimpleButton_Click);
            // 
            // OKSimpleButton
            // 
            this.OKSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("OKSimpleButton.Image")));
            this.OKSimpleButton.Location = new System.Drawing.Point(445, 411);
            this.OKSimpleButton.Margin = new System.Windows.Forms.Padding(2);
            this.OKSimpleButton.Name = "OKSimpleButton";
            this.OKSimpleButton.Size = new System.Drawing.Size(70, 27);
            this.OKSimpleButton.TabIndex = 4;
            this.OKSimpleButton.Text = "OK";
            this.OKSimpleButton.Click += new System.EventHandler(this.OKSimpleButton_Click);
            // 
            // NhomKhachhangDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 448);
            this.Controls.Add(this.CancelSimpleButton);
            this.Controls.Add(this.OKSimpleButton);
            this.Controls.Add(this.InformationGroupControl);
            this.MaximumSize = new System.Drawing.Size(638, 487);
            this.MinimumSize = new System.Drawing.Size(638, 487);
            this.Name = "NhomKhachhangDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin chi tiết Nhóm khách hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NhomKhachhangDetailForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.nhomKhachhangModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghichuTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenNhomKhachhangTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InformationGroupControl)).EndInit();
            this.InformationGroupControl.ResumeLayout(false);
            this.InformationGroupControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource nhomKhachhangModelBindingSource;
        private DevExpress.XtraEditors.MemoEdit ghichuTextEdit;
        private DevExpress.XtraEditors.TextEdit codeTextEdit;
        private DevExpress.XtraEditors.CheckEdit activeCheckEdit;
        private DevExpress.XtraEditors.TextEdit tenNhomKhachhangTextEdit;
        private DevExpress.XtraEditors.DateEdit ngayCapnhatDateEdit;
        private DevExpress.XtraEditors.GroupControl InformationGroupControl;
        private DevExpress.XtraEditors.SimpleButton CancelSimpleButton;
        private DevExpress.XtraEditors.SimpleButton OKSimpleButton;

    }
}