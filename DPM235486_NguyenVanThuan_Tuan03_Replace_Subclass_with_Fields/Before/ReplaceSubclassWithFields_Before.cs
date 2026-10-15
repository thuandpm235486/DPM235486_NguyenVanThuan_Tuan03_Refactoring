using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Replace_Subclass_with_Fields
{
    /// <summary>
    /// BEFORE: Code chua duoc refactor - 
    /// </summary>
    public class ReplaceSubclassWithFields_Before
    {
        // Van de: subclass chi khac nhau o constant values - thua subclass
        public abstract class Person
        {
            public abstract bool IsMale();
            public abstract char GetCode();
        }
        public class Male   : Person { public override bool IsMale() { return true; }  public override char GetCode() { return 'M'; } }
        public class Female : Person { public override bool IsMale() { return false; } public override char GetCode() { return 'F'; } }
        public void Execute()
        {
            Person p1 = new Male();
            Person p2 = new Female();
            Console.WriteLine("Male  : IsMale=" + p1.IsMale() + " Code=" + p1.GetCode());
            Console.WriteLine("Female: IsMale=" + p2.IsMale() + " Code=" + p2.GetCode());
        }
    }
}