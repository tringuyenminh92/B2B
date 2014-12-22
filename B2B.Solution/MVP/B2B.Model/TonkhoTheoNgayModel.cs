using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BMIModel;
using BusinessObject;

namespace B2B.Model
{
    public partial class TonkhoTheoNgayModel : Bus
    {
 		public TonkhoTheoNgayModel()
        {
        }
        public TonkhoTheoNgayModel(AutoObject value)
        {
            DataFromAutoObject(value);
        }
        
        [DisplayName("TenHanghoa")]
        public String TenHanghoa{get;set;}
        
        
        [DisplayName("Tongnhap")]
        public Nullable<Int32> Tongnhap{get;set;}
        
        
        [DisplayName("Tongxuat")]
        public Nullable<Int32> Tongxuat{get;set;}
        
        
        [DisplayName("TongtienNhap")]
        public Nullable<Double> TongtienNhap{get;set;}
        
        
        [DisplayName("TongtienXuat")]
        public Nullable<Double> TongtienXuat{get;set;}
        
        
        [DisplayName("SoduBandau")]
        public Nullable<Int32> SoduBandau{get;set;}
        
        
        [DisplayName("SoluongTon")]
        public Nullable<Int32> SoluongTon{get;set;}
        
        public override AutoObject DataToAutoObject()
        {
            var Items = new List<AutoItem>();

            Items.Add(new AutoItem {Name = "TenHanghoa", Value = TenHanghoa, SqlType = SqlDbType.NVarChar});
            Items.Add(new AutoItem {Name = "Tongnhap", Value = Tongnhap, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "Tongxuat", Value = Tongxuat, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "TongtienNhap", Value = TongtienNhap, SqlType = SqlDbType.Float});
            Items.Add(new AutoItem {Name = "TongtienXuat", Value = TongtienXuat, SqlType = SqlDbType.Float});
            Items.Add(new AutoItem {Name = "SoduBandau", Value = SoduBandau, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "SoluongTon", Value = SoluongTon, SqlType = SqlDbType.Int});

            return DataToAutoObject(Items.ToArray());
        }

        public override string GetSpName()
        {
            return "Tri_GetTonkhoTheoNgay";
        }
    }
}