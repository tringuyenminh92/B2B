/********************************************************************
	Class file: 
    Author: Nguyen Minh Tri
    Date Created: 04/09/2014
	Last Updated: 04/09/2014
	Updated By: Nguyen Minh Tri
	Update Description: 
*********************************************************************/

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
using B2B.View;
using B2B.Model;
using log4net;
using B2B.Presenter;

namespace B2B.Forms
{
    public partial class UserDetailForm : DevExpress.XtraEditors.XtraForm, IUserDetailView
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        UserDetailPresenter presenter;
        public UserDetailForm()
        {
            InitializeComponent();
            presenter = new UserDetailPresenter(this);
            presenter.DisplayNhanvien();
        }

        public UserDetailForm(UserModel value)
            : this()
        {
            Value = value;
            userModelBindingSource.DataSource = value;
        }

        private UserModel _value;
        public UserModel Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }

        public void RefreshData()
        {
            tenNhanvienTextEdit.RefreshEditValue();
        }

        private void OkSimpleButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelSimpleButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public List<NhanvienModel> NhanvienItems
        {
            get
            {
                return nhanvienModelBindingSource.DataSource as List<NhanvienModel>;
            }
            set
            {
                nhanvienModelBindingSource.DataSource = value;
            }
        }

        private void UserDetailForm_KeyUp(object sender, KeyEventArgs e)
        {
            userModelBindingSource.EndEdit();
        }
    }
}