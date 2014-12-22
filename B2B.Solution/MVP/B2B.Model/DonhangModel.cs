using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BMIModel;
using BusinessObject;

namespace B2B.Model
{
    public partial class DonhangModel : Bus
    {
        private Guid _DonhangId;
        private Nullable<Guid> _NhanvienId;
        private Nullable<Guid> _KhoId;
        private Nullable<Guid> _KhachhangId;
        private Nullable<Guid> _NhanvienCapnhatId;
        private Nullable<Guid> _TinhtrangDonhangCurrentId;
        private Nullable<Int32> _LoaiDonhang;
        private Nullable<Int32> _Step;
        private Nullable<DateTime> _Ngaylap;
        private Nullable<DateTime> _Ngaygiao;
        private Nullable<DateTime> _NgayCapnhat;
        private Nullable<DateTime> _HanDonhang;
        private Nullable<Double> _Tiengiam;
        private Nullable<Double> _PhantramGiam;
        private Nullable<Double> _Tongtien;
        private Byte[] _Version;
        private String _Code;
        private String _TenTinhtrangDonhang;
        private String _DiachiGiao;
        private String _TenTinhthanhGiao;
        private String _TenQuanhuyenGiao;
        private String _SoDienthoai;
        private String _Ghichu;

        public DonhangModel()
        {
			OnCreating();
            DonhangId = ModelCore.GetGuidId();
			OnCreated();
        }

