using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Extract_Class
{
    /// <summary>
    /// BEFORE: Code chua duoc refactor - 
    /// </summary>
    public class ExtractClass_Before
    {
        // Van de: class Person dam nhiem ca xu ly so dien thoai (lam hai viec)
        public class Person
        {
            public string Name { get; set; }
            public string OfficeAreaCode { get; set; }
            public string OfficeNumber { get; set; }
            public string GetTelephoneNumber()
            {
                return "(" + OfficeAreaCode + ") " + OfficeNumber;
            }
        }
        public void Execute()
        {
            var p = new Person { Name = "John", OfficeAreaCode = "028", OfficeNumber = "1234567" };
            Console.WriteLine(p.Name + " - Tel: " + p.GetTelephoneNumber());
        }
    }
}