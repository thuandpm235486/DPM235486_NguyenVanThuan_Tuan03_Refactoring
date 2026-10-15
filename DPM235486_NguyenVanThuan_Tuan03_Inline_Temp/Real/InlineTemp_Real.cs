using System;
using System.Collections.Generic;

namespace DPM235486_NguyenVanThuan_Tuan03_Inline_Temp
{
    /// <summary>
    /// REAL: Ung dung thuc te - 
    /// </summary>
    public class InlineTemp_Real
    {
        // Ung dung: kiem tra dieu kien truc tiep, khong can bien trung gian
        public void Run()
        {
            string[] names = { "An", "Binh", "Chau", "Dung" };
            Console.WriteLine("Total: " + names.Length);
            Console.WriteLine("First uppercase: " + names[0].ToUpper());
            Console.WriteLine("Has 'Chau': " + (Array.IndexOf(names, "Chau") >= 0));
        }
    }
}