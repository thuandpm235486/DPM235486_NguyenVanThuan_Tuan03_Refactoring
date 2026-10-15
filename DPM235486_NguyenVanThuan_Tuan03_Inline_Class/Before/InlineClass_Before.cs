using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Inline_Class
{
    /// <summary>
    /// BEFORE: Code chua duoc refactor - 
    /// </summary>
    public class InlineClass_Before
    {
        // Van de: class TelephoneNumber qua nho, it trach nhiem
        public class TelephoneNumber
        {
            public string AreaCode { get; set; }
            public string Number { get; set; }
        }
        public class Person
        {
            public string Name { get; set; }
            public TelephoneNumber Phone { get; set; } = new TelephoneNumber();
            public string GetPhone() { return "(" + Phone.AreaCode + ") " + Phone.Number; }
        }
        public void Execute()
        {
            var p = new Person { Name = "Bob" };
            p.Phone.AreaCode = "024";
            p.Phone.Number = "7654321";
            Console.WriteLine(p.Name + " - " + p.GetPhone());
        }
    }
}