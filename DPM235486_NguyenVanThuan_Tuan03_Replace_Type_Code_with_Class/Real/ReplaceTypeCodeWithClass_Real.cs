using System;
using System.Collections.Generic;

namespace DPM235486_NguyenVanThuan_Tuan03_Replace_Type_Code_with_Class
{
    /// <summary>
    /// REAL: Ung dung thuc te - 
    /// </summary>
    public class ReplaceTypeCodeWithClass_Real
    {
        // Ung dung: trang thai don hang type-safe
        public sealed class OrderStatus
        {
            public static readonly OrderStatus Pending   = new OrderStatus("Pending");
            public static readonly OrderStatus Confirmed = new OrderStatus("Confirmed");
            public static readonly OrderStatus Shipped   = new OrderStatus("Shipped");
            public static readonly OrderStatus Delivered = new OrderStatus("Delivered");
            public static readonly OrderStatus Cancelled = new OrderStatus("Cancelled");
            private string _name;
            private OrderStatus(string name) { _name = name; }
            public override string ToString() { return _name; }
        }
        public class Order
        {
            public string OrderId { get; set; }
            public OrderStatus Status { get; set; }
        }
        public void Run()
        {
            var orders = new[]
            {
                new Order { OrderId = "HD001", Status = OrderStatus.Confirmed },
                new Order { OrderId = "HD002", Status = OrderStatus.Shipped },
                new Order { OrderId = "HD003", Status = OrderStatus.Delivered }
            };
            foreach (var o in orders)
                Console.WriteLine("Order " + o.OrderId + " -> " + o.Status);
        }
    }
}