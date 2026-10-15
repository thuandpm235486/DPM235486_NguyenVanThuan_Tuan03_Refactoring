using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Self_Encapsulate_Field
{
    /// <summary>
    /// AFTER: Code da duoc refactor - 
    /// </summary>
    public class SelfEncapsulateField_After
    {
        // Giai phap: tao getter/setter va chi dung chung, ke ca trong noi bo
        private int _low;
        private int _high;
        protected int Low  { get { return _low; }  set { _low  = value; } }
        protected int High { get { return _high; } set { _high = value; } }
        public void Init(int low, int high) { Low = low; High = high; } // dung setter
        public bool Includes(int arg) { return arg >= Low && arg <= High; } // dung getter
        public void Execute()
        {
            Init(1, 10);
            Console.WriteLine("Includes 5 : " + Includes(5));
            Console.WriteLine("Includes 15: " + Includes(15));
        }
    }
}