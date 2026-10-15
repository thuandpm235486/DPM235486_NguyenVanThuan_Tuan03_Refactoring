using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Remove_Assignments_to_Parameters
{
    /// <summary>
    /// AFTER: Code da duoc refactor - 
    /// </summary>
    public class RemoveAssignmentsToParameters_After
    {
        // Giai phap: dung bien cuc bo thay vi sua tham so
        public int Discount(int inputVal, int quantity)
        {
            int result = inputVal;   // bien cuc bo moi
            if (inputVal > 50) result -= 2;
            if (quantity > 100) result -= 1;
            return result;
        }
        public void Execute()
        {
            int original = 60;
            int result = Discount(original, 120);
            Console.WriteLine("Original: " + original + " -> Result: " + result);
        }
    }
}