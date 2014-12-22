// ***********************************************************************
// Assembly         : B2B.Model
// Author           : Ga9286
// Created          : 08-11-2014
//
// Last Modified By : Ga9286
// Last Modified On : 08-11-2014
// ***********************************************************************
using System.Collections.Generic;

/// <summary>
/// The Model namespace.
/// </summary>
namespace B2B.Model
{
    /// <summary>
    /// Class LoaiNguyennhanModel.
    /// </summary>
    public class LoaiNguyennhanModel
    {
        /// <summary>
        /// Gets or sets the loai nguyennhan value.
        /// </summary>
        /// <value>The loai nguyennhan value.</value>
        public int LoaiNguyennhanValue { get; set; }

        /// <summary>
        /// Gets or sets the ten loai nguyennhan.
        /// </summary>
        /// <value>The ten loai nguyennhan.</value>
        public string TenLoaiNguyennhan { get; set; }

        /// <summary>
        /// The list loai nguyennhan
        /// </summary>
        public static List<LoaiNguyennhanModel> listLoaiNguyennhan = new List<LoaiNguyennhanModel>()
        {
            new LoaiNguyennhanModel { LoaiNguyennhanValue = 0, TenLoaiNguyennhan = "Đơn hàng" },
            new LoaiNguyennhanModel { LoaiNguyennhanValue = 1, TenLoaiNguyennhan = "Phiếu xuất" },
            new LoaiNguyennhanModel { LoaiNguyennhanValue = 2, TenLoaiNguyennhan = "Phiếu nhập" }
        };

        /// <summary>
        /// The list nhom
        /// </summary>
        private static Dictionary<int, string> listNhom = new Dictionary<int, string>()
        {
            { 0, "Đơn hàng" },
            { 1, "Phiếu xuất" },
              { 2, "Phiếu nhập"}
        };
        /// <summary>
        /// Gets the ten loai nguyennhan.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        public static string GetTenLoaiNguyennhan(int value)
        {
            string kq = "";
            if (listNhom.TryGetValue(value, out kq))
            {
                return kq;
            }
            return "";
        }
    }
}
