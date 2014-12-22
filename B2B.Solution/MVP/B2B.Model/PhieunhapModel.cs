using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BMIModel;
using BusinessObject;

namespace B2B.Model
{
    public partial class PhieunhapModel : Bus
    {
        private Guid _PhieunhapId;
        private Nullable<Guid> _NhanvienId;
        private Nullable<Guid> _KhoId;
        private Nullable<Guid> _NhacungcapId;
        private Nullable<Guid> _NguyennhanLydo;
        private Nullable<Guid> _TinhtrangPhieunhapCurrentId;
        private Nullable<Int32> _Step;
        private Nullable<DateTime> _Ngaylap;
        private Nullable<Double> _Tongtien;
        private Byte[] _Version;
        private String _Code;
        private String _Ghichu;

        public PhieunhapModel()
        {
			OnCreating();
            PhieunhapId = ModelCore.GetGuidId();
			OnCreated();
        }

        public PhieunhapModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }

        
        [DisplayName("PhieunhapId")]
        public Guid PhieunhapId
        {
            get
			{
				Guid vGet = _PhieunhapId;
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
        
        
        [DisplayName("NhacungcapId")]
        public Nullable<Guid> NhacungcapId
        {
            get
			{
				Nullable<Guid> vGet = _NhacungcapId;
				OnNhacungcapIdGetting(ref _NhacungcapId, ref vGet);
				return vGet;
			}
            set
            {
                OnNhacungcapIdChanging(value);
                SetProperty(ref _NhacungcapId, value);
                OnNhacungcapIdChanged();
            }
        }
        
        
        [DisplayName("NguyennhanLydo")]
        public Nullable<Guid> NguyennhanLydo
        {
            get
			{
				Nullable<Guid> vGet = _NguyennhanLydo;
				OnNguyennhanLydoGetting(ref _NguyennhanLydo, ref vGet);
				return vGet;
			}
            set
            {
                OnNguyennhanLydoChanging(value);
                SetProperty(ref _NguyennhanLydo, value);
                OnNguyennhanLydoChanged();
            }
        }
        
        
        [DisplayName("TinhtrangPhieunhapCurrentId")]
        public Nullable<Guid> TinhtrangPhieunhapCurrentId
        {
            get
			{
				Nullable<Guid> vGet = _TinhtrangPhieunhapCurrentId;
				OnTinhtrangPhieunhapCurrentIdGetting(ref _TinhtrangPhieunhapCurrentId, ref vGet);
				return vGet;
			}
            set
            {
                OnTinhtrangPhieunhapCurrentIdChanging(value);
                SetProperty(ref _TinhtrangPhieunhapCurrentId, value);
                OnTinhtrangPhieunhapCurrentIdChanged();
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
		
        
        partial void OnPhieunhapIdChanging(Guid value);
        partial void OnPhieunhapIdChanged();
		partial void OnPhieunhapIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnNhanvienIdChanging(Nullable<Guid> value);
        partial void OnNhanvienIdChanged();
		partial void OnNhanvienIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnKhoIdChanging(Nullable<Guid> value);
        partial void OnKhoIdChanged();
		partial void OnKhoIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnNhacungcapIdChanging(Nullable<Guid> value);
        partial void OnNhacungcapIdChanged();
		partial void OnNhacungcapIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnNguyennhanLydoChanging(Nullable<Guid> value);
        partial void OnNguyennhanLydoChanged();
		partial void OnNguyennhanLydoGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnTinhtrangPhieunhapCurrentIdChanging(Nullable<Guid> value);
        partial void OnTinhtrangPhieunhapCurrentIdChanged();
		partial void OnTinhtrangPhieunhapCurrentIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnNgaylapChanging(Nullable<DateTime> value);
        partial void OnNgaylapChanged();
		partial void OnNgaylapGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnTongtienChanging(Nullable<Double> value);
        partial void OnTongtienChanged();
		partial void OnTongtienGetting(ref Nullable<Double> value, ref Nullable<Double> vGet);
        
        
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

            Items.Add(new AutoItem {Name = "PhieunhapId", Value = PhieunhapId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "NhanvienId", Value = NhanvienId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "KhoId", Value = KhoId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "NhacungcapId", Value = NhacungcapId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "NguyennhanLydo", Value = NguyennhanLydo, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "TinhtrangPhieunhapCurrentId", Value = TinhtrangPhieunhapCurrentId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "Step", Value = Step, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "Ngaylap", Value = Ngaylap, SqlType = SqlDbType.DateTime});
            Items.Add(new AutoItem {Name = "Tongtien", Value = Tongtien, SqlType = SqlDbType.Float});
            Items.Add(new AutoItem {Name = "Version", Value = Version, SqlType = SqlDbType.Timestamp});
            Items.Add(new AutoItem {Name = "Code", Value = Code, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "Ghichu", Value = Ghichu, SqlType = SqlDbType.NVarChar});

            return DataToAutoObject(Items.ToArray());
        }

        public override string GetSpName()
        {
            if (State == RowState.Insert)
                return "sys_PhieunhapInsert";
            if (State == RowState.Update)
                return "sys_PhieunhapUpdate";
            if (State == RowState.Delete)
                return "sys_PhieunhapDelete";
            return "sys_PhieunhapSelect";
        }
    }
}