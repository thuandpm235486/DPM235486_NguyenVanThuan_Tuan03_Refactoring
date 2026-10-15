using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Introduce_Foreign_Method
{
    /// <summary>
    /// AFTER: Code da duoc refactor - 
    /// </summary>
    public class IntroduceForeignMethod_After
    {
        // Giai phap: tao Foreign Method trong client class
        private static DateTime NextDay(DateTime date)
        {
            return date.AddDays(1); // foreign method them vao client class
        }
        public void Execute()
        {
            DateTime previousEnd = new DateTime(2026, 10, 1);
            DateTime newStart = NextDay(previousEnd); // ro rang, de hieu
            Console.WriteLine("New start: " + newStart.ToString("yyyy-MM-dd"));
        }
    }
}