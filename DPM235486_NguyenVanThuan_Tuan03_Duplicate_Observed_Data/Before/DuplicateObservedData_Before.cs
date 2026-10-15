using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Duplicate_Observed_Data
{
    /// <summary>
    /// BEFORE: Code chua duoc refactor - 
    /// </summary>
    public class DuplicateObservedData_Before
    {
        // Van de: du lieu nghiep vu nam trong GUI class, kho test va tai su dung
        public class OrderWindow
        {
            private double _startValue = 100.0; // du lieu nghiep vu trong GUI!
            private double _endValue = 200.0;
            public void Display()
            {
                Console.WriteLine("[GUI] Start: " + _startValue);
                Console.WriteLine("[GUI] End  : " + _endValue);
                Console.WriteLine("[GUI] Length: " + (_endValue - _startValue));
            }
        }
        public void Execute() { new OrderWindow().Display(); }
    }
}