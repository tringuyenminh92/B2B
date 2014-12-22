using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BMIModel;
using BusinessObject;

namespace B2B.Model
{
    public partial class ChitietPhieunhapModel : Bus
    {
        private Guid _ChitietPhieunhapId;
        private Nullable<Guid> _PhieunhapId;
        private Nullable<Guid> _HanghoaId;
        private Nullable<Int32> _Soluong;
        private Nullable<Int32> _Step;
        private Nullable<DateTime> _NSX;
        private Nullable<DateTime> _HSD;
        private Nullable<Double> _Gianhap;
        private Nullable<Double> _Thanhtien;
        private Byte[] _Version;
        private String _Barcode;
        private String _Ghichu;
        private String _TenHanghoa;

        public ChitietPhieunhapModel()
        {
			OnCreating();
            ChitietPhieunhapId = ModelCore.GetGuidId();
			OnCreated();
        }

        public ChitietPhieunhapModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }

        
        [DisplayName("ChitietPhieunhapId")]
        public Guid ChitietPhieunhapId
        {
            get
			{
				Guid vGet = _ChitietPhieunhapId;
				OnChitietPhieunhapIdGetting(ref _ChitietPhieunhapId, ref vGet);
				return vGet;
			}
            set
            {
                OnChitietPhieunhapIdChanging(value);
                SetProperty(ref _ChitietPhieunhapId, value);
                OnChitietPhieunhapIdChanged();
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
        
        
        [DisplayName("NSX")]
        public Nullable<DateTime> NSX
        {
            get
			{
				Nullable<DateTime> vGet = _NSX;
				OnNSXGetting(ref _NSX, ref vGet);
				return vGet;
			}
            set
            {
                OnNSXChanging(value);
                SetProperty(ref _NSX, value);
                OnNSXChanged();
            }
        }
        
        
        [DisplayName("HSD")]
        public Nullable<DateTime> HSD
        {
            get
			{
				Nullable<DateTime> vGet = _HSD;
				OnHSDGetting(ref _HSD, ref vGet);
				return vGet;
			}
            set
            {
                OnHSDChanging(value);
                SetProperty(ref _HSD, value);
                OnHSDChanged();
            }
        }
        
        
        [DisplayName("Gianhap")]
        public Nullable<Double> Gianhap
        {
            get
			{
				Nullable<Double> vGet = _Gianhap;
				OnGianhapGetting(ref _Gianhap, ref vGet);
				return vGet;
			}
            set
            {
                OnGianhapChanging(value);
                SetProperty(ref _Gianhap, value);
                OnGianhapChanged();
            }
        }
        
        
        [DisplayName("Thanhtien")]
        public Nullable<Double> Thanhtien
        {
            get
			{
                //Nullable<Double> vGet = _Thanhtien;
                //OnThanhtienGetting(ref _Thanhtien, ref vGet);
                //return vGet;
			    return Soluong*Gianhap;}
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
        
        
        [DisplayName("Barcode")]
        public String Barcode
        {
            get
			{
				String vGet = _Barcode;
				OnBarcodeGetting(ref _Barcode, ref vGet);
				return vGet;
			}
            set
            {
                OnBarcodeChanging(value);
                SetProperty(ref _Barcode, value);
                OnBarcodeChanged();
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
        
		
		partial void OnCreating();
        partial void OnCreated();
		
        
        partial void OnChitietPhieunhapIdChanging(Guid value);
        partial void OnChitietPhieunhapIdChanged();
		partial void OnChitietPhieunhapIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnPhieunhapIdChanging(Nullable<Guid> value);
        partial void OnPhieunhapIdChanged();
		partial void OnPhieunhapIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnHanghoaIdChanging(Nullable<Guid> value);
        partial void OnHanghoaIdChanged();
		partial void OnHanghoaIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnSoluongChanging(Nullable<Int32> value);
        partial void OnSoluongChanged();
		partial void OnSoluongGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnNSXChanging(Nullable<DateTime> value);
        partial void OnNSXChanged();
		partial void OnNSXGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnHSDChanging(Nullable<DateTime> value);
        partial void OnHSDChanged();
		partial void OnHSDGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnGianhapChanging(Nullable<Double> value);
        partial void OnGianhapChanged();
		partial void OnGianhapGetting(ref Nullable<Double> value, ref Nullable<Double> vGet);
        
        
        partial void OnThanhtienChanging(Nullable<Double> value);
        partial void OnThanhtienChanged();
		partial void OnThanhtienGetting(ref Nullable<Double> value, ref Nullable<Double> vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void OnBarcodeChanging(String value);
        partial void OnBarcodeChanged();
		partial void OnBarcodeGetting(ref String value, ref String vGet);
        
        
        partial void OnGhichuChanging(String value);
        partial void OnGhichuChanged();
		partial void OnGhichuGetting(ref String value, ref String vGet);
        
        
        partial void OnTenHanghoaChanging(String value);
        partial void OnTenHanghoaChanged();
		partial void OnTenHanghoaGetting(ref String value, ref String vGet);
        

        public override AutoObject DataToAutoObject()
        {
            var Items = new List<AutoItem>();

            Items.Add(new AutoItem {Name = "ChitietPhieunhapId", Value = ChitietPhieunhapId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "PhieunhapId", Value = PhieunhapId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "HanghoaId", Value = HanghoaId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "Soluong", Value = Soluong, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "Step", Value = Step, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "NSX", Value = NSX, SqlType = SqlDbType.DateTime});
            Items.Add(new AutoItem {Name = "HSD", Value = HSD, SqlType = SqlDbType.DateTime});
            Items.Add(new AutoItem {Name = "Gianhap", Value = Gianhap, SqlType = SqlDbType.Float});
            Items.Add(new AutoItem {Name = "Thanhtien", Value = Thanhtien, SqlType = SqlDbType.Float});
            Items.Add(new AutoItem {Name = "Version", Value = Version, SqlType = SqlDbType.Timestamp});
            Items.Add(new AutoItem {Name = "Barcode", Value = Barcode, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "Ghichu", Value = Ghichu, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "TenHanghoa", Value = TenHanghoa, SqlType = SqlDbType.NVarChar});

            return DataToAutoObject(Items.ToArray());
        }

        public override string GetSpName()
        {
            if (State == RowState.Insert)
                return "sys_ChitietPhieunhapInsert";
            if (State == RowState.Update)
                return "sys_ChitietPhieunhapUpdate";
            if (State == RowState.Delete)
                return "sys_ChitietPhieunhapDelete";
            return "sys_ChitietPhieunhapSelect";
        }
    }
}