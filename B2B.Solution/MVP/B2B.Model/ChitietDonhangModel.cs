using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BMIModel;
using BusinessObject;

namespace B2B.Model
{
    public partial class ChitietDonhangModel : Bus
    {
        private Guid _ChitietDonhangId;
        private Nullable<Guid> _DonhangId;
        private Nullable<Guid> _HanghoaId;
        private Nullable<Int32> _Soluong;
        private Nullable<Int32> _SoluongGiao;
        private Nullable<Int32> _SoluongConlai;
        private Nullable<Int32> _Step;
        private Nullable<DateTime> _NgayCapnhat;
        private Nullable<Double> _Giaban;
        private Nullable<Double> _VAT;
        private Nullable<Double> _Tiengiam;
        private Nullable<Double> _PhantramGiam;
        private Nullable<Double> _Thanhtien;
        private Byte[] _Version;
        private String _TenHanghoa;
        private String _GhichuTrahang;

        public ChitietDonhangModel()
        {
			OnCreating();
            ChitietDonhangId = ModelCore.GetGuidId();
			OnCreated();
        }

        public ChitietDonhangModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }

        
        [DisplayName("ChitietDonhangId")]
        public Guid ChitietDonhangId
        {
            get
			{
				Guid vGet = _ChitietDonhangId;
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
        
        
        [DisplayName("DonhangId")]
        public Nullable<Guid> DonhangId
        {
            get
			{
				Nullable<Guid> vGet = _DonhangId;
				OnDonhangIdGetting(ref _DonhangId, ref vGet);
				return vGet;
			}
            set
            {
                OnDonhangIdChanging(value);
                SetProperty(ref _DonhangId, value);
                OnDonhangIdChanged();
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
        
        
        [DisplayName("SoluongGiao")]
        public Nullable<Int32> SoluongGiao
        {
            get
			{
				Nullable<Int32> vGet = _SoluongGiao;
				OnSoluongGiaoGetting(ref _SoluongGiao, ref vGet);
				return vGet;
			}
            set
            {
                OnSoluongGiaoChanging(value);
                SetProperty(ref _SoluongGiao, value);
                OnSoluongGiaoChanged();
            }
        }
        
        
        [DisplayName("SoluongConlai")]
        public Nullable<Int32> SoluongConlai
        {
            get
			{
				Nullable<Int32> vGet = _SoluongConlai;
				OnSoluongConlaiGetting(ref _SoluongConlai, ref vGet);
				return vGet;
			}
            set
            {
                OnSoluongConlaiChanging(value);
                SetProperty(ref _SoluongConlai, value);
                OnSoluongConlaiChanged();
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
        
        
        [DisplayName("Giaban")]
        public Nullable<Double> Giaban
        {
            get
			{
				Nullable<Double> vGet = _Giaban;
				OnGiabanGetting(ref _Giaban, ref vGet);
				return vGet;
			}
            set
            {
                OnGiabanChanging(value);
                SetProperty(ref _Giaban, value);
                OnGiabanChanged();
            }
        }
        
        
        [DisplayName("VAT")]
        public Nullable<Double> VAT
        {
            get
			{
				Nullable<Double> vGet = _VAT;
				OnVATGetting(ref _VAT, ref vGet);
				return vGet;
			}
            set
            {
                OnVATChanging(value);
                SetProperty(ref _VAT, value);
                OnVATChanged();
            }
        }
        
        
        [DisplayName("Tiengiam")]
        public Nullable<Double> Tiengiam
        {
            get
			{
				Nullable<Double> vGet = _Tiengiam;
				OnTiengiamGetting(ref _Tiengiam, ref vGet);
				return vGet;
			}
            set
            {
                OnTiengiamChanging(value);
                SetProperty(ref _Tiengiam, value);
                OnTiengiamChanged();
            }
        }
        
        
        [DisplayName("PhantramGiam")]
        public Nullable<Double> PhantramGiam
        {
            get
			{
				Nullable<Double> vGet = _PhantramGiam;
				OnPhantramGiamGetting(ref _PhantramGiam, ref vGet);
				return vGet;
			}
            set
            {
                OnPhantramGiamChanging(value);
                SetProperty(ref _PhantramGiam, value);
                OnPhantramGiamChanged();
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
        
        
        [DisplayName("GhichuTrahang")]
        public String GhichuTrahang
        {
            get
			{
				String vGet = _GhichuTrahang;
				OnGhichuTrahangGetting(ref _GhichuTrahang, ref vGet);
				return vGet;
			}
            set
            {
                OnGhichuTrahangChanging(value);
                SetProperty(ref _GhichuTrahang, value);
                OnGhichuTrahangChanged();
            }
        }
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnChitietDonhangIdChanging(Guid value);
        partial void OnChitietDonhangIdChanged();
		partial void OnChitietDonhangIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnDonhangIdChanging(Nullable<Guid> value);
        partial void OnDonhangIdChanged();
		partial void OnDonhangIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnHanghoaIdChanging(Nullable<Guid> value);
        partial void OnHanghoaIdChanged();
		partial void OnHanghoaIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnSoluongChanging(Nullable<Int32> value);
        partial void OnSoluongChanged();
		partial void OnSoluongGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnSoluongGiaoChanging(Nullable<Int32> value);
        partial void OnSoluongGiaoChanged();
		partial void OnSoluongGiaoGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnSoluongConlaiChanging(Nullable<Int32> value);
        partial void OnSoluongConlaiChanged();
		partial void OnSoluongConlaiGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnNgayCapnhatChanging(Nullable<DateTime> value);
        partial void OnNgayCapnhatChanged();
		partial void OnNgayCapnhatGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnGiabanChanging(Nullable<Double> value);
        partial void OnGiabanChanged();
		partial void OnGiabanGetting(ref Nullable<Double> value, ref Nullable<Double> vGet);
        
        
        partial void OnVATChanging(Nullable<Double> value);
        partial void OnVATChanged();
		partial void OnVATGetting(ref Nullable<Double> value, ref Nullable<Double> vGet);
        
        
        partial void OnTiengiamChanging(Nullable<Double> value);
        partial void OnTiengiamChanged();
		partial void OnTiengiamGetting(ref Nullable<Double> value, ref Nullable<Double> vGet);
        
        
        partial void OnPhantramGiamChanging(Nullable<Double> value);
        partial void OnPhantramGiamChanged();
		partial void OnPhantramGiamGetting(ref Nullable<Double> value, ref Nullable<Double> vGet);
        
        
        partial void OnThanhtienChanging(Nullable<Double> value);
        partial void OnThanhtienChanged();
		partial void OnThanhtienGetting(ref Nullable<Double> value, ref Nullable<Double> vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void OnTenHanghoaChanging(String value);
        partial void OnTenHanghoaChanged();
		partial void OnTenHanghoaGetting(ref String value, ref String vGet);
        
        
        partial void OnGhichuTrahangChanging(String value);
        partial void OnGhichuTrahangChanged();
		partial void OnGhichuTrahangGetting(ref String value, ref String vGet);
        

        public override AutoObject DataToAutoObject()
        {
            var Items = new List<AutoItem>();

            Items.Add(new AutoItem {Name = "ChitietDonhangId", Value = ChitietDonhangId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "DonhangId", Value = DonhangId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "HanghoaId", Value = HanghoaId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "Soluong", Value = Soluong, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "SoluongGiao", Value = SoluongGiao, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "SoluongConlai", Value = SoluongConlai, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "Step", Value = Step, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "NgayCapnhat", Value = NgayCapnhat, SqlType = SqlDbType.DateTime});
            Items.Add(new AutoItem {Name = "Giaban", Value = Giaban, SqlType = SqlDbType.Float});
            Items.Add(new AutoItem {Name = "VAT", Value = VAT, SqlType = SqlDbType.Float});
            Items.Add(new AutoItem {Name = "Tiengiam", Value = Tiengiam, SqlType = SqlDbType.Float});
            Items.Add(new AutoItem {Name = "PhantramGiam", Value = PhantramGiam, SqlType = SqlDbType.Float});
            Items.Add(new AutoItem {Name = "Thanhtien", Value = Thanhtien, SqlType = SqlDbType.Float});
            Items.Add(new AutoItem {Name = "Version", Value = Version, SqlType = SqlDbType.Timestamp});
            Items.Add(new AutoItem {Name = "TenHanghoa", Value = TenHanghoa, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "GhichuTrahang", Value = GhichuTrahang, SqlType = SqlDbType.NVarChar});

            return DataToAutoObject(Items.ToArray());
        }

        public override string GetSpName()
        {
            if (State == RowState.Insert)
                return "sys_ChitietDonhangInsert";
            if (State == RowState.Update)
                return "sys_ChitietDonhangUpdate";
            if (State == RowState.Delete)
                return "sys_ChitietDonhangDelete";
            return "sys_ChitietDonhangSelect";
        }
    }
}