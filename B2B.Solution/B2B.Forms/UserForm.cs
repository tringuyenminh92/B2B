/********************************************************************
	Class file: 
    Author: Nguyen Minh Tri
    Date Created: 04/09/2014
	Last Updated: 09/09/2014
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
using log4net;
using B2B.View;
using B2B.Model;
using B2B.Presenter;
using System.IO;

namespace B2B.Forms
{
    public partial class UserForm : DevExpress.XtraEditors.XtraForm, IUserView
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        UserPresenter presenter;

        MemoryStream memStream;
        public UserForm()
        {
            InitializeComponent();

            memStream = new MemoryStream();
            userModelGridView.SaveLayoutToStream(memStream);
            memStream.Seek(0, System.IO.SeekOrigin.Begin);

            presenter = new UserPresenter(this);
            presenter.Display();
        }

        private void reloadUserSimpleButton_Click(object sender, EventArgs e)
        {

            presenter.Display();
        }

        private void saveUserSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.Save();
            presenter.Display();
        }

        private void editUserSimpleButton_Click(object sender, EventArgs e)
        {
            if (userModelBindingSource.Count == 0)
            {
                return;
            }
            using (var f = new UserDetailForm(UserCurrent as UserModel))
            {
                if (f.ShowDialog(this) == DialogResult.Cancel)
                {
                    this.RefreshData();
                }
            }
        }

        private void addUserSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var currentStream = new MemoryStream())
                {
                    userModelGridView.SaveLayoutToStream(currentStream);
                    currentStream.Seek(0, System.IO.SeekOrigin.Begin);

                    userModelGridView.RestoreLayoutFromStream(memStream);
                    memStream.Seek(0, System.IO.SeekOrigin.Begin);

                    if (presenter.Addnew())
                    {
                        using (var f = new UserDetailForm(UserCurrent as UserModel))
                        {
                            userModelGridView.MoveLast();
                            if (f.ShowDialog(this) == DialogResult.Cancel)
                            {
                                presenter.Delete();
                            }
                        }
                    }

                    userModelGridView.RestoreLayoutFromStream(currentStream);
                    currentStream.Seek(0, System.IO.SeekOrigin.Begin);
                }
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("", ex);
                }
                return;
            }

        }

        private void exportUserSimpleButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteUserSimpleButton_Click(object sender, EventArgs e)
        {
            presenter.Delete();
        }

        public List<UserModel> UserItems
        {
            get
            {
                return userModelBindingSource.DataSource as List<UserModel>;
            }
            set
            {
                userModelBindingSource.DataSource = value;
            }
        }

        public UserModel UserCurrent
        {
            get { return userModelBindingSource.Current as UserModel; }
        }

        public void RefreshData()
        {
            userModelGridControl.RefreshDataSource();
        }

        private void userModelGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "")
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
    }
}