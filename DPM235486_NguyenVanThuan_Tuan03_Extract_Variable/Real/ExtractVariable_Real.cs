using System;
using System.Collections.Generic;

namespace DPM235486_NguyenVanThuan_Tuan03_Extract_Variable
{
    /// <summary>
    /// REAL: Ung dung thuc te - 
    /// </summary>
    public class ExtractVariable_Real
    {
        // Ung dung: tinh hoa don voi cac bien co ten ro rang
        public void Run()
        {
            double basePrice     = 1500000;
            double taxRate       = 0.1;
            double shippingFee   = 30000;
            double taxAmount     = basePrice * taxRate;
            double grandTotal    = basePrice + taxAmount + shippingFee;
            Console.WriteLine("Base price  : " + basePrice.ToString("N0"));
            Console.WriteLine("Tax (10%)   : " + taxAmount.ToString("N0"));
            Console.WriteLine("Shipping    : " + shippingFee.ToString("N0"));
            Console.WriteLine("Grand Total : " + grandTotal.ToString("N0") + " VND");
        }
    }
}