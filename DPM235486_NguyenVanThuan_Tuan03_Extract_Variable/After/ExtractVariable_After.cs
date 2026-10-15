using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Extract_Variable
{
    /// <summary>
    /// AFTER: Code da duoc refactor - 
    /// </summary>
    public class ExtractVariable_After
    {
        // Giai phap: dung bien co ten giai thich bieu thuc
        public void Execute()
        {
            double price = 200.0;
            int quantity = 5;
            double orderTotal = price * quantity;
            bool isValidOrder = orderTotal > 500 && orderTotal < 5000;
            if (isValidOrder)
            {
                Console.WriteLine("Valid order. Total: " + orderTotal);
            }
        }
    }
}