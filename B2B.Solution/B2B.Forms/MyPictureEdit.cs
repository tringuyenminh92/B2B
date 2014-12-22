// ***********************************************************************
// Assembly         : B2B.Forms
// Author           : Ga9286
// Created          : 01-11-2014
//
// Last Modified By : Ga9286
// Last Modified On : 01-11-2014
// ***********************************************************************
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

/// <summary>
/// The Forms namespace.
/// </summary>
namespace B2B.Forms
{
    /// <summary>
    /// Class MyPictureEdit. This class cannot be inherited.
    /// </summary>
    sealed public class MyPictureEdit : PictureEdit
    {

        /// <summary>
        /// PictureEdit menu
        /// </summary>
        PictureMenu _Menu;

        /// <summary>
        /// Path and name of the Image loaded in this PictureEdit
        /// </summary>
        private string _FileName;

        /// <summary>
        /// Gets or sets the path and name of the Image loaded in this PictureEdit
        /// </summary>
        /// <value>The name of the file.</value>
        public string FileName
        {
            get { return _FileName; }
            set { _FileName = value; }
        }

        /// <summary>
        /// Gets the popup menu assigned to this PictureEdit
        /// </summary>
        /// <value>The menu.</value>
        protected override PictureMenu Menu
        {
            get
            {
                if (_Menu == null) 
                    _Menu = new MyPictureMenu(this);
                return _Menu;
            }
        }


        /// <summary>
        /// Initializes a new instance fo the MyPictureEdit class
        /// </summary>
        public MyPictureEdit() : base() { }

    }


    /// <summary>
    /// Class MyPictureMenu. This class cannot be inherited.
    /// </summary>
    sealed public class MyPictureMenu : PictureMenu
    {

        /// <summary>
        /// Initializes a new instance of the MyPictureMenu class
        /// </summary>
        /// <param name="menuControl">PictureEdit menu</param>
        public MyPictureMenu(IPictureMenu menuControl) : base(menuControl) { }



        /// <summary>
        /// Pastes the image.
        /// </summary>
        /// <param name="im">The im.</param>
        protected override void PasteImage(Image im)
        {
            FieldInfo fi = typeof(PictureMenu).GetField("openFile", BindingFlags.Instance | BindingFlags.NonPublic);
            
            if (fi == null) 
                return;


            OpenFileDialog od = (fi.GetValue(this) as OpenFileDialog);

            string fileName = od.FileName;

            MyPictureEdit pe = (MenuControl as MyPictureEdit);
            
            if (pe != null) 
                pe.FileName = fileName;
            
            base.PasteImage(im);
        }
    }

}
