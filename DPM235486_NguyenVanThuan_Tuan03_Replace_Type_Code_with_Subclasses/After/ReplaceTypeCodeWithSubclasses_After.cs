using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Replace_Type_Code_with_Subclasses
{
    /// <summary>
    /// AFTER: Code da duoc refactor - 
    /// </summary>
    public class ReplaceTypeCodeWithSubclasses_After
    {
        // Giai phap: tao subclass cho moi loai, dung polymorphism
        public abstract class Employee
        {
            public string Name { get; set; }
            public abstract double GetPayAmount();
            public static Employee Create(int type, string name)
            {
                switch (type)
                {
                    case 0: return new Engineer { Name = name };
                    case 1: return new Salesman { Name = name };
                    case 2: return new Manager  { Name = name };
                    default: throw new Exception("Unknown type");
                }
            }
        }
        public class Engineer : Employee { public override double GetPayAmount() { return 5000000; } }
        public class Salesman : Employee { public override double GetPayAmount() { return 4500000; } }
        public class Manager  : Employee { public override double GetPayAmount() { return 8000000; } }
        public void Execute()
        {
            Employee[] staff = { Employee.Create(0,"An"), Employee.Create(1,"Binh"), Employee.Create(2,"Chau") };
            foreach (var e in staff)
                Console.WriteLine(e.GetType().Name + " " + e.Name + ": " + e.GetPayAmount().ToString("N0") + " VND");
        }
    }
}