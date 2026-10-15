using System;
using System.Collections.Generic;

namespace DPM235486_NguyenVanThuan_Tuan03_Introduce_Foreign_Method
{
    /// <summary>
    /// REAL: Ung dung thuc te - 
    /// </summary>
    public class IntroduceForeignMethod_Real
    {
        // Ung dung: cac foreign methods bo sung cho DateTime
        private static DateTime FirstDayOfMonth(DateTime d) { return new DateTime(d.Year, d.Month, 1); }
        private static DateTime LastDayOfMonth(DateTime d)  { return new DateTime(d.Year, d.Month, DateTime.DaysInMonth(d.Year, d.Month)); }
        private static DateTime NextMonday(DateTime d)
        {
            int daysUntilMonday = ((int)DayOfWeek.Monday - (int)d.DayOfWeek + 7) % 7;
            if (daysUntilMonday == 0) daysUntilMonday = 7;
            return d.AddDays(daysUntilMonday);
        }
        public void Run()
        {
            DateTime today = new DateTime(2026, 10, 15);
            Console.WriteLine("Today          : " + today.ToString("yyyy-MM-dd"));
            Console.WriteLine("First of month : " + FirstDayOfMonth(today).ToString("yyyy-MM-dd"));
            Console.WriteLine("Last of month  : " + LastDayOfMonth(today).ToString("yyyy-MM-dd"));
            Console.WriteLine("Next Monday    : " + NextMonday(today).ToString("yyyy-MM-dd"));
        }
    }
}