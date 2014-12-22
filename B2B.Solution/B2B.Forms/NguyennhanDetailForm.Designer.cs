namespace B2B.Forms
{
    partial class NguyennhanDetailForm
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
            System.Windows.Forms.Label noidungLabel;
            System.Windows.Forms.Label tenLoaiNguyennhanLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NguyennhanDetailForm));
            this.nguyennhanLydoModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ThongtinGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.NhomComboBox = new System.Windows.Forms.ComboBox();
            this.loaiNguyennhanModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activeCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.codeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.noidungTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ghichuTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.CancelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.OkSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            activeLabel = new System.Windows.Forms.Label();
            codeLabel = new System.Windows.Forms.Label();
            ghichuLabel = new System.Windows.Forms.Label();
            noidungLabel = new System.Windows.Forms.Label();
            tenLoaiNguyennhanLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nguyennhanLydoModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongtinGroupControl)).BeginInit();
            this.ThongtinGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaiNguyennhanModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noidungTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghichuTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // activeLabel
            // 
            activeLabel.AutoSize = true;
            activeLabel.Location = new System.Drawing.Point(282, 65);
            activeLabel.Name = "activeLabel";
            activeLabel.Size = new System.Drawing.Size(75, 25);
            activeLabel.TabIndex = 17;
            activeLabel.Text = "Active:";
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(16, 65);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(66, 25);
            codeLabel.TabIndex = 19;
            codeLabel.Text = "Code:";
            // 
            // ghichuLabel
            // 
            ghichuLabel.AutoSize = true;
            ghichuLabel.Location = new System.Drawing.Point(16, 169);
            ghichuLabel.Name = "ghichuLabel";
            ghichuLabel.Size = new System.Drawing.Size(84, 25);
            ghichuLabel.TabIndex = 21;
            ghichuLabel.Text = "Ghichu:";
            // 
            // noidungLabel
            // 
            noidungLabel.AutoSize = true;
            noidungLabel.Location = new System.Drawing.Point(16, 116);
            noidungLabel.Name = "noidungLabel";
            noidungLabel.Size = new System.Drawing.Size(104, 25);
            noidungLabel.TabIndex = 25;
            noidungLabel.Text = "Nội dung:";
            // 
            // tenLoaiNguyennhanLabel
            // 
            tenLoaiNguyennhanLabel.AutoSize = true;
            tenLoaiNguyennhanLabel.Location = new System.Drawing.Point(420, 65);
            tenLoaiNguyennhanLabel.Name = "tenLoaiNguyennhanLabel";
            tenLoaiNguyennhanLabel.Size = new System.Drawing.Size(204, 25);
            tenLoaiNguyennhanLabel.TabIndex = 29;
            tenLoaiNguyennhanLabel.Text = "Nhóm nguyên nhân:";
            // 
            // nguyennhanLydoModelBindingSource
            // 
            this.nguyennhanLydoModelBindingSource.DataSource = typeof(B2B.Model.NguyennhanLydoModel);
            // 
            // ThongtinGroupControl
            // 
            this.ThongtinGroupControl.Controls.Add(this.NhomComboBox);
            this.ThongtinGroupControl.Controls.Add(activeLabel);
            this.ThongtinGroupControl.Controls.Add(this.activeCheckEdit);
            this.ThongtinGroupControl.Controls.Add(codeLabel);
            this.ThongtinGroupControl.Controls.Add(this.codeTextEdit);
            this.ThongtinGroupControl.Controls.Add(ghichuLabel);
            this.ThongtinGroupControl.Controls.Add(noidungLabel);
            this.ThongtinGroupControl.Controls.Add(this.noidungTextEdit);
            this.ThongtinGroupControl.Controls.Add(tenLoaiNguyennhanLabel);
            this.ThongtinGroupControl.Controls.Add(this.ghichuTextEdit);
            this.ThongtinGroupControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ThongtinGroupControl.Location = new System.Drawing.Point(0, 0);
            this.ThongtinGroupControl.Name = "ThongtinGroupControl";
            this.ThongtinGroupControl.Size = new System.Drawing.Size(837, 550);
            this.ThongtinGroupControl.TabIndex = 17;
            this.ThongtinGroupControl.Text = "Thông tin";
            // 
            // NhomComboBox
            // 
            this.NhomComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.nguyennhanLydoModelBindingSource, "Step", true));
            this.NhomComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.nguyennhanLydoModelBindingSource, "Step", true));
            this.NhomComboBox.DataSource = this.loaiNguyennhanModelBindingSource;
            this.NhomComboBox.DisplayMember = "TenLoaiNguyennhan";
            this.NhomComboBox.FormattingEnabled = true;
            this.NhomComboBox.Location = new System.Drawing.Point(626, 61);
            this.NhomComboBox.Name = "NhomComboBox";
            this.NhomComboBox.Size = new System.Drawing.Size(144, 33);
            this.NhomComboBox.TabIndex = 30;
            this.NhomComboBox.ValueMember = "LoaiNguyennhanValue";
            // 
            // loaiNguyennhanModelBindingSource
            // 
            this.loaiNguyennhanModelBindingSource.DataSource = typeof(B2B.Model.LoaiNguyennhanModel);
            // 
            // activeCheckEdit
            // 
            this.activeCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nguyennhanLydoModelBindingSource, "Active", true));
            this.activeCheckEdit.EditValue = true;
            this.activeCheckEdit.Location = new System.Drawing.Point(363, 63);
            this.activeCheckEdit.Name = "activeCheckEdit";
            this.activeCheckEdit.Properties.Caption = "";
            this.activeCheckEdit.Size = new System.Drawing.Size(51, 19);
            this.activeCheckEdit.TabIndex = 1;
            // 
            // codeTextEdit
            // 
            this.codeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nguyennhanLydoModelBindingSource, "Code", true));
            this.codeTextEdit.Location = new System.Drawing.Point(126, 62);
            this.codeTextEdit.Name = "codeTextEdit";
            this.codeTextEdit.Size = new System.Drawing.Size(140, 32);
            this.codeTextEdit.TabIndex = 0;
            // 
            // noidungTextEdit
            // 
            this.noidungTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nguyennhanLydoModelBindingSource, "Noidung", true));
            this.noidungTextEdit.Location = new System.Drawing.Point(126, 113);
            this.noidungTextEdit.Name = "noidungTextEdit";
            this.noidungTextEdit.Size = new System.Drawing.Size(644, 32);
            this.noidungTextEdit.TabIndex = 3;
            // 
            // ghichuTextEdit
            // 
            this.ghichuTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nguyennhanLydoModelBindingSource, "Ghichu", true));
            this.ghichuTextEdit.Location = new System.Drawing.Point(126, 167);
            this.ghichuTextEdit.Name = "ghichuTextEdit";
            this.ghichuTextEdit.Size = new System.Drawing.Size(644, 335);
            this.ghichuTextEdit.TabIndex = 4;
            this.ghichuTextEdit.UseOptimizedRendering = true;
            // 
            // CancelSimpleButton
            // 
            this.CancelSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelSimpleButton.Image")));
            this.CancelSimpleButton.Location = new System.Drawing.Point(626, 567);
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
            this.OkSimpleButton.Location = new System.Drawing.Point(463, 567);
            this.OkSimpleButton.Name = "OkSimpleButton";
            this.OkSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.OkSimpleButton.TabIndex = 5;
            this.OkSimpleButton.Text = "OK";
            this.OkSimpleButton.Click += new System.EventHandler(this.OkSimpleButton_Click);
            // 
            // NguyennhanDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 650);
            this.Controls.Add(this.CancelSimpleButton);
            this.Controls.Add(this.OkSimpleButton);
            this.Controls.Add(this.ThongtinGroupControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(863, 721);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(863, 721);
            this.Name = "NguyennhanDetailForm";
            this.Text = "Thông tin chi tiết Nguyên nhân";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NguyennhanDetailForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.nguyennhanLydoModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongtinGroupControl)).EndInit();
            this.ThongtinGroupControl.ResumeLayout(false);
            this.ThongtinGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaiNguyennhanModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noidungTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghichuTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource nguyennhanLydoModelBindingSource;
        private DevExpress.XtraEditors.GroupControl ThongtinGroupControl;
        private DevExpress.XtraEditors.CheckEdit activeCheckEdit;
        private DevExpress.XtraEditors.TextEdit codeTextEdit;
        private DevExpress.XtraEditors.TextEdit noidungTextEdit;
        private DevExpress.XtraEditors.MemoEdit ghichuTextEdit;
        private DevExpress.XtraEditors.SimpleButton CancelSimpleButton;
        private DevExpress.XtraEditors.SimpleButton OkSimpleButton;
        private System.Windows.Forms.BindingSource loaiNguyennhanModelBindingSource;
        private System.Windows.Forms.ComboBox NhomComboBox;
    }
}