using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Encapsulate_Field
{
    /// <summary>
    /// BEFORE: Code chua duoc refactor - 
    /// </summary>
    public class EncapsulateField_Before
    {
        // Van de: public field lo ra ngoai, ai cung co the sua truc tiep
        public class Person
        {
            public string name; // public - khong co kiem soat
            public int age;
        }
        public void Execute()
        {
            var p = new Person();
            p.name = "John";
            p.age = -5; // co the dat gia tri vo nghia!
            Console.WriteLine(p.name + " | age: " + p.age);
        }
    }
}