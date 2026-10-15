using System;
using System.Collections.Generic;

namespace DPM235486_NguyenVanThuan_Tuan03_Replace_Temp_with_Query
{
    /// <summary>
    /// REAL: Ung dung thuc te - 
    /// </summary>
    public class ReplaceTempWithQuery_Real
    {
        // Ung dung: tinh bang luong voi cac query method ro rang
        private int _hoursWorked = 160;
        private double _hourlyRate = 50000;
        private double GrossPay() { return _hoursWorked * _hourlyRate; }
        private double IncomeTax() { return GrossPay() * 0.1; }
        private double NetPay() { return GrossPay() - IncomeTax(); }
        public void Run()
        {
            Console.WriteLine("Gross Pay  : " + GrossPay().ToString("N0") + " VND");
            Console.WriteLine("Income Tax : " + IncomeTax().ToString("N0") + " VND");
            Console.WriteLine("Net Pay    : " + NetPay().ToString("N0") + " VND");
        }
    }
}