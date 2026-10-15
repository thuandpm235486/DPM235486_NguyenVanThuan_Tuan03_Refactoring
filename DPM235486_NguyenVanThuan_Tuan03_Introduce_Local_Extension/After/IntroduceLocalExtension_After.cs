using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Introduce_Local_Extension
{
    /// <summary>
    /// AFTER: Code da duoc refactor - 
    /// </summary>
    public class IntroduceLocalExtension_After
    {
        // Giai phap: tao wrapper class (Local Extension) chua cac method can them
        public class MfDate
        {
            private readonly DateTime _date;
            public MfDate(DateTime date) { _date = date; }
            public MfDate(int year, int month, int day) { _date = new DateTime(year, month, day); }
            public DateTime NextDay()  { return _date.AddDays(1); }
            public DateTime NextWeek() { return _date.AddDays(7); }
            public DateTime NextMonth() { return _date.AddMonths(1); }
            public bool IsWeekend() { return _date.DayOfWeek == DayOfWeek.Saturday || _date.DayOfWeek == DayOfWeek.Sunday; }
            public override string ToString() { return _date.ToString("yyyy-MM-dd"); }
        }
        public void Execute()
        {
            var d = new MfDate(2026, 10, 1);
            Console.WriteLine("Date     : " + d);
            Console.WriteLine("Next day : " + d.NextDay().ToString("yyyy-MM-dd"));
            Console.WriteLine("Next week: " + d.NextWeek().ToString("yyyy-MM-dd"));
            Console.WriteLine("Is weekend: " + d.IsWeekend());
        }
    }
}