using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Replace_Array_with_Object
{
    /// <summary>
    /// BEFORE: Code chua duoc refactor - 
    /// </summary>
    public class ReplaceArrayWithObject_Before
    {
        // Van de: dung array voi cac chi so magic, kho hieu y nghia
        public void Execute()
        {
            string[] row = new string[3];
            row[0] = "Liverpool"; // 0 la gi?
            row[1] = "15";        // 1 la gi?
            row[2] = "35";        // 2 la gi?
            Console.WriteLine("row[0]=" + row[0] + " row[1]=" + row[1] + " row[2]=" + row[2]);
        }
    }
}