using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BMIModel;
using BusinessObject;

namespace B2B.Model
{
    public partial class KhachhangModel : Bus
    {
        private Guid _KhachhangId;
        private Nullable<Guid> _QuanhuyenId;
        private Nullable<Guid> _TinhthanhId;
        private Nullable<Guid> _NhomKhachhangId;
        private Nullable<Int32> _ThoigianCongno;
        private Nullable<Int32> _ToahangCongno;
        private Nullable<Int32> _Step;
        private Nullable<DateTime> _Ngaysinh;
        private Nullable<DateTime> _NgayCapnhat;
        private Nullable<Double> _HanmucCongno;
        private Nullable<Boolean> _Gioitinh;
        private Nullable<Boolean> _Active;
        private Byte[] _Version;
        private String _Code;
        private String _HotenKhachhang;
        private String _CMND;
        private String _Diachi;
        private String _DiachiGiaohang;
        private String _Linkanh;
        private String _Ghichu;
        private String _Mobile;
        private String _Fax;
        private String _MasoThue;
        private String _TenTaikhoan;
        private String _SoTaikhoan;
        private String _Nganhang;
        private String _Congty;
        private String _Chucvu;
        private String _Email;
        private String _DiachiCongty;
        private String _PhoneCongty;
        private String _Tel;

        public KhachhangModel()
        {
			OnCreating();
            KhachhangId = ModelCore.GetGuidId();
			OnCreated();
        }

