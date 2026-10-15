using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Extract_Variable
{
    /// <summary>
    /// BEFORE: Code chua duoc refactor - 
    /// </summary>
    public class ExtractVariable_Before
    {
        // Van de: bieu thuc phuc tap, kho hieu y nghia
        public void Execute()
        {
            double price = 200.0;
            int quantity = 5;
            if (price * quantity > 500 && price * quantity < 5000)
            {
                Console.WriteLine("Valid order. Total: " + price * quantity);
            }
        }
    }
}