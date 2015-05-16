namespace B2B.Forms
{
    partial class HanghoaDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HanghoaDetailForm));
            this.codeLabel = new System.Windows.Forms.Label();
            this.barcodeLabel = new System.Windows.Forms.Label();
            this.tenHanghoaLabel = new System.Windows.Forms.Label();
            this.donviIdLabel = new System.Windows.Forms.Label();
            this.giagocLabel = new System.Windows.Forms.Label();
            this.nhomHanghoaIdLabel = new System.Windows.Forms.Label();
            this.ghichuLabel = new System.Windows.Forms.Label();
            this.activeLabel = new System.Windows.Forms.Label();
            this.ngayCapnhatLabel = new System.Windows.Forms.Label();
            this.InformationGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.AnhMyPictureEdit = new B2B.Forms.MyPictureEdit();
            this.ngayCapnhatDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.hanghoaModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linkHinhanhTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.activeCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.tenHanghoaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.barcodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.codeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ghichuTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.giagocSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.donviIdTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.donviModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nhomHanghoaIdTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.nhomHanghoaModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CancelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.OKSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.InformationGroupControl)).BeginInit();
            this.InformationGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnhMyPictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hanghoaModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkHinhanhTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenHanghoaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghichuTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giagocSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donviIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donviModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomHanghoaIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomHanghoaModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(17, 44);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(36, 13);
            this.codeLabel.TabIndex = 0;
            this.codeLabel.Text = "Code:";
            // 
            // barcodeLabel
            // 
            this.barcodeLabel.AutoSize = true;
            this.barcodeLabel.Location = new System.Drawing.Point(228, 80);
            this.barcodeLabel.Name = "barcodeLabel";
            this.barcodeLabel.Size = new System.Drawing.Size(50, 13);
            this.barcodeLabel.TabIndex = 2;
            this.barcodeLabel.Text = "Barcode:";
            // 
            // tenHanghoaLabel
            // 
            this.tenHanghoaLabel.AutoSize = true;
            this.tenHanghoaLabel.Location = new System.Drawing.Point(17, 78);
            this.tenHanghoaLabel.Name = "tenHanghoaLabel";
            this.tenHanghoaLabel.Size = new System.Drawing.Size(77, 13);
            this.tenHanghoaLabel.TabIndex = 4;
            this.tenHanghoaLabel.Text = "Tên hàng hóa:";
            // 
            // donviIdLabel
            // 
            this.donviIdLabel.AutoSize = true;
            this.donviIdLabel.Location = new System.Drawing.Point(17, 112);
            this.donviIdLabel.Name = "donviIdLabel";
            this.donviIdLabel.Size = new System.Drawing.Size(42, 13);
            this.donviIdLabel.TabIndex = 6;
            this.donviIdLabel.Text = "Đơn vị:";
            // 
            // giagocLabel
            // 
            this.giagocLabel.AutoSize = true;
            this.giagocLabel.Location = new System.Drawing.Point(228, 152);
            this.giagocLabel.Name = "giagocLabel";
            this.giagocLabel.Size = new System.Drawing.Size(46, 13);
            this.giagocLabel.TabIndex = 8;
            this.giagocLabel.Text = "Giá gốc:";
            // 
            // nhomHanghoaIdLabel
            // 
            this.nhomHanghoaIdLabel.AutoSize = true;
            this.nhomHanghoaIdLabel.Location = new System.Drawing.Point(17, 146);
            this.nhomHanghoaIdLabel.Name = "nhomHanghoaIdLabel";
            this.nhomHanghoaIdLabel.Size = new System.Drawing.Size(86, 13);
            this.nhomHanghoaIdLabel.TabIndex = 10;
            this.nhomHanghoaIdLabel.Text = "Nhóm hàng hóa:";
            // 
            // ghichuLabel
            // 
            this.ghichuLabel.AutoSize = true;
            this.ghichuLabel.Location = new System.Drawing.Point(17, 180);
            this.ghichuLabel.Name = "ghichuLabel";
            this.ghichuLabel.Size = new System.Drawing.Size(43, 13);
            this.ghichuLabel.TabIndex = 12;
            this.ghichuLabel.Text = "Ghichu:";
            // 
            // activeLabel
            // 
            this.activeLabel.AutoSize = true;
            this.activeLabel.Location = new System.Drawing.Point(228, 44);
            this.activeLabel.Name = "activeLabel";
            this.activeLabel.Size = new System.Drawing.Size(41, 13);
            this.activeLabel.TabIndex = 14;
            this.activeLabel.Text = "Active:";
            // 
            // ngayCapnhatLabel
            // 
            this.ngayCapnhatLabel.AutoSize = true;
            this.ngayCapnhatLabel.Location = new System.Drawing.Point(228, 116);
            this.ngayCapnhatLabel.Name = "ngayCapnhatLabel";
            this.ngayCapnhatLabel.Size = new System.Drawing.Size(81, 13);
            this.ngayCapnhatLabel.TabIndex = 18;
            this.ngayCapnhatLabel.Text = "Ngày cập nhật:";
            // 
            // InformationGroupControl
            // 
            this.InformationGroupControl.Controls.Add(this.AnhMyPictureEdit);
            this.InformationGroupControl.Controls.Add(this.ngayCapnhatLabel);
            this.InformationGroupControl.Controls.Add(this.ngayCapnhatDateEdit);
            this.InformationGroupControl.Controls.Add(this.linkHinhanhTextEdit);
            this.InformationGroupControl.Controls.Add(this.activeLabel);
            this.InformationGroupControl.Controls.Add(this.activeCheckEdit);
            this.InformationGroupControl.Controls.Add(this.ghichuLabel);
            this.InformationGroupControl.Controls.Add(this.nhomHanghoaIdLabel);
            this.InformationGroupControl.Controls.Add(this.giagocLabel);
            this.InformationGroupControl.Controls.Add(this.donviIdLabel);
            this.InformationGroupControl.Controls.Add(this.tenHanghoaLabel);
            this.InformationGroupControl.Controls.Add(this.tenHanghoaTextEdit);
            this.InformationGroupControl.Controls.Add(this.barcodeLabel);
            this.InformationGroupControl.Controls.Add(this.barcodeTextEdit);
            this.InformationGroupControl.Controls.Add(this.codeLabel);
            this.InformationGroupControl.Controls.Add(this.codeTextEdit);
            this.InformationGroupControl.Controls.Add(this.ghichuTextEdit);
            this.InformationGroupControl.Controls.Add(this.giagocSpinEdit);
            this.InformationGroupControl.Controls.Add(this.donviIdTextEdit);
            this.InformationGroupControl.Controls.Add(this.nhomHanghoaIdTextEdit);
            this.InformationGroupControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.InformationGroupControl.Location = new System.Drawing.Point(0, 0);
            this.InformationGroupControl.Margin = new System.Windows.Forms.Padding(2);
            this.InformationGroupControl.Name = "InformationGroupControl";
            this.InformationGroupControl.Size = new System.Drawing.Size(596, 320);
            this.InformationGroupControl.TabIndex = 21;
            this.InformationGroupControl.Text = "Thông tin";
            // 
            // AnhMyPictureEdit
            // 
            this.AnhMyPictureEdit.FileName = null;
            this.AnhMyPictureEdit.Location = new System.Drawing.Point(437, 33);
            this.AnhMyPictureEdit.Margin = new System.Windows.Forms.Padding(2);
            this.AnhMyPictureEdit.Name = "AnhMyPictureEdit";
            this.AnhMyPictureEdit.Properties.InitialImage = null;
            this.AnhMyPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.AnhMyPictureEdit.Size = new System.Drawing.Size(137, 133);
            this.AnhMyPictureEdit.TabIndex = 43;
            this.AnhMyPictureEdit.EditValueChanged += new System.EventHandler(this.AnhMyPictureEdit_EditValueChanged);
            // 
            // ngayCapnhatDateEdit
            // 
            this.ngayCapnhatDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hanghoaModelBindingSource, "NgayCapnhat", true));
            this.ngayCapnhatDateEdit.EditValue = null;
            this.ngayCapnhatDateEdit.Location = new System.Drawing.Point(314, 110);
            this.ngayCapnhatDateEdit.Name = "ngayCapnhatDateEdit";
            this.ngayCapnhatDateEdit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.ngayCapnhatDateEdit.Properties.Appearance.Options.UseBackColor = true;
            this.ngayCapnhatDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayCapnhatDateEdit.Properties.ReadOnly = true;
            this.ngayCapnhatDateEdit.Size = new System.Drawing.Size(100, 20);
            this.ngayCapnhatDateEdit.TabIndex = 5;
            // 
            // hanghoaModelBindingSource
            // 
            this.hanghoaModelBindingSource.DataSource = typeof(B2B.Model.HanghoaModel);
            this.hanghoaModelBindingSource.CurrentItemChanged += new System.EventHandler(this.hanghoaModelBindingSource_CurrentItemChanged);
            // 
            // linkHinhanhTextEdit
            // 
            this.linkHinhanhTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hanghoaModelBindingSource, "LinkHinhanh", true));
            this.linkHinhanhTextEdit.Location = new System.Drawing.Point(20, 207);
            this.linkHinhanhTextEdit.Name = "linkHinhanhTextEdit";
            this.linkHinhanhTextEdit.Size = new System.Drawing.Size(33, 20);
            this.linkHinhanhTextEdit.TabIndex = 17;
            this.linkHinhanhTextEdit.Visible = false;
            // 
            // activeCheckEdit
            // 
            this.activeCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hanghoaModelBindingSource, "Active", true));
            this.activeCheckEdit.Location = new System.Drawing.Point(312, 41);
            this.activeCheckEdit.Name = "activeCheckEdit";
            this.activeCheckEdit.Properties.Caption = "";
            this.activeCheckEdit.Size = new System.Drawing.Size(75, 19);
            this.activeCheckEdit.TabIndex = 1;
            // 
            // tenHanghoaTextEdit
            // 
            this.tenHanghoaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hanghoaModelBindingSource, "TenHanghoa", true));
            this.tenHanghoaTextEdit.Location = new System.Drawing.Point(109, 76);
            this.tenHanghoaTextEdit.Name = "tenHanghoaTextEdit";
            this.tenHanghoaTextEdit.Size = new System.Drawing.Size(100, 20);
            this.tenHanghoaTextEdit.TabIndex = 2;
            // 
            // barcodeTextEdit
            // 
            this.barcodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hanghoaModelBindingSource, "Barcode", true));
            this.barcodeTextEdit.Location = new System.Drawing.Point(314, 75);
            this.barcodeTextEdit.Name = "barcodeTextEdit";
            this.barcodeTextEdit.Size = new System.Drawing.Size(100, 20);
            this.barcodeTextEdit.TabIndex = 3;
            // 
            // codeTextEdit
            // 
            this.codeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hanghoaModelBindingSource, "Code", true));
            this.codeTextEdit.Location = new System.Drawing.Point(109, 41);
            this.codeTextEdit.Name = "codeTextEdit";
            this.codeTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.codeTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.codeTextEdit.Properties.ReadOnly = true;
            this.codeTextEdit.Size = new System.Drawing.Size(100, 20);
            this.codeTextEdit.TabIndex = 0;
            // 
            // ghichuTextEdit
            // 
            this.ghichuTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hanghoaModelBindingSource, "Ghichu", true));
            this.ghichuTextEdit.Location = new System.Drawing.Point(109, 180);
            this.ghichuTextEdit.Name = "ghichuTextEdit";
            this.ghichuTextEdit.Size = new System.Drawing.Size(465, 123);
            this.ghichuTextEdit.TabIndex = 8;
            this.ghichuTextEdit.UseOptimizedRendering = true;
            // 
            // giagocSpinEdit
            // 
            this.giagocSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hanghoaModelBindingSource, "Giagoc", true));
            this.giagocSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.giagocSpinEdit.Location = new System.Drawing.Point(314, 145);
            this.giagocSpinEdit.Name = "giagocSpinEdit";
            this.giagocSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.giagocSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.giagocSpinEdit.TabIndex = 7;
            // 
            // donviIdTextEdit
            // 
            this.donviIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hanghoaModelBindingSource, "DonviId", true));
            this.donviIdTextEdit.Location = new System.Drawing.Point(109, 111);
            this.donviIdTextEdit.Name = "donviIdTextEdit";
            this.donviIdTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.donviIdTextEdit.Properties.DataSource = this.donviModelBindingSource;
            this.donviIdTextEdit.Properties.DisplayMember = "TenDonvi";
            this.donviIdTextEdit.Properties.NullText = "";
            this.donviIdTextEdit.Properties.ValueMember = "DonviId";
            this.donviIdTextEdit.Properties.View = this.gridLookUpEdit1View;
            this.donviIdTextEdit.Size = new System.Drawing.Size(100, 20);
            this.donviIdTextEdit.TabIndex = 4;
            this.donviIdTextEdit.EditValueChanged += new System.EventHandler(this.donviIdTextEdit_EditValueChanged);
            // 
            // donviModelBindingSource
            // 
            this.donviModelBindingSource.DataSource = typeof(B2B.Model.DonviModel);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Tên đơn vị";
            this.gridColumn7.FieldName = "TenDonvi";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            // 
            // nhomHanghoaIdTextEdit
            // 
            this.nhomHanghoaIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hanghoaModelBindingSource, "NhomHanghoaId", true));
            this.nhomHanghoaIdTextEdit.Location = new System.Drawing.Point(109, 146);
            this.nhomHanghoaIdTextEdit.Name = "nhomHanghoaIdTextEdit";
            this.nhomHanghoaIdTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nhomHanghoaIdTextEdit.Properties.DataSource = this.nhomHanghoaModelBindingSource;
            this.nhomHanghoaIdTextEdit.Properties.DisplayMember = "TenNhomHanghoa";
            this.nhomHanghoaIdTextEdit.Properties.NullText = "";
            this.nhomHanghoaIdTextEdit.Properties.ValueMember = "NhomHanghoaId";
            this.nhomHanghoaIdTextEdit.Properties.View = this.gridView2;
            this.nhomHanghoaIdTextEdit.Size = new System.Drawing.Size(100, 20);
            this.nhomHanghoaIdTextEdit.TabIndex = 6;
            this.nhomHanghoaIdTextEdit.EditValueChanged += new System.EventHandler(this.nhomHanghoaIdTextEdit_EditValueChanged);
            // 
            // nhomHanghoaModelBindingSource
            // 
            this.nhomHanghoaModelBindingSource.DataSource = typeof(B2B.Model.NhomHanghoaModel);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn8});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Tên nhóm hàng hóa";
            this.gridColumn8.FieldName = "TenNhomHanghoa";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 0;
            // 
            // CancelSimpleButton
            // 
            this.CancelSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelSimpleButton.Image")));
            this.CancelSimpleButton.Location = new System.Drawing.Point(503, 346);
            this.CancelSimpleButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelSimpleButton.Name = "CancelSimpleButton";
            this.CancelSimpleButton.Size = new System.Drawing.Size(70, 27);
            this.CancelSimpleButton.TabIndex = 23;
            this.CancelSimpleButton.Text = "Cancel";
            this.CancelSimpleButton.Click += new System.EventHandler(this.CancelSimpleButton_Click_1);
            // 
            // OKSimpleButton
            // 
            this.OKSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("OKSimpleButton.Image")));
            this.OKSimpleButton.Location = new System.Drawing.Point(421, 346);
            this.OKSimpleButton.Margin = new System.Windows.Forms.Padding(2);
            this.OKSimpleButton.Name = "OKSimpleButton";
            this.OKSimpleButton.Size = new System.Drawing.Size(70, 27);
            this.OKSimpleButton.TabIndex = 22;
            this.OKSimpleButton.Text = "OK";
            this.OKSimpleButton.Click += new System.EventHandler(this.OKSimpleButton_Click_1);
            // 
            // HanghoaDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 398);
            this.Controls.Add(this.CancelSimpleButton);
            this.Controls.Add(this.OKSimpleButton);
            this.Controls.Add(this.InformationGroupControl);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(612, 437);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(612, 437);
            this.Name = "HanghoaDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin chi tiết Hàng hóa";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HanghoaDetailForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.InformationGroupControl)).EndInit();
            this.InformationGroupControl.ResumeLayout(false);
            this.InformationGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnhMyPictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hanghoaModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkHinhanhTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenHanghoaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghichuTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giagocSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donviIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donviModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomHanghoaIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomHanghoaModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl InformationGroupControl;
        private DevExpress.XtraEditors.DateEdit ngayCapnhatDateEdit;
        private System.Windows.Forms.BindingSource hanghoaModelBindingSource;
        private DevExpress.XtraEditors.TextEdit linkHinhanhTextEdit;
        private DevExpress.XtraEditors.CheckEdit activeCheckEdit;
        private DevExpress.XtraEditors.TextEdit barcodeTextEdit;
        private DevExpress.XtraEditors.TextEdit codeTextEdit;
        private MyPictureEdit AnhMyPictureEdit;
        private DevExpress.XtraEditors.MemoEdit ghichuTextEdit;
        private System.Windows.Forms.BindingSource donviModelBindingSource;
        private System.Windows.Forms.BindingSource nhomHanghoaModelBindingSource;
        private DevExpress.XtraEditors.TextEdit tenHanghoaTextEdit;
        private DevExpress.XtraEditors.SpinEdit giagocSpinEdit;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.Label barcodeLabel;
        private System.Windows.Forms.Label tenHanghoaLabel;
        private System.Windows.Forms.Label donviIdLabel;
        private System.Windows.Forms.Label giagocLabel;
        private System.Windows.Forms.Label nhomHanghoaIdLabel;
        private System.Windows.Forms.Label ghichuLabel;
        private System.Windows.Forms.Label activeLabel;
        private System.Windows.Forms.Label ngayCapnhatLabel;
        private DevExpress.XtraEditors.SimpleButton CancelSimpleButton;
        private DevExpress.XtraEditors.SimpleButton OKSimpleButton;
        private DevExpress.XtraEditors.GridLookUpEdit donviIdTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.GridLookUpEdit nhomHanghoaIdTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
    }
}