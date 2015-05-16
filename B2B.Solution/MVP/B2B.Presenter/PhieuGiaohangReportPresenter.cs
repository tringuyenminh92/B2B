/********************************************************************
	Class file: 
    Author: Pham Xuan Vinh
    Date Created: 23/12/2014
	Last Updated: 29/12/2014
	Updated By: Pham Xuan Vinh
	Update Description:
*********************************************************************/

using B2B.Model;
using B2B.View;
using BMIModel;
using BusinessObject;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Presenter
{
    public class PhieuGiaohangReportPresenter : Presenter<IPhieuGiaohangReportView>
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        public PhieuGiaohangReportPresenter(IPhieuGiaohangReportView view) : base(view) { }

        public void DisplayChitietPhieuxuat()
        {
            if (View.ValuePhieuxuat == null)
            {
                return;
            }
            var items = new List<AutoItem>();
            items.Add(new AutoItem
            {
                Name = "PhieuxuatId",
                Value = View.ValuePhieuxuat.PhieuxuatId,
                SqlType = System.Data.SqlDbType.UniqueIdentifier
            });

            View.ValuePhieuxuat.ChitietPhieuxuatItems = Model.Get<ChitietPhieuxuatModel>(new AutoObject
            {
                Items = items,
                SpName = "Vinh_GetChitietPhieuxuatTheoPhieuxuat"
            }) as List<ChitietPhieuxuatModel>;
            var chitietPhieuxuatTemp = new List<ChitietPhieuxuatModel>();
            for (int i = 0; i < View.ValuePhieuxuat.ChitietPhieuxuatItems.Count;++i )
            {
                if (View.ValuePhieuxuat.ChitietPhieuxuatItems[i].Soluong == 0)
                    chitietPhieuxuatTemp.Add(View.ValuePhieuxuat.ChitietPhieuxuatItems[i]);
            }
            for (int i = 0; i < chitietPhieuxuatTemp.Count; ++i)
            {
                View.ValuePhieuxuat.ChitietPhieuxuatItems.Remove(chitietPhieuxuatTemp[i]);
            }

        }

        public void DisplayThongtinKhachhang()
        {
            if (View.ValuePhieuxuat == null)
            {
                return;
            }
            var items = new List<AutoItem>();
            items.Add(new AutoItem
            {
                Name = "PhieuxuatId",
                Value = View.ValuePhieuxuat.PhieuxuatId,
                SqlType = System.Data.SqlDbType.UniqueIdentifier
            });
            var Donhang = Model.Get<DonhangModel>(new AutoObject
            {
                Items = items,
                SpName = "Vinh_GetKhachhangTheoPhieuxuat"
            }) as List<DonhangModel>;

            if (Donhang.Count != 0)
            {
                View.ValuePhieuxuat.Donhang = Donhang[0];
            }

        }
    }
}
