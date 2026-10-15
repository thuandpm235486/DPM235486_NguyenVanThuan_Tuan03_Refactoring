using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Introduce_Local_Extension
{
    /// <summary>
    /// BEFORE: Code chua duoc refactor - 
    /// </summary>
    public class IntroduceLocalExtension_Before
    {
        // Van de: can nhieu method tien ich cho DateTime nhung khong sua duoc no
        public void Execute()
        {
            DateTime d = new DateTime(2026, 10, 1);
            DateTime nextDay  = d.AddDays(1);
            DateTime nextWeek = d.AddDays(7);
            bool isWeekend = d.DayOfWeek == DayOfWeek.Saturday || d.DayOfWeek == DayOfWeek.Sunday;
            Console.WriteLine("Date: " + d.ToString("yyyy-MM-dd (ddd)"));
            Console.WriteLine("Next day: " + nextDay.ToString("yyyy-MM-dd"));
            Console.WriteLine("Is weekend: " + isWeekend);
        }
    }
}