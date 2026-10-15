using System;
using System.Collections.Generic;

namespace DPM235486_NguyenVanThuan_Tuan03_Hide_Delegate
{
    /// <summary>
    /// REAL: Ung dung thuc te - 
    /// </summary>
    public class HideDelegate_Real
    {
        // Ung dung: an logic cua ShippingInfo sau Customer
        public class ShippingInfo
        {
            public string Address { get; set; }
            public double CalcCost(double weight) { return weight * 5000; }
        }
        public class Customer
        {
            public string Name { get; set; }
            private ShippingInfo _info = new ShippingInfo { Address = "123 ABC" };
            public string GetAddress() { return _info.Address; }
            public double GetShippingCost(double w) { return _info.CalcCost(w); }
        }
        public void Run()
        {
            var c = new Customer { Name = "Nguyen Van C" };
            Console.WriteLine("Address: " + c.GetAddress());
            Console.WriteLine("Ship 2kg: " + c.GetShippingCost(2) + " VND");
        }
    }
}