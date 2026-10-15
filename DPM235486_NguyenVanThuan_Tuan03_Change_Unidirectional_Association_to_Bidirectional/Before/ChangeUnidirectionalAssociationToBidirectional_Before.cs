using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Change_Unidirectional_Association_to_Bidirectional
{
    /// <summary>
    /// BEFORE: Code chua duoc refactor - 
    /// </summary>
    public class ChangeUnidirectionalAssociationToBidirectional_Before
    {
        // Van de: Order biet Customer, nhung Customer khong biet Orders cua minh
        public class Customer { public string Name { get; set; } }
        public class Order
        {
            public Customer Customer { get; set; }
            public string Product { get; set; }
        }
        public void Execute()
        {
            var c = new Customer { Name = "Alice" };
            var o = new Order { Customer = c, Product = "Book" };
            Console.WriteLine("Order -> Customer: " + o.Customer.Name); // chi 1 chieu
            // Khong the biet Customer co bao nhieu Order
        }
    }
}