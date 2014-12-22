namespace B2B.Forms
{
    partial class NhomHanghoaDetailForm
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
            System.Windows.Forms.Label ngayCapnhatLabel;
            System.Windows.Forms.Label tenNhomHanghoaLabel;
            System.Windows.Forms.Label activeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhomHanghoaDetailForm));
            this.nhomHanghoaModelBindingSource = new System.Windows.Forms.BindingSource();
            this.InformationGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.activeCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.tenNhomHanghoaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ngayCapnhatDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.codeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ghichuTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.CancelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.OKSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            ghichuLabel = new System.Windows.Forms.Label();
            codeLabel = new System.Windows.Forms.Label();
            ngayCapnhatLabel = new System.Windows.Forms.Label();
            tenNhomHanghoaLabel = new System.Windows.Forms.Label();
            activeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nhomHanghoaModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InformationGroupControl)).BeginInit();
            this.InformationGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenNhomHanghoaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghichuTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ghichuLabel
            // 
            ghichuLabel.AutoSize = true;
            ghichuLabel.Location = new System.Drawing.Point(23, 106);
            ghichuLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            ghichuLabel.Name = "ghichuLabel";
            ghichuLabel.Size = new System.Drawing.Size(46, 13);
            ghichuLabel.TabIndex = 10;
            ghichuLabel.Text = "Ghi chú:";
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
            // ngayCapnhatLabel
            // 
            ngayCapnhatLabel.AutoSize = true;
            ngayCapnhatLabel.Location = new System.Drawing.Point(350, 38);
            ngayCapnhatLabel.Name = "ngayCapnhatLabel";
            ngayCapnhatLabel.Size = new System.Drawing.Size(81, 13);
            ngayCapnhatLabel.TabIndex = 17;
            ngayCapnhatLabel.Text = "Ngày cập nhật:";
            // 
            // tenNhomHanghoaLabel
            // 
            tenNhomHanghoaLabel.AutoSize = true;
            tenNhomHanghoaLabel.Location = new System.Drawing.Point(23, 71);
            tenNhomHanghoaLabel.Name = "tenNhomHanghoaLabel";
            tenNhomHanghoaLabel.Size = new System.Drawing.Size(86, 13);
            tenNhomHanghoaLabel.TabIndex = 18;
            tenNhomHanghoaLabel.Text = "Nhóm hàng hóa:";
            // 
            // activeLabel
            // 
            activeLabel.AutoSize = true;
            activeLabel.Location = new System.Drawing.Point(231, 38);
            activeLabel.Name = "activeLabel";
            activeLabel.Size = new System.Drawing.Size(41, 13);
            activeLabel.TabIndex = 19;
            activeLabel.Text = "Active:";
            // 
            // nhomHanghoaModelBindingSource
            // 
            this.nhomHanghoaModelBindingSource.DataSource = typeof(B2B.Model.NhomHanghoaModel);
            // 
            // InformationGroupControl
            // 
            this.InformationGroupControl.Controls.Add(activeLabel);
            this.InformationGroupControl.Controls.Add(this.activeCheckEdit);
            this.InformationGroupControl.Controls.Add(tenNhomHanghoaLabel);
            this.InformationGroupControl.Controls.Add(this.tenNhomHanghoaTextEdit);
            this.InformationGroupControl.Controls.Add(ngayCapnhatLabel);
            this.InformationGroupControl.Controls.Add(this.ngayCapnhatDateEdit);
            this.InformationGroupControl.Controls.Add(codeLabel);
            this.InformationGroupControl.Controls.Add(this.codeTextEdit);
            this.InformationGroupControl.Controls.Add(ghichuLabel);
            this.InformationGroupControl.Controls.Add(this.ghichuTextEdit);
            this.InformationGroupControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.InformationGroupControl.Location = new System.Drawing.Point(0, 0);
            this.InformationGroupControl.Margin = new System.Windows.Forms.Padding(2);
            this.InformationGroupControl.Name = "InformationGroupControl";
            this.InformationGroupControl.Size = new System.Drawing.Size(620, 359);
            this.InformationGroupControl.TabIndex = 2;
            this.InformationGroupControl.Text = "Thông tin";
            // 
            // activeCheckEdit
            // 
            this.activeCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhomHanghoaModelBindingSource, "Active", true));
            this.activeCheckEdit.EditValue = true;
            this.activeCheckEdit.Location = new System.Drawing.Point(278, 35);
            this.activeCheckEdit.Name = "activeCheckEdit";
            this.activeCheckEdit.Properties.Caption = "";
            this.activeCheckEdit.Size = new System.Drawing.Size(20, 19);
            this.activeCheckEdit.TabIndex = 1;
            // 
            // tenNhomHanghoaTextEdit
            // 
            this.tenNhomHanghoaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhomHanghoaModelBindingSource, "TenNhomHanghoa", true));
            this.tenNhomHanghoaTextEdit.Location = new System.Drawing.Point(125, 69);
            this.tenNhomHanghoaTextEdit.Name = "tenNhomHanghoaTextEdit";
            this.tenNhomHanghoaTextEdit.Size = new System.Drawing.Size(173, 20);
            this.tenNhomHanghoaTextEdit.TabIndex = 2;
            // 
            // ngayCapnhatDateEdit
            // 
            this.ngayCapnhatDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhomHanghoaModelBindingSource, "NgayCapnhat", true));
            this.ngayCapnhatDateEdit.EditValue = null;
            this.ngayCapnhatDateEdit.Enabled = false;
            this.ngayCapnhatDateEdit.Location = new System.Drawing.Point(437, 35);
            this.ngayCapnhatDateEdit.Name = "ngayCapnhatDateEdit";
            this.ngayCapnhatDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayCapnhatDateEdit.Size = new System.Drawing.Size(157, 20);
            this.ngayCapnhatDateEdit.TabIndex = 18;
            // 
            // codeTextEdit
            // 
            this.codeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhomHanghoaModelBindingSource, "Code", true));
            this.codeTextEdit.Location = new System.Drawing.Point(125, 35);
            this.codeTextEdit.Name = "codeTextEdit";
            this.codeTextEdit.Size = new System.Drawing.Size(100, 20);
            this.codeTextEdit.TabIndex = 0;
            // 
            // ghichuTextEdit
            // 
            this.ghichuTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhomHanghoaModelBindingSource, "Ghichu", true));
            this.ghichuTextEdit.Location = new System.Drawing.Point(125, 103);
            this.ghichuTextEdit.Margin = new System.Windows.Forms.Padding(2);
            this.ghichuTextEdit.Name = "ghichuTextEdit";
            this.ghichuTextEdit.Size = new System.Drawing.Size(469, 236);
            this.ghichuTextEdit.TabIndex = 3;
            this.ghichuTextEdit.UseOptimizedRendering = true;
            // 
            // CancelSimpleButton
            // 
            this.CancelSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelSimpleButton.Image")));
            this.CancelSimpleButton.Location = new System.Drawing.Point(524, 409);
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
            this.OKSimpleButton.Location = new System.Drawing.Point(445, 409);
            this.OKSimpleButton.Margin = new System.Windows.Forms.Padding(2);
            this.OKSimpleButton.Name = "OKSimpleButton";
            this.OKSimpleButton.Size = new System.Drawing.Size(70, 27);
            this.OKSimpleButton.TabIndex = 4;
            this.OKSimpleButton.Text = "OK";
            this.OKSimpleButton.Click += new System.EventHandler(this.OKSimpleButton_Click);
            // 
            // NhomHanghoaDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 447);
            this.Controls.Add(this.CancelSimpleButton);
            this.Controls.Add(this.OKSimpleButton);
            this.Controls.Add(this.InformationGroupControl);
            this.Name = "NhomHanghoaDetailForm";
            this.Text = "Thông tin chi tiết Nhóm hàng hóa";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NhomHanghoaDetialForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.nhomHanghoaModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InformationGroupControl)).EndInit();
            this.InformationGroupControl.ResumeLayout(false);
            this.InformationGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenNhomHanghoaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghichuTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl InformationGroupControl;
        private DevExpress.XtraEditors.SimpleButton CancelSimpleButton;
        private DevExpress.XtraEditors.SimpleButton OKSimpleButton;
        private DevExpress.XtraEditors.TextEdit tenNhomHanghoaTextEdit;
        private System.Windows.Forms.BindingSource nhomHanghoaModelBindingSource;
        private DevExpress.XtraEditors.DateEdit ngayCapnhatDateEdit;
        private DevExpress.XtraEditors.TextEdit codeTextEdit;
        private DevExpress.XtraEditors.MemoEdit ghichuTextEdit;
        private DevExpress.XtraEditors.CheckEdit activeCheckEdit;
    }
}