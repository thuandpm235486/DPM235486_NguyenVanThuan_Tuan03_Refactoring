using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Extract_Method
{
    /// <summary>
    /// BEFORE: Code chua duoc refactor - 
    /// </summary>
    public class ExtractMethod_Before
    {
        // Van de: method qua dai, kho doc, kho hieu
        public void PrintOwing(double amount)
        {
            Console.WriteLine("*************************");
            Console.WriteLine("***** Customer Owes *****");
            Console.WriteLine("*************************");
            Console.WriteLine("name: John");
            Console.WriteLine("amount: " + amount);
        }
        public void Execute() { PrintOwing(150.0); }
    }
}