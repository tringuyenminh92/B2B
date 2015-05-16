// ***********************************************************************
// Assembly         : B2B.Presenter
// Author           : Ga9286
// Created          : 11-12-2014
//
// Last Modified By : Ga9286
// Last Modified On : 14-12-2014
// ***********************************************************************

using B2B.Model;
using B2B.View;
using BMIModel;
using BusinessObject;
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
    /// Class TonkhoPresenter.
    /// </summary>
    public class TonkhoPresenter : Presenter<ITonkhoView>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TonkhoPresenter"/> class.
        /// </summary>
        /// <param name="view">The view.</param>
        public TonkhoPresenter(ITonkhoView view) : base(view) { }

        /// <summary>
        /// Displays the thangnam nhapxuat.
        /// </summary>
        public void DisplayThangnamNhapxuat()
        {
            
            View.ThangnamNhapxuatItems = Model.Get<ThangnamNhapxuatModel>("Tri_GetThangNamNhapXuat");
            View.RefreshDataThangnam();
        }
        /// <summary>
        /// Displays the tonkho theo thang.
        /// </summary>
        public void DisplayTonkhoTheoThang()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem
            {
                Name = "Ngay",
                SqlType = System.Data.SqlDbType.DateTime,
                Value = View.NgayThangnamFilter
            });
            View.TonkhoItems = Model.Get<TonkhoTheoNgayModel>(new AutoObject
            {
                SpName = "Tri_GetTonkhoTheoNgay",
                Items = items
            });
            View.RefreshData();
        }
    }
}
