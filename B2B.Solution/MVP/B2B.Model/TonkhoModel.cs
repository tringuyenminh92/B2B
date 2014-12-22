using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BMIModel;
using BusinessObject;

namespace B2B.Model
{
    public partial class TonkhoModel : Bus
    {
        private Guid _TonkhoId;
        private Nullable<Guid> _HanghoaId;
        private Nullable<Guid> _KhoId;
        private Nullable<Guid> _NhanvienCapnhat;
        private Nullable<Int32> _Ngay;
        private Nullable<Int32> _Thang;
        private Nullable<Int32> _Nam;
        private Nullable<Int32> _SoduDauky;
        private Nullable<Int32> _SoluongNhap;
        private Nullable<Int32> _SoluongXuat;
        private Nullable<Int32> _SoluongTon;
        private Nullable<Int32> _Step;
        private Nullable<Int32> _SoluongTonDukien;
        private Nullable<DateTime> _NgayCapnhat;
        private Nullable<DateTime> _GioCapnhat;
        private Nullable<Double> _ThanhtienNhap;
        private Nullable<Double> _ThanhtienXuat;
        private Nullable<Boolean> _Active;
        private Byte[] _Version;

        public TonkhoModel()
        {
			OnCreating();
            TonkhoId = ModelCore.GetGuidId();
			OnCreated();
        }

