using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Split_Temporary_Variable
{
    /// <summary>
    /// BEFORE: Code chua duoc refactor - 
    /// </summary>
    public class SplitTemporaryVariable_Before
    {
        // Van de: mot bien tam duoc tai su dung cho nhieu muc dich
        public void Execute()
        {
            double temp = 2.0 * (5.0 + 10.0); // lan 1: chu vi
            Console.WriteLine("Perimeter: " + temp);
            temp = 5.0 * 10.0;                 // lan 2: dien tich - tai su dung!
            Console.WriteLine("Area: " + temp);
        }
    }
}