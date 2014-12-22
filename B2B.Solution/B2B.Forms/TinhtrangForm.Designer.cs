namespace B2B.Forms
{
    partial class TinhtrangForm
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
            System.Windows.Forms.Label LoaiTinhtrangLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TinhtrangForm));
            this.FilterGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.loaiTinhtrangValueComboBox = new System.Windows.Forms.ComboBox();
            this.loaiTinhtrangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NhanvienActionGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.addTinhtrangSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.deleteTinhtrangSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveTinhtrangSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.exportTinhtrangSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.tinhtrangModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tinhtrangModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.tinhtrangModelGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTinhtrangId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayCapnhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenTinhtrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhichu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SttGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenLoaiTinhtrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.loaiDonhangModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            LoaiTinhtrangLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FilterGroupControl)).BeginInit();
            this.FilterGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaiTinhtrangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanvienActionGroupControl)).BeginInit();
            this.NhanvienActionGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tinhtrangModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhtrangModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhtrangModelGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiDonhangModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LoaiTinhtrangLabel
            // 
            LoaiTinhtrangLabel.AutoSize = true;
            LoaiTinhtrangLabel.Location = new System.Drawing.Point(23, 61);
            LoaiTinhtrangLabel.Name = "LoaiTinhtrangLabel";
            LoaiTinhtrangLabel.Size = new System.Drawing.Size(227, 25);
            LoaiTinhtrangLabel.TabIndex = 3;
            LoaiTinhtrangLabel.Text = "Chọn nhóm tình trạng:";
            // 
            // FilterGroupControl
            // 
            this.FilterGroupControl.Controls.Add(LoaiTinhtrangLabel);
            this.FilterGroupControl.Controls.Add(this.loaiTinhtrangValueComboBox);
            this.FilterGroupControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.FilterGroupControl.Location = new System.Drawing.Point(0, 0);
            this.FilterGroupControl.Name = "FilterGroupControl";
            this.FilterGroupControl.Size = new System.Drawing.Size(1396, 116);
            this.FilterGroupControl.TabIndex = 0;
            this.FilterGroupControl.Text = "Điều kiện lọc";
            // 
            // loaiTinhtrangValueComboBox
            // 
            this.loaiTinhtrangValueComboBox.DataSource = this.loaiTinhtrangBindingSource;
            this.loaiTinhtrangValueComboBox.DisplayMember = "TenloaiTinhtrang";
            this.loaiTinhtrangValueComboBox.FormattingEnabled = true;
            this.loaiTinhtrangValueComboBox.Location = new System.Drawing.Point(267, 58);
            this.loaiTinhtrangValueComboBox.Name = "loaiTinhtrangValueComboBox";
            this.loaiTinhtrangValueComboBox.Size = new System.Drawing.Size(267, 33);
            this.loaiTinhtrangValueComboBox.TabIndex = 0;
            this.loaiTinhtrangValueComboBox.ValueMember = "LoaiTinhtrangValue";
            // 
            // loaiTinhtrangBindingSource
            // 
            this.loaiTinhtrangBindingSource.DataSource = typeof(B2B.Model.LoaiTinhtrangModel);
            this.loaiTinhtrangBindingSource.CurrentItemChanged += new System.EventHandler(this.loaiTinhtrangBindingSource_CurrentItemChanged);
            // 
            // NhanvienActionGroupControl
            // 
            this.NhanvienActionGroupControl.Controls.Add(this.addTinhtrangSimpleButton);
            this.NhanvienActionGroupControl.Controls.Add(this.deleteTinhtrangSimpleButton);
            this.NhanvienActionGroupControl.Controls.Add(this.saveTinhtrangSimpleButton);
            this.NhanvienActionGroupControl.Controls.Add(this.exportTinhtrangSimpleButton);
            this.NhanvienActionGroupControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NhanvienActionGroupControl.Location = new System.Drawing.Point(0, 815);
            this.NhanvienActionGroupControl.Name = "NhanvienActionGroupControl";
            this.NhanvienActionGroupControl.Size = new System.Drawing.Size(1396, 131);
            this.NhanvienActionGroupControl.TabIndex = 3;
            this.NhanvienActionGroupControl.Text = "Thao tác Tình trạng:";
            // 
            // addTinhtrangSimpleButton
            // 
            this.addTinhtrangSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addTinhtrangSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("addTinhtrangSimpleButton.Image")));
            this.addTinhtrangSimpleButton.Location = new System.Drawing.Point(316, 49);
            this.addTinhtrangSimpleButton.Name = "addTinhtrangSimpleButton";
            this.addTinhtrangSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.addTinhtrangSimpleButton.TabIndex = 4;
            this.addTinhtrangSimpleButton.Text = "Thêm";
            this.addTinhtrangSimpleButton.Click += new System.EventHandler(this.addTinhtrangSimpleButton_Click);
            // 
            // deleteTinhtrangSimpleButton
            // 
            this.deleteTinhtrangSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deleteTinhtrangSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteTinhtrangSimpleButton.Image")));
            this.deleteTinhtrangSimpleButton.Location = new System.Drawing.Point(18, 49);
            this.deleteTinhtrangSimpleButton.Name = "deleteTinhtrangSimpleButton";
            this.deleteTinhtrangSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.deleteTinhtrangSimpleButton.TabIndex = 6;
            this.deleteTinhtrangSimpleButton.Text = "Xóa";
            this.deleteTinhtrangSimpleButton.Click += new System.EventHandler(this.deleteTinhtrangSimpleButton_Click);
            // 
            // saveTinhtrangSimpleButton
            // 
            this.saveTinhtrangSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.saveTinhtrangSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("saveTinhtrangSimpleButton.Image")));
            this.saveTinhtrangSimpleButton.Location = new System.Drawing.Point(1224, 49);
            this.saveTinhtrangSimpleButton.Name = "saveTinhtrangSimpleButton";
            this.saveTinhtrangSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.saveTinhtrangSimpleButton.TabIndex = 2;
            this.saveTinhtrangSimpleButton.Text = "Lưu";
            this.saveTinhtrangSimpleButton.Click += new System.EventHandler(this.saveTinhtrangSimpleButton_Click);
            // 
            // exportTinhtrangSimpleButton
            // 
            this.exportTinhtrangSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.exportTinhtrangSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("exportTinhtrangSimpleButton.Image")));
            this.exportTinhtrangSimpleButton.Location = new System.Drawing.Point(167, 49);
            this.exportTinhtrangSimpleButton.Name = "exportTinhtrangSimpleButton";
            this.exportTinhtrangSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.exportTinhtrangSimpleButton.TabIndex = 5;
            this.exportTinhtrangSimpleButton.Text = "Excel";
            // 
            // tinhtrangModelBindingSource
            // 
            this.tinhtrangModelBindingSource.DataSource = typeof(B2B.Model.TinhtrangModel);
            // 
            // tinhtrangModelGridControl
            // 
            this.tinhtrangModelGridControl.DataSource = this.tinhtrangModelBindingSource;
            this.tinhtrangModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tinhtrangModelGridControl.Location = new System.Drawing.Point(0, 116);
            this.tinhtrangModelGridControl.MainView = this.tinhtrangModelGridView;
            this.tinhtrangModelGridControl.Name = "tinhtrangModelGridControl";
            this.tinhtrangModelGridControl.Size = new System.Drawing.Size(1396, 699);
            this.tinhtrangModelGridControl.TabIndex = 4;
            this.tinhtrangModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tinhtrangModelGridView});
            // 
            // tinhtrangModelGridView
            // 
            this.tinhtrangModelGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTinhtrangId,
            this.colStep,
            this.colNgayCapnhat,
            this.colActive,
            this.colVersion,
            this.colCode,
            this.colTenTinhtrang,
            this.colGhichu,
            this.colState,
            this.SttGridColumn,
            this.colTenLoaiTinhtrang});
            this.tinhtrangModelGridView.GridControl = this.tinhtrangModelGridControl;
            this.tinhtrangModelGridView.Name = "tinhtrangModelGridView";
            this.tinhtrangModelGridView.OptionsBehavior.Editable = false;
            this.tinhtrangModelGridView.OptionsView.ShowAutoFilterRow = true;
            this.tinhtrangModelGridView.OptionsView.ShowGroupPanel = false;
            this.tinhtrangModelGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.tinhtrangModelGridView_CustomColumnDisplayText);
            // 
            // colTinhtrangId
            // 
            this.colTinhtrangId.FieldName = "TinhtrangId";
            this.colTinhtrangId.Name = "colTinhtrangId";
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
            this.colNgayCapnhat.Width = 128;
            // 
            // colActive
            // 
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 4;
            this.colActive.Width = 86;
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
            this.colCode.Width = 129;
            // 
            // colTenTinhtrang
            // 
            this.colTenTinhtrang.Caption = "Tình trạng";
            this.colTenTinhtrang.FieldName = "TenTinhtrang";
            this.colTenTinhtrang.Name = "colTenTinhtrang";
            this.colTenTinhtrang.Visible = true;
            this.colTenTinhtrang.VisibleIndex = 2;
            this.colTenTinhtrang.Width = 310;
            // 
            // colGhichu
            // 
            this.colGhichu.Caption = "Ghi chú";
            this.colGhichu.FieldName = "Ghichu";
            this.colGhichu.Name = "colGhichu";
            this.colGhichu.Visible = true;
            this.colGhichu.VisibleIndex = 5;
            this.colGhichu.Width = 234;
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.OptionsColumn.ReadOnly = true;
            this.colState.Visible = true;
            this.colState.VisibleIndex = 7;
            this.colState.Width = 155;
            // 
            // SttGridColumn
            // 
            this.SttGridColumn.Caption = "STT";
            this.SttGridColumn.Name = "SttGridColumn";
            this.SttGridColumn.Visible = true;
            this.SttGridColumn.VisibleIndex = 0;
            this.SttGridColumn.Width = 83;
            // 
            // colTenLoaiTinhtrang
            // 
            this.colTenLoaiTinhtrang.Caption = "Thuộc nhóm";
            this.colTenLoaiTinhtrang.FieldName = "TenLoaiTinhtrang";
            this.colTenLoaiTinhtrang.Name = "colTenLoaiTinhtrang";
            this.colTenLoaiTinhtrang.Visible = true;
            this.colTenLoaiTinhtrang.VisibleIndex = 3;
            this.colTenLoaiTinhtrang.Width = 251;
            // 
            // loaiDonhangModelBindingSource
            // 
            this.loaiDonhangModelBindingSource.DataSource = typeof(B2B.Model.LoaiDonhangModel);
            // 
            // TinhtrangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 946);
            this.Controls.Add(this.tinhtrangModelGridControl);
            this.Controls.Add(this.NhanvienActionGroupControl);
            this.Controls.Add(this.FilterGroupControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1422, 1017);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1422, 1017);
            this.Name = "TinhtrangForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tình trạng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.FilterGroupControl)).EndInit();
            this.FilterGroupControl.ResumeLayout(false);
            this.FilterGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaiTinhtrangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanvienActionGroupControl)).EndInit();
            this.NhanvienActionGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tinhtrangModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhtrangModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhtrangModelGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiDonhangModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl FilterGroupControl;
        private DevExpress.XtraEditors.GroupControl NhanvienActionGroupControl;
        private DevExpress.XtraEditors.SimpleButton addTinhtrangSimpleButton;
        private DevExpress.XtraEditors.SimpleButton deleteTinhtrangSimpleButton;
        private DevExpress.XtraEditors.SimpleButton saveTinhtrangSimpleButton;
        private DevExpress.XtraEditors.SimpleButton exportTinhtrangSimpleButton;
        private System.Windows.Forms.ComboBox loaiTinhtrangValueComboBox;
        private System.Windows.Forms.BindingSource tinhtrangModelBindingSource;
        private DevExpress.XtraGrid.GridControl tinhtrangModelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView tinhtrangModelGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colTinhtrangId;
        private DevExpress.XtraGrid.Columns.GridColumn colStep;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayCapnhat;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colTenTinhtrang;
        private DevExpress.XtraGrid.Columns.GridColumn colGhichu;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraGrid.Columns.GridColumn SttGridColumn;
        private System.Windows.Forms.BindingSource loaiTinhtrangBindingSource;
        private System.Windows.Forms.BindingSource loaiDonhangModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colTenLoaiTinhtrang;
    }
}