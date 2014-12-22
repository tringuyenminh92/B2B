using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BMIModel;
using BusinessObject;

namespace B2B.Model
{
    public partial class TinhtrangPhieuxuatModel : Bus
    {
        private Guid _TinhtrangPhieuxuatId;
        private Nullable<Guid> _PhieuxuatId;
        private Nullable<Guid> _TinhtrangId;
        private Nullable<Guid> _NhanvienCapnhatId;
        private Nullable<DateTime> _NgayCapnhat;
        private Byte[] _Version;
        private String _GhichuLydo;

        public TinhtrangPhieuxuatModel()
        {
			OnCreating();
            TinhtrangPhieuxuatId = ModelCore.GetGuidId();
			OnCreated();
        }

        public TinhtrangPhieuxuatModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }

        
        [DisplayName("TinhtrangPhieuxuatId")]
        public Guid TinhtrangPhieuxuatId
        {
            get
			{
				Guid vGet = _TinhtrangPhieuxuatId;
				OnTinhtrangPhieuxuatIdGetting(ref _TinhtrangPhieuxuatId, ref vGet);
				return vGet;
			}
            set
            {
                OnTinhtrangPhieuxuatIdChanging(value);
                SetProperty(ref _TinhtrangPhieuxuatId, value);
                OnTinhtrangPhieuxuatIdChanged();
            }
        }
        
        
        [DisplayName("PhieuxuatId")]
        public Nullable<Guid> PhieuxuatId
        {
            get
			{
				Nullable<Guid> vGet = _PhieuxuatId;
				OnPhieuxuatIdGetting(ref _PhieuxuatId, ref vGet);
				return vGet;
			}
            set
            {
                OnPhieuxuatIdChanging(value);
                SetProperty(ref _PhieuxuatId, value);
                OnPhieuxuatIdChanged();
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
        
        
        [DisplayName("NhanvienCapnhatId")]
        public Nullable<Guid> NhanvienCapnhatId
        {
            get
			{
				Nullable<Guid> vGet = _NhanvienCapnhatId;
				OnNhanvienCapnhatIdGetting(ref _NhanvienCapnhatId, ref vGet);
				return vGet;
			}
            set
            {
                OnNhanvienCapnhatIdChanging(value);
                SetProperty(ref _NhanvienCapnhatId, value);
                OnNhanvienCapnhatIdChanged();
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
        
        
        [DisplayName("GhichuLydo")]
        public String GhichuLydo
        {
            get
			{
				String vGet = _GhichuLydo;
				OnGhichuLydoGetting(ref _GhichuLydo, ref vGet);
				return vGet;
			}
            set
            {
                OnGhichuLydoChanging(value);
                SetProperty(ref _GhichuLydo, value);
                OnGhichuLydoChanged();
            }
        }
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnTinhtrangPhieuxuatIdChanging(Guid value);
        partial void OnTinhtrangPhieuxuatIdChanged();
		partial void OnTinhtrangPhieuxuatIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnPhieuxuatIdChanging(Nullable<Guid> value);
        partial void OnPhieuxuatIdChanged();
		partial void OnPhieuxuatIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnTinhtrangIdChanging(Nullable<Guid> value);
        partial void OnTinhtrangIdChanged();
		partial void OnTinhtrangIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnNhanvienCapnhatIdChanging(Nullable<Guid> value);
        partial void OnNhanvienCapnhatIdChanged();
		partial void OnNhanvienCapnhatIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnNgayCapnhatChanging(Nullable<DateTime> value);
        partial void OnNgayCapnhatChanged();
		partial void OnNgayCapnhatGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void OnGhichuLydoChanging(String value);
        partial void OnGhichuLydoChanged();
		partial void OnGhichuLydoGetting(ref String value, ref String vGet);
        

        public override AutoObject DataToAutoObject()
        {
            var Items = new List<AutoItem>();

            Items.Add(new AutoItem {Name = "TinhtrangPhieuxuatId", Value = TinhtrangPhieuxuatId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "PhieuxuatId", Value = PhieuxuatId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "TinhtrangId", Value = TinhtrangId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "NhanvienCapnhatId", Value = NhanvienCapnhatId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "NgayCapnhat", Value = NgayCapnhat, SqlType = SqlDbType.DateTime});
            Items.Add(new AutoItem {Name = "Version", Value = Version, SqlType = SqlDbType.Timestamp});
            Items.Add(new AutoItem {Name = "GhichuLydo", Value = GhichuLydo, SqlType = SqlDbType.NVarChar});

            return DataToAutoObject(Items.ToArray());
        }

        public override string GetSpName()
        {
            if (State == RowState.Insert)
                return "sys_TinhtrangPhieuxuatInsert";
            if (State == RowState.Update)
                return "sys_TinhtrangPhieuxuatUpdate";
            if (State == RowState.Delete)
                return "sys_TinhtrangPhieuxuatDelete";
            return "sys_TinhtrangPhieuxuatSelect";
        }
    }
}