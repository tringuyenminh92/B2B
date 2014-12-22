namespace B2B.Forms
{
    partial class NhomHanghoaForm
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
            System.Windows.Forms.Label tenNhomHanghoaLabel;
            System.Windows.Forms.Label ngayCapnhatLabel;
            System.Windows.Forms.Label codeLabel;
            System.Windows.Forms.Label ghichuLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhomHanghoaForm));
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.nhomHangHoaModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.nhomHanghoaModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhomHanghoaModelGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNhomHanghoaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayCapnhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNhomHanghoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhichu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.addNhomHanghoaSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.deleteNhomHanghoaSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.editNhomHanghoaSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.exportNhomHanghoaSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.reloadNhomHanghoaSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveNhomHanghoaSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.InformationGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.ThongtinXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.activeCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.tenNhomHanghoaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ngayCapnhatDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.codeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ghichuTextEdit = new DevExpress.XtraEditors.MemoEdit();
            activeLabel = new System.Windows.Forms.Label();
            tenNhomHanghoaLabel = new System.Windows.Forms.Label();
            ngayCapnhatLabel = new System.Windows.Forms.Label();
            codeLabel = new System.Windows.Forms.Label();
            ghichuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomHangHoaModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomHanghoaModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomHanghoaModelGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InformationGroupControl)).BeginInit();
            this.InformationGroupControl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.ThongtinXtraTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenNhomHanghoaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghichuTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // activeLabel
            // 
            activeLabel.AutoSize = true;
            activeLabel.Location = new System.Drawing.Point(332, 35);
            activeLabel.Name = "activeLabel";
            activeLabel.Size = new System.Drawing.Size(41, 13);
            activeLabel.TabIndex = 29;
            activeLabel.Text = "Active:";
            // 
            // tenNhomHanghoaLabel
            // 
            tenNhomHanghoaLabel.AutoSize = true;
            tenNhomHanghoaLabel.Location = new System.Drawing.Point(20, 68);
            tenNhomHanghoaLabel.Name = "tenNhomHanghoaLabel";
            tenNhomHanghoaLabel.Size = new System.Drawing.Size(86, 13);
            tenNhomHanghoaLabel.TabIndex = 27;
            tenNhomHanghoaLabel.Text = "Nhóm hàng hóa:";
            // 
            // ngayCapnhatLabel
            // 
            ngayCapnhatLabel.AutoSize = true;
            ngayCapnhatLabel.Location = new System.Drawing.Point(20, 106);
            ngayCapnhatLabel.Name = "ngayCapnhatLabel";
            ngayCapnhatLabel.Size = new System.Drawing.Size(81, 13);
            ngayCapnhatLabel.TabIndex = 26;
            ngayCapnhatLabel.Text = "Ngày cập nhật:";
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(20, 35);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(36, 13);
            codeLabel.TabIndex = 25;
            codeLabel.Text = "Code:";
            // 
            // ghichuLabel
            // 
            ghichuLabel.AutoSize = true;
            ghichuLabel.Location = new System.Drawing.Point(20, 146);
            ghichuLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            ghichuLabel.Name = "ghichuLabel";
            ghichuLabel.Size = new System.Drawing.Size(46, 13);
            ghichuLabel.TabIndex = 24;
            ghichuLabel.Text = "Ghi chú:";
            ghichuLabel.Click += new System.EventHandler(this.ghichuLabel_Click);
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // nhomHangHoaModelGridControl
            // 
            this.nhomHangHoaModelGridControl.DataSource = this.nhomHanghoaModelBindingSource;
            this.nhomHangHoaModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nhomHangHoaModelGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.nhomHangHoaModelGridControl.Location = new System.Drawing.Point(0, 0);
            this.nhomHangHoaModelGridControl.MainView = this.nhomHanghoaModelGridView;
            this.nhomHangHoaModelGridControl.Margin = new System.Windows.Forms.Padding(2);
            this.nhomHangHoaModelGridControl.Name = "nhomHangHoaModelGridControl";
            this.nhomHangHoaModelGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.nhomHangHoaModelGridControl.Size = new System.Drawing.Size(499, 378);
            this.nhomHangHoaModelGridControl.TabIndex = 4;
            this.nhomHangHoaModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.nhomHanghoaModelGridView});
            // 
            // nhomHanghoaModelBindingSource
            // 
            this.nhomHanghoaModelBindingSource.DataSource = typeof(B2B.Model.NhomHanghoaModel);
            // 
            // nhomHanghoaModelGridView
            // 
            this.nhomHanghoaModelGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNhomHanghoaId,
            this.colStep,
            this.colNgayCapnhat,
            this.colActive,
            this.colVersion,
            this.colCode,
            this.colTenNhomHanghoa,
            this.colGhichu,
            this.colState,
            this.NoGridColumn});
            this.nhomHanghoaModelGridView.GridControl = this.nhomHangHoaModelGridControl;
            this.nhomHanghoaModelGridView.Name = "nhomHanghoaModelGridView";
            this.nhomHanghoaModelGridView.OptionsBehavior.Editable = false;
            this.nhomHanghoaModelGridView.OptionsView.ShowAutoFilterRow = true;
            this.nhomHanghoaModelGridView.OptionsView.ShowFooter = true;
            this.nhomHanghoaModelGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.nhomHanghoaModelGridView_CustomColumnDisplayText);
            // 
            // colNhomHanghoaId
            // 
            this.colNhomHanghoaId.FieldName = "NhomHanghoaId";
            this.colNhomHanghoaId.Name = "colNhomHanghoaId";
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
            this.colNgayCapnhat.Width = 88;
            // 
            // colActive
            // 
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 3;
            this.colActive.Width = 37;
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
            this.colCode.Width = 107;
            // 
            // colTenNhomHanghoa
            // 
            this.colTenNhomHanghoa.Caption = "Tên Nhóm hàng hóa";
            this.colTenNhomHanghoa.FieldName = "TenNhomHanghoa";
            this.colTenNhomHanghoa.Name = "colTenNhomHanghoa";
            this.colTenNhomHanghoa.Visible = true;
            this.colTenNhomHanghoa.VisibleIndex = 2;
            this.colTenNhomHanghoa.Width = 160;
            // 
            // colGhichu
            // 
            this.colGhichu.Caption = "Ghi chú";
            this.colGhichu.FieldName = "Ghichu";
            this.colGhichu.Name = "colGhichu";
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.OptionsColumn.ReadOnly = true;
            this.colState.Visible = true;
            this.colState.VisibleIndex = 5;
            this.colState.Width = 51;
            // 
            // NoGridColumn
            // 
            this.NoGridColumn.Caption = "STT";
            this.NoGridColumn.Name = "NoGridColumn";
            this.NoGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.NoGridColumn.Visible = true;
            this.NoGridColumn.VisibleIndex = 0;
            this.NoGridColumn.Width = 38;
            // 
            // addNhomHanghoaSimpleButton
            // 
            this.addNhomHanghoaSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addNhomHanghoaSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("addNhomHanghoaSimpleButton.Image")));
            this.addNhomHanghoaSimpleButton.Location = new System.Drawing.Point(160, 28);
            this.addNhomHanghoaSimpleButton.Margin = new System.Windows.Forms.Padding(2);
            this.addNhomHanghoaSimpleButton.Name = "addNhomHanghoaSimpleButton";
            this.addNhomHanghoaSimpleButton.Size = new System.Drawing.Size(70, 27);
            this.addNhomHanghoaSimpleButton.TabIndex = 28;
            this.addNhomHanghoaSimpleButton.Text = "Add";
            this.addNhomHanghoaSimpleButton.Click += new System.EventHandler(this.addNhomHanghoaSimpleButton_Click);
            // 
            // deleteNhomHanghoaSimpleButton
            // 
            this.deleteNhomHanghoaSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deleteNhomHanghoaSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteNhomHanghoaSimpleButton.Image")));
            this.deleteNhomHanghoaSimpleButton.Location = new System.Drawing.Point(10, 28);
            this.deleteNhomHanghoaSimpleButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteNhomHanghoaSimpleButton.Name = "deleteNhomHanghoaSimpleButton";
            this.deleteNhomHanghoaSimpleButton.Size = new System.Drawing.Size(70, 27);
            this.deleteNhomHanghoaSimpleButton.TabIndex = 29;
            this.deleteNhomHanghoaSimpleButton.Text = "Delete";
            this.deleteNhomHanghoaSimpleButton.Click += new System.EventHandler(this.deleteNhomHanghoaSimpleButton_Click);
            // 
            // editNhomHanghoaSimpleButton
            // 
            this.editNhomHanghoaSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.editNhomHanghoaSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("editNhomHanghoaSimpleButton.Image")));
            this.editNhomHanghoaSimpleButton.Location = new System.Drawing.Point(269, 28);
            this.editNhomHanghoaSimpleButton.Margin = new System.Windows.Forms.Padding(2);
            this.editNhomHanghoaSimpleButton.Name = "editNhomHanghoaSimpleButton";
            this.editNhomHanghoaSimpleButton.Size = new System.Drawing.Size(70, 27);
            this.editNhomHanghoaSimpleButton.TabIndex = 26;
            this.editNhomHanghoaSimpleButton.Text = "Edit";
            this.editNhomHanghoaSimpleButton.Click += new System.EventHandler(this.editNhomHanghoaSimpleButton_Click);
            // 
            // exportNhomHanghoaSimpleButton
            // 
            this.exportNhomHanghoaSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.exportNhomHanghoaSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("exportNhomHanghoaSimpleButton.Image")));
            this.exportNhomHanghoaSimpleButton.Location = new System.Drawing.Point(85, 28);
            this.exportNhomHanghoaSimpleButton.Margin = new System.Windows.Forms.Padding(2);
            this.exportNhomHanghoaSimpleButton.Name = "exportNhomHanghoaSimpleButton";
            this.exportNhomHanghoaSimpleButton.Size = new System.Drawing.Size(70, 27);
            this.exportNhomHanghoaSimpleButton.TabIndex = 27;
            this.exportNhomHanghoaSimpleButton.Text = "Export";
            this.exportNhomHanghoaSimpleButton.Click += new System.EventHandler(this.exportNhomHanghoaSimpleButton_Click);
            // 
            // reloadNhomHanghoaSimpleButton
            // 
            this.reloadNhomHanghoaSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.reloadNhomHanghoaSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("reloadNhomHanghoaSimpleButton.Image")));
            this.reloadNhomHanghoaSimpleButton.Location = new System.Drawing.Point(419, 28);
            this.reloadNhomHanghoaSimpleButton.Margin = new System.Windows.Forms.Padding(2);
            this.reloadNhomHanghoaSimpleButton.Name = "reloadNhomHanghoaSimpleButton";
            this.reloadNhomHanghoaSimpleButton.Size = new System.Drawing.Size(70, 27);
            this.reloadNhomHanghoaSimpleButton.TabIndex = 24;
            this.reloadNhomHanghoaSimpleButton.Text = "Reload";
            this.reloadNhomHanghoaSimpleButton.Click += new System.EventHandler(this.reloadNhomHanghoaSimpleButton_Click);
            // 
            // saveNhomHanghoaSimpleButton
            // 
            this.saveNhomHanghoaSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.saveNhomHanghoaSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("saveNhomHanghoaSimpleButton.Image")));
            this.saveNhomHanghoaSimpleButton.Location = new System.Drawing.Point(344, 28);
            this.saveNhomHanghoaSimpleButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveNhomHanghoaSimpleButton.Name = "saveNhomHanghoaSimpleButton";
            this.saveNhomHanghoaSimpleButton.Size = new System.Drawing.Size(70, 27);
            this.saveNhomHanghoaSimpleButton.TabIndex = 25;
            this.saveNhomHanghoaSimpleButton.Text = "Save";
            this.saveNhomHanghoaSimpleButton.Click += new System.EventHandler(this.saveNhomHanghoaSimpleButton_Click);
            // 
            // InformationGroupControl
            // 
            this.InformationGroupControl.Controls.Add(this.addNhomHanghoaSimpleButton);
            this.InformationGroupControl.Controls.Add(this.deleteNhomHanghoaSimpleButton);
            this.InformationGroupControl.Controls.Add(this.editNhomHanghoaSimpleButton);
            this.InformationGroupControl.Controls.Add(this.exportNhomHanghoaSimpleButton);
            this.InformationGroupControl.Controls.Add(this.reloadNhomHanghoaSimpleButton);
            this.InformationGroupControl.Controls.Add(this.saveNhomHanghoaSimpleButton);
            this.InformationGroupControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InformationGroupControl.Location = new System.Drawing.Point(0, 378);
            this.InformationGroupControl.Margin = new System.Windows.Forms.Padding(2);
            this.InformationGroupControl.Name = "InformationGroupControl";
            this.InformationGroupControl.Size = new System.Drawing.Size(499, 71);
            this.InformationGroupControl.TabIndex = 3;
            this.InformationGroupControl.Text = "Thao tác Nhóm hàng hóa";
            this.InformationGroupControl.Paint += new System.Windows.Forms.PaintEventHandler(this.InformationGroupControl_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nhomHangHoaModelGridControl);
            this.panel2.Controls.Add(this.InformationGroupControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(437, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(499, 449);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.xtraTabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 449);
            this.panel1.TabIndex = 5;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.ThongtinXtraTabPage;
            this.xtraTabControl1.Size = new System.Drawing.Size(437, 449);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.ThongtinXtraTabPage});
            // 
            // ThongtinXtraTabPage
            // 
            this.ThongtinXtraTabPage.Controls.Add(this.groupControl1);
            this.ThongtinXtraTabPage.Name = "ThongtinXtraTabPage";
            this.ThongtinXtraTabPage.Size = new System.Drawing.Size(431, 421);
            this.ThongtinXtraTabPage.Text = "Thông tin";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(activeLabel);
            this.groupControl1.Controls.Add(this.activeCheckEdit);
            this.groupControl1.Controls.Add(tenNhomHanghoaLabel);
            this.groupControl1.Controls.Add(this.tenNhomHanghoaTextEdit);
            this.groupControl1.Controls.Add(ngayCapnhatLabel);
            this.groupControl1.Controls.Add(this.ngayCapnhatDateEdit);
            this.groupControl1.Controls.Add(codeLabel);
            this.groupControl1.Controls.Add(this.codeTextEdit);
            this.groupControl1.Controls.Add(ghichuLabel);
            this.groupControl1.Controls.Add(this.ghichuTextEdit);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(431, 421);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // activeCheckEdit
            // 
            this.activeCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhomHanghoaModelBindingSource, "Active", true));
            this.activeCheckEdit.EditValue = true;
            this.activeCheckEdit.Location = new System.Drawing.Point(379, 32);
            this.activeCheckEdit.Name = "activeCheckEdit";
            this.activeCheckEdit.Properties.Caption = "";
            this.activeCheckEdit.Properties.ReadOnly = true;
            this.activeCheckEdit.Size = new System.Drawing.Size(20, 19);
            this.activeCheckEdit.TabIndex = 21;
            // 
            // tenNhomHanghoaTextEdit
            // 
            this.tenNhomHanghoaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhomHanghoaModelBindingSource, "TenNhomHanghoa", true));
            this.tenNhomHanghoaTextEdit.Location = new System.Drawing.Point(122, 66);
            this.tenNhomHanghoaTextEdit.Name = "tenNhomHanghoaTextEdit";
            this.tenNhomHanghoaTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.tenNhomHanghoaTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.tenNhomHanghoaTextEdit.Properties.ReadOnly = true;
            this.tenNhomHanghoaTextEdit.Size = new System.Drawing.Size(277, 20);
            this.tenNhomHanghoaTextEdit.TabIndex = 22;
            // 
            // ngayCapnhatDateEdit
            // 
            this.ngayCapnhatDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhomHanghoaModelBindingSource, "NgayCapnhat", true));
            this.ngayCapnhatDateEdit.EditValue = null;
            this.ngayCapnhatDateEdit.Location = new System.Drawing.Point(121, 103);
            this.ngayCapnhatDateEdit.Name = "ngayCapnhatDateEdit";
            this.ngayCapnhatDateEdit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.ngayCapnhatDateEdit.Properties.Appearance.Options.UseBackColor = true;
            this.ngayCapnhatDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayCapnhatDateEdit.Properties.ReadOnly = true;
            this.ngayCapnhatDateEdit.Size = new System.Drawing.Size(278, 20);
            this.ngayCapnhatDateEdit.TabIndex = 28;
            // 
            // codeTextEdit
            // 
            this.codeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhomHanghoaModelBindingSource, "Code", true));
            this.codeTextEdit.Location = new System.Drawing.Point(122, 32);
            this.codeTextEdit.Name = "codeTextEdit";
            this.codeTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.codeTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.codeTextEdit.Properties.ReadOnly = true;
            this.codeTextEdit.Size = new System.Drawing.Size(204, 20);
            this.codeTextEdit.TabIndex = 20;
            // 
            // ghichuTextEdit
            // 
            this.ghichuTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ghichuTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhomHanghoaModelBindingSource, "Ghichu", true));
            this.ghichuTextEdit.Location = new System.Drawing.Point(121, 155);
            this.ghichuTextEdit.Margin = new System.Windows.Forms.Padding(2);
            this.ghichuTextEdit.Name = "ghichuTextEdit";
            this.ghichuTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.ghichuTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.ghichuTextEdit.Properties.ReadOnly = true;
            this.ghichuTextEdit.Size = new System.Drawing.Size(278, 234);
            this.ghichuTextEdit.TabIndex = 23;
            this.ghichuTextEdit.UseOptimizedRendering = true;
            // 
            // NhomHanghoaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 449);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "NhomHanghoaForm";
            this.Text = "Nhóm hàng hóa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomHangHoaModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomHanghoaModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomHanghoaModelGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InformationGroupControl)).EndInit();
            this.InformationGroupControl.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.ThongtinXtraTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenNhomHanghoaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayCapnhatDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghichuTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.GridControl nhomHangHoaModelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView nhomHanghoaModelGridView;
        private DevExpress.XtraEditors.SimpleButton addNhomHanghoaSimpleButton;
        private DevExpress.XtraEditors.SimpleButton deleteNhomHanghoaSimpleButton;
        private DevExpress.XtraEditors.SimpleButton editNhomHanghoaSimpleButton;
        private DevExpress.XtraEditors.SimpleButton exportNhomHanghoaSimpleButton;
        private DevExpress.XtraEditors.SimpleButton reloadNhomHanghoaSimpleButton;
        private DevExpress.XtraEditors.SimpleButton saveNhomHanghoaSimpleButton;
        private DevExpress.XtraEditors.GroupControl InformationGroupControl;
        private System.Windows.Forms.BindingSource nhomHanghoaModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNhomHanghoaId;
        private DevExpress.XtraGrid.Columns.GridColumn colStep;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayCapnhat;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNhomHanghoa;
        private DevExpress.XtraGrid.Columns.GridColumn colGhichu;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraGrid.Columns.GridColumn NoGridColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage ThongtinXtraTabPage;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit activeCheckEdit;
        private DevExpress.XtraEditors.TextEdit tenNhomHanghoaTextEdit;
        private DevExpress.XtraEditors.DateEdit ngayCapnhatDateEdit;
        private DevExpress.XtraEditors.TextEdit codeTextEdit;
        private DevExpress.XtraEditors.MemoEdit ghichuTextEdit;
    }
}