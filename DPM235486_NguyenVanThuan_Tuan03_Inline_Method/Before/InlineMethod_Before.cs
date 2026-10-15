using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Inline_Method
{
    /// <summary>
    /// BEFORE: Code chua duoc refactor - 
    /// </summary>
    public class InlineMethod_Before
    {
        // Van de: method co body ro hon chÃ­nh ten goi no
        public int GetRating()
        {
            return MoreThanFiveLateDeliveries() ? 2 : 1;
        }
        private bool MoreThanFiveLateDeliveries()
        {
            return true; // qua don gian de tach rieng
        }
        public void Execute()
        {
            Console.WriteLine("Rating: " + GetRating());
        }
    }
}