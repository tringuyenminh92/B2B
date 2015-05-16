using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BMIModel;
using BusinessObject;

namespace B2B.Model
{
    public partial class TinhtrangDonhangModel : Bus
    {
        private Guid _TinhtrangDonhangId;
        private Nullable<Guid> _DonhangId;
        private Nullable<Guid> _PhieuxuatId;
        private Nullable<Guid> _NhanvienCapnhatId;
        private Nullable<Guid> _TinhtrangId;
        private Nullable<DateTime> _NgayCapnhat;
        private Byte[] _Version;
        private String _Ghichu;

        public TinhtrangDonhangModel()
        {
            OnCreating();
            TinhtrangDonhangId = ModelCore.GetGuidId();
            OnCreated();
        }

        public TinhtrangDonhangModel(AutoObject value)
        {
            OnCreating();
            DataFromAutoObject(value);
            OnCreated();
        }


        [DisplayName("TinhtrangDonhangId")]
        public Guid TinhtrangDonhangId
        {
            get
            {
                Guid vGet = _TinhtrangDonhangId;
                OnTinhtrangDonhangIdGetting(ref _TinhtrangDonhangId, ref vGet);
                return vGet;
            }
            set
            {
                OnTinhtrangDonhangIdChanging(value);
                SetProperty(ref _TinhtrangDonhangId, value);
                OnTinhtrangDonhangIdChanged();
            }
        }


        [DisplayName("DonhangId")]
        public Nullable<Guid> DonhangId
        {
            get
            {
                Nullable<Guid> vGet = _DonhangId;
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


        [DisplayName("TinhtrangId")]
        public Nullable<Guid> TinhtrangId
        {
            get
            {
                Nullable<Guid> vGet = _TinhtrangId;
                OnTinhtrangIdGetting(ref _TinhtrangId, ref vGet);
                return vGet;
            }
            set
            {
                OnTinhtrangIdChanging(value);
                SetProperty(ref _TinhtrangId, value);
                OnTinhtrangIdChanged();
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


        partial void OnTinhtrangDonhangIdChanging(Guid value);
        partial void OnTinhtrangDonhangIdChanged();
        partial void OnTinhtrangDonhangIdGetting(ref Guid value, ref Guid vGet);


        partial void OnDonhangIdChanging(Nullable<Guid> value);
        partial void OnDonhangIdChanged();
        partial void OnDonhangIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);


        partial void OnPhieuxuatIdChanging(Nullable<Guid> value);
        partial void OnPhieuxuatIdChanged();
        partial void OnPhieuxuatIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);


        partial void OnNhanvienCapnhatIdChanging(Nullable<Guid> value);
        partial void OnNhanvienCapnhatIdChanged();
        partial void OnNhanvienCapnhatIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);


        partial void OnTinhtrangIdChanging(Nullable<Guid> value);
        partial void OnTinhtrangIdChanged();
        partial void OnTinhtrangIdGetting(ref Nullable<Guid> value, ref Nullable<Guid> vGet);


        partial void OnNgayCapnhatChanging(Nullable<DateTime> value);
        partial void OnNgayCapnhatChanged();
        partial void OnNgayCapnhatGetting(ref Nullable<DateTime> value, ref Nullable<DateTime> vGet);


        partial void OnVersionChanging(Byte[] value);
        partial void OnVersionChanged();
        partial void OnVersionGetting(ref Byte[] value, ref Byte[] vGet);


        partial void OnGhichuChanging(String value);
        partial void OnGhichuChanged();
        partial void OnGhichuGetting(ref String value, ref String vGet);


        public override AutoObject DataToAutoObject()
        {
            var Items = new List<AutoItem>();

            Items.Add(new AutoItem { Name = "TinhtrangDonhangId", Value = TinhtrangDonhangId, SqlType = SqlDbType.UniqueIdentifier });
            Items.Add(new AutoItem { Name = "DonhangId", Value = DonhangId, SqlType = SqlDbType.UniqueIdentifier });
            Items.Add(new AutoItem { Name = "PhieuxuatId", Value = PhieuxuatId, SqlType = SqlDbType.UniqueIdentifier });
            Items.Add(new AutoItem { Name = "NhanvienCapnhatId", Value = NhanvienCapnhatId, SqlType = SqlDbType.UniqueIdentifier });
            Items.Add(new AutoItem { Name = "TinhtrangId", Value = TinhtrangId, SqlType = SqlDbType.UniqueIdentifier });
            Items.Add(new AutoItem { Name = "NgayCapnhat", Value = NgayCapnhat, SqlType = SqlDbType.DateTime });
            Items.Add(new AutoItem { Name = "Version", Value = Version, SqlType = SqlDbType.Timestamp });
            Items.Add(new AutoItem { Name = "Ghichu", Value = Ghichu, SqlType = SqlDbType.NVarChar });

            return DataToAutoObject(Items.ToArray());
        }

        public override string GetSpName()
        {
            if (State == RowState.Insert)
                return "sys_TinhtrangDonhangInsert";
            if (State == RowState.Update)
                return "sys_TinhtrangDonhangUpdate";
            if (State == RowState.Delete)
                return "sys_TinhtrangDonhangDelete";
            return "sys_TinhtrangDonhangSelect";
        }
    }
}