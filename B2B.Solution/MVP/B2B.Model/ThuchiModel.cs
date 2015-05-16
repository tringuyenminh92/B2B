using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BMIModel;
using BusinessObject;

namespace B2B.Model
{
    public partial class ThuchiModel : Bus
    {
        private Guid _ThuchiId;
        private Nullable<Guid> _NhanvienId;
        private Nullable<Guid> _PhieunhapId;
        private Nullable<Guid> _PhieuxuatId;
        private Nullable<Guid> _NhannopTienId;
        private Nullable<Int32> _Ngay;
        private Nullable<Int32> _Thang;
        private Nullable<Int32> _Nam;
        private Nullable<Int32> _Step;
        private Nullable<DateTime> _Vaoluc;
        private Nullable<Double> _Tongtien;
        private Byte[] _Version;
        private String _Ghichu;
        private String _TenNhannopTien;

        public ThuchiModel()
        {
			OnCreating();
            ThuchiId = ModelCore.GetGuidId();
			OnCreated();
        }

        public ThuchiModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }

        
        [DisplayName("ThuchiId")]
        public Guid ThuchiId
        {
            get
			{
				Guid vGet = _ThuchiId;
				OnThuchiIdGetting(ref _ThuchiId, ref vGet);
				return vGet;
			}
            set
            {
                OnThuchiIdChanging(value);
                SetProperty(ref _ThuchiId, value);
                OnThuchiIdChanged();
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
        
        
        [DisplayName("PhieunhapId")]
        public Nullable<Guid> PhieunhapId
        {
            get
			{
				Nullable<Guid> vGet = _PhieunhapId;
				OnPhieunhapIdGetting(ref _PhieunhapId, ref vGet);
				return vGet;
			}
            set
            {
                OnPhieunhapIdChanging(value);
                SetProperty(ref _PhieunhapId, value);
                OnPhieunhapIdChanged();
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
        
        
        [DisplayName("NhannopTienId")]
        public Nullable<Guid> NhannopTienId
        {
            get
			{
				Nullable<Guid> vGet = _NhannopTienId;
				OnNhannopTienIdGetting(ref _NhannopTienId, ref vGet);
				return vGet;
			}
            set
            {
                OnNhannopTienIdChanging(value);
                SetProperty(ref _NhannopTienId, value);
                OnNhannopTienIdChanged();
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
        
        
        [DisplayName("Vaoluc")]
        public Nullable<DateTime> Vaoluc
        {
            get
			{
				Nullable<DateTime> vGet = _Vaoluc;
				OnVaolucGetting(ref _Vaoluc, ref vGet);
				return vGet;
			}
            set
            {
                OnVaolucChanging(value);
                SetProperty(ref _Vaoluc, value);
                OnVaolucChanged();
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
        
        
        [DisplayName("TenNhannopTien")]
        public String TenNhannopTien
        {
            get
			{
				String vGet = _TenNhannopTien;
				OnTenNhannopTienGetting(ref _TenNhannopTien, ref vGet);
				return vGet;
			}
            set
            {
                OnTenNhannopTienChanging(value);
                SetProperty(ref _TenNhannopTien, value);
                OnTenNhannopTienChanged();
            }
        }
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnThuchiIdChanging(Guid value);
        partial void OnThuchiIdChanged();
		partial void OnThuchiIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnNhanvienIdChanging(Nullable<Guid> value);
        partial void OnNhanvienIdChanged();
		partial void OnNhanvienIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnPhieunhapIdChanging(Nullable<Guid> value);
        partial void OnPhieunhapIdChanged();
		partial void OnPhieunhapIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnPhieuxuatIdChanging(Nullable<Guid> value);
        partial void OnPhieuxuatIdChanged();
		partial void OnPhieuxuatIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnNhannopTienIdChanging(Nullable<Guid> value);
        partial void OnNhannopTienIdChanged();
		partial void OnNhannopTienIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnNgayChanging(Nullable<Int32> value);
        partial void OnNgayChanged();
		partial void OnNgayGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnThangChanging(Nullable<Int32> value);
        partial void OnThangChanged();
		partial void OnThangGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnNamChanging(Nullable<Int32> value);
        partial void OnNamChanged();
		partial void OnNamGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnVaolucChanging(Nullable<DateTime> value);
        partial void OnVaolucChanged();
		partial void OnVaolucGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnTongtienChanging(Nullable<Double> value);
        partial void OnTongtienChanged();
		partial void OnTongtienGetting(ref Nullable<Double> value, ref Nullable<Double> vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void OnGhichuChanging(String value);
        partial void OnGhichuChanged();
		partial void OnGhichuGetting(ref String value, ref String vGet);
        
        
        partial void OnTenNhannopTienChanging(String value);
        partial void OnTenNhannopTienChanged();
		partial void OnTenNhannopTienGetting(ref String value, ref String vGet);
        

        public override AutoObject DataToAutoObject()
        {
            var Items = new List<AutoItem>();

            Items.Add(new AutoItem {Name = "ThuchiId", Value = ThuchiId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "NhanvienId", Value = NhanvienId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "PhieunhapId", Value = PhieunhapId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "PhieuxuatId", Value = PhieuxuatId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "NhannopTienId", Value = NhannopTienId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "Ngay", Value = Ngay, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "Thang", Value = Thang, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "Nam", Value = Nam, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "Step", Value = Step, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "Vaoluc", Value = Vaoluc, SqlType = SqlDbType.DateTime});
            Items.Add(new AutoItem {Name = "Tongtien", Value = Tongtien, SqlType = SqlDbType.Float});
            Items.Add(new AutoItem {Name = "Version", Value = Version, SqlType = SqlDbType.Timestamp});
            Items.Add(new AutoItem {Name = "Ghichu", Value = Ghichu, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "TenNhannopTien", Value = TenNhannopTien, SqlType = SqlDbType.NVarChar});

            return DataToAutoObject(Items.ToArray());
        }

        public override string GetSpName()
        {
            if (State == RowState.Insert)
                return "sys_ThuchiInsert";
            if (State == RowState.Update)
                return "sys_ThuchiUpdate";
            if (State == RowState.Delete)
                return "sys_ThuchiDelete";
            return "sys_ThuchiSelect";
        }
    }
}