using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Extract_Class
{
    /// <summary>
    /// AFTER: Code da duoc refactor - 
    /// </summary>
    public class ExtractClass_After
    {
        // Giai phap: tach TelephoneNumber ra thanh class rieng
        public class TelephoneNumber
        {
            public string AreaCode { get; set; }
            public string Number { get; set; }
            public string GetTelephoneNumber() { return "(" + AreaCode + ") " + Number; }
        }
        public class Person
        {
            public string Name { get; set; }
            public TelephoneNumber OfficeTelephone { get; set; } = new TelephoneNumber();
            public string GetTelephoneNumber() { return OfficeTelephone.GetTelephoneNumber(); }
        }
        public void Execute()
        {
            var p = new Person { Name = "John" };
            p.OfficeTelephone.AreaCode = "028";
            p.OfficeTelephone.Number = "1234567";
            Console.WriteLine(p.Name + " - Tel: " + p.GetTelephoneNumber());
        }
    }
}