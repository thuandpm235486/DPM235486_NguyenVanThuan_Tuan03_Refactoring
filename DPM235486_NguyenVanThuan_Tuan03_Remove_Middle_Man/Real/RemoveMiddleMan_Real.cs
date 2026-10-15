using System;
using System.Collections.Generic;

namespace DPM235486_NguyenVanThuan_Tuan03_Remove_Middle_Man
{
    /// <summary>
    /// REAL: Ung dung thuc te - 
    /// </summary>
    public class RemoveMiddleMan_Real
    {
        // Ung dung: truy cap thong tin don hang truc tiep
        public class OrderDetail
        {
            public string ProductName { get; set; }
            public int Quantity { get; set; }
            public double UnitPrice { get; set; }
            public double SubTotal() { return Quantity * UnitPrice; }
        }
        public class Order
        {
            public string OrderId { get; set; }
            public OrderDetail Detail { get; set; }
        }
        public void Run()
        {
            var order = new Order
            {
                OrderId = "ORD001",
                Detail = new OrderDetail { ProductName = "Keyboard", Quantity = 2, UnitPrice = 350000 }
            };
            Console.WriteLine("Order: " + order.OrderId);
            Console.WriteLine("Product: " + order.Detail.ProductName + " x" + order.Detail.Quantity);
            Console.WriteLine("Subtotal: " + order.Detail.SubTotal().ToString("N0") + " VND");
        }
    }
}