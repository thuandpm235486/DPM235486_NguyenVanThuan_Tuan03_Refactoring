using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Hide_Delegate
{
    /// <summary>
    /// BEFORE: Code chua duoc refactor - 
    /// </summary>
    public class HideDelegate_Before
    {
        // Van de: client can biet ca Department moi lay duoc Manager
        public class Department { public Person Manager { get; set; } }
        public class Person
        {
            public string Name { get; set; }
            public Department Department { get; set; }
        }
        public void Execute()
        {
            var manager = new Person { Name = "Giam Doc" };
            var emp = new Person { Name = "Nhan Vien", Department = new Department { Manager = manager } };
            // Client phai biet co Department moi truy cap Manager
            Console.WriteLine("Manager: " + emp.Department.Manager.Name);
        }
    }
}