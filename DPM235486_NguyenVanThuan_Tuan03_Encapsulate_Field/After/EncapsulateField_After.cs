using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Encapsulate_Field
{
    /// <summary>
    /// AFTER: Code da duoc refactor - 
    /// </summary>
    public class EncapsulateField_After
    {
        // Giai phap: dong goi field, kiem soat qua property
        public class Person
        {
            private string _name;
            private int _age;
            public string Name
            {
                get { return _name; }
                set { _name = !string.IsNullOrEmpty(value) ? value : "Unknown"; }
            }
            public int Age
            {
                get { return _age; }
                set { _age = value >= 0 && value <= 150 ? value : 0; } // validation
            }
        }
        public void Execute()
        {
            var p = new Person();
            p.Name = "John";
            p.Age = -5; // tu dong duoc chinh thanh 0
            Console.WriteLine(p.Name + " | age: " + p.Age + " (invalid -5 -> 0)");
        }
    }
}