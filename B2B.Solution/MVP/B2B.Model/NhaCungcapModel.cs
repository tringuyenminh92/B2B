using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BMIModel;
using BusinessObject;

namespace B2B.Model
{
    public partial class NhaCungcapModel : Bus
    {
        private Guid _NhaCungcapId;
        private Nullable<Guid> _QuanhuyenId;
        private Nullable<Guid> _TinhthanhId;
        private Nullable<Int32> _Step;
        private Nullable<DateTime> _NgayCapnhat;
        private Nullable<Boolean> _Active;
        private Byte[] _Version;
        private String _Code;
        private String _TenNhaCungcap;
        private String _Diachi;
        private String _TenCongty;
        private String _Fax;
        private String _Tel;
        private String _Ghichu;
        private String _Mobile;
        private String _Email;
        private String _Website;
        private String _TenTaikhoan;
        private String _SoTaikhoan;
        private String _Nganhang;

        public NhaCungcapModel()
        {
			OnCreating();
            NhaCungcapId = ModelCore.GetGuidId();
			OnCreated();
        }

        public NhaCungcapModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }

        
        [DisplayName("NhaCungcapId")]
        public Guid NhaCungcapId
        {
            get
			{
				Guid vGet = _NhaCungcapId;
				OnNhaCungcapIdGetting(ref _NhaCungcapId, ref vGet);
				return vGet;
			}
            set
            {
                OnNhaCungcapIdChanging(value);
                SetProperty(ref _NhaCungcapId, value);
                OnNhaCungcapIdChanged();
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
        
        
        [DisplayName("TenNhaCungcap")]
        public String TenNhaCungcap
        {
            get
			{
				String vGet = _TenNhaCungcap;
				OnTenNhaCungcapGetting(ref _TenNhaCungcap, ref vGet);
				return vGet;
			}
            set
            {
                OnTenNhaCungcapChanging(value);
                SetProperty(ref _TenNhaCungcap, value);
                OnTenNhaCungcapChanged();
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
        
        
        [DisplayName("TenCongty")]
        public String TenCongty
        {
            get
			{
				String vGet = _TenCongty;
				OnTenCongtyGetting(ref _TenCongty, ref vGet);
				return vGet;
			}
            set
            {
                OnTenCongtyChanging(value);
                SetProperty(ref _TenCongty, value);
                OnTenCongtyChanged();
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
        
        
        [DisplayName("Website")]
        public String Website
        {
            get
			{
				String vGet = _Website;
				OnWebsiteGetting(ref _Website, ref vGet);
				return vGet;
			}
            set
            {
                OnWebsiteChanging(value);
                SetProperty(ref _Website, value);
                OnWebsiteChanged();
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
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnNhaCungcapIdChanging(Guid value);
        partial void OnNhaCungcapIdChanged();
		partial void OnNhaCungcapIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnQuanhuyenIdChanging(Nullable<Guid> value);
        partial void OnQuanhuyenIdChanged();
		partial void OnQuanhuyenIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnTinhthanhIdChanging(Nullable<Guid> value);
        partial void OnTinhthanhIdChanged();
		partial void OnTinhthanhIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnNgayCapnhatChanging(Nullable<DateTime> value);
        partial void OnNgayCapnhatChanged();
		partial void OnNgayCapnhatGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnActiveChanging(Nullable<Boolean> value);
        partial void OnActiveChanged();
		partial void OnActiveGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void OnCodeChanging(String value);
        partial void OnCodeChanged();
		partial void OnCodeGetting(ref String value, ref String vGet);
        
        
        partial void OnTenNhaCungcapChanging(String value);
        partial void OnTenNhaCungcapChanged();
		partial void OnTenNhaCungcapGetting(ref String value, ref String vGet);
        
        
        partial void OnDiachiChanging(String value);
        partial void OnDiachiChanged();
		partial void OnDiachiGetting(ref String value, ref String vGet);
        
        
        partial void OnTenCongtyChanging(String value);
        partial void OnTenCongtyChanged();
		partial void OnTenCongtyGetting(ref String value, ref String vGet);
        
        
        partial void OnFaxChanging(String value);
        partial void OnFaxChanged();
		partial void OnFaxGetting(ref String value, ref String vGet);
        
        
        partial void OnTelChanging(String value);
        partial void OnTelChanged();
		partial void OnTelGetting(ref String value, ref String vGet);
        
        
        partial void OnGhichuChanging(String value);
        partial void OnGhichuChanged();
		partial void OnGhichuGetting(ref String value, ref String vGet);
        
        
        partial void OnMobileChanging(String value);
        partial void OnMobileChanged();
		partial void OnMobileGetting(ref String value, ref String vGet);
        
        
        partial void OnEmailChanging(String value);
        partial void OnEmailChanged();
		partial void OnEmailGetting(ref String value, ref String vGet);
        
        
        partial void OnWebsiteChanging(String value);
        partial void OnWebsiteChanged();
		partial void OnWebsiteGetting(ref String value, ref String vGet);
        
        
        partial void OnTenTaikhoanChanging(String value);
        partial void OnTenTaikhoanChanged();
		partial void OnTenTaikhoanGetting(ref String value, ref String vGet);
        
        
        partial void OnSoTaikhoanChanging(String value);
        partial void OnSoTaikhoanChanged();
		partial void OnSoTaikhoanGetting(ref String value, ref String vGet);
        
        
        partial void OnNganhangChanging(String value);
        partial void OnNganhangChanged();
		partial void OnNganhangGetting(ref String value, ref String vGet);
        

        public override AutoObject DataToAutoObject()
        {
            var Items = new List<AutoItem>();

            Items.Add(new AutoItem {Name = "NhaCungcapId", Value = NhaCungcapId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "QuanhuyenId", Value = QuanhuyenId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "TinhthanhId", Value = TinhthanhId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "Step", Value = Step, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "NgayCapnhat", Value = NgayCapnhat, SqlType = SqlDbType.DateTime});
            Items.Add(new AutoItem {Name = "Active", Value = Active, SqlType = SqlDbType.Bit});
            Items.Add(new AutoItem {Name = "Version", Value = Version, SqlType = SqlDbType.Timestamp});
            Items.Add(new AutoItem {Name = "Code", Value = Code, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "TenNhaCungcap", Value = TenNhaCungcap, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "Diachi", Value = Diachi, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "TenCongty", Value = TenCongty, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "Fax", Value = Fax, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "Tel", Value = Tel, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "Ghichu", Value = Ghichu, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "Mobile", Value = Mobile, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "Email", Value = Email, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "Website", Value = Website, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "TenTaikhoan", Value = TenTaikhoan, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "SoTaikhoan", Value = SoTaikhoan, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "Nganhang", Value = Nganhang, SqlType = SqlDbType.NVarChar});

            return DataToAutoObject(Items.ToArray());
        }

        public override string GetSpName()
        {
            if (State == RowState.Insert)
                return "sys_NhaCungcapInsert";
            if (State == RowState.Update)
                return "sys_NhaCungcapUpdate";
            if (State == RowState.Delete)
                return "sys_NhaCungcapDelete";
            return "sys_NhaCungcapSelect";
        }
    }
}