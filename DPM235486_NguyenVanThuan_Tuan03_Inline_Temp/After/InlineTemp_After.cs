using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Inline_Temp
{
    /// <summary>
    /// AFTER: Code da duoc refactor - 
    /// </summary>
    public class InlineTemp_After
    {
        // Giai phap: thay bien tam bang bieu thuc truc tiep
        public double GetBasePrice(double qty, double price) { return qty * price; }
        public void Execute()
        {
            if (GetBasePrice(5, 20.0) > 50)
                Console.WriteLine("Large order. Total = " + GetBasePrice(5, 20.0));
        }
    }
}