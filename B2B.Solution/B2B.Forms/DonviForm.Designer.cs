namespace B2B.Forms
{
    partial class DonviForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonviForm));
            this.DonviActionGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.addDonviSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.editDonviSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.deleteDonviSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveDonviSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.reloadDonviSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.exportDonviSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.donviModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donviModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.donviModelGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDonviId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayCapnhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDonvi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhichu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LeftPanelControl = new DevExpress.XtraEditors.PanelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.activeCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.codeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ngayCapnhatDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.tenDonviTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ghichuTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.RightPanelControl = new DevExpress.XtraEditors.PanelControl();
            activeLabel = new System.Windows.Forms.Label();
            codeLabel = new System.Windows.Forms.Label();
            ghichuLabel = new System.Windows.Forms.Label();
            ngayCapnhatLabel = new System.Windows.Forms.Label();
            tenDonviLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DonviActionGroupControl)).BeginInit();
            this.DonviActionGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donviModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donviModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donviModelGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPanelControl)).BeginInit();
            this.LeftPanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenDonviTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghichuTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightPanelControl)).BeginInit();
            this.RightPanelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // activeLabel
            // 
            activeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            activeLabel.AutoSize = true;
            activeLabel.Location = new System.Drawing.Point(369, 23);
            activeLabel.Name = "activeLabel";
            activeLabel.Size = new System.Drawing.Size(75, 25);
            activeLabel.TabIndex = 23;
            activeLabel.Text = "Active:";
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(34, 23);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(66, 25);
            codeLabel.TabIndex = 27;
            codeLabel.Text = "Code:";
            // 
            // ghichuLabel
            // 
            ghichuLabel.AutoSize = true;
            ghichuLabel.Location = new System.Drawing.Point(34, 207);
            ghichuLabel.Name = "ghichuLabel";
            ghichuLabel.Size = new System.Drawing.Size(91, 25);
            ghichuLabel.TabIndex = 29;
            ghichuLabel.Text = "Ghi chú:";
            // 
            // ngayCapnhatLabel
            // 
            ngayCapnhatLabel.AutoSize = true;
            ngayCapnhatLabel.Location = new System.Drawing.Point(34, 137);
            ngayCapnhatLabel.Name = "ngayCapnhatLabel";
            ngayCapnhatLabel.Size = new System.Drawing.Size(155, 25);
            ngayCapnhatLabel.TabIndex = 30;
            ngayCapnhatLabel.Text = "Ngày cập nhật:";
            // 
            // tenDonviLabel
            // 
            tenDonviLabel.AutoSize = true;
            tenDonviLabel.Location = new System.Drawing.Point(34, 84);
            tenDonviLabel.Name = "tenDonviLabel";
            tenDonviLabel.Size = new System.Drawing.Size(80, 25);
            tenDonviLabel.TabIndex = 32;
            tenDonviLabel.Text = "Đơn vị:";
            // 
            // DonviActionGroupControl
            // 
            this.DonviActionGroupControl.Controls.Add(this.addDonviSimpleButton);
            this.DonviActionGroupControl.Controls.Add(this.editDonviSimpleButton);
            this.DonviActionGroupControl.Controls.Add(this.deleteDonviSimpleButton);
            this.DonviActionGroupControl.Controls.Add(this.saveDonviSimpleButton);
            this.DonviActionGroupControl.Controls.Add(this.reloadDonviSimpleButton);
            this.DonviActionGroupControl.Controls.Add(this.exportDonviSimpleButton);
            this.DonviActionGroupControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DonviActionGroupControl.Location = new System.Drawing.Point(2, 387);
            this.DonviActionGroupControl.Name = "DonviActionGroupControl";
            this.DonviActionGroupControl.Size = new System.Drawing.Size(928, 123);
            this.DonviActionGroupControl.TabIndex = 0;
            this.DonviActionGroupControl.Text = "Thao tác Đơn vị";
            // 
            // addDonviSimpleButton
            // 
            this.addDonviSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addDonviSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("addDonviSimpleButton.Image")));
            this.addDonviSimpleButton.Location = new System.Drawing.Point(316, 47);
            this.addDonviSimpleButton.Name = "addDonviSimpleButton";
            this.addDonviSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.addDonviSimpleButton.TabIndex = 40;
            this.addDonviSimpleButton.Text = "Add";
            this.addDonviSimpleButton.Click += new System.EventHandler(this.addDonviSimpleButton_Click);
            // 
            // editDonviSimpleButton
            // 
            this.editDonviSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.editDonviSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("editDonviSimpleButton.Image")));
            this.editDonviSimpleButton.Location = new System.Drawing.Point(475, 47);
            this.editDonviSimpleButton.Name = "editDonviSimpleButton";
            this.editDonviSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.editDonviSimpleButton.TabIndex = 38;
            this.editDonviSimpleButton.Text = "Edit";
            this.editDonviSimpleButton.Click += new System.EventHandler(this.editDonviSimpleButton_Click);
            // 
            // deleteDonviSimpleButton
            // 
            this.deleteDonviSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deleteDonviSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteDonviSimpleButton.Image")));
            this.deleteDonviSimpleButton.Location = new System.Drawing.Point(18, 47);
            this.deleteDonviSimpleButton.Name = "deleteDonviSimpleButton";
            this.deleteDonviSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.deleteDonviSimpleButton.TabIndex = 41;
            this.deleteDonviSimpleButton.Text = "Delete";
            this.deleteDonviSimpleButton.Click += new System.EventHandler(this.deleteDonviSimpleButton_Click);
            // 
            // saveDonviSimpleButton
            // 
            this.saveDonviSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.saveDonviSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("saveDonviSimpleButton.Image")));
            this.saveDonviSimpleButton.Location = new System.Drawing.Point(626, 47);
            this.saveDonviSimpleButton.Name = "saveDonviSimpleButton";
            this.saveDonviSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.saveDonviSimpleButton.TabIndex = 37;
            this.saveDonviSimpleButton.Text = "Save";
            this.saveDonviSimpleButton.Click += new System.EventHandler(this.saveDonviSimpleButton_Click);
            // 
            // reloadDonviSimpleButton
            // 
            this.reloadDonviSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.reloadDonviSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("reloadDonviSimpleButton.Image")));
            this.reloadDonviSimpleButton.Location = new System.Drawing.Point(777, 47);
            this.reloadDonviSimpleButton.Name = "reloadDonviSimpleButton";
            this.reloadDonviSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.reloadDonviSimpleButton.TabIndex = 36;
            this.reloadDonviSimpleButton.Text = "Reload";
            this.reloadDonviSimpleButton.Click += new System.EventHandler(this.reloadDonviSimpleButton_Click);
            // 
            // exportDonviSimpleButton
            // 
            this.exportDonviSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.exportDonviSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("exportDonviSimpleButton.Image")));
            this.exportDonviSimpleButton.Location = new System.Drawing.Point(167, 47);
            this.exportDonviSimpleButton.Name = "exportDonviSimpleButton";
            this.exportDonviSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.exportDonviSimpleButton.TabIndex = 39;
            this.exportDonviSimpleButton.Text = "Export";
            this.exportDonviSimpleButton.Click += new System.EventHandler(this.exportDonviSimpleButton_Click);
            // 
            // donviModelBindingSource
            // 
            this.donviModelBindingSource.DataSource = typeof(B2B.Model.DonviModel);
            // 
            // donviModelGridControl
            // 
            this.donviModelGridControl.DataSource = this.donviModelBindingSource;
            this.donviModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.donviModelGridControl.Location = new System.Drawing.Point(2, 2);
            this.donviModelGridControl.MainView = this.donviModelGridView;
            this.donviModelGridControl.Name = "donviModelGridControl";
            this.donviModelGridControl.Size = new System.Drawing.Size(928, 385);
            this.donviModelGridControl.TabIndex = 2;
            this.donviModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.donviModelGridView});
            // 
            // donviModelGridView
            // 
            this.donviModelGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDonviId,
            this.colStep,
            this.colNgayCapnhat,
            this.colActive,
            this.colVersion,
            this.colCode,
            this.colTenDonvi,
            this.colGhichu,
            this.colState,
            this.NoGridColumn});
            this.donviModelGridView.GridControl = this.donviModelGridControl;
            this.donviModelGridView.Name = "donviModelGridView";
            this.donviModelGridView.OptionsBehavior.Editable = false;
            this.donviModelGridView.OptionsFind.AlwaysVisible = true;
            this.donviModelGridView.OptionsView.ShowAutoFilterRow = true;
            this.donviModelGridView.OptionsView.ShowFooter = true;
            this.donviModelGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.donviModelGridView_CustomColumnDisplayText);
            // 
            // colDonviId
            // 
            this.colDonviId.FieldName = "DonviId";
            this.colDonviId.Name = "colDonviId";
            // 
            // colStep
            // 
            this.colStep.FieldName = "Step";
            this.colStep.Name = "colStep";
            // 
            // colNgayCapnhat
            // 
            this.colNgayCapnhat.Caption = "Ngày cập nhật";
            this.colNgayCapnhat.FieldName = "NgayCapnhat";
            this.colNgayCapnhat.Name = "colNgayCapnhat";
            this.colNgayCapnhat.Visible = true;
            this.colNgayCapnhat.VisibleIndex = 4;
            this.colNgayCapnhat.Width = 180;
            // 
            // colActive
            // 
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 3;
            this.colActive.Width = 103;
            // 
            // colVersion
            // 
            this.colVersion.FieldName = "Version";
            this.colVersion.Name = "colVersion";
            // 
            // colCode
            // 
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 1;
            this.colCode.Width = 245;
            // 
            // colTenDonvi
            // 
            this.colTenDonvi.Caption = "Tên Đơn vị";
            this.colTenDonvi.FieldName = "TenDonvi";
            this.colTenDonvi.Name = "colTenDonvi";
            this.colTenDonvi.Visible = true;
            this.colTenDonvi.VisibleIndex = 2;
            this.colTenDonvi.Width = 463;
            // 
            // colGhichu
            // 
            this.colGhichu.Caption = "Ghi chú";
            this.colGhichu.FieldName = "Ghichu";
            this.colGhichu.Name = "colGhichu";
            this.colGhichu.Width = 145;
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.OptionsColumn.ReadOnly = true;
            this.colState.Visible = true;
            this.colState.VisibleIndex = 5;
            this.colState.Width = 149;
            // 
            // NoGridColumn
            // 
            this.NoGridColumn.Caption = "STT";
            this.NoGridColumn.Name = "NoGridColumn";
            this.NoGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.NoGridColumn.Visible = true;
            this.NoGridColumn.VisibleIndex = 0;
            this.NoGridColumn.Width = 122;
            // 
            // LeftPanelControl
            // 
            this.LeftPanelControl.Controls.Add(this.xtraTabControl1);
            this.LeftPanelControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanelControl.Location = new System.Drawing.Point(0, 0);
            this.LeftPanelControl.Name = "LeftPanelControl";
            this.LeftPanelControl.Size = new System.Drawing.Size(528, 512);
            this.LeftPanelControl.TabIndex = 3;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(2, 2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(524, 508);
            this.xtraTabControl1.TabIndex = 23;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(activeLabel);
            this.xtraTabPage1.Controls.Add(this.activeCheckEdit);
            this.xtraTabPage1.Controls.Add(codeLabel);
            this.xtraTabPage1.Controls.Add(this.codeTextEdit);
            this.xtraTabPage1.Controls.Add(ghichuLabel);
            this.xtraTabPage1.Controls.Add(ngayCapnhatLabel);
            this.xtraTabPage1.Controls.Add(this.ngayCapnhatDateEdit);
            this.xtraTabPage1.Controls.Add(tenDonviLabel);
            this.xtraTabPage1.Controls.Add(this.tenDonviTextEdit);
            this.xtraTabPage1.Controls.Add(this.ghichuTextEdit);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(518, 468);
            this.xtraTabPage1.Text = "Thông tin";
            // 
            // activeCheckEdit
            // 
            this.activeCheckEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.activeCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.donviModelBindingSource, "Active", true));
            this.activeCheckEdit.EditValue = true;
            this.activeCheckEdit.Location = new System.Drawing.Point(450, 21);
            this.activeCheckEdit.Name = "activeCheckEdit";
            this.activeCheckEdit.Properties.Caption = "";
            this.activeCheckEdit.Properties.ReadOnly = true;
            this.activeCheckEdit.Size = new System.Drawing.Size(29, 19);
            this.activeCheckEdit.TabIndex = 26;
            // 
            // codeTextEdit
            // 
            this.codeTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.donviModelBindingSource, "Code", true));
            this.codeTextEdit.EditValue = "";
            this.codeTextEdit.Location = new System.Drawing.Point(200, 20);
            this.codeTextEdit.Name = "codeTextEdit";
            this.codeTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.codeTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.codeTextEdit.Properties.ReadOnly = true;
            this.codeTextEdit.Size = new System.Drawing.Size(150, 32);
            this.codeTextEdit.TabIndex = 24;
            // 
            // ngayCapnhatDateEdit
            // 
            this.ngayCapnhatDateEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ngayCapnhatDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.donviModelBindingSource, "NgayCapnhat", true));
            this.ngayCapnhatDateEdit.EditValue = null;
            this.ngayCapnhatDateEdit.Location = new System.Drawing.Point(204, 134);
            this.ngayCapnhatDateEdit.Name = "ngayCapnhatDateEdit";
            this.ngayCapnhatDateEdit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.ngayCapnhatDateEdit.Properties.Appearance.Options.UseBackColor = true;
            this.ngayCapnhatDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayCapnhatDateEdit.Properties.ReadOnly = true;
            this.ngayCapnhatDateEdit.Size = new System.Drawing.Size(277, 32);
            this.ngayCapnhatDateEdit.TabIndex = 31;
            // 
            // tenDonviTextEdit
            // 
            this.tenDonviTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tenDonviTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.donviModelBindingSource, "TenDonvi", true));
            this.tenDonviTextEdit.Location = new System.Drawing.Point(204, 77);
            this.tenDonviTextEdit.Name = "tenDonviTextEdit";
            this.tenDonviTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.tenDonviTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.tenDonviTextEdit.Properties.ReadOnly = true;
            this.tenDonviTextEdit.Size = new System.Drawing.Size(277, 32);
            this.tenDonviTextEdit.TabIndex = 25;
            // 
            // ghichuTextEdit
            // 
            this.ghichuTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ghichuTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.donviModelBindingSource, "Ghichu", true));
            this.ghichuTextEdit.Location = new System.Drawing.Point(204, 205);
            this.ghichuTextEdit.Name = "ghichuTextEdit";
            this.ghichuTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.ghichuTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.ghichuTextEdit.Properties.ReadOnly = true;
            this.ghichuTextEdit.Size = new System.Drawing.Size(275, 244);
            this.ghichuTextEdit.TabIndex = 28;
            this.ghichuTextEdit.UseOptimizedRendering = true;
            // 
            // RightPanelControl
            // 
            this.RightPanelControl.Controls.Add(this.donviModelGridControl);
            this.RightPanelControl.Controls.Add(this.DonviActionGroupControl);
            this.RightPanelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightPanelControl.Location = new System.Drawing.Point(528, 0);
            this.RightPanelControl.Name = "RightPanelControl";
            this.RightPanelControl.Size = new System.Drawing.Size(932, 512);
            this.RightPanelControl.TabIndex = 4;
            // 
            // DonviForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 516);
            this.Controls.Add(this.RightPanelControl);
            this.Controls.Add(this.LeftPanelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1490, 587);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1490, 587);
            this.Name = "DonviForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn vị";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DonviActionGroupControl)).EndInit();
            this.DonviActionGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.donviModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donviModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donviModelGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPanelControl)).EndInit();
            this.LeftPanelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenDonviTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghichuTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightPanelControl)).EndInit();
            this.RightPanelControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl DonviActionGroupControl;
        private DevExpress.XtraEditors.SimpleButton addDonviSimpleButton;
        private DevExpress.XtraEditors.SimpleButton editDonviSimpleButton;
        private DevExpress.XtraEditors.SimpleButton deleteDonviSimpleButton;
        private DevExpress.XtraEditors.SimpleButton saveDonviSimpleButton;
        private DevExpress.XtraEditors.SimpleButton reloadDonviSimpleButton;
        private DevExpress.XtraEditors.SimpleButton exportDonviSimpleButton;
        private System.Windows.Forms.BindingSource donviModelBindingSource;
        private DevExpress.XtraGrid.GridControl donviModelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView donviModelGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colDonviId;
        private DevExpress.XtraGrid.Columns.GridColumn colStep;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayCapnhat;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDonvi;
        private DevExpress.XtraGrid.Columns.GridColumn colGhichu;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraGrid.Columns.GridColumn NoGridColumn;
        private DevExpress.XtraEditors.PanelControl LeftPanelControl;
        private DevExpress.XtraEditors.PanelControl RightPanelControl;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.CheckEdit activeCheckEdit;
        private DevExpress.XtraEditors.TextEdit codeTextEdit;
        private DevExpress.XtraEditors.DateEdit ngayCapnhatDateEdit;
        private DevExpress.XtraEditors.TextEdit tenDonviTextEdit;
        private DevExpress.XtraEditors.MemoEdit ghichuTextEdit;
    }
}