        public TonkhoModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }

        
        [DisplayName("TonkhoId")]
        public Guid TonkhoId
        {
            get
			{
				Guid vGet = _TonkhoId;
				OnTonkhoIdGetting(ref _TonkhoId, ref vGet);
				return vGet;
			}
            set
            {
                OnTonkhoIdChanging(value);
                SetProperty(ref _TonkhoId, value);
                OnTonkhoIdChanged();
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
        
        
        [DisplayName("NhanvienCapnhat")]
        public Nullable<Guid> NhanvienCapnhat
        {
            get
			{
				Nullable<Guid> vGet = _NhanvienCapnhat;
				OnNhanvienCapnhatGetting(ref _NhanvienCapnhat, ref vGet);
				return vGet;
			}
            set
            {
                OnNhanvienCapnhatChanging(value);
                SetProperty(ref _NhanvienCapnhat, value);
                OnNhanvienCapnhatChanged();
            }
        }
        
        
        [DisplayName("Ngay")]
        public Nullable<Int32> Ngay
        {
            get
			{
				Nullable<Int32> vGet = _Ngay;
				OnNgayGetting(ref _Ngay, ref vGet);
				return vGet;
			}
            set
            {
                OnNgayChanging(value);
                SetProperty(ref _Ngay, value);
                OnNgayChanged();
            }
        }
        
        
        [DisplayName("Thang")]
        public Nullable<Int32> Thang
        {
            get
			{
				Nullable<Int32> vGet = _Thang;
				OnThangGetting(ref _Thang, ref vGet);
				return vGet;
			}
            set
            {
                OnThangChanging(value);
                SetProperty(ref _Thang, value);
                OnThangChanged();
            }
        }
        
        
        [DisplayName("Nam")]
        public Nullable<Int32> Nam
        {
            get
			{
				Nullable<Int32> vGet = _Nam;
				OnNamGetting(ref _Nam, ref vGet);
				return vGet;
			}
            set
            {
                OnNamChanging(value);
                SetProperty(ref _Nam, value);
                OnNamChanged();
            }
        }
        
        
        [DisplayName("SoduDauky")]
        public Nullable<Int32> SoduDauky
        {
            get
			{
				Nullable<Int32> vGet = _SoduDauky;
				OnSoduDaukyGetting(ref _SoduDauky, ref vGet);
				return vGet;
			}
            set
            {
                OnSoduDaukyChanging(value);
                SetProperty(ref _SoduDauky, value);
                OnSoduDaukyChanged();
            }
        }
        
        
        [DisplayName("SoluongNhap")]
        public Nullable<Int32> SoluongNhap
        {
            get
			{
				Nullable<Int32> vGet = _SoluongNhap;
				OnSoluongNhapGetting(ref _SoluongNhap, ref vGet);
				return vGet;
			}
            set
            {
                OnSoluongNhapChanging(value);
                SetProperty(ref _SoluongNhap, value);
                OnSoluongNhapChanged();
            }
        }
        
        
        [DisplayName("SoluongXuat")]
        public Nullable<Int32> SoluongXuat
        {
            get
			{
				Nullable<Int32> vGet = _SoluongXuat;
				OnSoluongXuatGetting(ref _SoluongXuat, ref vGet);
				return vGet;
			}
            set
            {
                OnSoluongXuatChanging(value);
                SetProperty(ref _SoluongXuat, value);
                OnSoluongXuatChanged();
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
        
        
        [DisplayName("SoluongTonDukien")]
        public Nullable<Int32> SoluongTonDukien
        {
            get
			{
				Nullable<Int32> vGet = _SoluongTonDukien;
				OnSoluongTonDukienGetting(ref _SoluongTonDukien, ref vGet);
				return vGet;
			}
            set
            {
                OnSoluongTonDukienChanging(value);
                SetProperty(ref _SoluongTonDukien, value);
                OnSoluongTonDukienChanged();
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
        
        
        [DisplayName("GioCapnhat")]
        public Nullable<DateTime> GioCapnhat
        {
            get
			{
				Nullable<DateTime> vGet = _GioCapnhat;
				OnGioCapnhatGetting(ref _GioCapnhat, ref vGet);
				return vGet;
			}
            set
            {
                OnGioCapnhatChanging(value);
                SetProperty(ref _GioCapnhat, value);
                OnGioCapnhatChanged();
            }
        }
        
        
        [DisplayName("ThanhtienNhap")]
        public Nullable<Double> ThanhtienNhap
        {
            get
			{
				Nullable<Double> vGet = _ThanhtienNhap;
				OnThanhtienNhapGetting(ref _ThanhtienNhap, ref vGet);
				return vGet;
			}
            set
            {
                OnThanhtienNhapChanging(value);
                SetProperty(ref _ThanhtienNhap, value);
                OnThanhtienNhapChanged();
            }
        }
        
        
        [DisplayName("ThanhtienXuat")]
        public Nullable<Double> ThanhtienXuat
        {
            get
			{
				Nullable<Double> vGet = _ThanhtienXuat;
				OnThanhtienXuatGetting(ref _ThanhtienXuat, ref vGet);
				return vGet;
			}
            set
            {
                OnThanhtienXuatChanging(value);
                SetProperty(ref _ThanhtienXuat, value);
                OnThanhtienXuatChanged();
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
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnTonkhoIdChanging(Guid value);
        partial void OnTonkhoIdChanged();
		partial void OnTonkhoIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnHanghoaIdChanging(Nullable<Guid> value);
        partial void OnHanghoaIdChanged();
		partial void OnHanghoaIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnKhoIdChanging(Nullable<Guid> value);
        partial void OnKhoIdChanged();
		partial void OnKhoIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnNhanvienCapnhatChanging(Nullable<Guid> value);
        partial void OnNhanvienCapnhatChanged();
		partial void OnNhanvienCapnhatGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnNgayChanging(Nullable<Int32> value);
        partial void OnNgayChanged();
		partial void OnNgayGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnThangChanging(Nullable<Int32> value);
        partial void OnThangChanged();
		partial void OnThangGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnNamChanging(Nullable<Int32> value);
        partial void OnNamChanged();
		partial void OnNamGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnSoduDaukyChanging(Nullable<Int32> value);
        partial void OnSoduDaukyChanged();
		partial void OnSoduDaukyGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnSoluongNhapChanging(Nullable<Int32> value);
        partial void OnSoluongNhapChanged();
		partial void OnSoluongNhapGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnSoluongXuatChanging(Nullable<Int32> value);
        partial void OnSoluongXuatChanged();
		partial void OnSoluongXuatGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnSoluongTonChanging(Nullable<Int32> value);
        partial void OnSoluongTonChanged();
		partial void OnSoluongTonGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnSoluongTonDukienChanging(Nullable<Int32> value);
        partial void OnSoluongTonDukienChanged();
		partial void OnSoluongTonDukienGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnNgayCapnhatChanging(Nullable<DateTime> value);
        partial void OnNgayCapnhatChanged();
		partial void OnNgayCapnhatGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnGioCapnhatChanging(Nullable<DateTime> value);
        partial void OnGioCapnhatChanged();
		partial void OnGioCapnhatGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnThanhtienNhapChanging(Nullable<Double> value);
        partial void OnThanhtienNhapChanged();
		partial void OnThanhtienNhapGetting(ref Nullable<Double> value, ref Nullable<Double> vGet);
        
        
        partial void OnThanhtienXuatChanging(Nullable<Double> value);
        partial void OnThanhtienXuatChanged();
		partial void OnThanhtienXuatGetting(ref Nullable<Double> value, ref Nullable<Double> vGet);
        
        
        partial void OnActiveChanging(Nullable<Boolean> value);
        partial void OnActiveChanged();
		partial void OnActiveGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        

        public override AutoObject DataToAutoObject()
        {
            var Items = new List<AutoItem>();

            Items.Add(new AutoItem {Name = "TonkhoId", Value = TonkhoId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "HanghoaId", Value = HanghoaId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "KhoId", Value = KhoId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "NhanvienCapnhat", Value = NhanvienCapnhat, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "Ngay", Value = Ngay, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "Thang", Value = Thang, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "Nam", Value = Nam, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "SoduDauky", Value = SoduDauky, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "SoluongNhap", Value = SoluongNhap, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "SoluongXuat", Value = SoluongXuat, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "SoluongTon", Value = SoluongTon, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "Step", Value = Step, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "SoluongTonDukien", Value = SoluongTonDukien, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "NgayCapnhat", Value = NgayCapnhat, SqlType = SqlDbType.DateTime});
            Items.Add(new AutoItem {Name = "GioCapnhat", Value = GioCapnhat, SqlType = SqlDbType.DateTime});
            Items.Add(new AutoItem {Name = "ThanhtienNhap", Value = ThanhtienNhap, SqlType = SqlDbType.Float});
            Items.Add(new AutoItem {Name = "ThanhtienXuat", Value = ThanhtienXuat, SqlType = SqlDbType.Float});
            Items.Add(new AutoItem {Name = "Active", Value = Active, SqlType = SqlDbType.Bit});
            Items.Add(new AutoItem {Name = "Version", Value = Version, SqlType = SqlDbType.Timestamp});

            return DataToAutoObject(Items.ToArray());
        }

        public override string GetSpName()
        {
            if (State == RowState.Insert)
                return "sys_TonkhoInsert";
            if (State == RowState.Update)
                return "sys_TonkhoUpdate";
            if (State == RowState.Delete)
                return "sys_TonkhoDelete";
            return "sys_TonkhoSelect";
        }
    }
}