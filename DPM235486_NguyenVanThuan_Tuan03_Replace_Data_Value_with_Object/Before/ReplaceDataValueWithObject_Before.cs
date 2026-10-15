using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Replace_Data_Value_with_Object
{
    /// <summary>
    /// BEFORE: Code chua duoc refactor - 
    /// </summary>
    public class ReplaceDataValueWithObject_Before
    {
        // Van de: Customer chi la string, khong co hanh vi hay rang buoc
        public class Order
        {
            private string _customerName; // chi la string
            public Order(string name) { _customerName = name; }
            public string GetCustomerName() { return _customerName; }
        }
        public void Execute()
        {
            var o = new Order("Nguyen Van A");
            Console.WriteLine("Customer: " + o.GetCustomerName());
        }
    }
}