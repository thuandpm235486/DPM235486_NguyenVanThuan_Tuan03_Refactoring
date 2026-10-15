using System;
using System.Collections.Generic;

namespace DPM235486_NguyenVanThuan_Tuan03_Replace_Method_with_Method_Object
{
    /// <summary>
    /// REAL: Ung dung thuc te - 
    /// </summary>
    public class ReplaceMethodWithMethodObject_Real
    {
        // Ung dung: class tinh tien thue phuc tap
        public class TaxCalculator
        {
            private readonly double _income;
            private readonly bool _hasDependent;
            private readonly bool _isSenior;
            public TaxCalculator(double income, bool hasDependent, bool isSenior)
            {
                _income = income; _hasDependent = hasDependent; _isSenior = isSenior;
            }
            private double TaxableIncome()
            {
                double taxable = _income;
                if (_hasDependent) taxable -= 3600000;
                if (_isSenior) taxable -= 1800000;
                return taxable > 0 ? taxable : 0;
            }
            public double Calculate() { return TaxableIncome() * 0.1; }
        }
        public void Run()
        {
            var calc = new TaxCalculator(15000000, true, false);
            Console.WriteLine("Tax payable: " + calc.Calculate().ToString("N0") + " VND");
        }
    }
}