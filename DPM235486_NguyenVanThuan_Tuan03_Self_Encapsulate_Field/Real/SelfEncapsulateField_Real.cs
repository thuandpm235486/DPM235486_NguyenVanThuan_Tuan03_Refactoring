using System;
using System.Collections.Generic;

namespace DPM235486_NguyenVanThuan_Tuan03_Self_Encapsulate_Field
{
    /// <summary>
    /// REAL: Ung dung thuc te - 
    /// </summary>
    public class SelfEncapsulateField_Real
    {
        // Ung dung: quy luong voi validation thong qua property
        private double _minSalary;
        private double _maxSalary;
        protected double MinSalary { get { return _minSalary; } set { _minSalary = value >= 0 ? value : 0; } }
        protected double MaxSalary { get { return _maxSalary; } set { _maxSalary = value >= MinSalary ? value : MinSalary; } }
        public bool IsInRange(double salary) { return salary >= MinSalary && salary <= MaxSalary; }
        public void Run()
        {
            MinSalary = 5000000;
            MaxSalary = 20000000;
            Console.WriteLine("Min: " + MinSalary.ToString("N0") + " | Max: " + MaxSalary.ToString("N0"));
            Console.WriteLine("8M in range : " + IsInRange(8000000));
            Console.WriteLine("25M in range: " + IsInRange(25000000));
        }
    }
}