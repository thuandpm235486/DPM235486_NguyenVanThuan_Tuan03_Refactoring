using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Remove_Assignments_to_Parameters
{
    /// <summary>
    /// BEFORE: Code chua duoc refactor - 
    /// </summary>
    public class RemoveAssignmentsToParameters_Before
    {
        // Van de: ghi de gia tri tham so trong than method, gay nham lan
        public int Discount(int inputVal, int quantity)
        {
            if (inputVal > 50) inputVal -= 2; // thay doi tham so!
            if (quantity > 100) inputVal -= 1;
            return inputVal;
        }
        public void Execute()
        {
            int original = 60;
            int result = Discount(original, 120);
            Console.WriteLine("Original: " + original + " -> Result: " + result);
        }
    }
}