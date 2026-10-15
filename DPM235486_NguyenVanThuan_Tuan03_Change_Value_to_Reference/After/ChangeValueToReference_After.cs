using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Change_Value_to_Reference
{
    /// <summary>
    /// AFTER: Code da duoc refactor - 
    /// </summary>
    public class ChangeValueToReference_After
    {
        // Giai phap: dung registry de chi co 1 instance cho moi ten
        public class Customer
        {
            private static Dictionary<string, Customer> _store = new Dictionary<string, Customer>();
            public string Name { get; }
            private Customer(string name) { Name = name; }
            public static Customer GetNamed(string name)
            {
                if (!_store.ContainsKey(name)) _store[name] = new Customer(name);
                return _store[name]; // luon tra ve cung 1 instance
            }
        }
        public class Order
        {
            public Customer Customer { get; }
            public Order(string name) { Customer = Customer.GetNamed(name); }
        }
        public void Execute()
        {
            var o1 = new Order("John");
            var o2 = new Order("John");
            Console.WriteLine("Same object? " + (o1.Customer == o2.Customer)); // true!
        }
    }
}