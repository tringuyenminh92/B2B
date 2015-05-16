/***********************************
Author: Lý Hoàng Tín
Date Created: 13/01/2014
Last Updated: 14/01/2014
Updated By: Lý Hoàng Tín
Update description: 
************************************/

using System.Collections.Generic;
using B2B.Model;
using BMIModel;

namespace B2B.View
{
    public interface ICongnoNhapView : IView
    {
        List<CongnoNhapModel> CongnoNhapItems { get; set; }
    }
}