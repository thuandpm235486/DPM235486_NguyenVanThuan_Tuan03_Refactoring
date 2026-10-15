using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Remove_Middle_Man
{
    /// <summary>
    /// BEFORE: Code chua duoc refactor - 
    /// </summary>
    public class RemoveMiddleMan_Before
    {
        // Van de: Person co qua nhieu delegation methods chi de chuyen tiep sang Department
        public class Department
        {
            public Person Manager { get; set; }
            public string Location { get; set; }
        }
        public class Person
        {
            public string Name { get; set; }
            public Department Department { get; set; }
            public Person GetManager() { return Department.Manager; }   // delegate
            public string GetLocation() { return Department.Location; } // delegate
        }
        public void Execute()
        {
            var mgr = new Person { Name = "Director" };
            var emp = new Person { Name = "Staff", Department = new Department { Manager = mgr, Location = "Tang 3" } };
            Console.WriteLine("Manager: " + emp.GetManager().Name);
            Console.WriteLine("Location: " + emp.GetLocation());
        }
    }
}