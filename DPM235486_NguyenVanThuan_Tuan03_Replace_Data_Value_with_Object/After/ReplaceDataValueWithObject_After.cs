using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Replace_Data_Value_with_Object
{
    /// <summary>
    /// AFTER: Code da duoc refactor - 
    /// </summary>
    public class ReplaceDataValueWithObject_After
    {
        // Giai phap: chuyen string thanh class Customer co hanh vi rieng
        public class Customer
        {
            public string Name { get; }
            public Customer(string name)
            {
                if (string.IsNullOrEmpty(name)) throw new ArgumentException("Name required");
                Name = name;
            }
            public override string ToString() { return Name; }
        }
        public class Order
        {
            private Customer _customer;
            public Order(string name) { _customer = new Customer(name); }
            public Customer GetCustomer() { return _customer; }
            public string GetCustomerName() { return _customer.Name; }
        }
        public void Execute()
        {
            var o = new Order("Nguyen Van A");
            Console.WriteLine("Customer: " + o.GetCustomer());
        }
    }
}