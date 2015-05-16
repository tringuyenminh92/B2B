using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B2B.Model;
using BMIModel;

namespace B2B.View
{
    public interface IPhieunhapDetailView:IView
    {
        PhieunhapModel CurrentPhieunhap { get; set; }

        //ist<ChitietPhieunhapModel> ChitietPhieunhapItems { get; set; }

        ChitietPhieunhapModel ChitietPhieunhapCurrent { get; }

        List<HanghoaModel> HanghoaItems { get; set; }

        void RefreshDataHanghoa();

        Guid? CurrentHanghoaId { get; }

        DateTime HansudungValue { get; }

        string GhichuValue { get; }

        int SoluongValue { get; }
        double GianhapValue { get; }

        List<TinhtrangModel> TinhtrangItems { get; set; }

        List<NhaCungcapModel> NhacungcapItems { get; set; }

        List<KhoModel> KhoItems { get; set; }

        void RefreshDataNhacungcap();

        void RefreshDataKho();

        List<NguyennhanLydoModel> NguyennhanLydoItems { get; set; }

        void RefeshNguyennhanLydo();
    }
}
