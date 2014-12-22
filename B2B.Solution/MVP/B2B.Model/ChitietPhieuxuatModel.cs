using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BMIModel;
using BusinessObject;

namespace B2B.Model
{
    public partial class ChitietPhieuxuatModel : Bus
    {
        private Guid _ChitietPhieuxuatId;
        private Nullable<Guid> _PhieuxuatId;
        private Nullable<Guid> _HanghoaId;
        private Nullable<Guid> _ChitietDonhangId;
        private Nullable<Int32> _Soluong;
        private Nullable<Int32> _Step;
        private Nullable<Double> _Thanhtien;
        private Nullable<Boolean> _Active;
        private Byte[] _Version;
        private String _Ghichu;

        public ChitietPhieuxuatModel()
        {
			OnCreating();
            ChitietPhieuxuatId = ModelCore.GetGuidId();
			OnCreated();
        }

        public ChitietPhieuxuatModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }

        
        [DisplayName("ChitietPhieuxuatId")]
        public Guid ChitietPhieuxuatId
        {
            get
			{
				Guid vGet = _ChitietPhieuxuatId;
				OnChitietPhieuxuatIdGetting(ref _ChitietPhieuxuatId, ref vGet);
				return vGet;
			}
            set
            {
                OnChitietPhieuxuatIdChanging(value);
                SetProperty(ref _ChitietPhieuxuatId, value);
                OnChitietPhieuxuatIdChanged();
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
        
        
        [DisplayName("HanghoaId")]
        public Nullable<Guid> HanghoaId
        {
            get
			{
				Nullable<Guid> vGet = _HanghoaId;
				OnHanghoaIdGetting(ref _HanghoaId, ref vGet);
				return vGet;
			}
            set
            {
                OnHanghoaIdChanging(value);
                SetProperty(ref _HanghoaId, value);
                OnHanghoaIdChanged();
            }
        }
        
        
        [DisplayName("ChitietDonhangId")]
        public Nullable<Guid> ChitietDonhangId
        {
            get
			{
				Nullable<Guid> vGet = _ChitietDonhangId;
				OnChitietDonhangIdGetting(ref _ChitietDonhangId, ref vGet);
				return vGet;
			}
            set
            {
                OnChitietDonhangIdChanging(value);
                SetProperty(ref _ChitietDonhangId, value);
                OnChitietDonhangIdChanged();
            }
        }
        
        
        [DisplayName("Soluong")]
        public Nullable<Int32> Soluong
        {
            get
			{
				Nullable<Int32> vGet = _Soluong;
				OnSoluongGetting(ref _Soluong, ref vGet);
				return vGet;
			}
            set
            {
                OnSoluongChanging(value);
                SetProperty(ref _Soluong, value);
                OnSoluongChanged();
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
        
        
        [DisplayName("Thanhtien")]
        public Nullable<Double> Thanhtien
        {
            get
			{
				Nullable<Double> vGet = _Thanhtien;
				OnThanhtienGetting(ref _Thanhtien, ref vGet);
				return vGet;
			}
            set
            {
                OnThanhtienChanging(value);
                SetProperty(ref _Thanhtien, value);
                OnThanhtienChanged();
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
		
        
        partial void OnChitietPhieuxuatIdChanging(Guid value);
        partial void OnChitietPhieuxuatIdChanged();
		partial void OnChitietPhieuxuatIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnPhieuxuatIdChanging(Nullable<Guid> value);
        partial void OnPhieuxuatIdChanged();
		partial void OnPhieuxuatIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnHanghoaIdChanging(Nullable<Guid> value);
        partial void OnHanghoaIdChanged();
		partial void OnHanghoaIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnChitietDonhangIdChanging(Nullable<Guid> value);
        partial void OnChitietDonhangIdChanged();
		partial void OnChitietDonhangIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnSoluongChanging(Nullable<Int32> value);
        partial void OnSoluongChanged();
		partial void OnSoluongGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnThanhtienChanging(Nullable<Double> value);
        partial void OnThanhtienChanged();
		partial void OnThanhtienGetting(ref Nullable<Double> value, ref Nullable<Double> vGet);
        
        
        partial void OnActiveChanging(Nullable<Boolean> value);
        partial void OnActiveChanged();
		partial void OnActiveGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void OnGhichuChanging(String value);
        partial void OnGhichuChanged();
		partial void OnGhichuGetting(ref String value, ref String vGet);
        

        public override AutoObject DataToAutoObject()
        {
            var Items = new List<AutoItem>();

            Items.Add(new AutoItem {Name = "ChitietPhieuxuatId", Value = ChitietPhieuxuatId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "PhieuxuatId", Value = PhieuxuatId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "HanghoaId", Value = HanghoaId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "ChitietDonhangId", Value = ChitietDonhangId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "Soluong", Value = Soluong, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "Step", Value = Step, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "Thanhtien", Value = Thanhtien, SqlType = SqlDbType.Float});
            Items.Add(new AutoItem {Name = "Active", Value = Active, SqlType = SqlDbType.Bit});
            Items.Add(new AutoItem {Name = "Version", Value = Version, SqlType = SqlDbType.Timestamp});
            Items.Add(new AutoItem {Name = "Ghichu", Value = Ghichu, SqlType = SqlDbType.NVarChar});

            return DataToAutoObject(Items.ToArray());
        }

        public override string GetSpName()
        {
            if (State == RowState.Insert)
                return "sys_ChitietPhieuxuatInsert";
            if (State == RowState.Update)
                return "sys_ChitietPhieuxuatUpdate";
            if (State == RowState.Delete)
                return "sys_ChitietPhieuxuatDelete";
            return "sys_ChitietPhieuxuatSelect";
        }
    }
}