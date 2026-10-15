using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Replace_Temp_with_Query
{
    /// <summary>
    /// AFTER: Code da duoc refactor - 
    /// </summary>
    public class ReplaceTempWithQuery_After
    {
        // Giai phap: thay bien tam bang method query co the tai su dung
        private double _quantity = 10;
        private double _itemPrice = 25.0;
        private double BasePrice() { return _quantity * _itemPrice; }
        public void Execute()
        {
            if (BasePrice() > 100)
                Console.WriteLine("Discount: " + BasePrice() * 0.95);
            else
                Console.WriteLine("Full price: " + BasePrice());
        }
    }
}