        public KhachhangModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }

        
        [DisplayName("KhachhangId")]
        public Guid KhachhangId
        {
            get
			{
				Guid vGet = _KhachhangId;
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
        
        
        [DisplayName("QuanhuyenId")]
        public Nullable<Guid> QuanhuyenId
        {
            get
			{
				Nullable<Guid> vGet = _QuanhuyenId;
				OnQuanhuyenIdGetting(ref _QuanhuyenId, ref vGet);
				return vGet;
			}
            set
            {
                OnQuanhuyenIdChanging(value);
                SetProperty(ref _QuanhuyenId, value);
                OnQuanhuyenIdChanged();
            }
        }
        
        
        [DisplayName("TinhthanhId")]
        public Nullable<Guid> TinhthanhId
        {
            get
			{
				Nullable<Guid> vGet = _TinhthanhId;
				OnTinhthanhIdGetting(ref _TinhthanhId, ref vGet);
				return vGet;
			}
            set
            {
                OnTinhthanhIdChanging(value);
                SetProperty(ref _TinhthanhId, value);
                OnTinhthanhIdChanged();
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
        
        
        [DisplayName("ThoigianCongno")]
        public Nullable<Int32> ThoigianCongno
        {
            get
			{
				Nullable<Int32> vGet = _ThoigianCongno;
				OnThoigianCongnoGetting(ref _ThoigianCongno, ref vGet);
				return vGet;
			}
            set
            {
                OnThoigianCongnoChanging(value);
                SetProperty(ref _ThoigianCongno, value);
                OnThoigianCongnoChanged();
            }
        }
        
        
        [DisplayName("ToahangCongno")]
        public Nullable<Int32> ToahangCongno
        {
            get
			{
				Nullable<Int32> vGet = _ToahangCongno;
				OnToahangCongnoGetting(ref _ToahangCongno, ref vGet);
				return vGet;
			}
            set
            {
                OnToahangCongnoChanging(value);
                SetProperty(ref _ToahangCongno, value);
                OnToahangCongnoChanged();
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
        
        
        [DisplayName("Ngaysinh")]
        public Nullable<DateTime> Ngaysinh
        {
            get
			{
				Nullable<DateTime> vGet = _Ngaysinh;
				OnNgaysinhGetting(ref _Ngaysinh, ref vGet);
				return vGet;
			}
            set
            {
                OnNgaysinhChanging(value);
                SetProperty(ref _Ngaysinh, value);
                OnNgaysinhChanged();
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
        
        
        [DisplayName("HanmucCongno")]
        public Nullable<Double> HanmucCongno
        {
            get
			{
				Nullable<Double> vGet = _HanmucCongno;
				OnHanmucCongnoGetting(ref _HanmucCongno, ref vGet);
				return vGet;
			}
            set
            {
                OnHanmucCongnoChanging(value);
                SetProperty(ref _HanmucCongno, value);
                OnHanmucCongnoChanged();
            }
        }
        
        
        [DisplayName("Gioitinh")]
        public Nullable<Boolean> Gioitinh
        {
            get
			{
				Nullable<Boolean> vGet = _Gioitinh;
				OnGioitinhGetting(ref _Gioitinh, ref vGet);
				return vGet;
			}
            set
            {
                OnGioitinhChanging(value);
                SetProperty(ref _Gioitinh, value);
                OnGioitinhChanged();
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
        
        
        [DisplayName("HotenKhachhang")]
        public String HotenKhachhang
        {
            get
			{
				String vGet = _HotenKhachhang;
				OnHotenKhachhangGetting(ref _HotenKhachhang, ref vGet);
				return vGet;
			}
            set
            {
                OnHotenKhachhangChanging(value);
                SetProperty(ref _HotenKhachhang, value);
                OnHotenKhachhangChanged();
            }
        }
        
        
        [DisplayName("CMND")]
        public String CMND
        {
            get
			{
				String vGet = _CMND;
				OnCMNDGetting(ref _CMND, ref vGet);
				return vGet;
			}
            set
            {
                OnCMNDChanging(value);
                SetProperty(ref _CMND, value);
                OnCMNDChanged();
            }
        }
        
        
        [DisplayName("Diachi")]
        public String Diachi
        {
            get
			{
				String vGet = _Diachi;
				OnDiachiGetting(ref _Diachi, ref vGet);
				return vGet;
			}
            set
            {
                OnDiachiChanging(value);
                SetProperty(ref _Diachi, value);
                OnDiachiChanged();
            }
        }
        
        
        [DisplayName("DiachiGiaohang")]
        public String DiachiGiaohang
        {
            get
			{
				String vGet = _DiachiGiaohang;
				OnDiachiGiaohangGetting(ref _DiachiGiaohang, ref vGet);
				return vGet;
			}
            set
            {
                OnDiachiGiaohangChanging(value);
                SetProperty(ref _DiachiGiaohang, value);
                OnDiachiGiaohangChanged();
            }
        }
        
        
        [DisplayName("Linkanh")]
        public String Linkanh
        {
            get
			{
				String vGet = _Linkanh;
				OnLinkanhGetting(ref _Linkanh, ref vGet);
				return vGet;
			}
            set
            {
                OnLinkanhChanging(value);
                SetProperty(ref _Linkanh, value);
                OnLinkanhChanged();
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
        
        
        [DisplayName("Mobile")]
        public String Mobile
        {
            get
			{
				String vGet = _Mobile;
				OnMobileGetting(ref _Mobile, ref vGet);
				return vGet;
			}
            set
            {
                OnMobileChanging(value);
                SetProperty(ref _Mobile, value);
                OnMobileChanged();
            }
        }
        
        
        [DisplayName("Fax")]
        public String Fax
        {
            get
			{
				String vGet = _Fax;
				OnFaxGetting(ref _Fax, ref vGet);
				return vGet;
			}
            set
            {
                OnFaxChanging(value);
                SetProperty(ref _Fax, value);
                OnFaxChanged();
            }
        }
        
        
        [DisplayName("MasoThue")]
        public String MasoThue
        {
            get
			{
				String vGet = _MasoThue;
				OnMasoThueGetting(ref _MasoThue, ref vGet);
				return vGet;
			}
            set
            {
                OnMasoThueChanging(value);
                SetProperty(ref _MasoThue, value);
                OnMasoThueChanged();
            }
        }
        
        
        [DisplayName("TenTaikhoan")]
        public String TenTaikhoan
        {
            get
			{
				String vGet = _TenTaikhoan;
				OnTenTaikhoanGetting(ref _TenTaikhoan, ref vGet);
				return vGet;
			}
            set
            {
                OnTenTaikhoanChanging(value);
                SetProperty(ref _TenTaikhoan, value);
                OnTenTaikhoanChanged();
            }
        }
        
        
        [DisplayName("SoTaikhoan")]
        public String SoTaikhoan
        {
            get
			{
				String vGet = _SoTaikhoan;
				OnSoTaikhoanGetting(ref _SoTaikhoan, ref vGet);
				return vGet;
			}
            set
            {
                OnSoTaikhoanChanging(value);
                SetProperty(ref _SoTaikhoan, value);
                OnSoTaikhoanChanged();
            }
        }
        
        
        [DisplayName("Nganhang")]
        public String Nganhang
        {
            get
			{
				String vGet = _Nganhang;
				OnNganhangGetting(ref _Nganhang, ref vGet);
				return vGet;
			}
            set
            {
                OnNganhangChanging(value);
                SetProperty(ref _Nganhang, value);
                OnNganhangChanged();
            }
        }
        
        
        [DisplayName("Congty")]
        public String Congty
        {
            get
			{
				String vGet = _Congty;
				OnCongtyGetting(ref _Congty, ref vGet);
				return vGet;
			}
            set
            {
                OnCongtyChanging(value);
                SetProperty(ref _Congty, value);
                OnCongtyChanged();
            }
        }
        
        
        [DisplayName("Chucvu")]
        public String Chucvu
        {
            get
			{
				String vGet = _Chucvu;
				OnChucvuGetting(ref _Chucvu, ref vGet);
				return vGet;
			}
            set
            {
                OnChucvuChanging(value);
                SetProperty(ref _Chucvu, value);
                OnChucvuChanged();
            }
        }
        
        
        [DisplayName("Email")]
        public String Email
        {
            get
			{
				String vGet = _Email;
				OnEmailGetting(ref _Email, ref vGet);
				return vGet;
			}
            set
            {
                OnEmailChanging(value);
                SetProperty(ref _Email, value);
                OnEmailChanged();
            }
        }
        
        
        [DisplayName("DiachiCongty")]
        public String DiachiCongty
        {
            get
			{
				String vGet = _DiachiCongty;
				OnDiachiCongtyGetting(ref _DiachiCongty, ref vGet);
				return vGet;
			}
            set
            {
                OnDiachiCongtyChanging(value);
                SetProperty(ref _DiachiCongty, value);
                OnDiachiCongtyChanged();
            }
        }
        
        
        [DisplayName("PhoneCongty")]
        public String PhoneCongty
        {
            get
			{
				String vGet = _PhoneCongty;
				OnPhoneCongtyGetting(ref _PhoneCongty, ref vGet);
				return vGet;
			}
            set
            {
                OnPhoneCongtyChanging(value);
                SetProperty(ref _PhoneCongty, value);
                OnPhoneCongtyChanged();
            }
        }
        
        
        [DisplayName("Tel")]
        public String Tel
        {
            get
			{
				String vGet = _Tel;
				OnTelGetting(ref _Tel, ref vGet);
				return vGet;
			}
            set
            {
                OnTelChanging(value);
                SetProperty(ref _Tel, value);
                OnTelChanged();
            }
        }
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnKhachhangIdChanging(Guid value);
        partial void OnKhachhangIdChanged();
		partial void OnKhachhangIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnQuanhuyenIdChanging(Nullable<Guid> value);
        partial void OnQuanhuyenIdChanged();
		partial void OnQuanhuyenIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnTinhthanhIdChanging(Nullable<Guid> value);
        partial void OnTinhthanhIdChanged();
		partial void OnTinhthanhIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnNhomKhachhangIdChanging(Nullable<Guid> value);
        partial void OnNhomKhachhangIdChanged();
		partial void OnNhomKhachhangIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnThoigianCongnoChanging(Nullable<Int32> value);
        partial void OnThoigianCongnoChanged();
		partial void OnThoigianCongnoGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnToahangCongnoChanging(Nullable<Int32> value);
        partial void OnToahangCongnoChanged();
		partial void OnToahangCongnoGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnNgaysinhChanging(Nullable<DateTime> value);
        partial void OnNgaysinhChanged();
		partial void OnNgaysinhGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnNgayCapnhatChanging(Nullable<DateTime> value);
        partial void OnNgayCapnhatChanged();
		partial void OnNgayCapnhatGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnHanmucCongnoChanging(Nullable<Double> value);
        partial void OnHanmucCongnoChanged();
		partial void OnHanmucCongnoGetting(ref Nullable<Double> value, ref Nullable<Double> vGet);
        
        
        partial void OnGioitinhChanging(Nullable<Boolean> value);
        partial void OnGioitinhChanged();
		partial void OnGioitinhGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnActiveChanging(Nullable<Boolean> value);
        partial void OnActiveChanged();
		partial void OnActiveGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void OnCodeChanging(String value);
        partial void OnCodeChanged();
		partial void OnCodeGetting(ref String value, ref String vGet);
        
        
        partial void OnHotenKhachhangChanging(String value);
        partial void OnHotenKhachhangChanged();
		partial void OnHotenKhachhangGetting(ref String value, ref String vGet);
        
        
        partial void OnCMNDChanging(String value);
        partial void OnCMNDChanged();
		partial void OnCMNDGetting(ref String value, ref String vGet);
        
        
        partial void OnDiachiChanging(String value);
        partial void OnDiachiChanged();
		partial void OnDiachiGetting(ref String value, ref String vGet);
        
        
        partial void OnDiachiGiaohangChanging(String value);
        partial void OnDiachiGiaohangChanged();
		partial void OnDiachiGiaohangGetting(ref String value, ref String vGet);
        
        
        partial void OnLinkanhChanging(String value);
        partial void OnLinkanhChanged();
		partial void OnLinkanhGetting(ref String value, ref String vGet);
        
        
        partial void OnGhichuChanging(String value);
        partial void OnGhichuChanged();
		partial void OnGhichuGetting(ref String value, ref String vGet);
        
        
        partial void OnMobileChanging(String value);
        partial void OnMobileChanged();
		partial void OnMobileGetting(ref String value, ref String vGet);
        
        
        partial void OnFaxChanging(String value);
        partial void OnFaxChanged();
		partial void OnFaxGetting(ref String value, ref String vGet);
        
        
        partial void OnMasoThueChanging(String value);
        partial void OnMasoThueChanged();
		partial void OnMasoThueGetting(ref String value, ref String vGet);
        
        
        partial void OnTenTaikhoanChanging(String value);
        partial void OnTenTaikhoanChanged();
		partial void OnTenTaikhoanGetting(ref String value, ref String vGet);
        
        
        partial void OnSoTaikhoanChanging(String value);
        partial void OnSoTaikhoanChanged();
		partial void OnSoTaikhoanGetting(ref String value, ref String vGet);
        
        
        partial void OnNganhangChanging(String value);
        partial void OnNganhangChanged();
		partial void OnNganhangGetting(ref String value, ref String vGet);
        
        
        partial void OnCongtyChanging(String value);
        partial void OnCongtyChanged();
		partial void OnCongtyGetting(ref String value, ref String vGet);
        
        
        partial void OnChucvuChanging(String value);
        partial void OnChucvuChanged();
		partial void OnChucvuGetting(ref String value, ref String vGet);
        
        
        partial void OnEmailChanging(String value);
        partial void OnEmailChanged();
		partial void OnEmailGetting(ref String value, ref String vGet);
        
        
        partial void OnDiachiCongtyChanging(String value);
        partial void OnDiachiCongtyChanged();
		partial void OnDiachiCongtyGetting(ref String value, ref String vGet);
        
        
        partial void OnPhoneCongtyChanging(String value);
        partial void OnPhoneCongtyChanged();
		partial void OnPhoneCongtyGetting(ref String value, ref String vGet);
        
        
        partial void OnTelChanging(String value);
        partial void OnTelChanged();
		partial void OnTelGetting(ref String value, ref String vGet);
        

        public override AutoObject DataToAutoObject()
        {
            var Items = new List<AutoItem>();

            Items.Add(new AutoItem {Name = "KhachhangId", Value = KhachhangId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "QuanhuyenId", Value = QuanhuyenId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "TinhthanhId", Value = TinhthanhId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "NhomKhachhangId", Value = NhomKhachhangId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "ThoigianCongno", Value = ThoigianCongno, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "ToahangCongno", Value = ToahangCongno, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "Step", Value = Step, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "Ngaysinh", Value = Ngaysinh, SqlType = SqlDbType.DateTime});
            Items.Add(new AutoItem {Name = "NgayCapnhat", Value = NgayCapnhat, SqlType = SqlDbType.DateTime});
            Items.Add(new AutoItem {Name = "HanmucCongno", Value = HanmucCongno, SqlType = SqlDbType.Float});
            Items.Add(new AutoItem {Name = "Gioitinh", Value = Gioitinh, SqlType = SqlDbType.Bit});
            Items.Add(new AutoItem {Name = "Active", Value = Active, SqlType = SqlDbType.Bit});
            Items.Add(new AutoItem {Name = "Version", Value = Version, SqlType = SqlDbType.Timestamp});
            Items.Add(new AutoItem {Name = "Code", Value = Code, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "HotenKhachhang", Value = HotenKhachhang, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "CMND", Value = CMND, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "Diachi", Value = Diachi, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "DiachiGiaohang", Value = DiachiGiaohang, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "Linkanh", Value = Linkanh, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "Ghichu", Value = Ghichu, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "Mobile", Value = Mobile, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "Fax", Value = Fax, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "MasoThue", Value = MasoThue, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "TenTaikhoan", Value = TenTaikhoan, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "SoTaikhoan", Value = SoTaikhoan, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "Nganhang", Value = Nganhang, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "Congty", Value = Congty, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "Chucvu", Value = Chucvu, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "Email", Value = Email, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "DiachiCongty", Value = DiachiCongty, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "PhoneCongty", Value = PhoneCongty, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "Tel", Value = Tel, SqlType = SqlDbType.NVarChar});

            return DataToAutoObject(Items.ToArray());
        }

        public override string GetSpName()
        {
            if (State == RowState.Insert)
                return "sys_KhachhangInsert";
            if (State == RowState.Update)
                return "sys_KhachhangUpdate";
            if (State == RowState.Delete)
                return "sys_KhachhangDelete";
            return "sys_KhachhangSelect";
        }
    }
}