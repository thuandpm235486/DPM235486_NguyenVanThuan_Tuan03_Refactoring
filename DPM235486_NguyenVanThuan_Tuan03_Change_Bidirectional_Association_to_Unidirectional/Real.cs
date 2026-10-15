using System;
using System.Collections.Generic;

namespace DPM235486_NguyenVanThuan_Tuan03_Change_Bidirectional_Association_to_Unidirectional
{
    // REAL: Ung dung thuc te cua refactoring nay
    public class Real
    {
        // Ung dung: don hang khong giu tham chieu kho hang
        public class Warehouse
        {
            public string Location { get; set; }
            public int Capacity { get; set; }
        }
        public class StockOrder
        {
            public string ItemName { get; set; }
            public int Quantity { get; set; }
            // Khong giu tham chieu Warehouse - truyen vao khi can
            public bool CanFulfill(Warehouse wh) { return wh.Capacity >= Quantity; }
        }
        public void Run()
        {
            var wh = new Warehouse { Location = "HCM", Capacity = 500 };
            var order = new StockOrder { ItemName = "Phone", Quantity = 100 };
            Console.WriteLine("Can fulfill: " + order.CanFulfill(wh));
        }
    }
}