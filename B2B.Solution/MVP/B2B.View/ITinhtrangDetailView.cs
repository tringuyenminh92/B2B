using B2B.Model;
using BMIModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.View
{
    public interface ITinhtrangDetailView : IView
    {
        List<LoaiTinhtrangModel> LoaiTinhtrangItems { get; set; }

        TinhtrangModel Value { get; set; }
    }
}
