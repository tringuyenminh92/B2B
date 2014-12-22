namespace B2B.Forms
{
    partial class KhoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhoForm));
            this.ThaotacKhoGoupControl = new DevExpress.XtraEditors.GroupControl();
            this.addKhoSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.editKhoSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.deleteKhoSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveKhoSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.exportKhoSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.khoModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.khoModelGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKhoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuanhuyenId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTinhthanhId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayCapnhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiachi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhichu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenQuanhuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenTinhthanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RightPanelControl = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ThaotacKhoGoupControl)).BeginInit();
            this.ThaotacKhoGoupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khoModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoModelGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightPanelControl)).BeginInit();
            this.RightPanelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ThaotacKhoGoupControl
            // 
            this.ThaotacKhoGoupControl.Controls.Add(this.addKhoSimpleButton);
            this.ThaotacKhoGoupControl.Controls.Add(this.editKhoSimpleButton);
            this.ThaotacKhoGoupControl.Controls.Add(this.deleteKhoSimpleButton);
            this.ThaotacKhoGoupControl.Controls.Add(this.saveKhoSimpleButton);
            this.ThaotacKhoGoupControl.Controls.Add(this.exportKhoSimpleButton);
            this.ThaotacKhoGoupControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ThaotacKhoGoupControl.Location = new System.Drawing.Point(2, 757);
            this.ThaotacKhoGoupControl.Margin = new System.Windows.Forms.Padding(4);
            this.ThaotacKhoGoupControl.Name = "ThaotacKhoGoupControl";
            this.ThaotacKhoGoupControl.Size = new System.Drawing.Size(1389, 123);
            this.ThaotacKhoGoupControl.TabIndex = 0;
            this.ThaotacKhoGoupControl.Text = "Thao tác Kho";
            // 
            // addKhoSimpleButton
            // 
            this.addKhoSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addKhoSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("addKhoSimpleButton.Image")));
            this.addKhoSimpleButton.Location = new System.Drawing.Point(320, 44);
            this.addKhoSimpleButton.Margin = new System.Windows.Forms.Padding(4);
            this.addKhoSimpleButton.Name = "addKhoSimpleButton";
            this.addKhoSimpleButton.Size = new System.Drawing.Size(140, 52);
            this.addKhoSimpleButton.TabIndex = 34;
            this.addKhoSimpleButton.Text = "Thêm";
            this.addKhoSimpleButton.Click += new System.EventHandler(this.addKhoSimpleButton_Click);
            // 
            // editKhoSimpleButton
            // 
            this.editKhoSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.editKhoSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("editKhoSimpleButton.Image")));
            this.editKhoSimpleButton.Location = new System.Drawing.Point(1068, 44);
            this.editKhoSimpleButton.Margin = new System.Windows.Forms.Padding(4);
            this.editKhoSimpleButton.Name = "editKhoSimpleButton";
            this.editKhoSimpleButton.Size = new System.Drawing.Size(140, 52);
            this.editKhoSimpleButton.TabIndex = 32;
            this.editKhoSimpleButton.Text = "Sửa";
            this.editKhoSimpleButton.Click += new System.EventHandler(this.editKhoSimpleButton_Click);
            // 
            // deleteKhoSimpleButton
            // 
            this.deleteKhoSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deleteKhoSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteKhoSimpleButton.Image")));
            this.deleteKhoSimpleButton.Location = new System.Drawing.Point(22, 44);
            this.deleteKhoSimpleButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteKhoSimpleButton.Name = "deleteKhoSimpleButton";
            this.deleteKhoSimpleButton.Size = new System.Drawing.Size(140, 52);
            this.deleteKhoSimpleButton.TabIndex = 35;
            this.deleteKhoSimpleButton.Text = "Xóa";
            this.deleteKhoSimpleButton.Click += new System.EventHandler(this.deleteKhoSimpleButton_Click);
            // 
            // saveKhoSimpleButton
            // 
            this.saveKhoSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.saveKhoSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("saveKhoSimpleButton.Image")));
            this.saveKhoSimpleButton.Location = new System.Drawing.Point(1218, 44);
            this.saveKhoSimpleButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveKhoSimpleButton.Name = "saveKhoSimpleButton";
            this.saveKhoSimpleButton.Size = new System.Drawing.Size(140, 52);
            this.saveKhoSimpleButton.TabIndex = 31;
            this.saveKhoSimpleButton.Text = "Lưu";
            this.saveKhoSimpleButton.Click += new System.EventHandler(this.saveKhoSimpleButton_Click);
            // 
            // exportKhoSimpleButton
            // 
            this.exportKhoSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.exportKhoSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("exportKhoSimpleButton.Image")));
            this.exportKhoSimpleButton.Location = new System.Drawing.Point(172, 44);
            this.exportKhoSimpleButton.Margin = new System.Windows.Forms.Padding(4);
            this.exportKhoSimpleButton.Name = "exportKhoSimpleButton";
            this.exportKhoSimpleButton.Size = new System.Drawing.Size(140, 52);
            this.exportKhoSimpleButton.TabIndex = 33;
            this.exportKhoSimpleButton.Text = "Excel";
            this.exportKhoSimpleButton.Click += new System.EventHandler(this.exportKhoSimpleButton_Click);
            // 
            // khoModelBindingSource
            // 
            this.khoModelBindingSource.DataSource = typeof(B2B.Model.KhoModel);
            // 
            // khoModelGridControl
            // 
            this.khoModelGridControl.DataSource = this.khoModelBindingSource;
            this.khoModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.khoModelGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.khoModelGridControl.Location = new System.Drawing.Point(2, 2);
            this.khoModelGridControl.MainView = this.khoModelGridView;
            this.khoModelGridControl.Margin = new System.Windows.Forms.Padding(4);
            this.khoModelGridControl.Name = "khoModelGridControl";
            this.khoModelGridControl.Size = new System.Drawing.Size(1389, 755);
            this.khoModelGridControl.TabIndex = 2;
            this.khoModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.khoModelGridView});
            // 
            // khoModelGridView
            // 
            this.khoModelGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKhoId,
            this.colQuanhuyenId,
            this.colTinhthanhId,
            this.colStep,
            this.colNgayCapnhat,
            this.colActive,
            this.colVersion,
            this.colCode,
            this.colTenKho,
            this.colDiachi,
            this.colGhichu,
            this.colState,
            this.colTenQuanhuyen,
            this.colTenTinhthanh,
            this.NoGridColumn});
            this.khoModelGridView.GridControl = this.khoModelGridControl;
            this.khoModelGridView.Name = "khoModelGridView";
            this.khoModelGridView.OptionsBehavior.Editable = false;
            this.khoModelGridView.OptionsView.ShowAutoFilterRow = true;
            this.khoModelGridView.OptionsView.ShowFooter = true;
            this.khoModelGridView.OptionsView.ShowGroupPanel = false;
            this.khoModelGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.khoModelGridView_CustomColumnDisplayText);
            // 
            // colKhoId
            // 
            this.colKhoId.FieldName = "KhoId";
            this.colKhoId.Name = "colKhoId";
            // 
            // colQuanhuyenId
            // 
            this.colQuanhuyenId.FieldName = "QuanhuyenId";
            this.colQuanhuyenId.Name = "colQuanhuyenId";
            // 
            // colTinhthanhId
            // 
            this.colTinhthanhId.FieldName = "TinhthanhId";
            this.colTinhthanhId.Name = "colTinhthanhId";
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
            this.colNgayCapnhat.VisibleIndex = 6;
            this.colNgayCapnhat.Width = 216;
            // 
            // colActive
            // 
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 8;
            this.colActive.Width = 130;
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
            this.colCode.Width = 304;
            // 
            // colTenKho
            // 
            this.colTenKho.Caption = "Tên Kho";
            this.colTenKho.FieldName = "TenKho";
            this.colTenKho.Name = "colTenKho";
            this.colTenKho.Visible = true;
            this.colTenKho.VisibleIndex = 2;
            this.colTenKho.Width = 492;
            // 
            // colDiachi
            // 
            this.colDiachi.Caption = "Địa chỉ";
            this.colDiachi.FieldName = "Diachi";
            this.colDiachi.Name = "colDiachi";
            this.colDiachi.Visible = true;
            this.colDiachi.VisibleIndex = 3;
            this.colDiachi.Width = 212;
            // 
            // colGhichu
            // 
            this.colGhichu.Caption = "Ghi chú";
            this.colGhichu.FieldName = "Ghichu";
            this.colGhichu.Name = "colGhichu";
            this.colGhichu.Visible = true;
            this.colGhichu.VisibleIndex = 7;
            this.colGhichu.Width = 318;
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.OptionsColumn.ReadOnly = true;
            this.colState.Visible = true;
            this.colState.VisibleIndex = 9;
            this.colState.Width = 239;
            // 
            // colTenQuanhuyen
            // 
            this.colTenQuanhuyen.Caption = "Quận huyện";
            this.colTenQuanhuyen.FieldName = "TenQuanhuyen";
            this.colTenQuanhuyen.Name = "colTenQuanhuyen";
            this.colTenQuanhuyen.Visible = true;
            this.colTenQuanhuyen.VisibleIndex = 4;
            this.colTenQuanhuyen.Width = 212;
            // 
            // colTenTinhthanh
            // 
            this.colTenTinhthanh.Caption = "Tỉnh thành";
            this.colTenTinhthanh.FieldName = "TenTinhthanh";
            this.colTenTinhthanh.Name = "colTenTinhthanh";
            this.colTenTinhthanh.Visible = true;
            this.colTenTinhthanh.VisibleIndex = 5;
            this.colTenTinhthanh.Width = 328;
            // 
            // NoGridColumn
            // 
            this.NoGridColumn.Caption = "STT";
            this.NoGridColumn.FieldName = "NoGridColumn";
            this.NoGridColumn.Name = "NoGridColumn";
            this.NoGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.NoGridColumn.Visible = true;
            this.NoGridColumn.VisibleIndex = 0;
            this.NoGridColumn.Width = 125;
            // 
            // RightPanelControl
            // 
            this.RightPanelControl.Controls.Add(this.khoModelGridControl);
            this.RightPanelControl.Controls.Add(this.ThaotacKhoGoupControl);
            this.RightPanelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightPanelControl.Location = new System.Drawing.Point(0, 0);
            this.RightPanelControl.Name = "RightPanelControl";
            this.RightPanelControl.Size = new System.Drawing.Size(1393, 882);
            this.RightPanelControl.TabIndex = 4;
            // 
            // KhoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 882);
            this.Controls.Add(this.RightPanelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1419, 953);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1419, 953);
            this.Name = "KhoForm";
            this.Text = "Kho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ThaotacKhoGoupControl)).EndInit();
            this.ThaotacKhoGoupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.khoModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoModelGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightPanelControl)).EndInit();
            this.RightPanelControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl ThaotacKhoGoupControl;
        private DevExpress.XtraEditors.SimpleButton addKhoSimpleButton;
        private DevExpress.XtraEditors.SimpleButton editKhoSimpleButton;
        private DevExpress.XtraEditors.SimpleButton deleteKhoSimpleButton;
        private DevExpress.XtraEditors.SimpleButton saveKhoSimpleButton;
        private DevExpress.XtraEditors.SimpleButton exportKhoSimpleButton;
        private System.Windows.Forms.BindingSource khoModelBindingSource;
        private DevExpress.XtraGrid.GridControl khoModelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView khoModelGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colKhoId;
        private DevExpress.XtraGrid.Columns.GridColumn colQuanhuyenId;
        private DevExpress.XtraGrid.Columns.GridColumn colTinhthanhId;
        private DevExpress.XtraGrid.Columns.GridColumn colStep;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayCapnhat;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKho;
        private DevExpress.XtraGrid.Columns.GridColumn colDiachi;
        private DevExpress.XtraGrid.Columns.GridColumn colGhichu;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraGrid.Columns.GridColumn colTenQuanhuyen;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTinhthanh;
        private DevExpress.XtraGrid.Columns.GridColumn NoGridColumn;
        private DevExpress.XtraEditors.PanelControl RightPanelControl;
    }
}