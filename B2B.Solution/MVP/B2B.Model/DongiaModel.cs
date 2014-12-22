using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BMIModel;
using BusinessObject;

namespace B2B.Model
{
    public partial class DongiaModel : Bus
    {
        private Guid _DongiaId;
        private Nullable<Guid> _HanghoaId;
        private Nullable<Guid> _NhomKhachhangId;
        private Nullable<Int32> _Step;
        private Nullable<DateTime> _NgayCapnhat;
        private Nullable<DateTime> _ApdungTu;
        private Nullable<Double> _Dongia;
        private Nullable<Boolean> _Active;
        private Byte[] _Version;
        private String _Code;
        private String _Ghichu;

        public DongiaModel()
        {
			OnCreating();
            DongiaId = ModelCore.GetGuidId();
			OnCreated();
        }

        public DongiaModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }

        
        [DisplayName("DongiaId")]
        public Guid DongiaId
        {
            get
			{
				Guid vGet = _DongiaId;
				OnDongiaIdGetting(ref _DongiaId, ref vGet);
				return vGet;
			}
            set
            {
                OnDongiaIdChanging(value);
                SetProperty(ref _DongiaId, value);
                OnDongiaIdChanged();
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
        
        
        [DisplayName("NhomKhachhangId")]
        public Nullable<Guid> NhomKhachhangId
        {
            get
			{
				Nullable<Guid> vGet = _NhomKhachhangId;
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
        
        
        [DisplayName("ApdungTu")]
        public Nullable<DateTime> ApdungTu
        {
            get
			{
				Nullable<DateTime> vGet = _ApdungTu;
				OnApdungTuGetting(ref _ApdungTu, ref vGet);
				return vGet;
			}
            set
            {
                OnApdungTuChanging(value);
                SetProperty(ref _ApdungTu, value);
                OnApdungTuChanged();
            }
        }
        
        
        [DisplayName("Dongia")]
        public Nullable<Double> Dongia
        {
            get
			{
				Nullable<Double> vGet = _Dongia;
				OnDongiaGetting(ref _Dongia, ref vGet);
				return vGet;
			}
            set
            {
                OnDongiaChanging(value);
                SetProperty(ref _Dongia, value);
                OnDongiaChanged();
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
		
        
        partial void OnDongiaIdChanging(Guid value);
        partial void OnDongiaIdChanged();
		partial void OnDongiaIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnHanghoaIdChanging(Nullable<Guid> value);
        partial void OnHanghoaIdChanged();
		partial void OnHanghoaIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnNhomKhachhangIdChanging(Nullable<Guid> value);
        partial void OnNhomKhachhangIdChanged();
		partial void OnNhomKhachhangIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnNgayCapnhatChanging(Nullable<DateTime> value);
        partial void OnNgayCapnhatChanged();
		partial void OnNgayCapnhatGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnApdungTuChanging(Nullable<DateTime> value);
        partial void OnApdungTuChanged();
		partial void OnApdungTuGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnDongiaChanging(Nullable<Double> value);
        partial void OnDongiaChanged();
		partial void OnDongiaGetting(ref Nullable<Double> value, ref Nullable<Double> vGet);
        
        
        partial void OnActiveChanging(Nullable<Boolean> value);
        partial void OnActiveChanged();
		partial void OnActiveGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void OnCodeChanging(String value);
        partial void OnCodeChanged();
		partial void OnCodeGetting(ref String value, ref String vGet);
        
        
        partial void OnGhichuChanging(String value);
        partial void OnGhichuChanged();
		partial void OnGhichuGetting(ref String value, ref String vGet);
        

        public override AutoObject DataToAutoObject()
        {
            var Items = new List<AutoItem>();

            Items.Add(new AutoItem {Name = "DongiaId", Value = DongiaId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "HanghoaId", Value = HanghoaId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "NhomKhachhangId", Value = NhomKhachhangId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "Step", Value = Step, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "NgayCapnhat", Value = NgayCapnhat, SqlType = SqlDbType.DateTime});
            Items.Add(new AutoItem {Name = "ApdungTu", Value = ApdungTu, SqlType = SqlDbType.DateTime});
            Items.Add(new AutoItem {Name = "Dongia", Value = Dongia, SqlType = SqlDbType.Float});
            Items.Add(new AutoItem {Name = "Active", Value = Active, SqlType = SqlDbType.Bit});
            Items.Add(new AutoItem {Name = "Version", Value = Version, SqlType = SqlDbType.Timestamp});
            Items.Add(new AutoItem {Name = "Code", Value = Code, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "Ghichu", Value = Ghichu, SqlType = SqlDbType.NVarChar});

            return DataToAutoObject(Items.ToArray());
        }

        public override string GetSpName()
        {
            if (State == RowState.Insert)
                return "sys_DongiaInsert";
            if (State == RowState.Update)
                return "sys_DongiaUpdate";
            if (State == RowState.Delete)
                return "sys_DongiaDelete";
            return "sys_DongiaSelect";
        }
    }
}