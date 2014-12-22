using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BMIModel;
using BusinessObject;

namespace B2B.Model
{
    public partial class NhanvienModel : Bus
    {
        private Guid _NhanvienId;
        private Nullable<Guid> _PhongbanId;
        private Nullable<Guid> _QuanhuyenId;
        private Nullable<Guid> _TinhthanhId;
        private Nullable<Int32> _Step;
        private Nullable<DateTime> _Ngaysinh;
        private Nullable<DateTime> _NgayBatdau;
        private Nullable<DateTime> _NgayKetthuc;
        private Nullable<DateTime> _NgayCapnhat;
        private Nullable<Boolean> _Gioitinh;
        private Nullable<Boolean> _Active;
        private Byte[] _Version;
        private String _Code;
        private String _TenNhanvien;
        private String _HoNhanvien;
        private String _HovatenNhanvien;
        private String _CMND;
        private String _Email;
        private String _Tel;
        private String _Mobile;
        private String _Diachi;
        private String _Ghichu;
        private String _Linkanh;

        public NhanvienModel()
        {
            OnCreating();
            NhanvienId = ModelCore.GetGuidId();
            OnCreated();
        }

        public NhanvienModel(AutoObject value)
        {
            OnCreating();
            DataFromAutoObject(value);
            OnCreated();
        }


        [DisplayName("NhanvienId")]
        public Guid NhanvienId
        {
            get
            {
                Guid vGet = _NhanvienId;
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


        [DisplayName("PhongbanId")]
        public Nullable<Guid> PhongbanId
        {
            get
            {
                Nullable<Guid> vGet = _PhongbanId;
                OnPhongbanIdGetting(ref _PhongbanId, ref vGet);
                return vGet;
            }
            set
            {
                OnPhongbanIdChanging(value);
                SetProperty(ref _PhongbanId, value);
                OnPhongbanIdChanged();
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


        [DisplayName("NgayBatdau")]
        public Nullable<DateTime> NgayBatdau
        {
            get
            {
                Nullable<DateTime> vGet = _NgayBatdau;
                OnNgayBatdauGetting(ref _NgayBatdau, ref vGet);
                return vGet;
            }
            set
            {
                OnNgayBatdauChanging(value);
                SetProperty(ref _NgayBatdau, value);
                OnNgayBatdauChanged();
            }
        }


        [DisplayName("NgayKetthuc")]
        public Nullable<DateTime> NgayKetthuc
        {
            get
            {
                Nullable<DateTime> vGet = _NgayKetthuc;
                OnNgayKetthucGetting(ref _NgayKetthuc, ref vGet);
                return vGet;
            }
            set
            {
                OnNgayKetthucChanging(value);
                SetProperty(ref _NgayKetthuc, value);
                OnNgayKetthucChanged();
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


        [DisplayName("TenNhanvien")]
        public String TenNhanvien
        {
            get
            {
                String vGet = _TenNhanvien;
                OnTenNhanvienGetting(ref _TenNhanvien, ref vGet);
                return vGet;
            }
            set
            {
                OnTenNhanvienChanging(value);
                SetProperty(ref _TenNhanvien, value);
                OnTenNhanvienChanged();
            }
        }


        [DisplayName("HoNhanvien")]
        public String HoNhanvien
        {
            get
            {
                String vGet = _HoNhanvien;
                OnHoNhanvienGetting(ref _HoNhanvien, ref vGet);
                return vGet;
            }
            set
            {
                OnHoNhanvienChanging(value);
                SetProperty(ref _HoNhanvien, value);
                OnHoNhanvienChanged();
            }
        }


        [DisplayName("HovatenNhanvien")]
        public String HovatenNhanvien
        {
            get
            {
                String vGet = _HovatenNhanvien;
                OnHovatenNhanvienGetting(ref _HovatenNhanvien, ref vGet);
                return (HoNhanvien + " " + TenNhanvien);
            }
            set
            {
                OnHovatenNhanvienChanging(value);
                SetProperty(ref _HovatenNhanvien, value);
                OnHovatenNhanvienChanged();
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


        partial void OnCreating();
        partial void OnCreated();


        partial void OnNhanvienIdChanging(Guid value);
        partial void OnNhanvienIdChanged();
        partial void OnNhanvienIdGetting(ref Guid value, ref Guid vGet);


        partial void OnPhongbanIdChanging(Nullable<Guid> value);
        partial void OnPhongbanIdChanged();
        partial void OnPhongbanIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);


        partial void OnQuanhuyenIdChanging(Nullable<Guid> value);
        partial void OnQuanhuyenIdChanged();
        partial void OnQuanhuyenIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);


        partial void OnTinhthanhIdChanging(Nullable<Guid> value);
        partial void OnTinhthanhIdChanged();
        partial void OnTinhthanhIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);


        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
        partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);


        partial void OnNgaysinhChanging(Nullable<DateTime> value);
        partial void OnNgaysinhChanged();
        partial void OnNgaysinhGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);


        partial void OnNgayBatdauChanging(Nullable<DateTime> value);
        partial void OnNgayBatdauChanged();
        partial void OnNgayBatdauGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);


        partial void OnNgayKetthucChanging(Nullable<DateTime> value);
        partial void OnNgayKetthucChanged();
        partial void OnNgayKetthucGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);


        partial void OnNgayCapnhatChanging(Nullable<DateTime> value);
        partial void OnNgayCapnhatChanged();
        partial void OnNgayCapnhatGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);


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


