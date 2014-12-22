
// ***********************************************************************
// Assembly         : B2B.View
// Author           : Ga9286
// Created          : 08-11-2014
//
// Last Modified By : Ga9286
// Last Modified On : 08-11-2014
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
    /// Interface INguyennhanDetailView
    /// </summary>
    public interface INguyennhanDetailView:IView
    {
        List<LoaiNguyennhanModel> LoaiNguyennhanItems { get; set; }

        NguyennhanLydoModel Value { get; set; }
    }
}
