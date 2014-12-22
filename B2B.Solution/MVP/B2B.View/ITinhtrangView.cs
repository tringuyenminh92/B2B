// ***********************************************************************
// Assembly         : B2B.View
// Author           : Ga9286
// Created          : 27-10-2014
//
// Last Modified By : Ga9286
// Last Modified On : 27-10-2014
// ***********************************************************************
using B2B.Model;
using BMIModel;
using System.Collections.Generic;


namespace B2B.View
{
    public interface ITinhtrangView:IView
    {
      
        List<TinhtrangModel> TinhtrangItems { get; set; }

        TinhtrangModel TinhtrangCurrent { get;}

        List<LoaiTinhtrangModel> LoaiTinhtrangItems { get; set; }

        int? LoaiTinhtrangCurrentValue { get; }
    }
}
