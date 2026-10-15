using System;
using System.Collections.Generic;

namespace DPM235486_NguyenVanThuan_Tuan03_Introduce_Local_Extension
{
    /// <summary>
    /// REAL: Ung dung thuc te - 
    /// </summary>
    public class IntroduceLocalExtension_Real
    {
        // Ung dung: WorkDate wrapper cho quan ly lich lam viec
        public class WorkDate
        {
            private readonly DateTime _date;
            public WorkDate(DateTime date) { _date = date; }
            public bool IsWorkday()
            {
                return _date.DayOfWeek != DayOfWeek.Saturday && _date.DayOfWeek != DayOfWeek.Sunday;
            }
            public DateTime NextWorkday()
            {
                DateTime next = _date.AddDays(1);
                while (next.DayOfWeek == DayOfWeek.Saturday || next.DayOfWeek == DayOfWeek.Sunday)
                    next = next.AddDays(1);
                return next;
            }
            public int WorkdaysUntil(DateTime target)
            {
                int count = 0;
                DateTime cur = _date.AddDays(1);
                while (cur <= target) { if (cur.DayOfWeek != DayOfWeek.Saturday && cur.DayOfWeek != DayOfWeek.Sunday) count++; cur = cur.AddDays(1); }
                return count;
            }
        }
        public void Run()
        {
            var friday = new WorkDate(new DateTime(2026, 10, 9)); // Thu 6
            Console.WriteLine("Is workday    : " + friday.IsWorkday());
            Console.WriteLine("Next workday  : " + friday.NextWorkday().ToString("yyyy-MM-dd (ddd)"));
            Console.WriteLine("Workdays to 20/10: " + friday.WorkdaysUntil(new DateTime(2026, 10, 20)));
        }
    }
}