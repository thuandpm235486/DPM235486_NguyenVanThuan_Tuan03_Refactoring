using System;
using System.Collections.Generic;

namespace DPM235486_NguyenVanThuan_Tuan03_Split_Temporary_Variable
{
    /// <summary>
    /// REAL: Ung dung thuc te - 
    /// </summary>
    public class SplitTemporaryVariable_Real
    {
        // Ung dung: tinh toan hinh hoc voi cac bien ro rang
        public void Run()
        {
            double width = 8.0, height = 6.0;
            double rectangleArea     = width * height;
            double rectanglePerimeter = 2 * (width + height);
            double diagonal          = Math.Sqrt(width * width + height * height);
            Console.WriteLine("Rectangle " + width + "x" + height + ":");
            Console.WriteLine("  Area      : " + rectangleArea);
            Console.WriteLine("  Perimeter : " + rectanglePerimeter);
            Console.WriteLine("  Diagonal  : " + Math.Round(diagonal, 2));
        }
    }
}