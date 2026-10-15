using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Replace_Type_Code_with_State_Strategy
{
    /// <summary>
    /// AFTER: Code da duoc refactor - 
    /// </summary>
    public class ReplaceTypeCodeWithStateStrategy_After
    {
        // Giai phap: dung State/Strategy object co the thay the khi runtime
        public abstract class EmployeeType { public abstract double GetPayAmount(); }
        public class EngineerType : EmployeeType { public override double GetPayAmount() { return 5000000; } }
        public class SalesmanType : EmployeeType { public override double GetPayAmount() { return 4500000; } }
        public class ManagerType  : EmployeeType { public override double GetPayAmount() { return 8000000; } }
        public class Employee
        {
            public EmployeeType Type { get; set; }
            public double GetPayAmount() { return Type.GetPayAmount(); }
        }
        public void Execute()
        {
            var e = new Employee { Type = new EngineerType() };
            Console.WriteLine("Pay: " + e.GetPayAmount().ToString("N0"));
            e.Type = new SalesmanType(); // thay doi State khi runtime
            Console.WriteLine("Pay after change: " + e.GetPayAmount().ToString("N0"));
        }
    }
}