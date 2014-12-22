// ***********************************************************************
// Assembly         : B2B.Model
// Author           : Ga9286
// Created          : 04-11-2014
//
// Last Modified By : Ga9286
// Last Modified On : 04-11-2014
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace B2B.Model
{
    /// <summary>
    /// Class TinhtrangModel.
    /// </summary>
    public partial class TinhtrangModel
    {
        /// <summary>
        /// Gets the ten loai tinhtrang.
        /// </summary>
        /// <value>The ten loai tinhtrang.</value>
        public string TenLoaiTinhtrang
        {
            get
            {
                return LoaiTinhtrangModel.GetTenloaiTinhtrang(Step.Value);
            }
        }
    }
}
