// ***********************************************************************
// Assembly         : B2B.View
// Author           : Ga9286
// Created          : 11-10-2014
//
// Last Modified By : Ga9286
// Last Modified On : 11-10-2014
// ***********************************************************************
// <copyright file="IDonhangDetailView.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using B2B.Model;
using BMIModel;
using System;
using System.Collections.Generic;

namespace B2B.View
{
    /// <summary>
    /// Interface IDonhangDetailView
    /// </summary>
    public interface IDonhangDetailView:IView
    {
        List<KhachhangModel> KhachhangItems { get; set; }

        Guid? KhachhangCurrentId { get; set; }

        List<KhoModel> KhoItems { get; set; }

        Guid? KhoCurrentId { get; }

        List<LoaiDonhangModel> LoaiDonhangItems { get; set; }

        int LoaiDonhangCurrentValue { get; }

        List<TinhtrangModel> TinhtrangItems { get; set; }

        Guid? TinhtrangCurrentId { get; }

        List<HanghoaModel> HanghoaItems { get; set; }

        Guid? HanghoaCurrentId { get; }

        HanghoaModel HanghoaCurrent { get; set; }

        List<ChitietDonhangModel> ChitietDonhangItems { get; set; }

        ChitietDonhangModel ChitietDonhangCurrent { get; }

        DonhangModel Value { get; set; }
    }
}
