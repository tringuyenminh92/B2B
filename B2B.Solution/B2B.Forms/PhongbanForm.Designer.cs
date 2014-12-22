namespace B2B.Forms
{
    partial class PhongbanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhongbanForm));
            this.phongbanModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RightPanelControl = new DevExpress.XtraEditors.PanelControl();
            this.phongbanModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.phongbanModelGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPhongbanId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayCapnhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenPhongban = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhichu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ActionGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.addPhongbanSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.editPhongbanSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.exportPhongbanSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.deletePhongbanSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.savePhongbanSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.phongbanModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightPanelControl)).BeginInit();
            this.RightPanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phongbanModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongbanModelGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActionGroupControl)).BeginInit();
            this.ActionGroupControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // phongbanModelBindingSource
            // 
            this.phongbanModelBindingSource.DataSource = typeof(B2B.Model.PhongbanModel);
            // 
            // RightPanelControl
            // 
            this.RightPanelControl.Controls.Add(this.phongbanModelGridControl);
            this.RightPanelControl.Controls.Add(this.ActionGroupControl);
            this.RightPanelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightPanelControl.Location = new System.Drawing.Point(0, 0);
            this.RightPanelControl.Name = "RightPanelControl";
            this.RightPanelControl.Size = new System.Drawing.Size(1084, 739);
            this.RightPanelControl.TabIndex = 1;
            // 
            // phongbanModelGridControl
            // 
            this.phongbanModelGridControl.DataSource = this.phongbanModelBindingSource;
            this.phongbanModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phongbanModelGridControl.Location = new System.Drawing.Point(2, 2);
            this.phongbanModelGridControl.MainView = this.phongbanModelGridView;
            this.phongbanModelGridControl.Name = "phongbanModelGridControl";
            this.phongbanModelGridControl.Size = new System.Drawing.Size(1080, 606);
            this.phongbanModelGridControl.TabIndex = 1;
            this.phongbanModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.phongbanModelGridView});
            // 
            // phongbanModelGridView
            // 
            this.phongbanModelGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPhongbanId,
            this.colStep,
            this.colNgayCapnhat,
            this.colActive,
            this.colVersion,
            this.colCode,
            this.colTenPhongban,
            this.colGhichu,
            this.colState,
            this.NoGridColumn});
            this.phongbanModelGridView.GridControl = this.phongbanModelGridControl;
            this.phongbanModelGridView.Name = "phongbanModelGridView";
            this.phongbanModelGridView.OptionsView.ShowAutoFilterRow = true;
            this.phongbanModelGridView.OptionsView.ShowFooter = true;
            this.phongbanModelGridView.OptionsView.ShowGroupPanel = false;
            this.phongbanModelGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.phongbanModelGridView_CustomColumnDisplayText);
            // 
            // colPhongbanId
            // 
            this.colPhongbanId.FieldName = "PhongbanId";
            this.colPhongbanId.Name = "colPhongbanId";
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
            this.colNgayCapnhat.Width = 147;
            // 
            // colActive
            // 
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 3;
            this.colActive.Width = 114;
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
            this.colCode.Width = 155;
            // 
            // colTenPhongban
            // 
            this.colTenPhongban.Caption = "Phòng ban";
            this.colTenPhongban.FieldName = "TenPhongban";
            this.colTenPhongban.Name = "colTenPhongban";
            this.colTenPhongban.Visible = true;
            this.colTenPhongban.VisibleIndex = 2;
            this.colTenPhongban.Width = 333;
            // 
            // colGhichu
            // 
            this.colGhichu.Caption = "Ghi chú";
            this.colGhichu.FieldName = "Ghichu";
            this.colGhichu.Name = "colGhichu";
            this.colGhichu.Visible = true;
            this.colGhichu.VisibleIndex = 5;
            this.colGhichu.Width = 141;
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.OptionsColumn.ReadOnly = true;
            this.colState.Visible = true;
            this.colState.VisibleIndex = 6;
            this.colState.Width = 95;
            // 
            // NoGridColumn
            // 
            this.NoGridColumn.Caption = "STT";
            this.NoGridColumn.Name = "NoGridColumn";
            this.NoGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.NoGridColumn.Visible = true;
            this.NoGridColumn.VisibleIndex = 0;
            this.NoGridColumn.Width = 77;
            // 
            // ActionGroupControl
            // 
            this.ActionGroupControl.Controls.Add(this.addPhongbanSimpleButton);
            this.ActionGroupControl.Controls.Add(this.editPhongbanSimpleButton);
            this.ActionGroupControl.Controls.Add(this.exportPhongbanSimpleButton);
            this.ActionGroupControl.Controls.Add(this.deletePhongbanSimpleButton);
            this.ActionGroupControl.Controls.Add(this.savePhongbanSimpleButton);
            this.ActionGroupControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ActionGroupControl.Location = new System.Drawing.Point(2, 608);
            this.ActionGroupControl.Name = "ActionGroupControl";
            this.ActionGroupControl.Size = new System.Drawing.Size(1080, 129);
            this.ActionGroupControl.TabIndex = 1;
            this.ActionGroupControl.Text = "Thao tác Khách hàng";
            // 
            // addPhongbanSimpleButton
            // 
            this.addPhongbanSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addPhongbanSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("addPhongbanSimpleButton.Image")));
            this.addPhongbanSimpleButton.Location = new System.Drawing.Point(316, 51);
            this.addPhongbanSimpleButton.Margin = new System.Windows.Forms.Padding(4);
            this.addPhongbanSimpleButton.Name = "addPhongbanSimpleButton";
            this.addPhongbanSimpleButton.Size = new System.Drawing.Size(140, 52);
            this.addPhongbanSimpleButton.TabIndex = 4;
            this.addPhongbanSimpleButton.Text = "Thêm";
            this.addPhongbanSimpleButton.Click += new System.EventHandler(this.addPhongbanSimpleButton_Click);
            // 
            // editPhongbanSimpleButton
            // 
            this.editPhongbanSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.editPhongbanSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("editPhongbanSimpleButton.Image")));
            this.editPhongbanSimpleButton.Location = new System.Drawing.Point(762, 51);
            this.editPhongbanSimpleButton.Margin = new System.Windows.Forms.Padding(4);
            this.editPhongbanSimpleButton.Name = "editPhongbanSimpleButton";
            this.editPhongbanSimpleButton.Size = new System.Drawing.Size(140, 52);
            this.editPhongbanSimpleButton.TabIndex = 3;
            this.editPhongbanSimpleButton.Text = "Sửa";
            this.editPhongbanSimpleButton.Click += new System.EventHandler(this.editPhongbanSimpleButton_Click);
            // 
            // exportPhongbanSimpleButton
            // 
            this.exportPhongbanSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.exportPhongbanSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("exportPhongbanSimpleButton.Image")));
            this.exportPhongbanSimpleButton.Location = new System.Drawing.Point(168, 51);
            this.exportPhongbanSimpleButton.Margin = new System.Windows.Forms.Padding(4);
            this.exportPhongbanSimpleButton.Name = "exportPhongbanSimpleButton";
            this.exportPhongbanSimpleButton.Size = new System.Drawing.Size(140, 52);
            this.exportPhongbanSimpleButton.TabIndex = 5;
            this.exportPhongbanSimpleButton.Text = "Excel";
            this.exportPhongbanSimpleButton.Click += new System.EventHandler(this.exportPhongbanSimpleButton_Click);
            // 
            // deletePhongbanSimpleButton
            // 
            this.deletePhongbanSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deletePhongbanSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("deletePhongbanSimpleButton.Image")));
            this.deletePhongbanSimpleButton.Location = new System.Drawing.Point(18, 51);
            this.deletePhongbanSimpleButton.Margin = new System.Windows.Forms.Padding(4);
            this.deletePhongbanSimpleButton.Name = "deletePhongbanSimpleButton";
            this.deletePhongbanSimpleButton.Size = new System.Drawing.Size(140, 52);
            this.deletePhongbanSimpleButton.TabIndex = 6;
            this.deletePhongbanSimpleButton.Text = "Xóa";
            this.deletePhongbanSimpleButton.Click += new System.EventHandler(this.deletePhongbanSimpleButton_Click);
            // 
            // savePhongbanSimpleButton
            // 
            this.savePhongbanSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.savePhongbanSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("savePhongbanSimpleButton.Image")));
            this.savePhongbanSimpleButton.Location = new System.Drawing.Point(912, 51);
            this.savePhongbanSimpleButton.Margin = new System.Windows.Forms.Padding(4);
            this.savePhongbanSimpleButton.Name = "savePhongbanSimpleButton";
            this.savePhongbanSimpleButton.Size = new System.Drawing.Size(140, 52);
            this.savePhongbanSimpleButton.TabIndex = 2;
            this.savePhongbanSimpleButton.Text = "Lưu";
            this.savePhongbanSimpleButton.Click += new System.EventHandler(this.savePhongbanSimpleButton_Click);
            // 
            // PhongbanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 739);
            this.Controls.Add(this.RightPanelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1110, 810);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1110, 810);
            this.Name = "PhongbanForm";
            this.Text = "Phòng ban";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.phongbanModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightPanelControl)).EndInit();
            this.RightPanelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.phongbanModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongbanModelGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActionGroupControl)).EndInit();
            this.ActionGroupControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl RightPanelControl;
        private DevExpress.XtraEditors.GroupControl ActionGroupControl;
        private DevExpress.XtraEditors.SimpleButton addPhongbanSimpleButton;
        private DevExpress.XtraEditors.SimpleButton editPhongbanSimpleButton;
        private DevExpress.XtraEditors.SimpleButton exportPhongbanSimpleButton;
        private DevExpress.XtraEditors.SimpleButton deletePhongbanSimpleButton;
        private DevExpress.XtraEditors.SimpleButton savePhongbanSimpleButton;
        private System.Windows.Forms.BindingSource phongbanModelBindingSource;
        private DevExpress.XtraGrid.GridControl phongbanModelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView phongbanModelGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colPhongbanId;
        private DevExpress.XtraGrid.Columns.GridColumn colStep;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayCapnhat;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colTenPhongban;
        private DevExpress.XtraGrid.Columns.GridColumn colGhichu;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraGrid.Columns.GridColumn NoGridColumn;
    }
}