using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Duplicate_Observed_Data
{
    /// <summary>
    /// AFTER: Code da duoc refactor - 
    /// </summary>
    public class DuplicateObservedData_After
    {
        // Giai phap: tach du lieu sang Domain class, GUI chi hien thi
        public class Interval // domain object - co the test doc lap
        {
            public double Start { get; set; }
            public double End { get; set; }
            public double Length { get { return End - Start; } }
        }
        public class OrderWindow // GUI class - chi hien thi
        {
            private Interval _subject = new Interval { Start = 100, End = 200 };
            public void Display()
            {
                Console.WriteLine("[GUI] Start : " + _subject.Start);
                Console.WriteLine("[GUI] End   : " + _subject.End);
                Console.WriteLine("[GUI] Length: " + _subject.Length);
            }
        }
        public void Execute() { new OrderWindow().Display(); }
    }
}