        partial void OnTenNhanvienChanging(String value);
        partial void OnTenNhanvienChanged();
        partial void OnTenNhanvienGetting(ref String value, ref String vGet);


        partial void OnHoNhanvienChanging(String value);
        partial void OnHoNhanvienChanged();
        partial void OnHoNhanvienGetting(ref String value, ref String vGet);


        partial void OnHovatenNhanvienChanging(String value);
        partial void OnHovatenNhanvienChanged();
        partial void OnHovatenNhanvienGetting(ref String value, ref String vGet);


        partial void OnCMNDChanging(String value);
        partial void OnCMNDChanged();
        partial void OnCMNDGetting(ref String value, ref String vGet);


        partial void OnEmailChanging(String value);
        partial void OnEmailChanged();
        partial void OnEmailGetting(ref String value, ref String vGet);


        partial void OnTelChanging(String value);
        partial void OnTelChanged();
        partial void OnTelGetting(ref String value, ref String vGet);


        partial void OnMobileChanging(String value);
        partial void OnMobileChanged();
        partial void OnMobileGetting(ref String value, ref String vGet);


        partial void OnDiachiChanging(String value);
        partial void OnDiachiChanged();
        partial void OnDiachiGetting(ref String value, ref String vGet);


        partial void OnGhichuChanging(String value);
        partial void OnGhichuChanged();
        partial void OnGhichuGetting(ref String value, ref String vGet);


        partial void OnLinkanhChanging(String value);
        partial void OnLinkanhChanged();
        partial void OnLinkanhGetting(ref String value, ref String vGet);


        public override AutoObject DataToAutoObject()
        {
            var Items = new List<AutoItem>();

            Items.Add(new AutoItem { Name = "NhanvienId", Value = NhanvienId, SqlType = SqlDbType.UniqueIdentifier });
            Items.Add(new AutoItem { Name = "PhongbanId", Value = PhongbanId, SqlType = SqlDbType.UniqueIdentifier });
            Items.Add(new AutoItem { Name = "QuanhuyenId", Value = QuanhuyenId, SqlType = SqlDbType.UniqueIdentifier });
            Items.Add(new AutoItem { Name = "TinhthanhId", Value = TinhthanhId, SqlType = SqlDbType.UniqueIdentifier });
            Items.Add(new AutoItem { Name = "Step", Value = Step, SqlType = SqlDbType.Int });
            Items.Add(new AutoItem { Name = "Ngaysinh", Value = Ngaysinh, SqlType = SqlDbType.DateTime });
            Items.Add(new AutoItem { Name = "NgayBatdau", Value = NgayBatdau, SqlType = SqlDbType.DateTime });
            Items.Add(new AutoItem { Name = "NgayKetthuc", Value = NgayKetthuc, SqlType = SqlDbType.DateTime });
            Items.Add(new AutoItem { Name = "NgayCapnhat", Value = NgayCapnhat, SqlType = SqlDbType.DateTime });
            Items.Add(new AutoItem { Name = "Gioitinh", Value = Gioitinh, SqlType = SqlDbType.Bit });
            Items.Add(new AutoItem { Name = "Active", Value = Active, SqlType = SqlDbType.Bit });
            Items.Add(new AutoItem { Name = "Version", Value = Version, SqlType = SqlDbType.Timestamp });
            Items.Add(new AutoItem { Name = "Code", Value = Code, SqlType = SqlDbType.NVarChar });
            Items.Add(new AutoItem { Name = "TenNhanvien", Value = TenNhanvien, SqlType = SqlDbType.NVarChar });
            Items.Add(new AutoItem { Name = "HoNhanvien", Value = HoNhanvien, SqlType = SqlDbType.NVarChar });
            Items.Add(new AutoItem { Name = "HovatenNhanvien", Value = HovatenNhanvien, SqlType = SqlDbType.NVarChar });
            Items.Add(new AutoItem { Name = "CMND", Value = CMND, SqlType = SqlDbType.NVarChar });
            Items.Add(new AutoItem { Name = "Email", Value = Email, SqlType = SqlDbType.NVarChar });
            Items.Add(new AutoItem { Name = "Tel", Value = Tel, SqlType = SqlDbType.NVarChar });
            Items.Add(new AutoItem { Name = "Mobile", Value = Mobile, SqlType = SqlDbType.NVarChar });
            Items.Add(new AutoItem { Name = "Diachi", Value = Diachi, SqlType = SqlDbType.NVarChar });
            Items.Add(new AutoItem { Name = "Ghichu", Value = Ghichu, SqlType = SqlDbType.NVarChar });
            Items.Add(new AutoItem { Name = "Linkanh", Value = Linkanh, SqlType = SqlDbType.NVarChar });

            return DataToAutoObject(Items.ToArray());
        }

        public override string GetSpName()
        {
            if (State == RowState.Insert)
                return "sys_NhanvienInsert";
            if (State == RowState.Update)
                return "sys_NhanvienUpdate";
            if (State == RowState.Delete)
                return "sys_NhanvienDelete";
            return "sys_NhanvienSelect";
        }
    }
}