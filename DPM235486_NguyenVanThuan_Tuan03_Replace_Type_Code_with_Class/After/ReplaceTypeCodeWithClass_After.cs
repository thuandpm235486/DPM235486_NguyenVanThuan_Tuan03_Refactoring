using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Replace_Type_Code_with_Class
{
    /// <summary>
    /// AFTER: Code da duoc refactor - 
    /// </summary>
    public class ReplaceTypeCodeWithClass_After
    {
        // Giai phap: tao class BloodGroup type-safe, khong the dat gia tri sai
        public sealed class BloodGroup
        {
            public static readonly BloodGroup O  = new BloodGroup(0, "O");
            public static readonly BloodGroup A  = new BloodGroup(1, "A");
            public static readonly BloodGroup B  = new BloodGroup(2, "B");
            public static readonly BloodGroup AB = new BloodGroup(3, "AB");
            private int _code; private string _label;
            private BloodGroup(int code, string label) { _code = code; _label = label; }
            public override string ToString() { return _label; }
        }
        public class Person
        {
            public string Name { get; set; }
            public BloodGroup BloodGroup { get; set; }
        }
        public void Execute()
        {
            var p = new Person { Name = "John", BloodGroup = BloodGroup.A };
            Console.WriteLine(p.Name + " - Blood: " + p.BloodGroup);
        }
    }
}