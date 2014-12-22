using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BMIModel;
using BusinessObject;

namespace B2B.Model
{
    public partial class ChitietKiemkeModel : Bus
    {
        private Guid _ChitietKiemkeId;
        private Nullable<Guid> _KiemkeId;
        private Nullable<Guid> _HanghoaId;
        private Nullable<Int32> _SoluongTon;
        private Nullable<Int32> _SoluongThuc;
        private Nullable<Int32> _Step;
        private Byte[] _Version;
        private String _TenHanghoa;
        private String _Ghichu;

        public ChitietKiemkeModel()
        {
			OnCreating();
            ChitietKiemkeId = ModelCore.GetGuidId();
			OnCreated();
        }

        public ChitietKiemkeModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }

        
        [DisplayName("ChitietKiemkeId")]
        public Guid ChitietKiemkeId
        {
            get
			{
				Guid vGet = _ChitietKiemkeId;
				OnChitietKiemkeIdGetting(ref _ChitietKiemkeId, ref vGet);
				return vGet;
			}
            set
            {
                OnChitietKiemkeIdChanging(value);
                SetProperty(ref _ChitietKiemkeId, value);
                OnChitietKiemkeIdChanged();
            }
        }
        
        
        [DisplayName("KiemkeId")]
        public Nullable<Guid> KiemkeId
        {
            get
			{
				Nullable<Guid> vGet = _KiemkeId;
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
        
        
        [DisplayName("SoluongTon")]
        public Nullable<Int32> SoluongTon
        {
            get
			{
				Nullable<Int32> vGet = _SoluongTon;
				OnSoluongTonGetting(ref _SoluongTon, ref vGet);
				return vGet;
			}
            set
            {
                OnSoluongTonChanging(value);
                SetProperty(ref _SoluongTon, value);
                OnSoluongTonChanged();
            }
        }
        
        
        [DisplayName("SoluongThuc")]
        public Nullable<Int32> SoluongThuc
        {
            get
			{
				Nullable<Int32> vGet = _SoluongThuc;
				OnSoluongThucGetting(ref _SoluongThuc, ref vGet);
				return vGet;
			}
            set
            {
                OnSoluongThucChanging(value);
                SetProperty(ref _SoluongThuc, value);
                OnSoluongThucChanged();
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
        
        
        [DisplayName("TenHanghoa")]
        public String TenHanghoa
        {
            get
			{
				String vGet = _TenHanghoa;
				OnTenHanghoaGetting(ref _TenHanghoa, ref vGet);
				return vGet;
			}
            set
            {
                OnTenHanghoaChanging(value);
                SetProperty(ref _TenHanghoa, value);
                OnTenHanghoaChanged();
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
		
        
        partial void OnChitietKiemkeIdChanging(Guid value);
        partial void OnChitietKiemkeIdChanged();
		partial void OnChitietKiemkeIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnKiemkeIdChanging(Nullable<Guid> value);
        partial void OnKiemkeIdChanged();
		partial void OnKiemkeIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnHanghoaIdChanging(Nullable<Guid> value);
        partial void OnHanghoaIdChanged();
		partial void OnHanghoaIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnSoluongTonChanging(Nullable<Int32> value);
        partial void OnSoluongTonChanged();
		partial void OnSoluongTonGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnSoluongThucChanging(Nullable<Int32> value);
        partial void OnSoluongThucChanged();
		partial void OnSoluongThucGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void OnTenHanghoaChanging(String value);
        partial void OnTenHanghoaChanged();
		partial void OnTenHanghoaGetting(ref String value, ref String vGet);
        
        
        partial void OnGhichuChanging(String value);
        partial void OnGhichuChanged();
		partial void OnGhichuGetting(ref String value, ref String vGet);
        

        public override AutoObject DataToAutoObject()
        {
            var Items = new List<AutoItem>();

            Items.Add(new AutoItem {Name = "ChitietKiemkeId", Value = ChitietKiemkeId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "KiemkeId", Value = KiemkeId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "HanghoaId", Value = HanghoaId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "SoluongTon", Value = SoluongTon, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "SoluongThuc", Value = SoluongThuc, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "Step", Value = Step, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "Version", Value = Version, SqlType = SqlDbType.Timestamp});
            Items.Add(new AutoItem {Name = "TenHanghoa", Value = TenHanghoa, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "Ghichu", Value = Ghichu, SqlType = SqlDbType.NVarChar});

            return DataToAutoObject(Items.ToArray());
        }

        public override string GetSpName()
        {
            if (State == RowState.Insert)
                return "sys_ChitietKiemkeInsert";
            if (State == RowState.Update)
                return "sys_ChitietKiemkeUpdate";
            if (State == RowState.Delete)
                return "sys_ChitietKiemkeDelete";
            return "sys_ChitietKiemkeSelect";
        }
    }
}