using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BMIModel;
using BusinessObject;

namespace B2B.Model
{
    public partial class HanghoaModel : Bus
    {
        private Guid _HanghoaId;
        private Nullable<Guid> _NhomHanghoaId;
        private Nullable<Guid> _DonviId;
        private Nullable<Int32> _Step;
        private Nullable<DateTime> _NgayCapnhat;
        private Nullable<Double> _Giagoc;
        private Nullable<Boolean> _Active;
        private Byte[] _Version;
        private String _Code;
        private String _TenHanghoa;
        private String _Barcode;
        private String _LinkHinhanh;
        private String _Ghichu;

        public HanghoaModel()
        {
			OnCreating();
            HanghoaId = ModelCore.GetGuidId();
			OnCreated();
        }

        public HanghoaModel(AutoObject value)
        {
			OnCreating();
            DataFromAutoObject(value);
			OnCreated();
        }

        
        [DisplayName("HanghoaId")]
        public Guid HanghoaId
        {
            get
			{
				Guid vGet = _HanghoaId;
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
        
        
        [DisplayName("NhomHanghoaId")]
        public Nullable<Guid> NhomHanghoaId
        {
            get
			{
				Nullable<Guid> vGet = _NhomHanghoaId;
				OnNhomHanghoaIdGetting(ref _NhomHanghoaId, ref vGet);
				return vGet;
			}
            set
            {
                OnNhomHanghoaIdChanging(value);
                SetProperty(ref _NhomHanghoaId, value);
                OnNhomHanghoaIdChanged();
            }
        }
        
        
        [DisplayName("DonviId")]
        public Nullable<Guid> DonviId
        {
            get
			{
				Nullable<Guid> vGet = _DonviId;
				OnDonviIdGetting(ref _DonviId, ref vGet);
				return vGet;
			}
            set
            {
                OnDonviIdChanging(value);
                SetProperty(ref _DonviId, value);
                OnDonviIdChanged();
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
        
        
        [DisplayName("Giagoc")]
        public Nullable<Double> Giagoc
        {
            get
			{
				Nullable<Double> vGet = _Giagoc;
				OnGiagocGetting(ref _Giagoc, ref vGet);
				return vGet;
			}
            set
            {
                OnGiagocChanging(value);
                SetProperty(ref _Giagoc, value);
                OnGiagocChanged();
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
        
        
        [DisplayName("LinkHinhanh")]
        public String LinkHinhanh
        {
            get
			{
				String vGet = _LinkHinhanh;
				OnLinkHinhanhGetting(ref _LinkHinhanh, ref vGet);
				return vGet;
			}
            set
            {
                OnLinkHinhanhChanging(value);
                SetProperty(ref _LinkHinhanh, value);
                OnLinkHinhanhChanged();
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
		
        
        partial void OnHanghoaIdChanging(Guid value);
        partial void OnHanghoaIdChanged();
		partial void OnHanghoaIdGetting(ref Guid value, ref Guid vGet);
        
        
        partial void OnNhomHanghoaIdChanging(Nullable<Guid> value);
        partial void OnNhomHanghoaIdChanged();
		partial void OnNhomHanghoaIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnDonviIdChanging(Nullable<Guid> value);
        partial void OnDonviIdChanged();
		partial void OnDonviIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);
        
        
        partial void OnStepChanging(Nullable<Int32> value);
        partial void OnStepChanged();
		partial void OnStepGetting(ref Nullable<Int32> value, ref Nullable<Int32> vGet);
        
        
        partial void OnNgayCapnhatChanging(Nullable<DateTime> value);
        partial void OnNgayCapnhatChanged();
		partial void OnNgayCapnhatGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);
        
        
        partial void OnGiagocChanging(Nullable<Double> value);
        partial void OnGiagocChanged();
		partial void OnGiagocGetting(ref Nullable<Double> value, ref Nullable<Double> vGet);
        
        
        partial void OnActiveChanging(Nullable<Boolean> value);
        partial void OnActiveChanged();
		partial void OnActiveGetting(ref Nullable<Boolean> value, ref Nullable<Boolean> vGet);
        
        
        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
		partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);
        
        
        partial void OnCodeChanging(String value);
        partial void OnCodeChanged();
		partial void OnCodeGetting(ref String value, ref String vGet);
        
        
        partial void OnTenHanghoaChanging(String value);
        partial void OnTenHanghoaChanged();
		partial void OnTenHanghoaGetting(ref String value, ref String vGet);
        
        
        partial void OnBarcodeChanging(String value);
        partial void OnBarcodeChanged();
		partial void OnBarcodeGetting(ref String value, ref String vGet);
        
        
        partial void OnLinkHinhanhChanging(String value);
        partial void OnLinkHinhanhChanged();
		partial void OnLinkHinhanhGetting(ref String value, ref String vGet);
        
        
        partial void OnGhichuChanging(String value);
        partial void OnGhichuChanged();
		partial void OnGhichuGetting(ref String value, ref String vGet);
        

        public override AutoObject DataToAutoObject()
        {
            var Items = new List<AutoItem>();

            Items.Add(new AutoItem {Name = "HanghoaId", Value = HanghoaId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "NhomHanghoaId", Value = NhomHanghoaId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "DonviId", Value = DonviId, SqlType = SqlDbType.UniqueIdentifier});
            Items.Add(new AutoItem {Name = "Step", Value = Step, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "NgayCapnhat", Value = NgayCapnhat, SqlType = SqlDbType.DateTime});
            Items.Add(new AutoItem {Name = "Giagoc", Value = Giagoc, SqlType = SqlDbType.Float});
            Items.Add(new AutoItem {Name = "Active", Value = Active, SqlType = SqlDbType.Bit});
            Items.Add(new AutoItem {Name = "Version", Value = Version, SqlType = SqlDbType.Timestamp});
            Items.Add(new AutoItem {Name = "Code", Value = Code, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "TenHanghoa", Value = TenHanghoa, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "Barcode", Value = Barcode, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "LinkHinhanh", Value = LinkHinhanh, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "Ghichu", Value = Ghichu, SqlType = SqlDbType.NVarChar});

            return DataToAutoObject(Items.ToArray());
        }

        public override string GetSpName()
        {
            if (State == RowState.Insert)
                return "sys_HanghoaInsert";
            if (State == RowState.Update)
                return "sys_HanghoaUpdate";
            if (State == RowState.Delete)
                return "sys_HanghoaDelete";
            return "sys_HanghoaSelect";
        }
    }
}