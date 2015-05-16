using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BMIModel;
using BusinessObject;

namespace B2B.Model
{
    public partial class CongnoNhapModel : Bus
    {
        private Guid _CongnoNhapId;
        private Nullable<Guid> _NhaCungcapId;
        private Nullable<Guid> _NhanvienId;
        private Nullable<Int32> _Step;
        private Nullable<DateTime> _NgayGiaodich;
        private Nullable<DateTime> _NgayHentra;
        private Nullable<Double> _SoduTruocGiaodich;
        private Nullable<Double> _SotienGiaodich;
        private Nullable<Double> _Tongno;
        private Byte[] _Version;
        private String _Ghichu;

        public CongnoNhapModel()
        {
			OnCreating();
            CongnoNhapId = ModelCore.GetGuidId();
			OnCreated();
        }

        public CongnoNhapModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }

        
        [DisplayName("CongnoNhapId")]
        public Guid CongnoNhapId
        {
            get
			{
				Guid vGet = _CongnoNhapId;
				OnCongnoNhapIdGetting(ref _CongnoNhapId, ref vGet);
				return vGet;
			}
            set
            {
                OnCongnoNhapIdChanging(value);
                SetProperty(ref _CongnoNhapId, value);
                OnCongnoNhapIdChanged();
            }
        }
        
        
        [DisplayName("NhaCungcapId")]
        public Nullable<Guid> NhaCungcapId
        {
            get
			{
				Nullable<Guid> vGet = _NhaCungcapId;
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
        
        
        [DisplayName("NgayHentra")]
        public Nullable<DateTime> NgayHentra
        {
            get
			{
				Nullable<DateTime> vGet = _NgayHentra;
				OnNgayHentraGetting(ref _NgayHentra, ref vGet);
				return vGet;
			}
            set
            {
                OnNgayHentraChanging(value);
                SetProperty(ref _NgayHentra, value);
                OnNgayHentraChanged();
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
		
        
        partial void OnCongnoNhapIdChanging(Guid value);
        partial void OnCongnoNhapIdChanged();
		partial void OnCongnoNhapIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnNhaCungcapIdChanging(Nullable<Guid> value);
        partial void OnNhaCungcapIdChanged();
		partial void OnNhaCungcapIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnNhanvienIdChanging(Nullable<Guid> value);
        partial void OnNhanvienIdChanged();
		partial void OnNhanvienIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnNgayGiaodichChanging(Nullable<DateTime> value);
        partial void OnNgayGiaodichChanged();
		partial void OnNgayGiaodichGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnNgayHentraChanging(Nullable<DateTime> value);
        partial void OnNgayHentraChanged();
		partial void OnNgayHentraGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
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
        
        
        partial void OnGhichuChanging(String value);
        partial void OnGhichuChanged();
		partial void OnGhichuGetting(ref String value, ref String vGet);
        

        public override AutoObject DataToAutoObject()
        {
            var Items = new List<AutoItem>();

            Items.Add(new AutoItem {Name = "CongnoNhapId", Value = CongnoNhapId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "NhaCungcapId", Value = NhaCungcapId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "NhanvienId", Value = NhanvienId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "Step", Value = Step, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "NgayGiaodich", Value = NgayGiaodich, SqlType = SqlDbType.DateTime});
            Items.Add(new AutoItem {Name = "NgayHentra", Value = NgayHentra, SqlType = SqlDbType.DateTime});
            Items.Add(new AutoItem {Name = "SoduTruocGiaodich", Value = SoduTruocGiaodich, SqlType = SqlDbType.Float});
            Items.Add(new AutoItem {Name = "SotienGiaodich", Value = SotienGiaodich, SqlType = SqlDbType.Float});
            Items.Add(new AutoItem {Name = "Tongno", Value = Tongno, SqlType = SqlDbType.Float});
            Items.Add(new AutoItem {Name = "Version", Value = Version, SqlType = SqlDbType.Timestamp});
            Items.Add(new AutoItem {Name = "Ghichu", Value = Ghichu, SqlType = SqlDbType.NVarChar});

            return DataToAutoObject(Items.ToArray());
        }

        public override string GetSpName()
        {
            if (State == RowState.Insert)
                return "sys_CongnoNhapInsert";
            if (State == RowState.Update)
                return "sys_CongnoNhapUpdate";
            if (State == RowState.Delete)
                return "sys_CongnoNhapDelete";
            return "sys_CongnoNhapSelect";
        }
    }
}