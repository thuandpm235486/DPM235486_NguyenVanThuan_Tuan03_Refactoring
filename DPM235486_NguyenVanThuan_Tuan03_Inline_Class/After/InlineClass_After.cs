using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Inline_Class
{
    /// <summary>
    /// AFTER: Code da duoc refactor - 
    /// </summary>
    public class InlineClass_After
    {
        // Giai phap: gop TelephoneNumber vao Person (class qua don gian)
        public class Person
        {
            public string Name { get; set; }
            public string OfficeAreaCode { get; set; }
            public string OfficeNumber { get; set; }
            public string GetPhone() { return "(" + OfficeAreaCode + ") " + OfficeNumber; }
        }
        public void Execute()
        {
            var p = new Person { Name = "Bob", OfficeAreaCode = "024", OfficeNumber = "7654321" };
            Console.WriteLine(p.Name + " - " + p.GetPhone());
        }
    }
}