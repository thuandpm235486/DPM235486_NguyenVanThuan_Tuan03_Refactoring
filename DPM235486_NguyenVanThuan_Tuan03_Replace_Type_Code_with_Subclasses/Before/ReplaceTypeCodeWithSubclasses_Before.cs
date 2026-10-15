using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Replace_Type_Code_with_Subclasses
{
    /// <summary>
    /// BEFORE: Code chua duoc refactor - 
    /// </summary>
    public class ReplaceTypeCodeWithSubclasses_Before
    {
        // Van de: type code kiem soat hanh vi qua switch/if
        public class Employee
        {
            public const int ENGINEER  = 0;
            public const int SALESMAN  = 1;
            public const int MANAGER   = 2;
            public int Type { get; set; }
            public double GetPayAmount()
            {
                switch (Type)
                {
                    case ENGINEER:  return 5000000;
                    case SALESMAN:  return 4500000;
                    case MANAGER:   return 8000000;
                    default: throw new Exception("Unknown type: " + Type);
                }
            }
        }
        public void Execute()
        {
            var e = new Employee { Type = Employee.SALESMAN };
            Console.WriteLine("Pay (code=" + e.Type + "): " + e.GetPayAmount().ToString("N0"));
        }
    }
}