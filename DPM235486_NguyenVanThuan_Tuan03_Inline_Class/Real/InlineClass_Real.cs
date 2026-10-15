using System;
using System.Collections.Generic;

namespace DPM235486_NguyenVanThuan_Tuan03_Inline_Class
{
    /// <summary>
    /// REAL: Ung dung thuc te - 
    /// </summary>
    public class InlineClass_Real
    {
        // Ung dung: gop thong tin giao hang don gian vao DonHang
        public class Order
        {
            public string OrderId { get; set; }
            public string CustomerName { get; set; }
            public string ShipAddress { get; set; }
            public string ShipCity { get; set; }
            public string GetShipInfo()
            {
                return CustomerName + " | " + ShipAddress + ", " + ShipCity;
            }
        }
        public void Run()
        {
            var o = new Order
            {
                OrderId = "HD001",
                CustomerName = "Tran Thi B",
                ShipAddress = "456 Le Loi",
                ShipCity = "Da Nang"
            };
            Console.WriteLine("Order " + o.OrderId + " -> " + o.GetShipInfo());
        }
    }
}