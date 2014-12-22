// ***********************************************************************
// Assembly         : B2B.Presenter
// Author           : Ga9286
// Created          : 08-11-2014
//
// Last Modified By : Ga9286
// Last Modified On : 09-11-2014
// ***********************************************************************
using B2B.Model;
using B2B.View;
using BMIModel;
using BusinessObject;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// The Presenter namespace.
/// </summary>
namespace B2B.Presenter
{
    /// <summary>
    /// Class NguyennhanPresenter.
    /// </summary>
    public class NguyennhanPresenter : Presenter<INguyennhanView>
    {
        //Create instance of logger for using log4net methods
        /// <summary>
        /// The logger
        /// </summary>
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        /// <summary>
        /// The is error enabled
        /// </summary>
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;
        /// <summary>
        /// Initializes a new instance of the <see cref="NguyennhanPresenter"/> class.
        /// </summary>
        /// <param name="view">The view.</param>
        public NguyennhanPresenter(INguyennhanView view)
            : base(view)
        { }

        /// <summary>
        /// Displays the loai nguyennhan.
        /// </summary>
        public void DisplayLoaiNguyennhan()
        {
            try
            {
                var listNguyennhan = new List<LoaiNguyennhanModel>();
                listNguyennhan.Add(new LoaiNguyennhanModel { LoaiNguyennhanValue = -1, TenLoaiNguyennhan = "Tất cả" });
                listNguyennhan.AddRange(LoaiNguyennhanModel.listLoaiNguyennhan);
                View.LoaiNguyennhanItems = listNguyennhan;
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("", ex);
                }
            }
        }

        /// <summary>
        /// Displays the nguyenhan theo loai.
        /// </summary>
        public void DisplayNguyenhanTheoLoai()
        {
            try
            {
                var items = new List<AutoItem>();
                items.Add(new AutoItem
                {
                    Name = "LoaiNguyennhanValue",
                    Value = View.LoaiNguyennhanCurrentValue,
                    SqlType = System.Data.SqlDbType.Int
                });
                View.NguyennhanItems = Model.Get<NguyennhanLydoModel>(new AutoObject
                {
                    SpName = "Tri_GetNguyennhanTheoLoai",
                    Items = items
                });
                View.RefreshData();
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("", ex);
                }

            }
        }

        /// <summary>
        /// Addnews this instance.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Addnew()
        {
            try
            {
                if (!View.LoaiNguyennhanCurrentValue.HasValue)
                {
                    return false;
                }
                View.NguyennhanItems.Add(new NguyennhanLydoModel
                {
                    Step = View.LoaiNguyennhanCurrentValue.Value < 0 ? 0 : View.LoaiNguyennhanCurrentValue.Value,
                    Active = true
                });
                View.RefreshData();
                return true;
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("", ex);
                }
                return false;
            }
        }

        /// <summary>
        /// Deletes this instance.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Delete()
        {
            var NguyennhanCurrent = View.NguyennhanCurrent as NguyennhanLydoModel;
            if (NguyennhanCurrent == null)
            {
                return false;
            }
            if (NguyennhanCurrent.State == RowState.Insert)
            {
                View.NguyennhanItems.Remove(NguyennhanCurrent);
                View.RefreshData();
                return true;
            }
            NguyennhanCurrent.MakeDelete();
            View.RefreshData();
            return true;
        }

        /// <summary>
        /// Saves this instance.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Save()
        {
            try
            {
                Model.Set(View.NguyennhanItems);
                return true;
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("", ex);
                }
                return false;
            }
        }
    }
}
