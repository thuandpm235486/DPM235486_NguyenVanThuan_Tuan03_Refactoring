using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Change_Unidirectional_Association_to_Bidirectional
{
    /// <summary>
    /// AFTER: Code da duoc refactor - 
    /// </summary>
    public class ChangeUnidirectionalAssociationToBidirectional_After
    {
        // Giai phap: them lien ket nguoc tu Customer -> Orders
        public class Order2
        {
            private Customer2 _customer;
            public string Product { get; set; }
            public Customer2 Customer
            {
                get { return _customer; }
                set
                {
                    if (_customer != null) _customer.Orders.Remove(this);
                    _customer = value;
                    if (_customer != null) _customer.Orders.Add(this);
                }
            }
        }
        public class Customer2
        {
            public string Name { get; set; }
            public List<Order2> Orders { get; } = new List<Order2>(); // lien ket nguoc
        }
        public void Execute()
        {
            var c = new Customer2 { Name = "Alice" };
            var o1 = new Order2 { Product = "Book" };
            var o2 = new Order2 { Product = "Pen" };
            o1.Customer = c;
            o2.Customer = c;
            Console.WriteLine(c.Name + " has " + c.Orders.Count + " orders:");
            foreach (var o in c.Orders) Console.WriteLine("  - " + o.Product);
        }
    }
}