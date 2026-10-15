using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Split_Temporary_Variable
{
    /// <summary>
    /// AFTER: Code da duoc refactor - 
    /// </summary>
    public class SplitTemporaryVariable_After
    {
        // Giai phap: moi muc dich dung 1 bien rieng co ten ro rang
        public void Execute()
        {
            double perimeter = 2.0 * (5.0 + 10.0);
            Console.WriteLine("Perimeter: " + perimeter);
            double area = 5.0 * 10.0;
            Console.WriteLine("Area: " + area);
        }
    }
}