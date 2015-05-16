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
    public partial class BackupForm : DevExpress.XtraEditors.XtraForm
    {
        public BackupForm()
        {
            InitializeComponent();
        }

        private void BackupForm_Load(object sender, EventArgs e)
        {
            TenTaptinTextEdit.Text = "QLBH_" + DateTime.Now.ToString("ddMMyyhhssmm") + ".bak";
        }

        private void OpenPathSimpleButton_Click(object sender, EventArgs e)
        {
            if (DuongdanFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                DuongdanTextEdit.Text = DuongdanFolderBrowserDialog.SelectedPath;
            }
        }

        private void CancelSimpleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                string savePath = Path.Combine(DuongdanFolderBrowserDialog.SelectedPath, TenTaptinTextEdit.Text);
                DatabaseHelper.Helper.BackupDatabase(savePath);
                MessageBox.Show("Thao tác thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}