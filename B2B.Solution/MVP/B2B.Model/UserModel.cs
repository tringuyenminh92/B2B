using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BMIModel;
using BusinessObject;

namespace B2B.Model
{
    public partial class UserModel : Bus
    {
        private Guid _UserId;
        private Nullable<Guid> _NhanvienId;
        private Nullable<Int32> _Step;
        private Nullable<Boolean> _Active;
        private Byte[] _Version;
        private String __Username;
        private String __Password;

        public UserModel()
        {
			OnCreating();
            UserId = ModelCore.GetGuidId();
			OnCreated();
        }

        public UserModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }

        
        [DisplayName("UserId")]
        public Guid UserId
        {
            get
			{
				Guid vGet = _UserId;
				OnUserIdGetting(ref _UserId, ref vGet);
				return vGet;
			}
            set
            {
                OnUserIdChanging(value);
                SetProperty(ref _UserId, value);
                OnUserIdChanged();
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
        
        
        [DisplayName("_Username")]
        public String _Username
        {
            get
			{
				String vGet = __Username;
				On_UsernameGetting(ref __Username, ref vGet);
				return vGet;
			}
            set
            {
                On_UsernameChanging(value);
                SetProperty(ref __Username, value);
                On_UsernameChanged();
            }
        }
        
        
        [DisplayName("_Password")]
        public String _Password
        {
            get
			{
				String vGet = __Password;
				On_PasswordGetting(ref __Password, ref vGet);
				return vGet;
			}
            set
            {
                On_PasswordChanging(value);
                SetProperty(ref __Password, value);
                On_PasswordChanged();
            }
        }
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnUserIdChanging(Guid value);
        partial void OnUserIdChanged();
		partial void OnUserIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnNhanvienIdChanging(Nullable<Guid> value);
        partial void OnNhanvienIdChanged();
		partial void OnNhanvienIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnActiveChanging(Nullable<Boolean> value);
        partial void OnActiveChanged();
		partial void OnActiveGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void On_UsernameChanging(String value);
        partial void On_UsernameChanged();
		partial void On_UsernameGetting(ref String value, ref String vGet);
        
        
        partial void On_PasswordChanging(String value);
        partial void On_PasswordChanged();
		partial void On_PasswordGetting(ref String value, ref String vGet);
        

        public override AutoObject DataToAutoObject()
        {
            var Items = new List<AutoItem>();

            Items.Add(new AutoItem {Name = "UserId", Value = UserId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "NhanvienId", Value = NhanvienId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "Step", Value = Step, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "Active", Value = Active, SqlType = SqlDbType.Bit});
            Items.Add(new AutoItem {Name = "Version", Value = Version, SqlType = SqlDbType.Timestamp});
            Items.Add(new AutoItem {Name = "_Username", Value = _Username, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "_Password", Value = _Password, SqlType = SqlDbType.NVarChar});

            return DataToAutoObject(Items.ToArray());
        }

        public override string GetSpName()
        {
            if (State == RowState.Insert)
                return "sys_UserInsert";
            if (State == RowState.Update)
                return "sys_UserUpdate";
            if (State == RowState.Delete)
                return "sys_UserDelete";
            return "sys_UserSelect";
        }
    }
}