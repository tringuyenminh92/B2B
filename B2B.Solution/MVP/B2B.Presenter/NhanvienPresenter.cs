/********************************************************************
	Class file: 
    Author: Nguyen Minh Tri
    Date Created: 30/08/2014
	Last Updated: 04/09/2014
	Updated By: Nguyen Minh Tri
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
    public class NhanvienPresenter : Presenter<INhanvienView>
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;


        public NhanvienPresenter(INhanvienView view)
            : base(view)
        {
        }

        public void Display()
        {
            try
            {
                View.NhanvienItems = Model.Get<NhanvienModel>("Tri_GetNhanvien");
                View.RefreshData();
            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("Tri_GetNhanvien", ex);
                }
                return;
            }
        }

        public void DisplayNhanvienTheoPhongban()
        {
            //try
            //{
                var PhongbanCurrentId = View.PhongbanCurrentId as Guid?;
                if (PhongbanCurrentId == null)
                {
                    return;
                }

                var items = new List<AutoItem>();

                items.Add(new AutoItem
                {
                    Name = "PhongbanId",
                    Value = PhongbanCurrentId,
                    SqlType = System.Data.SqlDbType.UniqueIdentifier
                });

                View.NhanvienItems = Model.Get<NhanvienModel>(new AutoObject
                {
                    Items = items,
                    SpName = "Tri_GetNhanvienTheoPhongban"
                });

                View.RefreshData();
            //}
            //catch (System.Exception ex)
            //{
            //    //Check log flag and log error to file.
            //    if (isErrorEnabled)
            //    {
            //        logger.Error(string.Format("Name: {0} SpName: {1}", "PhongbanId", "Tri_GetNhanvienTheoPhongban"), ex);
            //    }
            //    return;
            //}
        }

        public void DisplayPhongban()
        {
            try
            {
                var listPhongban = new List<PhongbanModel>();
                listPhongban.Add(new PhongbanModel
                {
                    PhongbanId = new Guid("00000000-0000-0000-0000-000000000000"),
                    TenPhongban = "Tất cả",
                    Active = false
                });
                listPhongban.AddRange(Model.Get<PhongbanModel>("sys_PhongbanSelect"));
                View.PhongbanItems = listPhongban;
                View.RefreshDataPhongban();
            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("sys_PhongbanSelect", ex);
                }
                return;
            }
        }
        public bool Addnew()
        {
            try
            {
                var PhongbanCurrentId = View.PhongbanCurrentId as Guid?;
                if (PhongbanCurrentId == null)
                {
                    return false;
                }
                var PhongbanCurrent = View.PhongbanItems.FirstOrDefault(p => p.PhongbanId == PhongbanCurrentId);
                if (PhongbanCurrent != null)
                {
                    if (PhongbanCurrent.Active == false)
                    {
                        return false;
                    }
                }
                View.NhanvienItems.Add(new NhanvienModel
                {
                    NgayCapnhat = DateTime.Now,
                    Active = true,
                    PhongbanId = PhongbanCurrent.PhongbanId,
                    TenPhongban=PhongbanCurrent.TenPhongban
                });
                View.RefreshData();
                return true;
            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("None", ex);
                }
                return false;
            }
        }

        public void Save()
        {
            try
            {
                foreach (var item in View.NhanvienItems)
                {
                    item.NgayCapnhat = DateTime.Now;
                }
                Model.Set(View.NhanvienItems);
                View.RefreshData();
            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("Save", ex);
                }
                return;
            }
        }

        public void Delete()
        {
            try
            {
                var current = View.NhanvienCurrent as NhanvienModel;
                if (current == null)
                {
                    return;
                }
                if (current.State == BusinessObject.RowState.Insert)
                {
                    View.NhanvienItems.Remove(current);
                    View.RefreshData();
                    return;
                }
                current.MakeDelete();
                View.RefreshData();
            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error(string.Format("id: {0} nhom: {1}", View.NhanvienCurrent.NhanvienId, View.NhanvienCurrent.TenPhongban), ex);
                }
                return;
            }
        }
    }
}
