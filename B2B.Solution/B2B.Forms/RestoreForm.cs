using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;

namespace B2B.Forms
{
    public partial class RestoreForm : DevExpress.XtraEditors.XtraForm
    {
        public RestoreForm()
        {
            InitializeComponent();
        }

        private void CancelSimpleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenPathSimpleButton_Click(object sender, EventArgs e)
        {
            if (backupOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                DuongdanTextEdit.Text = backupOpenFileDialog.FileName;
                TenTaptinTextEdit.Text = Path.GetFileName(backupOpenFileDialog.FileName);
            }
        }

        private void OkSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(backupOpenFileDialog.FileName))
                {
                    DatabaseHelper.Helper.RestoreDatabase(backupOpenFileDialog.FileName);
                }
                MessageBox.Show("Thao tác thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}