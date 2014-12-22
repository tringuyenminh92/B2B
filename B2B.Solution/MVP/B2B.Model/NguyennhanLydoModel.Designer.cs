// ***********************************************************************
// Assembly         : B2B.Model
// Author           : Ga9286
// Created          : 08-11-2014
//
// Last Modified By : Ga9286
// Last Modified On : 08-11-2014
// ***********************************************************************

/// <summary>
/// The Model namespace.
/// </summary>
using System;
namespace B2B.Model
{
    /// <summary>
    /// Class NguyennhanLydoModel.
    /// </summary>
    public partial class NguyennhanLydoModel
    {
        public string TenLoaiNguyennhan
        {
            get
            {
                return LoaiNguyennhanModel.GetTenLoaiNguyennhan(Step.Value);
            }
        }
    }
}
