
/********************************************************************
	Class file: 
    Author: Tran Nguyen Hoang Khuyen
    Date Created: 17/01/2015
	Last Updated: 20/01/2015
	Updated By: Tran Nguyen Hoang Khuyen
	Update Description:
*********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B2B.View;
using BMIModel;
using log4net;
using B2B.Model;
using BusinessObject;

namespace B2B.Presenter
{
    public class ThuchiPresenter:Presenter<IThuchiView>
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        public ThuchiPresenter(IThuchiView view) : base(view) { }

        public void DisplayThuchi()
        {
            try
            {
                View.ThuchiItems = Model.Get<ThuchiModel>("Khuyen_GetThuchi");
            }
            catch (System.Exception ex)
            {
            	//Check log flag and log error to file.
            	if (isErrorEnabled)
            	{
                    logger.Error("Khuyen_GetThuchi", ex);
            	}
            	return;
            }
        }

        public bool AddnewPhieuthu()
        {
            try
            {
                var phieuthu = new ThuchiModel()
                {
                    PhieuxuatId = new Guid("00000000-0000-0000-0000-000000000000"),
                    NhanvienId = View.NhanvienCapNhat.NhanvienId,
                    TenNhanvien = View.NhanvienCapNhat.HovatenNhanvien,
                    Vaoluc = DateTime.Now,
                    Ngay = DateTime.Now.Day,
                    Thang = DateTime.Now.Month,
                    Nam = DateTime.Now.Year,
                };
                    //ThuchiModel phieuthu = new ThuchiModel();
                    //phieuthu.PhieuxuatId = new Guid("00000000-0000-0000-0000-000000000000");
                    //phieuthu.NhanvienId = View.NhanvienCapNhat.NhanvienId;
                View.ThuchiItems.Add(phieuthu);
                    View.RefreshData();
                    return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }
        }

        public void DisplayNhanvienCapnhat()
        {
            var items = new List<AutoItem>();
            items.Add(new AutoItem
            {
                Name = "UserId",
                Value = ModelCore.UserId,
                SqlType = System.Data.SqlDbType.UniqueIdentifier
            });

            View.NhanvienCapNhat = Model.Get<NhanvienModel>(new AutoObject
            {
                Items = items,
                SpName = "Vinh_GetNhanvienTheoUserId"
            }).FirstOrDefault();
        }
        
        public void Delete()
        {
            try
            {
                var currentPhieuthu = View.ThuchiCurent as ThuchiModel;
                if (currentPhieuthu == null)
                {
                    return;
                }
                View.ThuchiItems.Remove(currentPhieuthu);
                View.RefreshData();
            }
            catch (System.Exception ex)
            {
            	//Check log flag and log error to file.
            	if (isErrorEnabled)
            	{
            		logger.Error("Delete Phieuthu", ex);
            	}
            	return;
            }
        }



        public bool AddnewPhieuchi()
        {
            try
            {
                var phieuchi = new ThuchiModel()
                {
                    PhieunhapId = new Guid("00000000-0000-0000-0000-000000000000"),
                    NhanvienId = View.NhanvienCapNhat.NhanvienId,
                    TenNhanvien = View.NhanvienCapNhat.HovatenNhanvien,
                    Vaoluc = DateTime.Now,
                    Ngay = DateTime.Now.Day,
                    Thang = DateTime.Now.Month,
                    Nam = DateTime.Now.Year,
                };
                View.ThuchiItems.Add(phieuchi);
                View.RefreshData();
                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }
        }
    }
}
