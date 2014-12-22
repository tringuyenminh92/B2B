namespace B2B.Forms
{
    partial class PhieuGiaohangDetailForm
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
            System.Windows.Forms.Label codeLabel;
            System.Windows.Forms.Label tenKhachhangLabel;
            System.Windows.Forms.Label ngaylapLabel;
            System.Windows.Forms.Label codeLabel1;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label tenNhanvienGiaohangLabel;
            this.donhangModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tenKhachhangTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.chitietPhieuxuatModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chitietPhieuxuatModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.phieuxuatModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ngaylapDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.codeTextEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.tenNhanvienGiaohangTextEdit = new DevExpress.XtraEditors.TextEdit();
            codeLabel = new System.Windows.Forms.Label();
            tenKhachhangLabel = new System.Windows.Forms.Label();
            ngaylapLabel = new System.Windows.Forms.Label();
            codeLabel1 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            tenNhanvienGiaohangLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.donhangModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenKhachhangTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitietPhieuxuatModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitietPhieuxuatModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuxuatModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaylapDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaylapDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenNhanvienGiaohangTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(99, 37);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(36, 13);
            codeLabel.TabIndex = 1;
            codeLabel.Text = "Code:";
            // 
            // tenKhachhangLabel
            // 
            tenKhachhangLabel.AutoSize = true;
            tenKhachhangLabel.Location = new System.Drawing.Point(75, 74);
            tenKhachhangLabel.Name = "tenKhachhangLabel";
            tenKhachhangLabel.Size = new System.Drawing.Size(85, 13);
            tenKhachhangLabel.TabIndex = 3;
            tenKhachhangLabel.Text = "Ten Khachhang:";
            // 
            // ngaylapLabel
            // 
            ngaylapLabel.AutoSize = true;
            ngaylapLabel.Location = new System.Drawing.Point(534, 120);
            ngaylapLabel.Name = "ngaylapLabel";
            ngaylapLabel.Size = new System.Drawing.Size(50, 13);
            ngaylapLabel.TabIndex = 7;
            ngaylapLabel.Text = "Ngaylap:";
            // 
            // codeLabel1
            // 
            codeLabel1.AutoSize = true;
            codeLabel1.Location = new System.Drawing.Point(754, 63);
            codeLabel1.Name = "codeLabel1";
            codeLabel1.Size = new System.Drawing.Size(36, 13);
            codeLabel1.TabIndex = 9;
            codeLabel1.Text = "Code:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(728, 116);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(62, 13);
            label1.TabIndex = 12;
            label1.Text = "Ngày giao: ";
            // 
            // tenNhanvienGiaohangLabel
            // 
            tenNhanvienGiaohangLabel.AutoSize = true;
            tenNhanvienGiaohangLabel.Location = new System.Drawing.Point(611, 37);
            tenNhanvienGiaohangLabel.Name = "tenNhanvienGiaohangLabel";
            tenNhanvienGiaohangLabel.Size = new System.Drawing.Size(125, 13);
            tenNhanvienGiaohangLabel.TabIndex = 13;
            tenNhanvienGiaohangLabel.Text = "Ten Nhanvien Giaohang:";
            // 
            // donhangModelBindingSource
            // 
            this.donhangModelBindingSource.DataSource = typeof(B2B.Model.DonhangModel);
            // 
            // codeTextEdit
            // 
            this.codeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.donhangModelBindingSource, "Code", true));
            this.codeTextEdit.Location = new System.Drawing.Point(166, 30);
            this.codeTextEdit.Name = "codeTextEdit";
            this.codeTextEdit.Size = new System.Drawing.Size(100, 20);
            this.codeTextEdit.TabIndex = 2;
            // 
            // tenKhachhangTextEdit
            // 
            this.tenKhachhangTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.donhangModelBindingSource, "TenKhachhang", true));
            this.tenKhachhangTextEdit.Location = new System.Drawing.Point(166, 71);
            this.tenKhachhangTextEdit.Name = "tenKhachhangTextEdit";
            this.tenKhachhangTextEdit.Size = new System.Drawing.Size(100, 20);
            this.tenKhachhangTextEdit.TabIndex = 4;
            // 
            // chitietPhieuxuatModelBindingSource
            // 
            this.chitietPhieuxuatModelBindingSource.DataSource = typeof(B2B.Model.ChitietPhieuxuatModel);
            // 
            // chitietPhieuxuatModelGridControl
            // 
            this.chitietPhieuxuatModelGridControl.DataSource = this.chitietPhieuxuatModelBindingSource;
            this.chitietPhieuxuatModelGridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chitietPhieuxuatModelGridControl.Location = new System.Drawing.Point(0, 164);
            this.chitietPhieuxuatModelGridControl.MainView = this.gridView1;
            this.chitietPhieuxuatModelGridControl.Name = "chitietPhieuxuatModelGridControl";
            this.chitietPhieuxuatModelGridControl.Size = new System.Drawing.Size(918, 290);
            this.chitietPhieuxuatModelGridControl.TabIndex = 5;
            this.chitietPhieuxuatModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.chitietPhieuxuatModelGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // phieuxuatModelBindingSource
            // 
            this.phieuxuatModelBindingSource.DataSource = typeof(B2B.Model.PhieuxuatModel);
            // 
            // ngaylapDateEdit
            // 
            this.ngaylapDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuxuatModelBindingSource, "Ngaylap", true));
            this.ngaylapDateEdit.EditValue = null;
            this.ngaylapDateEdit.Location = new System.Drawing.Point(590, 117);
            this.ngaylapDateEdit.Name = "ngaylapDateEdit";
            this.ngaylapDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngaylapDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngaylapDateEdit.Size = new System.Drawing.Size(100, 20);
            this.ngaylapDateEdit.TabIndex = 8;
            // 
            // codeTextEdit1
            // 
            this.codeTextEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuxuatModelBindingSource, "Code", true));
            this.codeTextEdit1.Location = new System.Drawing.Point(796, 60);
            this.codeTextEdit1.Name = "codeTextEdit1";
            this.codeTextEdit1.Size = new System.Drawing.Size(100, 20);
            this.codeTextEdit1.TabIndex = 10;
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuxuatModelBindingSource, "Code", true));
            this.textEdit1.Location = new System.Drawing.Point(796, 113);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 11;
            // 
            // tenNhanvienGiaohangTextEdit
            // 
            this.tenNhanvienGiaohangTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuxuatModelBindingSource, "TenNhanvienGiaohang", true));
            this.tenNhanvienGiaohangTextEdit.Location = new System.Drawing.Point(742, 34);
            this.tenNhanvienGiaohangTextEdit.Name = "tenNhanvienGiaohangTextEdit";
            this.tenNhanvienGiaohangTextEdit.Size = new System.Drawing.Size(100, 20);
            this.tenNhanvienGiaohangTextEdit.TabIndex = 14;
            // 
            // PhieuGiaohangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 454);
            this.Controls.Add(tenNhanvienGiaohangLabel);
            this.Controls.Add(this.tenNhanvienGiaohangTextEdit);
            this.Controls.Add(label1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(codeLabel1);
            this.Controls.Add(this.codeTextEdit1);
            this.Controls.Add(ngaylapLabel);
            this.Controls.Add(this.ngaylapDateEdit);
            this.Controls.Add(this.chitietPhieuxuatModelGridControl);
            this.Controls.Add(tenKhachhangLabel);
            this.Controls.Add(this.tenKhachhangTextEdit);
            this.Controls.Add(codeLabel);
            this.Controls.Add(this.codeTextEdit);
            this.Name = "PhieuGiaohangForm";
            this.Text = "PhieuGiaohangForm";
            ((System.ComponentModel.ISupportInitialize)(this.donhangModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenKhachhangTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitietPhieuxuatModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitietPhieuxuatModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuxuatModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaylapDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaylapDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenNhanvienGiaohangTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource donhangModelBindingSource;
        private DevExpress.XtraEditors.TextEdit codeTextEdit;
        private DevExpress.XtraEditors.TextEdit tenKhachhangTextEdit;
        private System.Windows.Forms.BindingSource chitietPhieuxuatModelBindingSource;
        private DevExpress.XtraGrid.GridControl chitietPhieuxuatModelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource phieuxuatModelBindingSource;
        private DevExpress.XtraEditors.DateEdit ngaylapDateEdit;
        private DevExpress.XtraEditors.TextEdit codeTextEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit tenNhanvienGiaohangTextEdit;
    }
}