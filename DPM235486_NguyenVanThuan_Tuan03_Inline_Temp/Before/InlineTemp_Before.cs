using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Inline_Temp
{
    /// <summary>
    /// BEFORE: Code chua duoc refactor - 
    /// </summary>
    public class InlineTemp_Before
    {
        // Van de: bien tam chi giu ket qua cua 1 bieu thuc, dung 1 lan
        public double GetBasePrice(double qty, double price) { return qty * price; }
        public void Execute()
        {
            double basePrice = GetBasePrice(5, 20.0); // chi dung 1 lan
            if (basePrice > 50)
                Console.WriteLine("Large order. Total = " + basePrice);
        }
    }
}