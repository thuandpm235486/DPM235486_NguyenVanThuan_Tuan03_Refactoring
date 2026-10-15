using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Introduce_Foreign_Method
{
    /// <summary>
    /// BEFORE: Code chua duoc refactor - 
    /// </summary>
    public class IntroduceForeignMethod_Before
    {
        // Van de: class DateTime khong co method NextDay, phai tinh thu cong
        public void Execute()
        {
            DateTime previousEnd = new DateTime(2026, 10, 1);
            // Phai tu tinh vi DateTime khong co NextDay()
            DateTime newStart = new DateTime(previousEnd.Year, previousEnd.Month, previousEnd.Day + 1);
            Console.WriteLine("New start: " + newStart.ToString("yyyy-MM-dd"));
        }
    }
}