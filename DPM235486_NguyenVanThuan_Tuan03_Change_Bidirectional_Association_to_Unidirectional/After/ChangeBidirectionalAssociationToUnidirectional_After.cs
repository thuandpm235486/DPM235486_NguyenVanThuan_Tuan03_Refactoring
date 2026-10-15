using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Change_Bidirectional_Association_to_Unidirectional
{
    /// <summary>
    /// AFTER: Code da duoc refactor - 
    /// </summary>
    public class ChangeBidirectionalAssociationToUnidirectional_After
    {
        // Giai phap: xoa tham chieu Customer khoi Order, truyen vao khi can
        public class Customer4 { public string Name { get; set; } }
        public class Order4
        {
            public string Product { get; set; }
            // Khong giu tham chieu Customer - truyen qua tham so khi can
            public double GetDiscountedPrice(double price, Customer4 customer)
            {
                bool isPremium = customer.Name.StartsWith("VIP");
                return price * (isPremium ? 0.8 : 0.9);
            }
        }
        public void Execute()
        {
            var c = new Customer4 { Name = "Bob" };
            var o = new Order4 { Product = "Laptop" };
            Console.WriteLine("Discounted: " + o.GetDiscountedPrice(10000000, c).ToString("N0"));
        }
    }
}