using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Change_Bidirectional_Association_to_Unidirectional
{
    /// <summary>
    /// BEFORE: Code chua duoc refactor - 
    /// </summary>
    public class ChangeBidirectionalAssociationToUnidirectional_Before
    {
        // Van de: Order giu tham chieu Customer nhung it khi dung -> phuc tap, kho quan ly
        public class Customer3 { public string Name { get; set; } }
        public class Order3
        {
            public Customer3 Customer { get; set; } // tham chieu 2 chieu phuc tap
            public string Product { get; set; }
            public double GetDiscountedPrice(double price)
            {
                bool isPremium = Customer.Name.StartsWith("VIP");
                return price * (isPremium ? 0.8 : 0.9);
            }
        }
        public void Execute()
        {
            var c = new Customer3 { Name = "Bob" };
            var o = new Order3 { Customer = c, Product = "Laptop" };
            Console.WriteLine("Discounted: " + o.GetDiscountedPrice(10000000).ToString("N0"));
        }
    }
}