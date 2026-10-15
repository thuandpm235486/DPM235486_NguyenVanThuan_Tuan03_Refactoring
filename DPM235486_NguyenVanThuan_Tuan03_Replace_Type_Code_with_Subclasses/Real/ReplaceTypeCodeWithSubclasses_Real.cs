using System;
using System.Collections.Generic;

namespace DPM235486_NguyenVanThuan_Tuan03_Replace_Type_Code_with_Subclasses
{
    /// <summary>
    /// REAL: Ung dung thuc te - 
    /// </summary>
    public class ReplaceTypeCodeWithSubclasses_Real
    {
        // Ung dung: tinh phi cau toll theo loai xe dung polymorphism
        public abstract class Vehicle
        {
            public string LicensePlate { get; set; }
            public abstract double TollFee();
        }
        public class Motorbike : Vehicle { public override double TollFee() { return 5000; } }
        public class Car       : Vehicle { public override double TollFee() { return 15000; } }
        public class Truck     : Vehicle { public override double TollFee() { return 45000; } }
        public void Run()
        {
            var vehicles = new Vehicle[]
            {
                new Motorbike { LicensePlate = "59X1-12345" },
                new Car       { LicensePlate = "51F-99876"  },
                new Truck     { LicensePlate = "50H-54321"  }
            };
            foreach (var v in vehicles)
                Console.WriteLine(v.GetType().Name + " " + v.LicensePlate + " -> Toll: " + v.TollFee().ToString("N0") + " VND");
        }
    }
}