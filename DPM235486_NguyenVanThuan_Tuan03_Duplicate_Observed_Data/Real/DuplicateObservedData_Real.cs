using System;
using System.Collections.Generic;

namespace DPM235486_NguyenVanThuan_Tuan03_Duplicate_Observed_Data
{
    /// <summary>
    /// REAL: Ung dung thuc te - 
    /// </summary>
    public class DuplicateObservedData_Real
    {
        // Ung dung: tach PriceModel khoi PriceForm
        public class PriceModel // domain - co the test rieng
        {
            public double BasePrice { get; set; }
            public double DiscountRate { get; set; }
            public double FinalPrice { get { return BasePrice * (1 - DiscountRate); } }
        }
        public class PriceForm // GUI - chi hien thi
        {
            private PriceModel _model = new PriceModel { BasePrice = 500000, DiscountRate = 0.1 };
            public void Display()
            {
                Console.WriteLine("Base Price : " + _model.BasePrice.ToString("N0") + " VND");
                Console.WriteLine("Discount   : " + (_model.DiscountRate * 100) + "%");
                Console.WriteLine("Final Price: " + _model.FinalPrice.ToString("N0") + " VND");
            }
        }
        public void Run() { new PriceForm().Display(); }
    }
}