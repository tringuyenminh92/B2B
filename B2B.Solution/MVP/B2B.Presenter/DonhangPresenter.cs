// ***********************************************************************
// Assembly         : B2B.Presenter
// Author           : Ga9286
// Created          : 22-9-2014
//
// Last Modified By : Ga9286
// Last Modified On : 22-11-2014
// ***********************************************************************


using B2B.Model;
using B2B.View;
using BMIModel;
using BusinessObject;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// The Presenter namespace.
/// </summary>
namespace B2B.Presenter
{
    /// <summary>
    /// Class DonhangPresenter.
    /// </summary>
    public class DonhangPresenter : Presenter<IDonhangView>
    {
        /// <summary>
        /// The logger
        /// </summary>
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        /// The is error enabled
        /// </summary>
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        /// <summary>
        /// Initializes a new instance of the <see cref="DonhangPresenter" /> class.
        /// </summary>
        /// <param name="view">The view.</param>
        public DonhangPresenter(IDonhangView view)
            : base(view)
        { }
        /// <summary>
        /// Displays the loai donhang.
        /// </summary>
        public void DisplayLoaiDonhang()
        {
            try
            {
                var listLoaiDonhang = new List<LoaiDonhangModel>();
                listLoaiDonhang.Add(new LoaiDonhangModel
                {
                    LoaiDonhangValue = -1,
                    TenLoaiDonhang = "Tất Cả"
                });
                listLoaiDonhang.AddRange(LoaiDonhangModel.listLoaiDonhang);
                View.LoaiDonhangItems = listLoaiDonhang;
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
        /// Displays this instance.
        /// </summary>
        public void Display()
        {
            try
            {
                //Check loaidonhang's filter value null
                if (!View.LoaiDonhangCurrentValue.HasValue)
                {
                    return;
                }

                var items = new List<AutoItem>();
                items.Add(new AutoItem
                {
                    Name = "Ngaylap",
                    Value = View.filterValue,
                    SqlType = System.Data.SqlDbType.DateTime
                });
                items.Add(new AutoItem
                {
                    Name = "LoaiDonhangValue",
                    Value = View.LoaiDonhangCurrentValue.Value,
                    SqlType = System.Data.SqlDbType.Int
                });
                View.DonhangItems = Model.Get<DonhangModel>(new AutoObject
                {
                    Items = items,
                    SpName = "Tri_GetDonhangTheoThang"
                });
                View.RefreshData();
            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error(string.Format("NgayLap: {0}, LoaiDonhangValue: {1},SProc: {2} - {3}", View.filterValue,
                            View.LoaiDonhangCurrentValue.Value, "Tri_GetDonhangTheoThang", "Tri_GetTinhtrangDonhangCurrent"), ex);
                }
            }
        }

        /// <summary>
        /// Addnews this instance.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Addnew()
        {
            //try//{
            var items = new List<AutoItem>();
            items.Add(new AutoItem
            {
                Name = "UserId",
                SqlType = System.Data.SqlDbType.UniqueIdentifier,
                Value = ModelCore.UserId
            });
            var nhanvienCurrent = Model.Get<NhanvienModel>(new AutoObject
            {
                Items = items,
                SpName = "Vinh_GetNhanvienTheoUserId"
            });

            if (nhanvienCurrent == null)
            {
                return false;
            }

            var khoItems = Model.Get<KhoModel>("sys_KhoSelect");
            if (khoItems.Count == 0)
            {
                return false;
            }
            if (!View.LoaiDonhangCurrentValue.HasValue || View.LoaiDonhangCurrentValue.Value < 0)
            {
                View.LoaiDonhangCurrentValue = 0;
            }
            var donhang = new DonhangModel
            {
                LoaiDonhang = View.LoaiDonhangCurrentValue.Value,
                Step = View.LoaiDonhangCurrentValue.Value,
                KhoId = khoItems[0].KhoId,
                Ngaylap = DateTime.Now,
                NhanvienId = nhanvienCurrent[0].NhanvienId,
                TenNhanvienLap = nhanvienCurrent[0].TenNhanvien,
                NgayCapnhat = DateTime.Now,
                NhanvienCapnhatId = nhanvienCurrent[0].NhanvienId,
                TenNhanvienCapnhat = nhanvienCurrent[0].TenNhanvien,
                ChitietDonhangItems = new List<ChitietDonhangModel>(),
                Tongtien = 0,
                Ngaygiao=DateTime.Now
            };

            //Get Tinhtrang Dalap to assign new Tinhtrang
            var itemsTinhtrang = new List<AutoItem>();
            itemsTinhtrang.Add(new AutoItem
            {
                Name = "Code",
                Value = "TTDH01",
                SqlType = System.Data.SqlDbType.NVarChar
            });

            var TinhtrangDalaps = Model.Get<TinhtrangModel>(new AutoObject
            {
                Items = itemsTinhtrang,
                SpName = "Tri_GetTinhtrangDalap"
            });
            if (TinhtrangDalaps.Count == 0)
            {
                return false;
            }
            donhang.TinhtrangDonhangCurrentId = TinhtrangDalaps[0].TinhtrangId;

            //Set default value for SoluongConlai,SoluongGiao
            foreach (var ctdh in donhang.ChitietDonhangItems)
            {
                ctdh.SoluongConlai = 0;
                ctdh.SoluongGiao = 0;
            }

            //Add to list Donhang
            View.DonhangItems.Add(donhang);
            View.RefreshData(); return true;
            //}
            //catch (Exception ex)
            //{
            //    //Check log flag and log error to file.
            //    if (isErrorEnabled)
            //    {
            //        logger.Error("Vinh_GetNhanvienTheoUserId", ex);
            //    }
            //    return false;
            //}
        }

        /// <summary>
        /// Saves this instance.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Save()
        {
            try
            {
                //Get nhanvien Current to save to NhanvienCapnhat
                var items = new List<AutoItem>();
                items.Add(new AutoItem
                {
                    Name = "UserId",
                    SqlType = System.Data.SqlDbType.UniqueIdentifier,
                    Value = ModelCore.UserId
                });
                var nhanvienCurrent = Model.Get<NhanvienModel>(new AutoObject
                {
                    Items = items,
                    SpName = "Vinh_GetNhanvienTheoUserId"
                });

                if (nhanvienCurrent.Count < 1)
                {
                    return false;
                }

                View.DonhangItems.Where(d => d.State == RowState.Update)
                    .All(d =>
                    {
                        d.NhanvienId = nhanvienCurrent[0].NhanvienId;
                        d.TenNhanvienCapnhat = nhanvienCurrent[0].HovatenNhanvien;
                        return true;
                    });

                var listDonhangThaydoi = View.DonhangItems.Where(p => p.State == RowState.Insert || p.State == RowState.Update).ToList();

                //Save list Donhang
                Model.Set(View.DonhangItems);

                //Save New TinhtrangDonhang and List ChitietDonhang
                foreach (var dh in listDonhangThaydoi)
                {
                    //Insert new line TinhtrangDonhang to table TinhtrangDonhang
                    var tinhtrangDonhang = new TinhtrangDonhangModel
                    {
                        DonhangId = dh.DonhangId,
                        TinhtrangId = dh.TinhtrangDonhangCurrentId,
                        NgayCapnhat = DateTime.Now
                    };
                    Model.Set(tinhtrangDonhang);
                    Model.Set(dh.ChitietDonhangItems);
                }

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

        private void SaveTonkho()
        {

        }

        /// <summary>
        /// Deletes this instance.
        /// </summary>
        public bool Delete()
        {
            try
            {
                var DonhangCurrent = View.DonhangCurrent as DonhangModel;
                if (DonhangCurrent == null)
                {
                    return false;
                }

                if (DonhangCurrent.State == RowState.Insert)
                {
                    View.DonhangItems.Remove(DonhangCurrent);
                    View.RefreshData();
                    return true;
                }
                DonhangCurrent.MakeDelete();
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
    }
}
