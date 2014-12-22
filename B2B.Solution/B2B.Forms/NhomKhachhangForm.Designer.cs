namespace B2B.Forms
{
    partial class NhomKhachhangForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhomKhachhangForm));
            this.InformationGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.addNhaCungcapSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.deleteNhaCungcapSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.editNhaCungcapSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.exportNhaCungcapSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.reloadNhaCungcapSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveNhaCungcapSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.nhomKhachhangModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.nhomKhachhangModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhomKhachhangModelGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhomKhachhangId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayCapnhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNhomKhachhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.InformationGroupControl)).BeginInit();
            this.InformationGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhomKhachhangModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomKhachhangModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomKhachhangModelGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // InformationGroupControl
            // 
            this.InformationGroupControl.Controls.Add(this.addNhaCungcapSimpleButton);
            this.InformationGroupControl.Controls.Add(this.deleteNhaCungcapSimpleButton);
            this.InformationGroupControl.Controls.Add(this.editNhaCungcapSimpleButton);
            this.InformationGroupControl.Controls.Add(this.exportNhaCungcapSimpleButton);
            this.InformationGroupControl.Controls.Add(this.reloadNhaCungcapSimpleButton);
            this.InformationGroupControl.Controls.Add(this.saveNhaCungcapSimpleButton);
            this.InformationGroupControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InformationGroupControl.Location = new System.Drawing.Point(0, 336);
            this.InformationGroupControl.Margin = new System.Windows.Forms.Padding(2);
            this.InformationGroupControl.Name = "InformationGroupControl";
            this.InformationGroupControl.Size = new System.Drawing.Size(638, 66);
            this.InformationGroupControl.TabIndex = 0;
            this.InformationGroupControl.Text = "Thao tác Nhóm khách hàng";
            // 
            // addNhaCungcapSimpleButton
            // 
            this.addNhaCungcapSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addNhaCungcapSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("addNhaCungcapSimpleButton.Image")));
            this.addNhaCungcapSimpleButton.Location = new System.Drawing.Point(160, 25);
            this.addNhaCungcapSimpleButton.Margin = new System.Windows.Forms.Padding(2);
            this.addNhaCungcapSimpleButton.Name = "addNhaCungcapSimpleButton";
            this.addNhaCungcapSimpleButton.Size = new System.Drawing.Size(70, 27);
            this.addNhaCungcapSimpleButton.TabIndex = 28;
            this.addNhaCungcapSimpleButton.Text = "Add";
            this.addNhaCungcapSimpleButton.Click += new System.EventHandler(this.addNhomKhachhangSimpleButton_Click);
            // 
            // deleteNhaCungcapSimpleButton
            // 
            this.deleteNhaCungcapSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deleteNhaCungcapSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteNhaCungcapSimpleButton.Image")));
            this.deleteNhaCungcapSimpleButton.Location = new System.Drawing.Point(10, 25);
            this.deleteNhaCungcapSimpleButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteNhaCungcapSimpleButton.Name = "deleteNhaCungcapSimpleButton";
            this.deleteNhaCungcapSimpleButton.Size = new System.Drawing.Size(70, 27);
            this.deleteNhaCungcapSimpleButton.TabIndex = 29;
            this.deleteNhaCungcapSimpleButton.Text = "Delete";
            this.deleteNhaCungcapSimpleButton.Click += new System.EventHandler(this.deleteNhomKhachhangSimpleButton_Click);
            // 
            // editNhaCungcapSimpleButton
            // 
            this.editNhaCungcapSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.editNhaCungcapSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("editNhaCungcapSimpleButton.Image")));
            this.editNhaCungcapSimpleButton.Location = new System.Drawing.Point(408, 25);
            this.editNhaCungcapSimpleButton.Margin = new System.Windows.Forms.Padding(2);
            this.editNhaCungcapSimpleButton.Name = "editNhaCungcapSimpleButton";
            this.editNhaCungcapSimpleButton.Size = new System.Drawing.Size(70, 27);
            this.editNhaCungcapSimpleButton.TabIndex = 26;
            this.editNhaCungcapSimpleButton.Text = "Edit";
            this.editNhaCungcapSimpleButton.Click += new System.EventHandler(this.editNhomKhachhangSimpleButton_Click);
            // 
            // exportNhaCungcapSimpleButton
            // 
            this.exportNhaCungcapSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.exportNhaCungcapSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("exportNhaCungcapSimpleButton.Image")));
            this.exportNhaCungcapSimpleButton.Location = new System.Drawing.Point(85, 25);
            this.exportNhaCungcapSimpleButton.Margin = new System.Windows.Forms.Padding(2);
            this.exportNhaCungcapSimpleButton.Name = "exportNhaCungcapSimpleButton";
            this.exportNhaCungcapSimpleButton.Size = new System.Drawing.Size(70, 27);
            this.exportNhaCungcapSimpleButton.TabIndex = 27;
            this.exportNhaCungcapSimpleButton.Text = "Export";
            this.exportNhaCungcapSimpleButton.Click += new System.EventHandler(this.exportNhaCungcapSimpleButton_Click);
            // 
            // reloadNhaCungcapSimpleButton
            // 
            this.reloadNhaCungcapSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.reloadNhaCungcapSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("reloadNhaCungcapSimpleButton.Image")));
            this.reloadNhaCungcapSimpleButton.Location = new System.Drawing.Point(558, 25);
            this.reloadNhaCungcapSimpleButton.Margin = new System.Windows.Forms.Padding(2);
            this.reloadNhaCungcapSimpleButton.Name = "reloadNhaCungcapSimpleButton";
            this.reloadNhaCungcapSimpleButton.Size = new System.Drawing.Size(70, 27);
            this.reloadNhaCungcapSimpleButton.TabIndex = 24;
            this.reloadNhaCungcapSimpleButton.Text = "Reload";
            this.reloadNhaCungcapSimpleButton.Click += new System.EventHandler(this.reloadNhomKhachhangSimpleButton_Click);
            // 
            // saveNhaCungcapSimpleButton
            // 
            this.saveNhaCungcapSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.saveNhaCungcapSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("saveNhaCungcapSimpleButton.Image")));
            this.saveNhaCungcapSimpleButton.Location = new System.Drawing.Point(483, 25);
            this.saveNhaCungcapSimpleButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveNhaCungcapSimpleButton.Name = "saveNhaCungcapSimpleButton";
            this.saveNhaCungcapSimpleButton.Size = new System.Drawing.Size(70, 27);
            this.saveNhaCungcapSimpleButton.TabIndex = 25;
            this.saveNhaCungcapSimpleButton.Text = "Save";
            this.saveNhaCungcapSimpleButton.Click += new System.EventHandler(this.saveNhaCungcapSimpleButton_Click);
            // 
            // nhomKhachhangModelGridControl
            // 
            this.nhomKhachhangModelGridControl.DataSource = this.nhomKhachhangModelBindingSource;
            this.nhomKhachhangModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nhomKhachhangModelGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.nhomKhachhangModelGridControl.Location = new System.Drawing.Point(0, 0);
            this.nhomKhachhangModelGridControl.MainView = this.nhomKhachhangModelGridView;
            this.nhomKhachhangModelGridControl.Margin = new System.Windows.Forms.Padding(2);
            this.nhomKhachhangModelGridControl.Name = "nhomKhachhangModelGridControl";
            this.nhomKhachhangModelGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.nhomKhachhangModelGridControl.Size = new System.Drawing.Size(638, 336);
            this.nhomKhachhangModelGridControl.TabIndex = 2;
            this.nhomKhachhangModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.nhomKhachhangModelGridView});
            // 
            // nhomKhachhangModelBindingSource
            // 
            this.nhomKhachhangModelBindingSource.DataSource = typeof(B2B.Model.NhomKhachhangModel);
            // 
            // nhomKhachhangModelGridView
            // 
            this.nhomKhachhangModelGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode,
            this.colNhomKhachhangId,
            this.colStep,
            this.colNgayCapnhat,
            this.colActive,
            this.colVersion,
            this.colTenNhomKhachhang,
            this.colState,
            this.NoGridColumn});
            this.nhomKhachhangModelGridView.GridControl = this.nhomKhachhangModelGridControl;
            this.nhomKhachhangModelGridView.Name = "nhomKhachhangModelGridView";
            this.nhomKhachhangModelGridView.OptionsBehavior.Editable = false;
            this.nhomKhachhangModelGridView.OptionsView.ShowAutoFilterRow = true;
            this.nhomKhachhangModelGridView.OptionsView.ShowFooter = true;
            this.nhomKhachhangModelGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.nhomKhachhangModelGridView_CustomColumnDisplayText);
            // 
            // colCode
            // 
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 1;
            this.colCode.Width = 138;
            // 
            // colNhomKhachhangId
            // 
            this.colNhomKhachhangId.FieldName = "NhomKhachhangId";
            this.colNhomKhachhangId.Name = "colNhomKhachhangId";
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
            this.colNgayCapnhat.Width = 84;
            // 
            // colActive
            // 
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 3;
            this.colActive.Width = 42;
            // 
            // colVersion
            // 
            this.colVersion.FieldName = "Version";
            this.colVersion.Name = "colVersion";
            // 
            // colTenNhomKhachhang
            // 
            this.colTenNhomKhachhang.Caption = "Tên Nhóm Khách hàng";
            this.colTenNhomKhachhang.FieldName = "TenNhomKhachhang";
            this.colTenNhomKhachhang.Name = "colTenNhomKhachhang";
            this.colTenNhomKhachhang.Visible = true;
            this.colTenNhomKhachhang.VisibleIndex = 2;
            this.colTenNhomKhachhang.Width = 248;
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.OptionsColumn.ReadOnly = true;
            this.colState.Visible = true;
            this.colState.VisibleIndex = 5;
            this.colState.Width = 65;
            // 
            // NoGridColumn
            // 
            this.NoGridColumn.Caption = "STT";
            this.NoGridColumn.Name = "NoGridColumn";
            this.NoGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.NoGridColumn.Visible = true;
            this.NoGridColumn.VisibleIndex = 0;
            this.NoGridColumn.Width = 41;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // NhomKhachhangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 402);
            this.Controls.Add(this.nhomKhachhangModelGridControl);
            this.Controls.Add(this.InformationGroupControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NhomKhachhangForm";
            this.Text = "Nhóm khách hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.InformationGroupControl)).EndInit();
            this.InformationGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nhomKhachhangModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomKhachhangModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomKhachhangModelGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl InformationGroupControl;
        private DevExpress.XtraGrid.GridControl nhomKhachhangModelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView nhomKhachhangModelGridView;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.SimpleButton addNhaCungcapSimpleButton;
        private DevExpress.XtraEditors.SimpleButton deleteNhaCungcapSimpleButton;
        private DevExpress.XtraEditors.SimpleButton editNhaCungcapSimpleButton;
        private DevExpress.XtraEditors.SimpleButton exportNhaCungcapSimpleButton;
        private DevExpress.XtraEditors.SimpleButton reloadNhaCungcapSimpleButton;
        private DevExpress.XtraEditors.SimpleButton saveNhaCungcapSimpleButton;
        private System.Windows.Forms.BindingSource nhomKhachhangModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNhomKhachhangId;
        private DevExpress.XtraGrid.Columns.GridColumn colStep;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayCapnhat;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNhomKhachhang;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraGrid.Columns.GridColumn NoGridColumn;
    }
}