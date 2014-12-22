namespace B2B.Forms
{
    partial class NguyennhanForm
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
            System.Windows.Forms.Label loaiNguyennhanValueLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NguyennhanForm));
            this.nguyennhanLydoModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nguyennhanLydoModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.nguyennhanLydoModelGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNguyennhanLydoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoidung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhichu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenLoaiNguyennhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STTHridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThaotacGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.addNguyennhanSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.editNguyennhanSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.deleteNguyennhanSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveNguyennhanSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.exportNguyennhanSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.LoaiNguennhanComboBox = new System.Windows.Forms.ComboBox();
            this.loaiNguyennhanModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            loaiNguyennhanValueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nguyennhanLydoModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguyennhanLydoModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguyennhanLydoModelGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThaotacGroupControl)).BeginInit();
            this.ThaotacGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaiNguyennhanModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // loaiNguyennhanValueLabel
            // 
            loaiNguyennhanValueLabel.AutoSize = true;
            loaiNguyennhanValueLabel.Location = new System.Drawing.Point(22, 59);
            loaiNguyennhanValueLabel.Name = "loaiNguyennhanValueLabel";
            loaiNguyennhanValueLabel.Size = new System.Drawing.Size(270, 25);
            loaiNguyennhanValueLabel.TabIndex = 0;
            loaiNguyennhanValueLabel.Text = "Nguyên nhân thuộc nhóm: ";
            // 
            // nguyennhanLydoModelBindingSource
            // 
            this.nguyennhanLydoModelBindingSource.DataSource = typeof(B2B.Model.NguyennhanLydoModel);
            // 
            // nguyennhanLydoModelGridControl
            // 
            this.nguyennhanLydoModelGridControl.DataSource = this.nguyennhanLydoModelBindingSource;
            this.nguyennhanLydoModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nguyennhanLydoModelGridControl.Location = new System.Drawing.Point(0, 108);
            this.nguyennhanLydoModelGridControl.MainView = this.nguyennhanLydoModelGridView;
            this.nguyennhanLydoModelGridControl.Name = "nguyennhanLydoModelGridControl";
            this.nguyennhanLydoModelGridControl.Size = new System.Drawing.Size(1049, 571);
            this.nguyennhanLydoModelGridControl.TabIndex = 1;
            this.nguyennhanLydoModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.nguyennhanLydoModelGridView});
            // 
            // nguyennhanLydoModelGridView
            // 
            this.nguyennhanLydoModelGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNguyennhanLydoId,
            this.colStep,
            this.colActive,
            this.colVersion,
            this.colCode,
            this.colNoidung,
            this.colGhichu,
            this.colState,
            this.colTenLoaiNguyennhan,
            this.STTHridColumn});
            this.nguyennhanLydoModelGridView.GridControl = this.nguyennhanLydoModelGridControl;
            this.nguyennhanLydoModelGridView.Name = "nguyennhanLydoModelGridView";
            this.nguyennhanLydoModelGridView.OptionsView.ShowGroupPanel = false;
            this.nguyennhanLydoModelGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.nguyennhanLydoModelGridView_CustomColumnDisplayText);
            // 
            // colNguyennhanLydoId
            // 
            this.colNguyennhanLydoId.FieldName = "NguyennhanLydoId";
            this.colNguyennhanLydoId.Name = "colNguyennhanLydoId";
            // 
            // colStep
            // 
            this.colStep.FieldName = "Step";
            this.colStep.Name = "colStep";
            // 
            // colActive
            // 
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 4;
            this.colActive.Width = 65;
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
            this.colCode.Width = 134;
            // 
            // colNoidung
            // 
            this.colNoidung.Caption = "Nội dung";
            this.colNoidung.FieldName = "Noidung";
            this.colNoidung.Name = "colNoidung";
            this.colNoidung.Visible = true;
            this.colNoidung.VisibleIndex = 2;
            this.colNoidung.Width = 239;
            // 
            // colGhichu
            // 
            this.colGhichu.Caption = "Ghi chú";
            this.colGhichu.FieldName = "Ghichu";
            this.colGhichu.Name = "colGhichu";
            this.colGhichu.Visible = true;
            this.colGhichu.VisibleIndex = 5;
            this.colGhichu.Width = 312;
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.OptionsColumn.ReadOnly = true;
            this.colState.Visible = true;
            this.colState.VisibleIndex = 6;
            this.colState.Width = 168;
            // 
            // colTenLoaiNguyennhan
            // 
            this.colTenLoaiNguyennhan.Caption = "Nhóm";
            this.colTenLoaiNguyennhan.FieldName = "TenLoaiNguyennhan";
            this.colTenLoaiNguyennhan.Name = "colTenLoaiNguyennhan";
            this.colTenLoaiNguyennhan.Visible = true;
            this.colTenLoaiNguyennhan.VisibleIndex = 3;
            this.colTenLoaiNguyennhan.Width = 154;
            // 
            // STTHridColumn
            // 
            this.STTHridColumn.Caption = "STT";
            this.STTHridColumn.Name = "STTHridColumn";
            this.STTHridColumn.Visible = true;
            this.STTHridColumn.VisibleIndex = 0;
            this.STTHridColumn.Width = 96;
            // 
            // ThaotacGroupControl
            // 
            this.ThaotacGroupControl.Controls.Add(this.addNguyennhanSimpleButton);
            this.ThaotacGroupControl.Controls.Add(this.editNguyennhanSimpleButton);
            this.ThaotacGroupControl.Controls.Add(this.deleteNguyennhanSimpleButton);
            this.ThaotacGroupControl.Controls.Add(this.saveNguyennhanSimpleButton);
            this.ThaotacGroupControl.Controls.Add(this.exportNguyennhanSimpleButton);
            this.ThaotacGroupControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ThaotacGroupControl.Location = new System.Drawing.Point(0, 679);
            this.ThaotacGroupControl.Name = "ThaotacGroupControl";
            this.ThaotacGroupControl.Size = new System.Drawing.Size(1049, 122);
            this.ThaotacGroupControl.TabIndex = 2;
            this.ThaotacGroupControl.Text = "Thao tác";
            // 
            // addNguyennhanSimpleButton
            // 
            this.addNguyennhanSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addNguyennhanSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("addNguyennhanSimpleButton.Image")));
            this.addNguyennhanSimpleButton.Location = new System.Drawing.Point(335, 46);
            this.addNguyennhanSimpleButton.Name = "addNguyennhanSimpleButton";
            this.addNguyennhanSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.addNguyennhanSimpleButton.TabIndex = 9;
            this.addNguyennhanSimpleButton.Text = "Thêm";
            this.addNguyennhanSimpleButton.Click += new System.EventHandler(this.addNguyennhanSimpleButton_Click);
            // 
            // editNguyennhanSimpleButton
            // 
            this.editNguyennhanSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.editNguyennhanSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("editNguyennhanSimpleButton.Image")));
            this.editNguyennhanSimpleButton.Location = new System.Drawing.Point(727, 46);
            this.editNguyennhanSimpleButton.Name = "editNguyennhanSimpleButton";
            this.editNguyennhanSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.editNguyennhanSimpleButton.TabIndex = 8;
            this.editNguyennhanSimpleButton.Text = "Sửa";
            this.editNguyennhanSimpleButton.Click += new System.EventHandler(this.editNguyennhanSimpleButton_Click);
            // 
            // deleteNguyennhanSimpleButton
            // 
            this.deleteNguyennhanSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deleteNguyennhanSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteNguyennhanSimpleButton.Image")));
            this.deleteNguyennhanSimpleButton.Location = new System.Drawing.Point(37, 46);
            this.deleteNguyennhanSimpleButton.Name = "deleteNguyennhanSimpleButton";
            this.deleteNguyennhanSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.deleteNguyennhanSimpleButton.TabIndex = 11;
            this.deleteNguyennhanSimpleButton.Text = "Xóa";
            this.deleteNguyennhanSimpleButton.Click += new System.EventHandler(this.deleteNguyennhanSimpleButton_Click);
            // 
            // saveNguyennhanSimpleButton
            // 
            this.saveNguyennhanSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.saveNguyennhanSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("saveNguyennhanSimpleButton.Image")));
            this.saveNguyennhanSimpleButton.Location = new System.Drawing.Point(878, 46);
            this.saveNguyennhanSimpleButton.Name = "saveNguyennhanSimpleButton";
            this.saveNguyennhanSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.saveNguyennhanSimpleButton.TabIndex = 7;
            this.saveNguyennhanSimpleButton.Text = "Lưu";
            this.saveNguyennhanSimpleButton.Click += new System.EventHandler(this.saveNguyennhanSimpleButton_Click);
            // 
            // exportNguyennhanSimpleButton
            // 
            this.exportNguyennhanSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.exportNguyennhanSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("exportNguyennhanSimpleButton.Image")));
            this.exportNguyennhanSimpleButton.Location = new System.Drawing.Point(186, 46);
            this.exportNguyennhanSimpleButton.Name = "exportNguyennhanSimpleButton";
            this.exportNguyennhanSimpleButton.Size = new System.Drawing.Size(139, 52);
            this.exportNguyennhanSimpleButton.TabIndex = 10;
            this.exportNguyennhanSimpleButton.Text = "Excel";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.LoaiNguennhanComboBox);
            this.groupControl1.Controls.Add(loaiNguyennhanValueLabel);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1049, 108);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Điều kiện lọc";
            // 
            // LoaiNguennhanComboBox
            // 
            this.LoaiNguennhanComboBox.DataSource = this.loaiNguyennhanModelBindingSource;
            this.LoaiNguennhanComboBox.DisplayMember = "TenLoaiNguyennhan";
            this.LoaiNguennhanComboBox.FormattingEnabled = true;
            this.LoaiNguennhanComboBox.Location = new System.Drawing.Point(298, 56);
            this.LoaiNguennhanComboBox.Name = "LoaiNguennhanComboBox";
            this.LoaiNguennhanComboBox.Size = new System.Drawing.Size(222, 33);
            this.LoaiNguennhanComboBox.TabIndex = 1;
            this.LoaiNguennhanComboBox.ValueMember = "LoaiNguyennhanValue";
            // 
            // loaiNguyennhanModelBindingSource
            // 
            this.loaiNguyennhanModelBindingSource.DataSource = typeof(B2B.Model.LoaiNguyennhanModel);
            this.loaiNguyennhanModelBindingSource.CurrentItemChanged += new System.EventHandler(this.loaiNguyennhanModelBindingSource_CurrentItemChanged);
            // 
            // NguyennhanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 801);
            this.Controls.Add(this.nguyennhanLydoModelGridControl);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ThaotacGroupControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NguyennhanForm";
            this.Text = "Nguyên nhân";
            ((System.ComponentModel.ISupportInitialize)(this.nguyennhanLydoModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguyennhanLydoModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguyennhanLydoModelGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThaotacGroupControl)).EndInit();
            this.ThaotacGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaiNguyennhanModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource nguyennhanLydoModelBindingSource;
        private DevExpress.XtraGrid.GridControl nguyennhanLydoModelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView nguyennhanLydoModelGridView;
        private DevExpress.XtraEditors.GroupControl ThaotacGroupControl;
        private DevExpress.XtraEditors.SimpleButton addNguyennhanSimpleButton;
        private DevExpress.XtraEditors.SimpleButton editNguyennhanSimpleButton;
        private DevExpress.XtraEditors.SimpleButton deleteNguyennhanSimpleButton;
        private DevExpress.XtraEditors.SimpleButton saveNguyennhanSimpleButton;
        private DevExpress.XtraEditors.SimpleButton exportNguyennhanSimpleButton;
        private DevExpress.XtraGrid.Columns.GridColumn colNguyennhanLydoId;
        private DevExpress.XtraGrid.Columns.GridColumn colStep;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colNoidung;
        private DevExpress.XtraGrid.Columns.GridColumn colGhichu;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraGrid.Columns.GridColumn colTenLoaiNguyennhan;
        private DevExpress.XtraGrid.Columns.GridColumn STTHridColumn;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.BindingSource loaiNguyennhanModelBindingSource;
        private System.Windows.Forms.ComboBox LoaiNguennhanComboBox;
    }
}