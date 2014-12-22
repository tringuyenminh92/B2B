using B2B.Model;
using BMIModel;
// ***********************************************************************
// Assembly         : B2B.View
// Author           : Ga9286
// Created          : 08-11-2014
//
// Last Modified By : Ga9286
// Last Modified On : 08-11-2014
// ***********************************************************************
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
    /// Interface INguyennhanView
    /// </summary>
    public interface INguyennhanView:IView
    {
        List<NguyennhanLydoModel> NguyennhanItems { get; set; }

        NguyennhanLydoModel NguyennhanCurrent { get; }

        List<LoaiNguyennhanModel> LoaiNguyennhanItems { get; set; }

        int? LoaiNguyennhanCurrentValue { get; }
    }
}
