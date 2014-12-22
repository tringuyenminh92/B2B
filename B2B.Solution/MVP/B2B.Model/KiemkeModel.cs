using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BMIModel;
using BusinessObject;

namespace B2B.Model
{
    public partial class KiemkeModel : Bus
    {
        private Guid _KiemkeId;
        private Nullable<Guid> _KhoId;
        private Nullable<Guid> _NhanvienId;
        private Nullable<Int32> _Step;
        private Nullable<DateTime> _Ngaylap;
        private Nullable<Boolean> _Active;
        private Byte[] _Version;
        private String _Code;

        public KiemkeModel()
        {
			OnCreating();
            KiemkeId = ModelCore.GetGuidId();
			OnCreated();
        }

        public KiemkeModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }

        
        [DisplayName("KiemkeId")]
        public Guid KiemkeId
        {
            get
			{
				Guid vGet = _KiemkeId;
				OnKiemkeIdGetting(ref _KiemkeId, ref vGet);
				return vGet;
			}
            set
            {
                OnKiemkeIdChanging(value);
                SetProperty(ref _KiemkeId, value);
                OnKiemkeIdChanged();
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
        
        
        [DisplayName("NhanvienId")]
        public Nullable<Guid> NhanvienId
        {
            get
			{
				Nullable<Guid> vGet = _NhanvienId;
				OnNhanvienIdGetting(ref _NhanvienId, ref vGet);
				return vGet;
			}
            set
            {
                OnNhanvienIdChanging(value);
                SetProperty(ref _NhanvienId, value);
                OnNhanvienIdChanged();
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
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnKiemkeIdChanging(Guid value);
        partial void OnKiemkeIdChanged();
		partial void OnKiemkeIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnKhoIdChanging(Nullable<Guid> value);
        partial void OnKhoIdChanged();
		partial void OnKhoIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnNhanvienIdChanging(Nullable<Guid> value);
        partial void OnNhanvienIdChanged();
		partial void OnNhanvienIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnNgaylapChanging(Nullable<DateTime> value);
        partial void OnNgaylapChanged();
		partial void OnNgaylapGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnActiveChanging(Nullable<Boolean> value);
        partial void OnActiveChanged();
		partial void OnActiveGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void OnCodeChanging(String value);
        partial void OnCodeChanged();
		partial void OnCodeGetting(ref String value, ref String vGet);
        

        public override AutoObject DataToAutoObject()
        {
            var Items = new List<AutoItem>();

            Items.Add(new AutoItem {Name = "KiemkeId", Value = KiemkeId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "KhoId", Value = KhoId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "NhanvienId", Value = NhanvienId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "Step", Value = Step, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "Ngaylap", Value = Ngaylap, SqlType = SqlDbType.DateTime});
            Items.Add(new AutoItem {Name = "Active", Value = Active, SqlType = SqlDbType.Bit});
            Items.Add(new AutoItem {Name = "Version", Value = Version, SqlType = SqlDbType.Timestamp});
            Items.Add(new AutoItem {Name = "Code", Value = Code, SqlType = SqlDbType.NVarChar});

            return DataToAutoObject(Items.ToArray());
        }

        public override string GetSpName()
        {
            if (State == RowState.Insert)
                return "sys_KiemkeInsert";
            if (State == RowState.Update)
                return "sys_KiemkeUpdate";
            if (State == RowState.Delete)
                return "sys_KiemkeDelete";
            return "sys_KiemkeSelect";
        }
    }
}