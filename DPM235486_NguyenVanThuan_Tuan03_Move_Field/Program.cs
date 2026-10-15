using System;

namespace DPM235486_NguyenVanThuan_Tuan03_Move_Field
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("============================================================");
            Console.WriteLine("  Technique : ");
            Console.WriteLine("  Student   : Nguyen Van Thuan - DPM235486");
            Console.WriteLine("  Reference : https://refactoring.guru/refactoring/techniques");
            Console.WriteLine("============================================================");

            Console.WriteLine("\n--- [1] BEFORE ---  (code chua refactor)");
            var before = new MoveField_Before();
            before.Execute();

            Console.WriteLine("\n--- [2] AFTER ---   (code da refactor)");
            var after = new MoveField_After();
            after.Execute();

            Console.WriteLine("\n--- [3] REAL ---    (ung dung thuc te)");
            var real = new MoveField_Real();
            real.Run();

            Console.WriteLine("\nNhan Enter de thoat...");
            Console.ReadLine();
        }
    }
}