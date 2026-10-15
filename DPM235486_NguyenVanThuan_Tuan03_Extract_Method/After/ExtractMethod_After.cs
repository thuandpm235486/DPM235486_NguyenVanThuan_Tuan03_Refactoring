using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Extract_Method
{
    /// <summary>
    /// AFTER: Code da duoc refactor - 
    /// </summary>
    public class ExtractMethod_After
    {
        // Giai phap: tach thanh cac method nho, moi method lam 1 viec
        public void PrintOwing(double amount)
        {
            PrintBanner();
            PrintDetails(amount);
        }
        private void PrintBanner()
        {
            Console.WriteLine("*************************");
            Console.WriteLine("***** Customer Owes *****");
            Console.WriteLine("*************************");
        }
        private void PrintDetails(double amount)
        {
            Console.WriteLine("name: John");
            Console.WriteLine("amount: " + amount);
        }
        public void Execute() { PrintOwing(150.0); }
    }
}