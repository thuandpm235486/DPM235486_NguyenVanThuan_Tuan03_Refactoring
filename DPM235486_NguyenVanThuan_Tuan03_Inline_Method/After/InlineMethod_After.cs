using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Inline_Method
{
    /// <summary>
    /// AFTER: Code da duoc refactor - 
    /// </summary>
    public class InlineMethod_After
    {
        // Giai phap: inline body cua method qua don gian
        public int GetRating()
        {
            return (true) ? 2 : 1; // inlined truc tiep
        }
        public void Execute()
        {
            Console.WriteLine("Rating: " + GetRating());
        }
    }
}