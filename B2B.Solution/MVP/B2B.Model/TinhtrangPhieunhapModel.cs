using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BMIModel;
using BusinessObject;

namespace B2B.Model
{
    public partial class TinhtrangPhieunhapModel : Bus
    {
        private Guid _TinhtrangPhieunhapId;
        private Nullable<Guid> _PhieunhapId;
        private Nullable<Guid> _TinhtrangId;
        private Nullable<Guid> _NhanvienCapnhat;
        private Nullable<DateTime> _NgayCapnhat;
        private Byte[] _Version;

        public TinhtrangPhieunhapModel()
        {
			OnCreating();
            TinhtrangPhieunhapId = ModelCore.GetGuidId();
			OnCreated();
        }

        public TinhtrangPhieunhapModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }

        
        [DisplayName("TinhtrangPhieunhapId")]
        public Guid TinhtrangPhieunhapId
        {
            get
			{
				Guid vGet = _TinhtrangPhieunhapId;
				OnTinhtrangPhieunhapIdGetting(ref _TinhtrangPhieunhapId, ref vGet);
				return vGet;
			}
            set
            {
                OnTinhtrangPhieunhapIdChanging(value);
                SetProperty(ref _TinhtrangPhieunhapId, value);
                OnTinhtrangPhieunhapIdChanged();
            }
        }
        
        
        [DisplayName("PhieunhapId")]
        public Nullable<Guid> PhieunhapId
        {
            get
			{
				Nullable<Guid> vGet = _PhieunhapId;
				OnPhieunhapIdGetting(ref _PhieunhapId, ref vGet);
				return vGet;
			}
            set
            {
                OnPhieunhapIdChanging(value);
                SetProperty(ref _PhieunhapId, value);
                OnPhieunhapIdChanged();
            }
        }
        
        
        [DisplayName("TinhtrangId")]
        public Nullable<Guid> TinhtrangId
        {
            get
			{
				Nullable<Guid> vGet = _TinhtrangId;
				OnTinhtrangIdGetting(ref _TinhtrangId, ref vGet);
				return vGet;
			}
            set
            {
                OnTinhtrangIdChanging(value);
                SetProperty(ref _TinhtrangId, value);
                OnTinhtrangIdChanged();
            }
        }
        
        
        [DisplayName("NhanvienCapnhat")]
        public Nullable<Guid> NhanvienCapnhat
        {
            get
			{
				Nullable<Guid> vGet = _NhanvienCapnhat;
				OnNhanvienCapnhatGetting(ref _NhanvienCapnhat, ref vGet);
				return vGet;
			}
            set
            {
                OnNhanvienCapnhatChanging(value);
                SetProperty(ref _NhanvienCapnhat, value);
                OnNhanvienCapnhatChanged();
            }
        }
        
        
        [DisplayName("NgayCapnhat")]
        public Nullable<DateTime> NgayCapnhat
        {
            get
			{
				Nullable<DateTime> vGet = _NgayCapnhat;
				OnNgayCapnhatGetting(ref _NgayCapnhat, ref vGet);
				return vGet;
			}
            set
            {
                OnNgayCapnhatChanging(value);
                SetProperty(ref _NgayCapnhat, value);
                OnNgayCapnhatChanged();
            }
        }
        
        
        [DisplayName("Version")]
        public Byte[] Version
        {
            get
			{
				Byte[] vGet = _Version;
				OnVersionGetting(ref _Version, ref vGet);
				return vGet;
			}
            set
            {
                OnVersionChanging(value);
                SetProperty(ref _Version, value);
                OnVersionChanged();
            }
        }
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnTinhtrangPhieunhapIdChanging(Guid value);
        partial void OnTinhtrangPhieunhapIdChanged();
		partial void OnTinhtrangPhieunhapIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnPhieunhapIdChanging(Nullable<Guid> value);
        partial void OnPhieunhapIdChanged();
		partial void OnPhieunhapIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnTinhtrangIdChanging(Nullable<Guid> value);
        partial void OnTinhtrangIdChanged();
		partial void OnTinhtrangIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnNhanvienCapnhatChanging(Nullable<Guid> value);
        partial void OnNhanvienCapnhatChanged();
		partial void OnNhanvienCapnhatGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnNgayCapnhatChanging(Nullable<DateTime> value);
        partial void OnNgayCapnhatChanged();
		partial void OnNgayCapnhatGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        

        public override AutoObject DataToAutoObject()
        {
            var Items = new List<AutoItem>();

            Items.Add(new AutoItem {Name = "TinhtrangPhieunhapId", Value = TinhtrangPhieunhapId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "PhieunhapId", Value = PhieunhapId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "TinhtrangId", Value = TinhtrangId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "NhanvienCapnhat", Value = NhanvienCapnhat, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "NgayCapnhat", Value = NgayCapnhat, SqlType = SqlDbType.DateTime});
            Items.Add(new AutoItem {Name = "Version", Value = Version, SqlType = SqlDbType.Timestamp});

            return DataToAutoObject(Items.ToArray());
        }

        public override string GetSpName()
        {
            if (State == RowState.Insert)
                return "sys_TinhtrangPhieunhapInsert";
            if (State == RowState.Update)
                return "sys_TinhtrangPhieunhapUpdate";
            if (State == RowState.Delete)
                return "sys_TinhtrangPhieunhapDelete";
            return "sys_TinhtrangPhieunhapSelect";
        }
    }
}