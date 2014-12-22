namespace B2B.Forms
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.ActionUserGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.addUserSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.editUserSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.exportUserSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.deleteUserSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveUserSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.userModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userModelGridControl = new DevExpress.XtraGrid.GridControl();
            this.userModelGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhanvienId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Username = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.col_Password = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNhanvien = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ActionUserGroupControl)).BeginInit();
            this.ActionUserGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userModelGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userModelGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // ActionUserGroupControl
            // 
            this.ActionUserGroupControl.Controls.Add(this.addUserSimpleButton);
            this.ActionUserGroupControl.Controls.Add(this.editUserSimpleButton);
            this.ActionUserGroupControl.Controls.Add(this.exportUserSimpleButton);
            this.ActionUserGroupControl.Controls.Add(this.deleteUserSimpleButton);
            this.ActionUserGroupControl.Controls.Add(this.saveUserSimpleButton);
            this.ActionUserGroupControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ActionUserGroupControl.Location = new System.Drawing.Point(0, 553);
            this.ActionUserGroupControl.Name = "ActionUserGroupControl";
            this.ActionUserGroupControl.Size = new System.Drawing.Size(822, 134);
            this.ActionUserGroupControl.TabIndex = 0;
            this.ActionUserGroupControl.Text = "Thao tác User";
            // 
            // addUserSimpleButton
            // 
            this.addUserSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addUserSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("addUserSimpleButton.Image")));
            this.addUserSimpleButton.Location = new System.Drawing.Point(339, 53);
            this.addUserSimpleButton.Name = "addUserSimpleButton";
            this.addUserSimpleButton.Size = new System.Drawing.Size(139, 69);
            this.addUserSimpleButton.TabIndex = 40;
            this.addUserSimpleButton.Text = "Thêm";
            this.addUserSimpleButton.Click += new System.EventHandler(this.addUserSimpleButton_Click);
            // 
            // editUserSimpleButton
            // 
            this.editUserSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.editUserSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("editUserSimpleButton.Image")));
            this.editUserSimpleButton.Location = new System.Drawing.Point(494, 53);
            this.editUserSimpleButton.Name = "editUserSimpleButton";
            this.editUserSimpleButton.Size = new System.Drawing.Size(139, 69);
            this.editUserSimpleButton.TabIndex = 38;
            this.editUserSimpleButton.Text = "Đổi\r\n Mật khẩu";
            this.editUserSimpleButton.Click += new System.EventHandler(this.editUserSimpleButton_Click);
            // 
            // exportUserSimpleButton
            // 
            this.exportUserSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.exportUserSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("exportUserSimpleButton.Image")));
            this.exportUserSimpleButton.Location = new System.Drawing.Point(180, 53);
            this.exportUserSimpleButton.Name = "exportUserSimpleButton";
            this.exportUserSimpleButton.Size = new System.Drawing.Size(139, 69);
            this.exportUserSimpleButton.TabIndex = 39;
            this.exportUserSimpleButton.Text = "Excel";
            this.exportUserSimpleButton.Click += new System.EventHandler(this.exportUserSimpleButton_Click);
            // 
            // deleteUserSimpleButton
            // 
            this.deleteUserSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deleteUserSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteUserSimpleButton.Image")));
            this.deleteUserSimpleButton.Location = new System.Drawing.Point(24, 53);
            this.deleteUserSimpleButton.Name = "deleteUserSimpleButton";
            this.deleteUserSimpleButton.Size = new System.Drawing.Size(139, 69);
            this.deleteUserSimpleButton.TabIndex = 41;
            this.deleteUserSimpleButton.Text = "Xóa";
            this.deleteUserSimpleButton.Click += new System.EventHandler(this.deleteUserSimpleButton_Click);
            // 
            // saveUserSimpleButton
            // 
            this.saveUserSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.saveUserSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("saveUserSimpleButton.Image")));
            this.saveUserSimpleButton.Location = new System.Drawing.Point(650, 53);
            this.saveUserSimpleButton.Name = "saveUserSimpleButton";
            this.saveUserSimpleButton.Size = new System.Drawing.Size(139, 69);
            this.saveUserSimpleButton.TabIndex = 37;
            this.saveUserSimpleButton.Text = "Lưu";
            this.saveUserSimpleButton.Click += new System.EventHandler(this.saveUserSimpleButton_Click);
            // 
            // userModelBindingSource
            // 
            this.userModelBindingSource.DataSource = typeof(B2B.Model.UserModel);
            // 
            // userModelGridControl
            // 
            this.userModelGridControl.DataSource = this.userModelBindingSource;
            this.userModelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userModelGridControl.Location = new System.Drawing.Point(0, 0);
            this.userModelGridControl.MainView = this.userModelGridView;
            this.userModelGridControl.Name = "userModelGridControl";
            this.userModelGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2});
            this.userModelGridControl.Size = new System.Drawing.Size(822, 553);
            this.userModelGridControl.TabIndex = 2;
            this.userModelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.userModelGridView});
            // 
            // userModelGridView
            // 
            this.userModelGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserId,
            this.colNhanvienId,
            this.colStep,
            this.colActive,
            this.colVersion,
            this.col_Username,
            this.col_Password,
            this.colState,
            this.NoGridColumn,
            this.colTenNhanvien});
            this.userModelGridView.GridControl = this.userModelGridControl;
            this.userModelGridView.Name = "userModelGridView";
            this.userModelGridView.OptionsBehavior.Editable = false;
            this.userModelGridView.OptionsView.ShowAutoFilterRow = true;
            this.userModelGridView.OptionsView.ShowFooter = true;
            this.userModelGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.userModelGridView_CustomColumnDisplayText);
            // 
            // colUserId
            // 
            this.colUserId.FieldName = "UserId";
            this.colUserId.Name = "colUserId";
            // 
            // colNhanvienId
            // 
            this.colNhanvienId.FieldName = "NhanvienId";
            this.colNhanvienId.Name = "colNhanvienId";
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
            // 
            // colVersion
            // 
            this.colVersion.FieldName = "Version";
            this.colVersion.Name = "colVersion";
            // 
            // col_Username
            // 
            this.col_Username.ColumnEdit = this.repositoryItemTextEdit2;
            this.col_Username.FieldName = "_Username";
            this.col_Username.Name = "col_Username";
            this.col_Username.Visible = true;
            this.col_Username.VisibleIndex = 2;
            this.col_Username.Width = 240;
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            this.repositoryItemTextEdit2.PasswordChar = '*';
            // 
            // col_Password
            // 
            this.col_Password.ColumnEdit = this.repositoryItemTextEdit1;
            this.col_Password.FieldName = "_Password";
            this.col_Password.Name = "col_Password";
            this.col_Password.Visible = true;
            this.col_Password.VisibleIndex = 3;
            this.col_Password.Width = 318;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.PasswordChar = '*';
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.OptionsColumn.ReadOnly = true;
            this.colState.Visible = true;
            this.colState.VisibleIndex = 4;
            this.colState.Width = 166;
            // 
            // NoGridColumn
            // 
            this.NoGridColumn.Caption = "STT";
            this.NoGridColumn.Name = "NoGridColumn";
            this.NoGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.NoGridColumn.Visible = true;
            this.NoGridColumn.VisibleIndex = 0;
            this.NoGridColumn.Width = 110;
            // 
            // colTenNhanvien
            // 
            this.colTenNhanvien.Caption = "Nhân viên";
            this.colTenNhanvien.FieldName = "TenNhanvien";
            this.colTenNhanvien.Name = "colTenNhanvien";
            this.colTenNhanvien.Visible = true;
            this.colTenNhanvien.VisibleIndex = 1;
            this.colTenNhanvien.Width = 506;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 687);
            this.Controls.Add(this.userModelGridControl);
            this.Controls.Add(this.ActionUserGroupControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(848, 758);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(848, 758);
            this.Name = "UserForm";
            this.Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)(this.ActionUserGroupControl)).EndInit();
            this.ActionUserGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userModelGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userModelGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl ActionUserGroupControl;
        private DevExpress.XtraEditors.SimpleButton addUserSimpleButton;
        private DevExpress.XtraEditors.SimpleButton editUserSimpleButton;
        private DevExpress.XtraEditors.SimpleButton exportUserSimpleButton;
        private DevExpress.XtraEditors.SimpleButton deleteUserSimpleButton;
        private DevExpress.XtraEditors.SimpleButton saveUserSimpleButton;
        private System.Windows.Forms.BindingSource userModelBindingSource;
        private DevExpress.XtraGrid.GridControl userModelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView userModelGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colUserId;
        private DevExpress.XtraGrid.Columns.GridColumn colNhanvienId;
        private DevExpress.XtraGrid.Columns.GridColumn colStep;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion;
        private DevExpress.XtraGrid.Columns.GridColumn col_Username;
        private DevExpress.XtraGrid.Columns.GridColumn col_Password;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraGrid.Columns.GridColumn NoGridColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNhanvien;
    }
}