        public DonhangModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }

        
        [DisplayName("DonhangId")]
        public Guid DonhangId
        {
            get
			{
				Guid vGet = _DonhangId;
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
        
        
        [DisplayName("KhachhangId")]
        public Nullable<Guid> KhachhangId
        {
            get
			{
				Nullable<Guid> vGet = _KhachhangId;
				OnKhachhangIdGetting(ref _KhachhangId, ref vGet);
				return vGet;
			}
            set
            {
                OnKhachhangIdChanging(value);
                SetProperty(ref _KhachhangId, value);
                OnKhachhangIdChanged();
            }
        }
        
        
        [DisplayName("NhanvienCapnhatId")]
        public Nullable<Guid> NhanvienCapnhatId
        {
            get
			{
				Nullable<Guid> vGet = _NhanvienCapnhatId;
				OnNhanvienCapnhatIdGetting(ref _NhanvienCapnhatId, ref vGet);
				return vGet;
			}
            set
            {
                OnNhanvienCapnhatIdChanging(value);
                SetProperty(ref _NhanvienCapnhatId, value);
                OnNhanvienCapnhatIdChanged();
            }
        }
        
        
        [DisplayName("TinhtrangDonhangCurrentId")]
        public Nullable<Guid> TinhtrangDonhangCurrentId
        {
            get
			{
				Nullable<Guid> vGet = _TinhtrangDonhangCurrentId;
				OnTinhtrangDonhangCurrentIdGetting(ref _TinhtrangDonhangCurrentId, ref vGet);
				return vGet;
			}
            set
            {
                OnTinhtrangDonhangCurrentIdChanging(value);
                SetProperty(ref _TinhtrangDonhangCurrentId, value);
                OnTinhtrangDonhangCurrentIdChanged();
            }
        }
        
        
        [DisplayName("LoaiDonhang")]
        public Nullable<Int32> LoaiDonhang
        {
            get
			{
				Nullable<Int32> vGet = _LoaiDonhang;
				OnLoaiDonhangGetting(ref _LoaiDonhang, ref vGet);
				return vGet;
			}
            set
            {
                OnLoaiDonhangChanging(value);
                SetProperty(ref _LoaiDonhang, value);
                OnLoaiDonhangChanged();
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
        
        
        [DisplayName("Ngaygiao")]
        public Nullable<DateTime> Ngaygiao
        {
            get
			{
				Nullable<DateTime> vGet = _Ngaygiao;
				OnNgaygiaoGetting(ref _Ngaygiao, ref vGet);
				return vGet;
			}
            set
            {
                OnNgaygiaoChanging(value);
                SetProperty(ref _Ngaygiao, value);
                OnNgaygiaoChanged();
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
        
        
        [DisplayName("HanDonhang")]
        public Nullable<DateTime> HanDonhang
        {
            get
			{
				Nullable<DateTime> vGet = _HanDonhang;
				OnHanDonhangGetting(ref _HanDonhang, ref vGet);
				return vGet;
			}
            set
            {
                OnHanDonhangChanging(value);
                SetProperty(ref _HanDonhang, value);
                OnHanDonhangChanged();
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
        
        
        [DisplayName("Tongtien")]
        public Nullable<Double> Tongtien
        {
            get
			{
				Nullable<Double> vGet = _Tongtien;
				OnTongtienGetting(ref _Tongtien, ref vGet);
				return vGet;
			}
            set
            {
                OnTongtienChanging(value);
                SetProperty(ref _Tongtien, value);
                OnTongtienChanged();
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
        
        
        [DisplayName("TenTinhtrangDonhang")]
        public String TenTinhtrangDonhang
        {
            get
			{
				String vGet = _TenTinhtrangDonhang;
				OnTenTinhtrangDonhangGetting(ref _TenTinhtrangDonhang, ref vGet);
				return vGet;
			}
            set
            {
                OnTenTinhtrangDonhangChanging(value);
                SetProperty(ref _TenTinhtrangDonhang, value);
                OnTenTinhtrangDonhangChanged();
            }
        }
        
        
        [DisplayName("DiachiGiao")]
        public String DiachiGiao
        {
            get
			{
				String vGet = _DiachiGiao;
				OnDiachiGiaoGetting(ref _DiachiGiao, ref vGet);
				return vGet;
			}
            set
            {
                OnDiachiGiaoChanging(value);
                SetProperty(ref _DiachiGiao, value);
                OnDiachiGiaoChanged();
            }
        }
        
        
        [DisplayName("TenTinhthanhGiao")]
        public String TenTinhthanhGiao
        {
            get
			{
				String vGet = _TenTinhthanhGiao;
				OnTenTinhthanhGiaoGetting(ref _TenTinhthanhGiao, ref vGet);
				return vGet;
			}
            set
            {
                OnTenTinhthanhGiaoChanging(value);
                SetProperty(ref _TenTinhthanhGiao, value);
                OnTenTinhthanhGiaoChanged();
            }
        }
        
        
        [DisplayName("TenQuanhuyenGiao")]
        public String TenQuanhuyenGiao
        {
            get
			{
				String vGet = _TenQuanhuyenGiao;
				OnTenQuanhuyenGiaoGetting(ref _TenQuanhuyenGiao, ref vGet);
				return vGet;
			}
            set
            {
                OnTenQuanhuyenGiaoChanging(value);
                SetProperty(ref _TenQuanhuyenGiao, value);
                OnTenQuanhuyenGiaoChanged();
            }
        }
        
        
        [DisplayName("SoDienthoai")]
        public String SoDienthoai
        {
            get
			{
				String vGet = _SoDienthoai;
				OnSoDienthoaiGetting(ref _SoDienthoai, ref vGet);
				return vGet;
			}
            set
            {
                OnSoDienthoaiChanging(value);
                SetProperty(ref _SoDienthoai, value);
                OnSoDienthoaiChanged();
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
		
        
        partial void OnDonhangIdChanging(Guid value);
        partial void OnDonhangIdChanged();
		partial void OnDonhangIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnNhanvienIdChanging(Nullable<Guid> value);
        partial void OnNhanvienIdChanged();
		partial void OnNhanvienIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnKhoIdChanging(Nullable<Guid> value);
        partial void OnKhoIdChanged();
		partial void OnKhoIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnKhachhangIdChanging(Nullable<Guid> value);
        partial void OnKhachhangIdChanged();
		partial void OnKhachhangIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnNhanvienCapnhatIdChanging(Nullable<Guid> value);
        partial void OnNhanvienCapnhatIdChanged();
		partial void OnNhanvienCapnhatIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnTinhtrangDonhangCurrentIdChanging(Nullable<Guid> value);
        partial void OnTinhtrangDonhangCurrentIdChanged();
		partial void OnTinhtrangDonhangCurrentIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnLoaiDonhangChanging(Nullable<Int32> value);
        partial void OnLoaiDonhangChanged();
		partial void OnLoaiDonhangGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnNgaylapChanging(Nullable<DateTime> value);
        partial void OnNgaylapChanged();
		partial void OnNgaylapGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnNgaygiaoChanging(Nullable<DateTime> value);
        partial void OnNgaygiaoChanged();
		partial void OnNgaygiaoGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnNgayCapnhatChanging(Nullable<DateTime> value);
        partial void OnNgayCapnhatChanged();
		partial void OnNgayCapnhatGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnHanDonhangChanging(Nullable<DateTime> value);
        partial void OnHanDonhangChanged();
		partial void OnHanDonhangGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnTiengiamChanging(Nullable<Double> value);
        partial void OnTiengiamChanged();
		partial void OnTiengiamGetting(ref Nullable<Double> value, ref Nullable<Double> vGet);
        
        
        partial void OnPhantramGiamChanging(Nullable<Double> value);
        partial void OnPhantramGiamChanged();
		partial void OnPhantramGiamGetting(ref Nullable<Double> value, ref Nullable<Double> vGet);
        
        
        partial void OnTongtienChanging(Nullable<Double> value);
        partial void OnTongtienChanged();
		partial void OnTongtienGetting(ref Nullable<Double> value, ref Nullable<Double> vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void OnCodeChanging(String value);
        partial void OnCodeChanged();
		partial void OnCodeGetting(ref String value, ref String vGet);
        
        
        partial void OnTenTinhtrangDonhangChanging(String value);
        partial void OnTenTinhtrangDonhangChanged();
		partial void OnTenTinhtrangDonhangGetting(ref String value, ref String vGet);
        
        
        partial void OnDiachiGiaoChanging(String value);
        partial void OnDiachiGiaoChanged();
		partial void OnDiachiGiaoGetting(ref String value, ref String vGet);
        
        
        partial void OnTenTinhthanhGiaoChanging(String value);
        partial void OnTenTinhthanhGiaoChanged();
		partial void OnTenTinhthanhGiaoGetting(ref String value, ref String vGet);
        
        
        partial void OnTenQuanhuyenGiaoChanging(String value);
        partial void OnTenQuanhuyenGiaoChanged();
		partial void OnTenQuanhuyenGiaoGetting(ref String value, ref String vGet);
        
        
        partial void OnSoDienthoaiChanging(String value);
        partial void OnSoDienthoaiChanged();
		partial void OnSoDienthoaiGetting(ref String value, ref String vGet);
        
        
        partial void OnGhichuChanging(String value);
        partial void OnGhichuChanged();
		partial void OnGhichuGetting(ref String value, ref String vGet);
        

        public override AutoObject DataToAutoObject()
        {
            var Items = new List<AutoItem>();

            Items.Add(new AutoItem {Name = "DonhangId", Value = DonhangId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "NhanvienId", Value = NhanvienId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "KhoId", Value = KhoId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "KhachhangId", Value = KhachhangId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "NhanvienCapnhatId", Value = NhanvienCapnhatId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "TinhtrangDonhangCurrentId", Value = TinhtrangDonhangCurrentId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "LoaiDonhang", Value = LoaiDonhang, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "Step", Value = Step, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "Ngaylap", Value = Ngaylap, SqlType = SqlDbType.DateTime});
            Items.Add(new AutoItem {Name = "Ngaygiao", Value = Ngaygiao, SqlType = SqlDbType.DateTime});
            Items.Add(new AutoItem {Name = "NgayCapnhat", Value = NgayCapnhat, SqlType = SqlDbType.DateTime});
            Items.Add(new AutoItem {Name = "HanDonhang", Value = HanDonhang, SqlType = SqlDbType.DateTime});
            Items.Add(new AutoItem {Name = "Tiengiam", Value = Tiengiam, SqlType = SqlDbType.Float});
            Items.Add(new AutoItem {Name = "PhantramGiam", Value = PhantramGiam, SqlType = SqlDbType.Float});
            Items.Add(new AutoItem {Name = "Tongtien", Value = Tongtien, SqlType = SqlDbType.Float});
            Items.Add(new AutoItem {Name = "Version", Value = Version, SqlType = SqlDbType.Timestamp});
            Items.Add(new AutoItem {Name = "Code", Value = Code, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "TenTinhtrangDonhang", Value = TenTinhtrangDonhang, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "DiachiGiao", Value = DiachiGiao, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "TenTinhthanhGiao", Value = TenTinhthanhGiao, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "TenQuanhuyenGiao", Value = TenQuanhuyenGiao, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "SoDienthoai", Value = SoDienthoai, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "Ghichu", Value = Ghichu, SqlType = SqlDbType.NVarChar});

            return DataToAutoObject(Items.ToArray());
        }

        public override string GetSpName()
        {
            if (State == RowState.Insert)
                return "sys_DonhangInsert";
            if (State == RowState.Update)
                return "sys_DonhangUpdate";
            if (State == RowState.Delete)
                return "sys_DonhangDelete";
            return "sys_DonhangSelect";
        }
    }
}