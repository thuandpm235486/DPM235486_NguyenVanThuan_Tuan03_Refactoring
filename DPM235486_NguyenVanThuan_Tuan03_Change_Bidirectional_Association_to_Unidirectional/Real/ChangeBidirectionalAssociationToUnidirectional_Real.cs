using System;
using System.Collections.Generic;

namespace DPM235486_NguyenVanThuan_Tuan03_Change_Bidirectional_Association_to_Unidirectional
{
    /// <summary>
    /// REAL: Ung dung thuc te - 
    /// </summary>
    public class ChangeBidirectionalAssociationToUnidirectional_Real
    {
        // Ung dung: StockOrder khong giu tham chieu Kho hang
        public class Warehouse { public string Location { get; set; } public int Capacity { get; set; } }
        public class StockOrder
        {
            public string ItemName { get; set; }
            public int Quantity { get; set; }
            // Truyen Warehouse vao khi kiem tra, khong giu tham chieu
            public bool CanFulfill(Warehouse wh) { return wh.Capacity >= Quantity; }
            public string GetInfo() { return ItemName + " x" + Quantity; }
        }
        public void Run()
        {
            var wh = new Warehouse { Location = "HCM", Capacity = 500 };
            var o1 = new StockOrder { ItemName = "Phone",  Quantity = 100 };
            var o2 = new StockOrder { ItemName = "Laptop", Quantity = 600 };
            Console.WriteLine(o1.GetInfo() + " -> Can fulfill: " + o1.CanFulfill(wh));
            Console.WriteLine(o2.GetInfo() + " -> Can fulfill: " + o2.CanFulfill(wh));
        }
    }
}