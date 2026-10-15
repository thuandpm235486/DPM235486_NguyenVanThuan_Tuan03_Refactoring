using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Replace_Temp_with_Query
{
    /// <summary>
    /// BEFORE: Code chua duoc refactor - 
    /// </summary>
    public class ReplaceTempWithQuery_Before
    {
        // Van de: bien tam luu ket qua de dung nhieu noi trong method
        private double _quantity = 10;
        private double _itemPrice = 25.0;
        public void Execute()
        {
            double basePrice = _quantity * _itemPrice; // bien tam
            if (basePrice > 100)
                Console.WriteLine("Discount: " + basePrice * 0.95);
            else
                Console.WriteLine("Full price: " + basePrice);
        }
    }
}