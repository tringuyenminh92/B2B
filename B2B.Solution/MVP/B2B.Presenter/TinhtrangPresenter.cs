// ***********************************************************************
// Assembly         : B2B.Presenter
// Author           : Ga9286
// Created          : 27-10-2014
//
// Last Modified By : Ga9286
// Last Modified On : 27-10-2014
// ***********************************************************************

using System.Reflection;
using B2B.View;
using BMIModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using B2B.Model;
using BusinessObject;

/// <summary>
/// The Presenter namespace.
/// </summary>
namespace B2B.Presenter
{
    /// <summary>
    /// Class TinhtrangPresenter.
    /// </summary>
    public class TinhtrangPresenter : Presenter<ITinhtrangView>
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        /// <summary>
        /// Initializes a new instance of the <see cref="TinhtrangPresenter"/> class.
        /// </summary>
        /// <param name="view">The view.</param>
        public TinhtrangPresenter(ITinhtrangView view)
            : base(view)
        { }

        public void DisplayTinhtrangTheoLoai()
        {
            try
            {
                if (!View.LoaiTinhtrangCurrentValue.HasValue)
                {
                    return;
                }
                var LoaiTinhtrangCurrent = View.LoaiTinhtrangCurrentValue.Value;
                var items = new List<AutoItem>();
                items.Add(new AutoItem
                {
                    Name = "LoaiTinhtrangValue",
                    SqlType = System.Data.SqlDbType.Int,
                    Value = LoaiTinhtrangCurrent
                });
                View.TinhtrangItems = Model.Get<TinhtrangModel>(new AutoObject
                {
                    Items = items,
                    SpName = "Tri_GetTinhtrangTheoLoai"
                });
                View.RefreshData();
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("Tri_GetTinhtrangTheoLoai", ex);
                }

            }
        }

        public void DisplayLoaiTinhtrang()
        {
            try
            {
                var LoaiTinhtrangItems = new List<LoaiTinhtrangModel>();
                LoaiTinhtrangItems.Add(new LoaiTinhtrangModel { LoaiTinhtrangValue = -1, TenloaiTinhtrang = "Tất cả" });
                LoaiTinhtrangItems.AddRange(LoaiTinhtrangModel.listLoaiTinhtrang);
                View.LoaiTinhtrangItems = LoaiTinhtrangItems;
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("LoaiDonhangModel.listLoaiDonhang", ex);
                }
            }
        }

        public bool Addnew()
        {
            try
            {
                if (!View.LoaiTinhtrangCurrentValue.HasValue)
                {
                    return false;
                }

                View.TinhtrangItems.Add(new TinhtrangModel
                {
                    Step = View.LoaiTinhtrangCurrentValue.Value < 0 ? 0 : View.LoaiTinhtrangCurrentValue.Value,
                    Active = true,
                    NgayCapnhat = DateTime.Now,
                });
                View.RefreshData();
                return true;
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("LoaiTinhtrangCurrentValue: " + View.LoaiTinhtrangCurrentValue.Value, ex);
                }
                return false;

            }

        }

        public bool Delete()
        {
            try
            {
                var Current = View.TinhtrangCurrent as TinhtrangModel;
                if (Current == null)
                {
                    return false;
                }
                if (Current.CanDelete.HasValue && Current.CanDelete.Value != true)
                {
                    return false;
                }
                if (Current.State == RowState.Insert)
                {
                    View.TinhtrangItems.Remove(Current);
                    View.RefreshData();
                    return true;
                }
                Current.MakeDelete();
                return true;
            }
            catch (Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("Delete Current", ex);
                }
                return false;
            }
        }
        public bool Save()
        {
            try
            {
                foreach (var item in View.TinhtrangItems)
                {
                    if (item.State == RowState.Insert || item.State == RowState.Update)
                    {
                        item.NgayCapnhat = DateTime.Now;
                    }
                }
                Model.Set(View.TinhtrangItems);
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

