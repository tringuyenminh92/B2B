// ***********************************************************************
// Assembly         : B2B.View
// Author           : Ga9286
// Created          : 01-12-2014
//
// Last Modified By : Ga9286
// Last Modified On : 04-12-2014
// ***********************************************************************
using B2B.Model;
using BMIModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// The View namespace.
/// </summary>
namespace B2B.View
{
    /// <summary>
    /// Interface ITonkhoView
    /// </summary>
    public interface ITonkhoView:IView
    {
        List<TonkhoTheoNgayModel> TonkhoItems { get; set; }

        List<ThangnamNhapxuatModel> ThangnamNhapxuatItems { get; set; }

        DateTime NgayThangnamFilter { get; }

        void RefreshDataThangnam();
    }
}
