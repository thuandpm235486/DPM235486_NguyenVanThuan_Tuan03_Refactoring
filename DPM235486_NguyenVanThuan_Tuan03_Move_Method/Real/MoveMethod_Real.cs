using System;
using System.Collections.Generic;

namespace DPM235486_NguyenVanThuan_Tuan03_Move_Method
{
    /// <summary>
    /// REAL: Ung dung thuc te - 
    /// </summary>
    public class MoveMethod_Real
    {
        // Ung dung: chuyen tinh phi van chuyen sang class LoaiXe
        public class VehicleType
        {
            public string Name { get; set; }
            public double RatePerKm { get; set; }
            public double CalculateFee(double distance) { return distance * RatePerKm; }
        }
        public class Delivery
        {
            public VehicleType Vehicle { get; set; }
            public double Distance { get; set; }
            public double GetFee() { return Vehicle.CalculateFee(Distance); }
        }
        public void Run()
        {
            var d = new Delivery
            {
                Vehicle = new VehicleType { Name = "Xe tai", RatePerKm = 8000 },
                Distance = 120
            };
            Console.WriteLine(d.Vehicle.Name + " 120km: " + d.GetFee().ToString("N0") + " VND");
        }
    }
}