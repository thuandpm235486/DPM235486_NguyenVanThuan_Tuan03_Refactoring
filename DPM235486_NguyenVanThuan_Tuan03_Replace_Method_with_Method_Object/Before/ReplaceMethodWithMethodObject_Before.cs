using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Replace_Method_with_Method_Object
{
    /// <summary>
    /// BEFORE: Code chua duoc refactor - 
    /// </summary>
    public class ReplaceMethodWithMethodObject_Before
    {
        // Van de: method phuc tap, nhieu bien cuc bo, kho tach Extract Method
        public class Account
        {
            public double Gamma(double inputVal, int quantity, int yearToDate)
            {
                double importantValue1 = (inputVal * quantity) + Delta();
                double importantValue2 = (inputVal * yearToDate) + 100;
                if ((yearToDate - importantValue1) > 100)
                    importantValue2 -= 20;
                return (importantValue2 * 7) - (2 * importantValue1);
            }
            private double Delta() { return 5.0; }
        }
        public void Execute()
        {
            var acc = new Account();
            Console.WriteLine("Gamma result: " + acc.Gamma(10, 3, 120));
        }
    }
}