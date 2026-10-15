using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Replace_Type_Code_with_State_Strategy
{
    /// <summary>
    /// BEFORE: Code chua duoc refactor - 
    /// </summary>
    public class ReplaceTypeCodeWithStateStrategy_Before
    {
        // Van de: type code co the thay doi khi runtime, gia tri anh huong hanh vi
        public class Employee
        {
            public int Type { get; set; } // co the thay doi
            public double GetPayAmount()
            {
                if (Type == 0) return 5000000;
                if (Type == 1) return 4500000;
                return 0;
            }
        }
        public void Execute()
        {
            var e = new Employee { Type = 0 };
            Console.WriteLine("Pay: " + e.GetPayAmount().ToString("N0"));
            e.Type = 1; // thay doi khi runtime
            Console.WriteLine("Pay after change: " + e.GetPayAmount().ToString("N0"));
        }
    }
}