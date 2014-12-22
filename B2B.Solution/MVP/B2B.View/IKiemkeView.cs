using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMIModel;
using B2B.Model;

namespace B2B.View
{
    public interface IKiemkeView:IView
    {
        DateTime timeValue { get; }

        void RefeshKiemke();

        List<Model.KiemkeModel> KiemkeItems { get; set; }
        KiemkeModel KiemkeCurrent { get; set; }
        List<Model.ChitietKiemkeModel> ChitietKiemkeItems { get; set; }
        ChitietKiemkeModel ChitietKiemkeCurrent { get; set; }
        NhanvienModel NhanvienCapnhat { get; set; }

        List<HanghoaModel> HanghoaItems { get; set; }

        void RefeshHanghoa();

        object KhoValue { get; set; }
        Guid? HanghoaCurrentId { get; }
        string TenHanghoaCurrent { get; }
        int? SoluongTonValue { get; }
        int? SoluongThucValue { get; }
        string GhichuValue { get; }


        void RefeshChitietKiemke();
    }
}
