using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Replace_Magic_Number_with_Symbolic_Constant
{
    /// <summary>
    /// BEFORE: Code chua duoc refactor - 
    /// </summary>
    public class ReplaceMagicNumberWithSymbolicConstant_Before
    {
        // Van de: su dung so magic, nguoi doc khong hieu y nghia
        public double PotentialEnergy(double mass, double height)
        {
            return mass * 9.81 * height; // 9.81 la gi???
        }
        public double CircleArea(double r) { return 3.14159265 * r * r; }
        public int DaysToSeconds(int days) { return days * 24 * 60 * 60; }
        public void Execute()
        {
            Console.WriteLine("Energy: " + Math.Round(PotentialEnergy(10, 5), 2));
            Console.WriteLine("Area  : " + Math.Round(CircleArea(7), 2));
            Console.WriteLine("1 day : " + DaysToSeconds(1) + " seconds");
        }
    }
}