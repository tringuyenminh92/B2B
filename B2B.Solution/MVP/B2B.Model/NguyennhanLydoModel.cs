using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BMIModel;
using BusinessObject;

namespace B2B.Model
{
    public partial class NguyennhanLydoModel : Bus
    {
        private Guid _NguyennhanLydoId;
        private Nullable<Int32> _Step;
        private Nullable<Boolean> _Active;
        private Byte[] _Version;
        private String _Code;
        private String _Noidung;
        private String _Ghichu;

        public NguyennhanLydoModel()
        {
			OnCreating();
            NguyennhanLydoId = ModelCore.GetGuidId();
			OnCreated();
        }

        public NguyennhanLydoModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }

        
        [DisplayName("NguyennhanLydoId")]
        public Guid NguyennhanLydoId
        {
            get
			{
				Guid vGet = _NguyennhanLydoId;
				OnNguyennhanLydoIdGetting(ref _NguyennhanLydoId, ref vGet);
				return vGet;
			}
            set
            {
                OnNguyennhanLydoIdChanging(value);
                SetProperty(ref _NguyennhanLydoId, value);
                OnNguyennhanLydoIdChanged();
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
        
        
        [DisplayName("Noidung")]
        public String Noidung
        {
            get
			{
				String vGet = _Noidung;
				OnNoidungGetting(ref _Noidung, ref vGet);
				return vGet;
			}
            set
            {
                OnNoidungChanging(value);
                SetProperty(ref _Noidung, value);
                OnNoidungChanged();
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
		
        
        partial void OnNguyennhanLydoIdChanging(Guid value);
        partial void OnNguyennhanLydoIdChanged();
		partial void OnNguyennhanLydoIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnActiveChanging(Nullable<Boolean> value);
        partial void OnActiveChanged();
		partial void OnActiveGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void OnCodeChanging(String value);
        partial void OnCodeChanged();
		partial void OnCodeGetting(ref String value, ref String vGet);
        
        
        partial void OnNoidungChanging(String value);
        partial void OnNoidungChanged();
		partial void OnNoidungGetting(ref String value, ref String vGet);
        
        
        partial void OnGhichuChanging(String value);
        partial void OnGhichuChanged();
		partial void OnGhichuGetting(ref String value, ref String vGet);
        

        public override AutoObject DataToAutoObject()
        {
            var Items = new List<AutoItem>();

            Items.Add(new AutoItem {Name = "NguyennhanLydoId", Value = NguyennhanLydoId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "Step", Value = Step, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "Active", Value = Active, SqlType = SqlDbType.Bit});
            Items.Add(new AutoItem {Name = "Version", Value = Version, SqlType = SqlDbType.Timestamp});
            Items.Add(new AutoItem {Name = "Code", Value = Code, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "Noidung", Value = Noidung, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "Ghichu", Value = Ghichu, SqlType = SqlDbType.NVarChar});

            return DataToAutoObject(Items.ToArray());
        }

        public override string GetSpName()
        {
            if (State == RowState.Insert)
                return "sys_NguyennhanLydoInsert";
            if (State == RowState.Update)
                return "sys_NguyennhanLydoUpdate";
            if (State == RowState.Delete)
                return "sys_NguyennhanLydoDelete";
            return "sys_NguyennhanLydoSelect";
        }
    }
}