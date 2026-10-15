using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Self_Encapsulate_Field
{
    /// <summary>
    /// BEFORE: Code chua duoc refactor - 
    /// </summary>
    public class SelfEncapsulateField_Before
    {
        // Van de: truy cap field truc tiep trong chinh class, kho override
        private int _low;
        private int _high;
        public void Init(int low, int high) { _low = low; _high = high; }
        public bool Includes(int arg) { return arg >= _low && arg <= _high; }
        public void Execute()
        {
            Init(1, 10);
            Console.WriteLine("Includes 5 : " + Includes(5));
            Console.WriteLine("Includes 15: " + Includes(15));
        }
    }
}