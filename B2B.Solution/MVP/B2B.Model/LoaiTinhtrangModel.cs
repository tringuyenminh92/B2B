// ***********************************************************************
// Assembly         : B2B.Model
// Author           : Ga9286
// Created          : 27-10-2014
//
// Last Modified By : Ga9286
// Last Modified On : 27-10-2014
// ***********************************************************************

using System.Collections.Generic;

namespace B2B.Model
{
    public partial class LoaiTinhtrangModel
    {

        public int LoaiTinhtrangValue { get; set; }

        public string TenloaiTinhtrang { get; set; }

        public static List<LoaiTinhtrangModel> listLoaiTinhtrang = new List<LoaiTinhtrangModel>()
        {
            new LoaiTinhtrangModel { LoaiTinhtrangValue = 0, TenloaiTinhtrang = "Đơn hàng" },
            new LoaiTinhtrangModel { LoaiTinhtrangValue = 1, TenloaiTinhtrang = "Phiếu xuất" },
            new LoaiTinhtrangModel { LoaiTinhtrangValue = 2, TenloaiTinhtrang = "Phiếu nhập" }
        };

        /// <summary>
        /// The list nhom
        /// </summary>
        private static Dictionary<int, string> listNhom = new Dictionary<int, string>()
        {
            { 0, "Đơn hàng" },
            { 1, "Phiếu xuất" },
            { 2, "Phiếu nhập" }
        };

        public static string GetTenloaiTinhtrang(int value)
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
