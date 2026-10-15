using System;
using System.Collections.Generic;

namespace DPM235486_NguyenVanThuan_Tuan03_Replace_Array_with_Object
{
    /// <summary>
    /// REAL: Ung dung thuc te - 
    /// </summary>
    public class ReplaceArrayWithObject_Real
    {
        // Ung dung: thay toa do array bang class Point co phuong thuc
        public class Point
        {
            public double X { get; set; }
            public double Y { get; set; }
            public double DistanceTo(Point other)
            {
                double dx = X - other.X;
                double dy = Y - other.Y;
                return Math.Round(Math.Sqrt(dx * dx + dy * dy), 2);
            }
            public override string ToString() { return "(" + X + ", " + Y + ")"; }
        }
        public void Run()
        {
            var p1 = new Point { X = 0, Y = 0 };
            var p2 = new Point { X = 3, Y = 4 };
            Console.WriteLine("Point 1: " + p1);
            Console.WriteLine("Point 2: " + p2);
            Console.WriteLine("Distance: " + p1.DistanceTo(p2));
        }
    }
}