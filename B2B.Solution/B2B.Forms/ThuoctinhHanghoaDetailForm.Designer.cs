namespace B2B.Forms
{
    partial class ThuoctinhHanghoaDetailForm
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
            System.Windows.Forms.Label tenHanghoaLabel;
            System.Windows.Forms.Label tenThuoctinhLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThuoctinhHanghoaDetailForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.CancelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.OkSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.thuoctinhHanghoaModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InformationGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.activeCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.codeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ngayCapnhatDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.tenHanghoaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tenThuoctinhTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ghichuTextEdit = new DevExpress.XtraEditors.MemoEdit();
            activeLabel = new System.Windows.Forms.Label();
            codeLabel = new System.Windows.Forms.Label();
            ghichuLabel = new System.Windows.Forms.Label();
            ngayCapnhatLabel = new System.Windows.Forms.Label();
            tenHanghoaLabel = new System.Windows.Forms.Label();
            tenThuoctinhLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thuoctinhHanghoaModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InformationGroupControl)).BeginInit();
            this.InformationGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenHanghoaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenThuoctinhTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghichuTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // activeLabel
            // 
            activeLabel.AutoSize = true;
            activeLabel.Location = new System.Drawing.Point(215, 38);
            activeLabel.Name = "activeLabel";
            activeLabel.Size = new System.Drawing.Size(41, 13);
            activeLabel.TabIndex = 42;
            activeLabel.Text = "Active:";
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(23, 37);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(36, 13);
            codeLabel.TabIndex = 44;
            codeLabel.Text = "Code:";
            // 
            // ghichuLabel
            // 
            ghichuLabel.AutoSize = true;
            ghichuLabel.Location = new System.Drawing.Point(23, 88);
            ghichuLabel.Name = "ghichuLabel";
            ghichuLabel.Size = new System.Drawing.Size(46, 13);
            ghichuLabel.TabIndex = 46;
            ghichuLabel.Text = "Ghi chú:";
            // 
            // ngayCapnhatLabel
            // 
            ngayCapnhatLabel.AutoSize = true;
            ngayCapnhatLabel.Location = new System.Drawing.Point(365, 63);
            ngayCapnhatLabel.Name = "ngayCapnhatLabel";
            ngayCapnhatLabel.Size = new System.Drawing.Size(77, 13);
            ngayCapnhatLabel.TabIndex = 50;
            ngayCapnhatLabel.Text = "Ngày cập nhật";
            // 
            // tenHanghoaLabel
            // 
            tenHanghoaLabel.AutoSize = true;
            tenHanghoaLabel.Location = new System.Drawing.Point(365, 37);
            tenHanghoaLabel.Name = "tenHanghoaLabel";
            tenHanghoaLabel.Size = new System.Drawing.Size(77, 13);
            tenHanghoaLabel.TabIndex = 54;
            tenHanghoaLabel.Text = "Tên hàng hóa:";
            // 
            // tenThuoctinhLabel
            // 
            tenThuoctinhLabel.AutoSize = true;
            tenThuoctinhLabel.Location = new System.Drawing.Point(23, 63);
            tenThuoctinhLabel.Name = "tenThuoctinhLabel";
            tenThuoctinhLabel.Size = new System.Drawing.Size(80, 13);
            tenThuoctinhLabel.TabIndex = 56;
            tenThuoctinhLabel.Text = "Tên thuộc tính:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.CancelSimpleButton);
            this.panelControl1.Controls.Add(this.OkSimpleButton);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 378);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(702, 59);
            this.panelControl1.TabIndex = 23;
            // 
            // CancelSimpleButton
            // 
            this.CancelSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelSimpleButton.Image")));
            this.CancelSimpleButton.Location = new System.Drawing.Point(632, 21);
            this.CancelSimpleButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelSimpleButton.Name = "CancelSimpleButton";
            this.CancelSimpleButton.Size = new System.Drawing.Size(70, 27);
            this.CancelSimpleButton.TabIndex = 7;
            this.CancelSimpleButton.Text = "Cancel";
            this.CancelSimpleButton.Click += new System.EventHandler(this.CancelSimpleButton_Click);
            // 
            // OkSimpleButton
            // 
            this.OkSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("OkSimpleButton.Image")));
            this.OkSimpleButton.Location = new System.Drawing.Point(551, 21);
            this.OkSimpleButton.Margin = new System.Windows.Forms.Padding(2);
            this.OkSimpleButton.Name = "OkSimpleButton";
            this.OkSimpleButton.Size = new System.Drawing.Size(70, 27);
            this.OkSimpleButton.TabIndex = 6;
            this.OkSimpleButton.Text = "OK";
            this.OkSimpleButton.Click += new System.EventHandler(this.OkSimpleButton_Click);
            // 
            // thuoctinhHanghoaModelBindingSource
            // 
            this.thuoctinhHanghoaModelBindingSource.DataSource = typeof(B2B.Model.ThuoctinhHanghoaModel);
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
            this.InformationGroupControl.Controls.Add(tenHanghoaLabel);
            this.InformationGroupControl.Controls.Add(this.tenHanghoaTextEdit);
            this.InformationGroupControl.Controls.Add(tenThuoctinhLabel);
            this.InformationGroupControl.Controls.Add(this.tenThuoctinhTextEdit);
            this.InformationGroupControl.Controls.Add(this.ghichuTextEdit);
            this.InformationGroupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InformationGroupControl.Location = new System.Drawing.Point(0, 0);
            this.InformationGroupControl.Name = "InformationGroupControl";
            this.InformationGroupControl.Size = new System.Drawing.Size(702, 378);
            this.InformationGroupControl.TabIndex = 42;
            this.InformationGroupControl.Text = "Thông tin";
            // 
            // activeCheckEdit
            // 
            this.activeCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.thuoctinhHanghoaModelBindingSource, "Active", true));
            this.activeCheckEdit.Location = new System.Drawing.Point(262, 35);
            this.activeCheckEdit.Name = "activeCheckEdit";
            this.activeCheckEdit.Properties.Caption = "";
            this.activeCheckEdit.Size = new System.Drawing.Size(19, 19);
            this.activeCheckEdit.TabIndex = 1;
            // 
            // codeTextEdit
            // 
            this.codeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.thuoctinhHanghoaModelBindingSource, "Code", true));
            this.codeTextEdit.Location = new System.Drawing.Point(110, 34);
            this.codeTextEdit.Name = "codeTextEdit";
            this.codeTextEdit.Size = new System.Drawing.Size(100, 20);
            this.codeTextEdit.TabIndex = 0;
            // 
            // ngayCapnhatDateEdit
            // 
            this.ngayCapnhatDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.thuoctinhHanghoaModelBindingSource, "NgayCapnhat", true));
            this.ngayCapnhatDateEdit.EditValue = null;
            this.ngayCapnhatDateEdit.Enabled = false;
            this.ngayCapnhatDateEdit.Location = new System.Drawing.Point(488, 60);
            this.ngayCapnhatDateEdit.Name = "ngayCapnhatDateEdit";
            this.ngayCapnhatDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayCapnhatDateEdit.Size = new System.Drawing.Size(168, 20);
            this.ngayCapnhatDateEdit.TabIndex = 4;
            // 
            // tenHanghoaTextEdit
            // 
            this.tenHanghoaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.thuoctinhHanghoaModelBindingSource, "TenHanghoa", true));
            this.tenHanghoaTextEdit.Enabled = false;
            this.tenHanghoaTextEdit.Location = new System.Drawing.Point(488, 34);
            this.tenHanghoaTextEdit.Name = "tenHanghoaTextEdit";
            this.tenHanghoaTextEdit.Size = new System.Drawing.Size(168, 20);
            this.tenHanghoaTextEdit.TabIndex = 3;
            // 
            // tenThuoctinhTextEdit
            // 
            this.tenThuoctinhTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.thuoctinhHanghoaModelBindingSource, "TenThuoctinh", true));
            this.tenThuoctinhTextEdit.Location = new System.Drawing.Point(110, 60);
            this.tenThuoctinhTextEdit.Name = "tenThuoctinhTextEdit";
            this.tenThuoctinhTextEdit.Size = new System.Drawing.Size(168, 20);
            this.tenThuoctinhTextEdit.TabIndex = 2;
            // 
            // ghichuTextEdit
            // 
            this.ghichuTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.thuoctinhHanghoaModelBindingSource, "Ghichu", true));
            this.ghichuTextEdit.Location = new System.Drawing.Point(110, 96);
            this.ghichuTextEdit.Name = "ghichuTextEdit";
            this.ghichuTextEdit.Size = new System.Drawing.Size(546, 282);
            this.ghichuTextEdit.TabIndex = 5;
            this.ghichuTextEdit.UseOptimizedRendering = true;
            // 
            // ThuoctinhHanghoaDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 437);
            this.Controls.Add(this.InformationGroupControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "ThuoctinhHanghoaDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết thuộc tính hàng hóa ";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ThuoctinhHanghoaDetailForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.thuoctinhHanghoaModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InformationGroupControl)).EndInit();
            this.InformationGroupControl.ResumeLayout(false);
            this.InformationGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenHanghoaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenThuoctinhTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghichuTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton CancelSimpleButton;
        private DevExpress.XtraEditors.SimpleButton OkSimpleButton;
        private System.Windows.Forms.BindingSource thuoctinhHanghoaModelBindingSource;
        private DevExpress.XtraEditors.GroupControl InformationGroupControl;
        private DevExpress.XtraEditors.CheckEdit activeCheckEdit;
        private DevExpress.XtraEditors.TextEdit codeTextEdit;
        private DevExpress.XtraEditors.DateEdit ngayCapnhatDateEdit;
        private DevExpress.XtraEditors.TextEdit tenHanghoaTextEdit;
        private DevExpress.XtraEditors.TextEdit tenThuoctinhTextEdit;
        private DevExpress.XtraEditors.MemoEdit ghichuTextEdit;
    }
}