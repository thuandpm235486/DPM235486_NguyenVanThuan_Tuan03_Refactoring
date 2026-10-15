using System;
using System.Collections.Generic;

namespace DPM235486_NguyenVanThuan_Tuan03_Inline_Method
{
    /// <summary>
    /// REAL: Ung dung thuc te - 
    /// </summary>
    public class InlineMethod_Real
    {
        // Ung dung: tinh phi don gian khong can method rieng
        public double CalculateShipping(double weight)
        {
            return weight <= 5 ? 30000 : 30000 + (weight - 5) * 5000;
        }
        public void Run()
        {
            Console.WriteLine("Ship 3kg : " + CalculateShipping(3) + " VND");
            Console.WriteLine("Ship 10kg: " + CalculateShipping(10) + " VND");
        }
    }
}