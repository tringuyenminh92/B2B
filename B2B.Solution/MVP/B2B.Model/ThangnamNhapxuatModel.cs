using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BMIModel;
using BusinessObject;

namespace B2B.Model
{
    public partial class ThangnamNhapxuatModel : Bus
    {
 		public ThangnamNhapxuatModel()
        {
        }
        public ThangnamNhapxuatModel(AutoObject value)
        {
            DataFromAutoObject(value);
        }
        
        [DisplayName("inYear")]
        public Nullable<Int32> inYear{get;set;}
        
        
        [DisplayName("inMonth")]
        public Nullable<Int32> inMonth{get;set;}
        
        
        [DisplayName("onNgay")]
        public Nullable<Int32> onNgay{get;set;}
        
        
        [DisplayName("tongNhap")]
        public Nullable<Double> tongNhap{get;set;}
        
        
        [DisplayName("tongXuat")]
        public Nullable<Double> tongXuat{get;set;}
        
        public override AutoObject DataToAutoObject()
        {
            var Items = new List<AutoItem>();

            Items.Add(new AutoItem {Name = "inYear", Value = inYear, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "inMonth", Value = inMonth, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "onNgay", Value = onNgay, SqlType = SqlDbType.Int});
            Items.Add(new AutoItem {Name = "tongNhap", Value = tongNhap, SqlType = SqlDbType.Float});
            Items.Add(new AutoItem {Name = "tongXuat", Value = tongXuat, SqlType = SqlDbType.Float});

            return DataToAutoObject(Items.ToArray());
        }

        public override string GetSpName()
        {
            return "Tri_GetThangNamNhapXuat";
        }
    }
}