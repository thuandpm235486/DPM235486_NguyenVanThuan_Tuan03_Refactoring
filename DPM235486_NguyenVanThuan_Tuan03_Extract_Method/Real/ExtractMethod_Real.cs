using System;
using System.Collections.Generic;

namespace DPM235486_NguyenVanThuan_Tuan03_Extract_Method
{
    /// <summary>
    /// REAL: Ung dung thuc te - 
    /// </summary>
    public class ExtractMethod_Real
    {
        // Ung dung: xu ly don hang tach thanh cac buoc ro rang
        public void ProcessOrder(string customer, double price, int qty)
        {
            PrintOrderHeader(customer);
            double total = CalculateTotal(price, qty);
            PrintOrderSummary(total);
        }
        private void PrintOrderHeader(string customer)
        {
            Console.WriteLine("=== Order for: " + customer + " ===");
        }
        private double CalculateTotal(double price, int qty)
        {
            return price * qty;
        }
        private void PrintOrderSummary(double total)
        {
            Console.WriteLine("Total amount: " + total.ToString("N0") + " VND");
        }
        public void Run()
        {
            ProcessOrder("Nguyen Van Tuan", 50000, 3);
        }
    }
}