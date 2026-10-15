using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Replace_Method_with_Method_Object
{
    /// <summary>
    /// AFTER: Code da duoc refactor - 
    /// </summary>
    public class ReplaceMethodWithMethodObject_After
    {
        // Giai phap: chuyen method thanh class rieng, bien cuc bo thanh fields
        public class GammaCalculator
        {
            private readonly double _inputVal;
            private readonly int _quantity;
            private readonly int _yearToDate;
            private double _importantValue1;
            private double _importantValue2;

            public GammaCalculator(double inputVal, int quantity, int yearToDate)
            {
                _inputVal = inputVal;
                _quantity = quantity;
                _yearToDate = yearToDate;
            }
            private double Delta() { return 5.0; }
            public double Compute()
            {
                _importantValue1 = (_inputVal * _quantity) + Delta();
                _importantValue2 = (_inputVal * _yearToDate) + 100;
                if ((_yearToDate - _importantValue1) > 100)
                    _importantValue2 -= 20;
                return (_importantValue2 * 7) - (2 * _importantValue1);
            }
        }
        public void Execute()
        {
            var calc = new GammaCalculator(10, 3, 120);
            Console.WriteLine("Gamma result: " + calc.Compute());
        }
    }
}