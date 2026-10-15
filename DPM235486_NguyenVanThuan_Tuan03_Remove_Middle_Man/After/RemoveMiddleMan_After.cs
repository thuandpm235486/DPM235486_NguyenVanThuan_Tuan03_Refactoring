using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Remove_Middle_Man
{
    /// <summary>
    /// AFTER: Code da duoc refactor - 
    /// </summary>
    public class RemoveMiddleMan_After
    {
        // Giai phap: xoa delegation methods, cho client goi Department truc tiep
        public class Department
        {
            public Person Manager { get; set; }
            public string Location { get; set; }
        }
        public class Person
        {
            public string Name { get; set; }
            public Department Department { get; set; } // public de client truy cap thang
            // Da xoa GetManager() va GetLocation()
        }
        public void Execute()
        {
            var mgr = new Person { Name = "Director" };
            var emp = new Person { Name = "Staff", Department = new Department { Manager = mgr, Location = "Tang 3" } };
            Console.WriteLine("Manager: " + emp.Department.Manager.Name);
            Console.WriteLine("Location: " + emp.Department.Location);
        }
    }
}