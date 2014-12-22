/********************************************************************
	Class file: 
    Author: Pham Xuân Vinh
    Date Created: 04/09/2014
	Last Updated: 19/09/2014
	Updated By: Pham Xuân Vinh
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
using System.Data;

namespace B2B.Presenter
{
    public class HanghoaPresenter : Presenter<IHanghoaView>
    {
        //Create instance of logger for using log4net methods
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //Flag to check if error level was enabled.
        private static readonly bool isErrorEnabled = logger.IsErrorEnabled;


        public HanghoaPresenter(IHanghoaView view)
            : base(view)
        {
        }

        public void Display()
        {
            try
            {
                View.HanghoaItems = Model.Get<HanghoaModel>("Khuyen_GetHanghoa");
                View.RefreshData();
            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("Khuyen_GetHanghoa", ex);
                }
                return;
            }
        }

        public bool Addnew()
        {
            try
            {
                var currentId = View.NhomHanghoaCurrentId as Guid?;

                if (currentId == null)
                {
                    return false;
                }

                var NhomHannghoaCurrent = View.NhomHanghoaItems.FirstOrDefault(p => p.NhomHanghoaId == currentId);

                if(NhomHannghoaCurrent != null)
                {
                    if(NhomHannghoaCurrent.Active == false)
                    {
                        return false;
                    }
                    View.HanghoaItems.Add(new HanghoaModel() 
                    { 
                        NgayCapnhat = DateTime.Now,
                        NhomHanghoaId = currentId,
                        TenNhomhanghoa = NhomHannghoaCurrent.TenNhomHanghoa,
                        Active = true 
                    });
                }
                View.RefreshData();
                return true;
            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("Add new", ex);
                }
                return false;
            }
        }

        public bool Save()
        {
            try
            {
                foreach (var item in View.HanghoaItems)
                {
                    item.NgayCapnhat = DateTime.Now;
                }
                Model.Set(View.HanghoaItems);
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
                var current = View.HanghoaCurrent as HanghoaModel;
                if (current == null)
                {
                    return;
                }
                if (current.State == BusinessObject.RowState.Insert)
                {
                    View.HanghoaItems.Remove(current);
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
                    logger.Error(string.Format("Delete id: {0} ", View.HanghoaCurrent.HanghoaId), ex);
                }
                return;
            }
        }

        public void DisplayNhomHanghoa()
        {
            try
            {
                var listNhomHanghoa = new List<NhomHanghoaModel>();
                listNhomHanghoa.Add(new NhomHanghoaModel
                {
                    NhomHanghoaId = new Guid("00000000-0000-0000-0000-000000000000"),
                    TenNhomHanghoa = "Tất cả",
                    Active = false
                });

                listNhomHanghoa.AddRange(Model.Get<NhomHanghoaModel>("sys_NhomHanghoaSelect"));

                View.NhomHanghoaItems = listNhomHanghoa;
                View.RefreshDataNhomHanghoa();
            }
            catch (System.Exception ex)
            {
                //Check log flag and log error to file.
                if (isErrorEnabled)
                {
                    logger.Error("sys_NhomHanghoaSelect", ex);
                }
                return;
            }

        }

        public void DisplayHanghoaTheoNhom()
        {
            try
            {
                var currentId = View.NhomHanghoaCurrentId as Guid?;
                if (currentId == null)
                {
                    return;
                }
                
                var items = new List<AutoItem>();
                items.Add(new AutoItem
                {
                    Name = "NhomHanghoaId",
                    Value = currentId,
                    SqlType = System.Data.SqlDbType.UniqueIdentifier
                });

                View.HanghoaItems = Model.Get<HanghoaModel>(new AutoObject
                {
                    Items = items,
                    SpName = "Khuyen_GetHanghoaTheoNhom"
                });

                View.RefreshData();
            }
            catch (System.Exception ex)
            {
            	//Check log flag and log error to file.
            	if (isErrorEnabled)
            	{
                    logger.Error(string.Format("Name: {0} SpName: {1}", "NhomHanghoaId", "Khuyen_GetHanghoaTheoNhom"), ex);
            	}
            	return;
            }
        }
    }
}
