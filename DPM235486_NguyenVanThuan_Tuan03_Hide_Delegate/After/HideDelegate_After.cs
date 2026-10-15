using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Hide_Delegate
{
    /// <summary>
    /// AFTER: Code da duoc refactor - 
    /// </summary>
    public class HideDelegate_After
    {
        // Giai phap: Person an Department, cung cap GetManager() truc tiep
        public class Department { public Person Manager { get; set; } }
        public class Person
        {
            public string Name { get; set; }
            private Department _dept;
            public void SetDepartment(Person manager) { _dept = new Department { Manager = manager }; }
            public Person GetManager() { return _dept?.Manager; } // client chi goi GetManager()
        }
        public void Execute()
        {
            var manager = new Person { Name = "Giam Doc" };
            var emp = new Person { Name = "Nhan Vien" };
            emp.SetDepartment(manager);
            Console.WriteLine("Manager: " + emp.GetManager().Name);
        }
    }
}