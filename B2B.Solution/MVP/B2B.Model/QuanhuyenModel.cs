using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BMIModel;
using BusinessObject;

namespace B2B.Model
{
    public partial class QuanhuyenModel : Bus
    {
        private Guid _QuanhuyenId;
        private Nullable<Guid> _TinhthanhId;
        private Nullable<Int32> _Step;
        private Nullable<DateTime> _NgayCapnhat;
        private Nullable<Boolean> _Active;
        private Byte[] _Version;
        private String _Code;
        private String _TenQuanhuyen;
        private String _Ghichu;

        public QuanhuyenModel()
        {
			OnCreating();
            QuanhuyenId = ModelCore.GetGuidId();
			OnCreated();
        }

        public QuanhuyenModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }

        
        [DisplayName("QuanhuyenId")]
        public Guid QuanhuyenId
        {
            get
			{
				Guid vGet = _QuanhuyenId;
				OnQuanhuyenIdGetting(ref _QuanhuyenId, ref vGet);
				return vGet;
			}
            set
            {
                OnQuanhuyenIdChanging(value);
                SetProperty(ref _QuanhuyenId, value);
                OnQuanhuyenIdChanged();
            }
        }
        
        
        [DisplayName("TinhthanhId")]
        public Nullable<Guid> TinhthanhId
        {
            get
			{
				Nullable<Guid> vGet = _TinhthanhId;
				OnTinhthanhIdGetting(ref _TinhthanhId, ref vGet);
				return vGet;
			}
            set
            {
                OnTinhthanhIdChanging(value);
                SetProperty(ref _TinhthanhId, value);
                OnTinhthanhIdChanged();
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
        
        
        [DisplayName("TenQuanhuyen")]
        public String TenQuanhuyen
        {
            get
			{
				String vGet = _TenQuanhuyen;
				OnTenQuanhuyenGetting(ref _TenQuanhuyen, ref vGet);
				return vGet;
			}
            set
            {
                OnTenQuanhuyenChanging(value);
                SetProperty(ref _TenQuanhuyen, value);
                OnTenQuanhuyenChanged();
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
		
        
        partial void OnQuanhuyenIdChanging(Guid value);
        partial void OnQuanhuyenIdChanged();
		partial void OnQuanhuyenIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnTinhthanhIdChanging(Nullable<Guid> value);
        partial void OnTinhthanhIdChanged();
		partial void OnTinhthanhIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
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
        
        
        partial void OnTenQuanhuyenChanging(String value);
        partial void OnTenQuanhuyenChanged();
		partial void OnTenQuanhuyenGetting(ref String value, ref String vGet);
        
        
        partial void OnGhichuChanging(String value);
        partial void OnGhichuChanged();
		partial void OnGhichuGetting(ref String value, ref String vGet);
        

        public override AutoObject DataToAutoObject()
        {
            var Items = new List<AutoItem>();

            Items.Add(new AutoItem {Name = "QuanhuyenId", Value = QuanhuyenId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "TinhthanhId", Value = TinhthanhId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "Step", Value = Step, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "NgayCapnhat", Value = NgayCapnhat, SqlType = SqlDbType.DateTime});
            Items.Add(new AutoItem {Name = "Active", Value = Active, SqlType = SqlDbType.Bit});
            Items.Add(new AutoItem {Name = "Version", Value = Version, SqlType = SqlDbType.Timestamp});
            Items.Add(new AutoItem {Name = "Code", Value = Code, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "TenQuanhuyen", Value = TenQuanhuyen, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "Ghichu", Value = Ghichu, SqlType = SqlDbType.NVarChar});

            return DataToAutoObject(Items.ToArray());
        }

        public override string GetSpName()
        {
            if (State == RowState.Insert)
                return "sys_QuanhuyenInsert";
            if (State == RowState.Update)
                return "sys_QuanhuyenUpdate";
            if (State == RowState.Delete)
                return "sys_QuanhuyenDelete";
            return "sys_QuanhuyenSelect";
        }
    }
}