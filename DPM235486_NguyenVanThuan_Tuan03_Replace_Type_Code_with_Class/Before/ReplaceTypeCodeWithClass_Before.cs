using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Replace_Type_Code_with_Class
{
    /// <summary>
    /// BEFORE: Code chua duoc refactor - 
    /// </summary>
    public class ReplaceTypeCodeWithClass_Before
    {
        // Van de: dung int constants cho loai mau, khong type-safe
        public class Person
        {
            public const int O  = 0;
            public const int A  = 1;
            public const int B  = 2;
            public const int AB = 3;
            public int BloodGroup { get; set; } // co the dat = 999, khong kiem soat!
        }
        public void Execute()
        {
            var p = new Person { BloodGroup = Person.A };
            Console.WriteLine("Blood code: " + p.BloodGroup);
        }
    }
}