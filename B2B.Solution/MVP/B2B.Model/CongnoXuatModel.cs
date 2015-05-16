using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BMIModel;
using BusinessObject;

namespace B2B.Model
{
    public partial class CongnoXuatModel : Bus
    {
        private Guid _CongnoXuatId;
        private Nullable<Guid> _KhachhangId;
        private Nullable<Guid> _NhanvienId;
        private Nullable<Int32> _Step;
        private Nullable<DateTime> _NgayGiaodich;
        private Nullable<DateTime> _NgayhenTra;
        private Nullable<Double> _SoduTruocGiaodich;
        private Nullable<Double> _SotienGiaodich;
        private Nullable<Double> _Tongno;
        private Byte[] _Version;
        private String _Dienthoai;
        private String _Diachi;
        private String _Ghichu;

        public CongnoXuatModel()
        {
			OnCreating();
            CongnoXuatId = ModelCore.GetGuidId();
			OnCreated();
        }

        public CongnoXuatModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }

        
        [DisplayName("CongnoXuatId")]
        public Guid CongnoXuatId
        {
            get
			{
				Guid vGet = _CongnoXuatId;
				OnCongnoXuatIdGetting(ref _CongnoXuatId, ref vGet);
				return vGet;
			}
            set
            {
                OnCongnoXuatIdChanging(value);
                SetProperty(ref _CongnoXuatId, value);
                OnCongnoXuatIdChanged();
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
        
        
        [DisplayName("NgayGiaodich")]
        public Nullable<DateTime> NgayGiaodich
        {
            get
			{
				Nullable<DateTime> vGet = _NgayGiaodich;
				OnNgayGiaodichGetting(ref _NgayGiaodich, ref vGet);
				return vGet;
			}
            set
            {
                OnNgayGiaodichChanging(value);
                SetProperty(ref _NgayGiaodich, value);
                OnNgayGiaodichChanged();
            }
        }
        
        
        [DisplayName("NgayhenTra")]
        public Nullable<DateTime> NgayhenTra
        {
            get
			{
				Nullable<DateTime> vGet = _NgayhenTra;
				OnNgayhenTraGetting(ref _NgayhenTra, ref vGet);
				return vGet;
			}
            set
            {
                OnNgayhenTraChanging(value);
                SetProperty(ref _NgayhenTra, value);
                OnNgayhenTraChanged();
            }
        }
        
        
        [DisplayName("SoduTruocGiaodich")]
        public Nullable<Double> SoduTruocGiaodich
        {
            get
			{
				Nullable<Double> vGet = _SoduTruocGiaodich;
				OnSoduTruocGiaodichGetting(ref _SoduTruocGiaodich, ref vGet);
				return vGet;
			}
            set
            {
                OnSoduTruocGiaodichChanging(value);
                SetProperty(ref _SoduTruocGiaodich, value);
                OnSoduTruocGiaodichChanged();
            }
        }
        
        
        [DisplayName("SotienGiaodich")]
        public Nullable<Double> SotienGiaodich
        {
            get
			{
				Nullable<Double> vGet = _SotienGiaodich;
				OnSotienGiaodichGetting(ref _SotienGiaodich, ref vGet);
				return vGet;
			}
            set
            {
                OnSotienGiaodichChanging(value);
                SetProperty(ref _SotienGiaodich, value);
                OnSotienGiaodichChanged();
            }
        }
        
        
        [DisplayName("Tongno")]
        public Nullable<Double> Tongno
        {
            get
			{
				Nullable<Double> vGet = _Tongno;
				OnTongnoGetting(ref _Tongno, ref vGet);
				return vGet;
			}
            set
            {
                OnTongnoChanging(value);
                SetProperty(ref _Tongno, value);
                OnTongnoChanged();
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
        
        
        [DisplayName("Dienthoai")]
        public String Dienthoai
        {
            get
			{
				String vGet = _Dienthoai;
				OnDienthoaiGetting(ref _Dienthoai, ref vGet);
				return vGet;
			}
            set
            {
                OnDienthoaiChanging(value);
                SetProperty(ref _Dienthoai, value);
                OnDienthoaiChanged();
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
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnCongnoXuatIdChanging(Guid value);
        partial void OnCongnoXuatIdChanged();
		partial void OnCongnoXuatIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnKhachhangIdChanging(Nullable<Guid> value);
        partial void OnKhachhangIdChanged();
		partial void OnKhachhangIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnNhanvienIdChanging(Nullable<Guid> value);
        partial void OnNhanvienIdChanged();
		partial void OnNhanvienIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnNgayGiaodichChanging(Nullable<DateTime> value);
        partial void OnNgayGiaodichChanged();
		partial void OnNgayGiaodichGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnNgayhenTraChanging(Nullable<DateTime> value);
        partial void OnNgayhenTraChanged();
		partial void OnNgayhenTraGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnSoduTruocGiaodichChanging(Nullable<Double> value);
        partial void OnSoduTruocGiaodichChanged();
		partial void OnSoduTruocGiaodichGetting(ref Nullable<Double> value, ref Nullable<Double> vGet);
        
        
        partial void OnSotienGiaodichChanging(Nullable<Double> value);
        partial void OnSotienGiaodichChanged();
		partial void OnSotienGiaodichGetting(ref Nullable<Double> value, ref Nullable<Double> vGet);
        
        
        partial void OnTongnoChanging(Nullable<Double> value);
        partial void OnTongnoChanged();
		partial void OnTongnoGetting(ref Nullable<Double> value, ref Nullable<Double> vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void OnDienthoaiChanging(String value);
        partial void OnDienthoaiChanged();
		partial void OnDienthoaiGetting(ref String value, ref String vGet);
        
        
        partial void OnDiachiChanging(String value);
        partial void OnDiachiChanged();
		partial void OnDiachiGetting(ref String value, ref String vGet);
        
        
        partial void OnGhichuChanging(String value);
        partial void OnGhichuChanged();
		partial void OnGhichuGetting(ref String value, ref String vGet);
        

        public override AutoObject DataToAutoObject()
        {
            var Items = new List<AutoItem>();

            Items.Add(new AutoItem {Name = "CongnoXuatId", Value = CongnoXuatId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "KhachhangId", Value = KhachhangId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "NhanvienId", Value = NhanvienId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "Step", Value = Step, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "NgayGiaodich", Value = NgayGiaodich, SqlType = SqlDbType.DateTime});
            Items.Add(new AutoItem {Name = "NgayhenTra", Value = NgayhenTra, SqlType = SqlDbType.DateTime});
            Items.Add(new AutoItem {Name = "SoduTruocGiaodich", Value = SoduTruocGiaodich, SqlType = SqlDbType.Float});
            Items.Add(new AutoItem {Name = "SotienGiaodich", Value = SotienGiaodich, SqlType = SqlDbType.Float});
            Items.Add(new AutoItem {Name = "Tongno", Value = Tongno, SqlType = SqlDbType.Float});
            Items.Add(new AutoItem {Name = "Version", Value = Version, SqlType = SqlDbType.Timestamp});
            Items.Add(new AutoItem {Name = "Dienthoai", Value = Dienthoai, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "Diachi", Value = Diachi, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "Ghichu", Value = Ghichu, SqlType = SqlDbType.NVarChar});

            return DataToAutoObject(Items.ToArray());
        }

        public override string GetSpName()
        {
            if (State == RowState.Insert)
                return "sys_CongnoXuatInsert";
            if (State == RowState.Update)
                return "sys_CongnoXuatUpdate";
            if (State == RowState.Delete)
                return "sys_CongnoXuatDelete";
            return "sys_CongnoXuatSelect";
        }
    }
}