/********************************************************************
	Class file: 
    Author: Nguyen Minh Tri
    Date Created: 14/09/2014
	Last Updated: 14/09/2014
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
    public class KhachhangPresenter : Presenter<IKhachhangView>
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;

        public KhachhangPresenter(IKhachhangView view)
            : base(view)
        { }

        public void DisplayNhomKhachhang()
        {
            //try
            //{
                var listNhomKhachhang = new List<NhomKhachhangModel>();
                listNhomKhachhang.Add(new NhomKhachhangModel
                {
                    NhomKhachhangId = new Guid("00000000-0000-0000-0000-000000000000"),
                    TenNhomKhachhang = "Tất cả",
                    Active=false
                });
                listNhomKhachhang.AddRange(Model.Get<NhomKhachhangModel>("sys_NhomKhachhangSelect"));

                View.NhomKhachhangItems = listNhomKhachhang;
                View.RefreshDataNhomKhachhang();
            //}
            //catch (System.Exception ex)
            //{
            //    //Check log flag and log error to file.
            //    if (isErrorEnabled)
            //    {
            //        logger.Error("sys_NhomKhachhangSelect", ex);
            //    }
            //    return;
            //}
        }

        public void DisplayKhachhangTheoNhom()
        {
            //try
            //{
                var currentId = View.NhomKhachhangCurrentId as Guid?;
                if (currentId == null)
                {
                    return;
                }

                var items = new List<AutoItem>();
                items.Add(new AutoItem
                {
                    Name = "NhomKhachhangId",
                    Value = currentId,
                    SqlType = System.Data.SqlDbType.UniqueIdentifier
                });

                View.KhachhangItems = Model.Get<KhachhangModel>(new AutoObject
                {
                    Items = items,
                    SpName = "Tri_GetKhachhangTheoNhomKhachhang"
                });
                View.RefreshData();
            //}
            //catch (System.Exception ex)
            //{
            //    //Check log flag and log error to file.
            //    if (isErrorEnabled)
            //    {
            //        logger.Error("Tri_GetKhachhangTheoNhomKhachhang", ex);
            //    }
            //    return;
            //}
        }

        public bool Addnew()
        {
            try
            {
                var currentId = View.NhomKhachhangCurrentId as Guid?;
                if (currentId == null)
                {
                    return false;
                }
                var NhomKhachhangCurrent = View.NhomKhachhangItems.FirstOrDefault(p => p.NhomKhachhangId == currentId);
                if (NhomKhachhangCurrent != null)
                {
                    if (NhomKhachhangCurrent.Active == false)
                    {
                        return false;
                    }
                }
                View.KhachhangItems.Add(new KhachhangModel
                {
                    NhomKhachhangId = currentId,
                    Active = true,
                    NgayCapnhat = DateTime.Now
                });
                View.RefreshData();
                return true;
            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("", ex);
                }
                return false;
            }
        }

        public bool Save()
        {
            try
            {
                foreach (var item in View.KhachhangItems)
                {
                    if (item.State == RowState.Insert || item.State == RowState.Update)
                    {
                        item.NgayCapnhat = DateTime.Now;
                    }
                }
                Model.Set(View.KhachhangItems);
                View.RefreshData();
                return true;
            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("Save", ex);
                }
                return false;
            }
        }

        public void Delete()
        {
            try
            {
                var current = View.KhachhangCurrent as KhachhangModel;
                if (current == null)
                {
                    return;
                }

                if (current.State == RowState.Insert)
                {
                    View.KhachhangItems.Remove(current);
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
                    logger.Error(string.Format("state: {0}", View.KhachhangCurrent.State), ex);
                }
                return;
            }
        }
    }
}
