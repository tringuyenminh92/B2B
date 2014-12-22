using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BMIModel;
using BusinessObject;

namespace B2B.Model
{
    public partial class TinhtrangModel : Bus
    {
        private Guid _TinhtrangId;
        private Nullable<Int32> _Step;
        private Nullable<DateTime> _NgayCapnhat;
        private Nullable<Boolean> _Active;
        private Nullable<Boolean> _CanDelete;
        private Byte[] _Version;
        private String _Code;
        private String _TenTinhtrang;
        private String _Ghichu;

        public TinhtrangModel()
        {
			OnCreating();
            TinhtrangId = ModelCore.GetGuidId();
			OnCreated();
        }

        public TinhtrangModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }

        
        [DisplayName("TinhtrangId")]
        public Guid TinhtrangId
        {
            get
			{
				Guid vGet = _TinhtrangId;
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
        
        
        [DisplayName("CanDelete")]
        public Nullable<Boolean> CanDelete
        {
            get
			{
				Nullable<Boolean> vGet = _CanDelete;
				OnCanDeleteGetting(ref _CanDelete, ref vGet);
				return vGet;
			}
            set
            {
                OnCanDeleteChanging(value);
                SetProperty(ref _CanDelete, value);
                OnCanDeleteChanged();
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
        
        
        [DisplayName("TenTinhtrang")]
        public String TenTinhtrang
        {
            get
			{
				String vGet = _TenTinhtrang;
				OnTenTinhtrangGetting(ref _TenTinhtrang, ref vGet);
				return vGet;
			}
            set
            {
                OnTenTinhtrangChanging(value);
                SetProperty(ref _TenTinhtrang, value);
                OnTenTinhtrangChanged();
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
		
        
        partial void OnTinhtrangIdChanging(Guid value);
        partial void OnTinhtrangIdChanged();
		partial void OnTinhtrangIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnNgayCapnhatChanging(Nullable<DateTime> value);
        partial void OnNgayCapnhatChanged();
		partial void OnNgayCapnhatGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnActiveChanging(Nullable<Boolean> value);
        partial void OnActiveChanged();
		partial void OnActiveGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnCanDeleteChanging(Nullable<Boolean> value);
        partial void OnCanDeleteChanged();
		partial void OnCanDeleteGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void OnCodeChanging(String value);
        partial void OnCodeChanged();
		partial void OnCodeGetting(ref String value, ref String vGet);
        
        
        partial void OnTenTinhtrangChanging(String value);
        partial void OnTenTinhtrangChanged();
		partial void OnTenTinhtrangGetting(ref String value, ref String vGet);
        
        
        partial void OnGhichuChanging(String value);
        partial void OnGhichuChanged();
		partial void OnGhichuGetting(ref String value, ref String vGet);
        

        public override AutoObject DataToAutoObject()
        {
            var Items = new List<AutoItem>();

            Items.Add(new AutoItem {Name = "TinhtrangId", Value = TinhtrangId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "Step", Value = Step, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "NgayCapnhat", Value = NgayCapnhat, SqlType = SqlDbType.DateTime});
            Items.Add(new AutoItem {Name = "Active", Value = Active, SqlType = SqlDbType.Bit});
            Items.Add(new AutoItem {Name = "CanDelete", Value = CanDelete, SqlType = SqlDbType.Bit});
            Items.Add(new AutoItem {Name = "Version", Value = Version, SqlType = SqlDbType.Timestamp});
            Items.Add(new AutoItem {Name = "Code", Value = Code, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "TenTinhtrang", Value = TenTinhtrang, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "Ghichu", Value = Ghichu, SqlType = SqlDbType.NVarChar});

            return DataToAutoObject(Items.ToArray());
        }

        public override string GetSpName()
        {
            if (State == RowState.Insert)
                return "sys_TinhtrangInsert";
            if (State == RowState.Update)
                return "sys_TinhtrangUpdate";
            if (State == RowState.Delete)
                return "sys_TinhtrangDelete";
            return "sys_TinhtrangSelect";
        }
    }
}