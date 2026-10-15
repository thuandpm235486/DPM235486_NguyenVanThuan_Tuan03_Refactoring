using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Replace_Magic_Number_with_Symbolic_Constant
{
    /// <summary>
    /// AFTER: Code da duoc refactor - 
    /// </summary>
    public class ReplaceMagicNumberWithSymbolicConstant_After
    {
        // Giai phap: dat ten hang so co y nghia cho cac gia tri magic
        private const double GRAVITATIONAL_CONSTANT = 9.81;
        private const double PI = Math.PI;
        private const int SECONDS_PER_DAY = 24 * 60 * 60;
        private const double TAX_RATE = 0.1;

        public double PotentialEnergy(double mass, double height)
        {
            return mass * GRAVITATIONAL_CONSTANT * height;
        }
        public double CircleArea(double r) { return PI * r * r; }
        public int DaysToSeconds(int days) { return days * SECONDS_PER_DAY; }
        public void Execute()
        {
            Console.WriteLine("Energy: " + Math.Round(PotentialEnergy(10, 5), 2));
            Console.WriteLine("Area  : " + Math.Round(CircleArea(7), 2));
            Console.WriteLine("1 day : " + DaysToSeconds(1) + " seconds");
        }
    }
}