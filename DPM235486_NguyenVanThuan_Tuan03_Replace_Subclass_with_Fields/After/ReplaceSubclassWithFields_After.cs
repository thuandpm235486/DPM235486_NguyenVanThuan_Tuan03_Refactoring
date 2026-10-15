using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Replace_Subclass_with_Fields
{
    /// <summary>
    /// AFTER: Code da duoc refactor - 
    /// </summary>
    public class ReplaceSubclassWithFields_After
    {
        // Giai phap: gop vao 1 class, dung fields thay the subclass
        public class Person
        {
            private readonly bool _isMale;
            private readonly char _code;
            private Person(bool isMale, char code) { _isMale = isMale; _code = code; }
            public static Person CreateMale()   { return new Person(true,  'M'); }
            public static Person CreateFemale() { return new Person(false, 'F'); }
            public bool IsMale() { return _isMale; }
            public char GetCode() { return _code; }
        }
        public void Execute()
        {
            var p1 = Person.CreateMale();
            var p2 = Person.CreateFemale();
            Console.WriteLine("Male  : IsMale=" + p1.IsMale() + " Code=" + p1.GetCode());
            Console.WriteLine("Female: IsMale=" + p2.IsMale() + " Code=" + p2.GetCode());
        }
    }
}