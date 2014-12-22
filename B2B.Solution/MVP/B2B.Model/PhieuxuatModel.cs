using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BMIModel;
using BusinessObject;

namespace B2B.Model
{
    public partial class PhieuxuatModel : Bus
    {
        private Guid _PhieuxuatId;
        private Nullable<Guid> _NhanvienLapId;
        private Nullable<Guid> _KhoId;
        private Nullable<Guid> _DonhangId;
        private Nullable<Guid> _NhanvienGiaohangId;
        private Nullable<Guid> _NguyennhanLydo;
        private Nullable<Guid> _TinhtrangPhieuxuatCurrentId;
        private Nullable<Int32> _Step;
        private Nullable<DateTime> _Ngaylap;
        private Nullable<DateTime> _NgayCapnhat;
        private Byte[] _Version;
        private String _Code;
        private String _TenTinhtrangPhieuxuat;
        private String _Ghichu;

        public PhieuxuatModel()
        {
			OnCreating();
            PhieuxuatId = ModelCore.GetGuidId();
			OnCreated();
        }

        public PhieuxuatModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }

        
        [DisplayName("PhieuxuatId")]
        public Guid PhieuxuatId
        {
            get
			{
				Guid vGet = _PhieuxuatId;
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
        
        
        [DisplayName("NhanvienLapId")]
        public Nullable<Guid> NhanvienLapId
        {
            get
			{
				Nullable<Guid> vGet = _NhanvienLapId;
				OnNhanvienLapIdGetting(ref _NhanvienLapId, ref vGet);
				return vGet;
			}
            set
            {
                OnNhanvienLapIdChanging(value);
                SetProperty(ref _NhanvienLapId, value);
                OnNhanvienLapIdChanged();
            }
        }
        
        
        [DisplayName("KhoId")]
        public Nullable<Guid> KhoId
        {
            get
			{
				Nullable<Guid> vGet = _KhoId;
				OnKhoIdGetting(ref _KhoId, ref vGet);
				return vGet;
			}
            set
            {
                OnKhoIdChanging(value);
                SetProperty(ref _KhoId, value);
                OnKhoIdChanged();
            }
        }
        
        
        [DisplayName("DonhangId")]
        public Nullable<Guid> DonhangId
        {
            get
			{
				Nullable<Guid> vGet = _DonhangId;
				OnDonhangIdGetting(ref _DonhangId, ref vGet);
				return vGet;
			}
            set
            {
                OnDonhangIdChanging(value);
                SetProperty(ref _DonhangId, value);
                OnDonhangIdChanged();
            }
        }
        
        
        [DisplayName("NhanvienGiaohangId")]
        public Nullable<Guid> NhanvienGiaohangId
        {
            get
			{
				Nullable<Guid> vGet = _NhanvienGiaohangId;
				OnNhanvienGiaohangIdGetting(ref _NhanvienGiaohangId, ref vGet);
				return vGet;
			}
            set
            {
                OnNhanvienGiaohangIdChanging(value);
                SetProperty(ref _NhanvienGiaohangId, value);
                OnNhanvienGiaohangIdChanged();
            }
        }
        
        
        [DisplayName("NguyennhanLydo")]
        public Nullable<Guid> NguyennhanLydo
        {
            get
			{
				Nullable<Guid> vGet = _NguyennhanLydo;
				OnNguyennhanLydoGetting(ref _NguyennhanLydo, ref vGet);
				return vGet;
			}
            set
            {
                OnNguyennhanLydoChanging(value);
                SetProperty(ref _NguyennhanLydo, value);
                OnNguyennhanLydoChanged();
            }
        }
        
        
        [DisplayName("TinhtrangPhieuxuatCurrentId")]
        public Nullable<Guid> TinhtrangPhieuxuatCurrentId
        {
            get
			{
				Nullable<Guid> vGet = _TinhtrangPhieuxuatCurrentId;
				OnTinhtrangPhieuxuatCurrentIdGetting(ref _TinhtrangPhieuxuatCurrentId, ref vGet);
				return vGet;
			}
            set
            {
                OnTinhtrangPhieuxuatCurrentIdChanging(value);
                SetProperty(ref _TinhtrangPhieuxuatCurrentId, value);
                OnTinhtrangPhieuxuatCurrentIdChanged();
            }
        }
        
        
        [DisplayName("Step")]
        public Nullable<Int32> Step
        {
            get
			{
				Nullable<Int32> vGet = _Step;
				OnStepGetting(ref _Step, ref vGet);
				return vGet;
			}
            set
            {
                OnStepChanging(value);
                SetProperty(ref _Step, value);
                OnStepChanged();
            }
        }
        
        
        [DisplayName("Ngaylap")]
        public Nullable<DateTime> Ngaylap
        {
            get
			{
				Nullable<DateTime> vGet = _Ngaylap;
				OnNgaylapGetting(ref _Ngaylap, ref vGet);
				return vGet;
			}
            set
            {
                OnNgaylapChanging(value);
                SetProperty(ref _Ngaylap, value);
                OnNgaylapChanged();
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
        
        
        [DisplayName("Code")]
        public String Code
        {
            get
			{
				String vGet = _Code;
				OnCodeGetting(ref _Code, ref vGet);
				return vGet;
			}
            set
            {
                OnCodeChanging(value);
                SetProperty(ref _Code, value);
                OnCodeChanged();
            }
        }
        
        
        [DisplayName("TenTinhtrangPhieuxuat")]
        public String TenTinhtrangPhieuxuat
        {
            get
			{
				String vGet = _TenTinhtrangPhieuxuat;
				OnTenTinhtrangPhieuxuatGetting(ref _TenTinhtrangPhieuxuat, ref vGet);
				return vGet;
			}
            set
            {
                OnTenTinhtrangPhieuxuatChanging(value);
                SetProperty(ref _TenTinhtrangPhieuxuat, value);
                OnTenTinhtrangPhieuxuatChanged();
            }
        }
        
        
        [DisplayName("Ghichu")]
        public String Ghichu
        {
            get
			{
				String vGet = _Ghichu;
				OnGhichuGetting(ref _Ghichu, ref vGet);
				return vGet;
			}
            set
            {
                OnGhichuChanging(value);
                SetProperty(ref _Ghichu, value);
                OnGhichuChanged();
            }
        }
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnPhieuxuatIdChanging(Guid value);
        partial void OnPhieuxuatIdChanged();
		partial void OnPhieuxuatIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnNhanvienLapIdChanging(Nullable<Guid> value);
        partial void OnNhanvienLapIdChanged();
		partial void OnNhanvienLapIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnKhoIdChanging(Nullable<Guid> value);
        partial void OnKhoIdChanged();
		partial void OnKhoIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnDonhangIdChanging(Nullable<Guid> value);
        partial void OnDonhangIdChanged();
		partial void OnDonhangIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnNhanvienGiaohangIdChanging(Nullable<Guid> value);
        partial void OnNhanvienGiaohangIdChanged();
		partial void OnNhanvienGiaohangIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnNguyennhanLydoChanging(Nullable<Guid> value);
        partial void OnNguyennhanLydoChanged();
		partial void OnNguyennhanLydoGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnTinhtrangPhieuxuatCurrentIdChanging(Nullable<Guid> value);
        partial void OnTinhtrangPhieuxuatCurrentIdChanged();
		partial void OnTinhtrangPhieuxuatCurrentIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnNgaylapChanging(Nullable<DateTime> value);
        partial void OnNgaylapChanged();
		partial void OnNgaylapGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnNgayCapnhatChanging(Nullable<DateTime> value);
        partial void OnNgayCapnhatChanged();
		partial void OnNgayCapnhatGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void OnCodeChanging(String value);
        partial void OnCodeChanged();
		partial void OnCodeGetting(ref String value, ref String vGet);
        
        
        partial void OnTenTinhtrangPhieuxuatChanging(String value);
        partial void OnTenTinhtrangPhieuxuatChanged();
		partial void OnTenTinhtrangPhieuxuatGetting(ref String value, ref String vGet);
        
        
        partial void OnGhichuChanging(String value);
        partial void OnGhichuChanged();
		partial void OnGhichuGetting(ref String value, ref String vGet);
        

        public override AutoObject DataToAutoObject()
        {
            var Items = new List<AutoItem>();

            Items.Add(new AutoItem {Name = "PhieuxuatId", Value = PhieuxuatId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "NhanvienLapId", Value = NhanvienLapId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "KhoId", Value = KhoId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "DonhangId", Value = DonhangId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "NhanvienGiaohangId", Value = NhanvienGiaohangId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "NguyennhanLydo", Value = NguyennhanLydo, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "TinhtrangPhieuxuatCurrentId", Value = TinhtrangPhieuxuatCurrentId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "Step", Value = Step, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "Ngaylap", Value = Ngaylap, SqlType = SqlDbType.DateTime});
            Items.Add(new AutoItem {Name = "NgayCapnhat", Value = NgayCapnhat, SqlType = SqlDbType.DateTime});
            Items.Add(new AutoItem {Name = "Version", Value = Version, SqlType = SqlDbType.Timestamp});
            Items.Add(new AutoItem {Name = "Code", Value = Code, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "TenTinhtrangPhieuxuat", Value = TenTinhtrangPhieuxuat, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "Ghichu", Value = Ghichu, SqlType = SqlDbType.NVarChar});

            return DataToAutoObject(Items.ToArray());
        }

        public override string GetSpName()
        {
            if (State == RowState.Insert)
                return "sys_PhieuxuatInsert";
            if (State == RowState.Update)
                return "sys_PhieuxuatUpdate";
            if (State == RowState.Delete)
                return "sys_PhieuxuatDelete";
            return "sys_PhieuxuatSelect";
        }
    }
}