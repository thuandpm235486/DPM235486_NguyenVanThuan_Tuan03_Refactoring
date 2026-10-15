using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Replace_Array_with_Object
{
    /// <summary>
    /// AFTER: Code da duoc refactor - 
    /// </summary>
    public class ReplaceArrayWithObject_After
    {
        // Giai phap: thay array bang class co truong co ten ro rang
        public class Performance
        {
            public string TeamName { get; set; }
            public int Wins { get; set; }
            public int Points { get; set; }
            public override string ToString()
            {
                return TeamName + " | Wins: " + Wins + " | Points: " + Points;
            }
        }
        public void Execute()
        {
            var row = new Performance { TeamName = "Liverpool", Wins = 15, Points = 35 };
            Console.WriteLine(row);
        }
    }
}