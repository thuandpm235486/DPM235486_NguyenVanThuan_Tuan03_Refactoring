using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Change_Value_to_Reference
{
    /// <summary>
    /// BEFORE: Code chua duoc refactor - 
    /// </summary>
    public class ChangeValueToReference_Before
    {
        // Van de: moi Order tao Customer moi du cung ten -> bong bo
        public class Customer
        {
            public string Name { get; }
            public Customer(string name) { Name = name; }
        }
        public class Order
        {
            public Customer Customer { get; }
            public Order(string name) { Customer = new Customer(name); } // tao moi moi lan
        }
        public void Execute()
        {
            var o1 = new Order("John");
            var o2 = new Order("John");
            Console.WriteLine("Same object? " + (o1.Customer == o2.Customer)); // false - khac nhau!
        }
    }
}