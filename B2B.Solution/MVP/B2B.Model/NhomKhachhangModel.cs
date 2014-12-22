using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BMIModel;
using BusinessObject;

namespace B2B.Model
{
    public partial class NhomKhachhangModel : Bus
    {
        private Guid _NhomKhachhangId;
        private Nullable<Int32> _Step;
        private Nullable<DateTime> _NgayCapnhat;
        private Nullable<Boolean> _Active;
        private Byte[] _Version;
        private String _Code;
        private String _TenNhomKhachhang;
        private String _Ghichu;

        public NhomKhachhangModel()
        {
			OnCreating();
            NhomKhachhangId = ModelCore.GetGuidId();
			OnCreated();
        }

        public NhomKhachhangModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }

        
        [DisplayName("NhomKhachhangId")]
        public Guid NhomKhachhangId
        {
            get
			{
				Guid vGet = _NhomKhachhangId;
				OnNhomKhachhangIdGetting(ref _NhomKhachhangId, ref vGet);
				return vGet;
			}
            set
            {
                OnNhomKhachhangIdChanging(value);
                SetProperty(ref _NhomKhachhangId, value);
                OnNhomKhachhangIdChanged();
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
        
        
        [DisplayName("Active")]
        public Nullable<Boolean> Active
        {
            get
			{
				Nullable<Boolean> vGet = _Active;
				OnActiveGetting(ref _Active, ref vGet);
				return vGet;
			}
            set
            {
                OnActiveChanging(value);
                SetProperty(ref _Active, value);
                OnActiveChanged();
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
        
        
        [DisplayName("TenNhomKhachhang")]
        public String TenNhomKhachhang
        {
            get
			{
				String vGet = _TenNhomKhachhang;
				OnTenNhomKhachhangGetting(ref _TenNhomKhachhang, ref vGet);
				return vGet;
			}
            set
            {
                OnTenNhomKhachhangChanging(value);
                SetProperty(ref _TenNhomKhachhang, value);
                OnTenNhomKhachhangChanged();
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
		
        
        partial void OnNhomKhachhangIdChanging(Guid value);
        partial void OnNhomKhachhangIdChanged();
		partial void OnNhomKhachhangIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnNgayCapnhatChanging(Nullable<DateTime> value);
        partial void OnNgayCapnhatChanged();
		partial void OnNgayCapnhatGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnActiveChanging(Nullable<Boolean> value);
        partial void OnActiveChanged();
		partial void OnActiveGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void OnCodeChanging(String value);
        partial void OnCodeChanged();
		partial void OnCodeGetting(ref String value, ref String vGet);
        
        
        partial void OnTenNhomKhachhangChanging(String value);
        partial void OnTenNhomKhachhangChanged();
		partial void OnTenNhomKhachhangGetting(ref String value, ref String vGet);
        
        
        partial void OnGhichuChanging(String value);
        partial void OnGhichuChanged();
		partial void OnGhichuGetting(ref String value, ref String vGet);
        

        public override AutoObject DataToAutoObject()
        {
            var Items = new List<AutoItem>();

            Items.Add(new AutoItem {Name = "NhomKhachhangId", Value = NhomKhachhangId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "Step", Value = Step, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "NgayCapnhat", Value = NgayCapnhat, SqlType = SqlDbType.DateTime});
            Items.Add(new AutoItem {Name = "Active", Value = Active, SqlType = SqlDbType.Bit});
            Items.Add(new AutoItem {Name = "Version", Value = Version, SqlType = SqlDbType.Timestamp});
            Items.Add(new AutoItem {Name = "Code", Value = Code, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "TenNhomKhachhang", Value = TenNhomKhachhang, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "Ghichu", Value = Ghichu, SqlType = SqlDbType.NVarChar});

            return DataToAutoObject(Items.ToArray());
        }

        public override string GetSpName()
        {
            if (State == RowState.Insert)
                return "sys_NhomKhachhangInsert";
            if (State == RowState.Update)
                return "sys_NhomKhachhangUpdate";
            if (State == RowState.Delete)
                return "sys_NhomKhachhangDelete";
            return "sys_NhomKhachhangSelect";
        }
    }
}