using System;
using System.Collections.Generic;

namespace DPM235486_NguyenVanThuan_Tuan03_Encapsulate_Collection
{
    /// <summary>
    /// REAL: Ung dung thuc te - 
    /// </summary>
    public class EncapsulateCollection_Real
    {
        // Ung dung: gio hang dong goi danh sach san pham
        public class ShoppingCart
        {
            private readonly List<string> _items = new List<string>();
            public IReadOnlyList<string> Items { get { return _items.AsReadOnly(); } }
            public void AddItem(string item) { _items.Add(item); }
            public bool RemoveItem(string item) { return _items.Remove(item); }
            public int Count { get { return _items.Count; } }
            public string Summary() { return Count + " items: " + string.Join(", ", _items); }
        }
        public void Run()
        {
            var cart = new ShoppingCart();
            cart.AddItem("iPhone 16"); cart.AddItem("AirPods Pro"); cart.AddItem("MagSafe");
            cart.RemoveItem("MagSafe");
            Console.WriteLine("Cart -> " + cart.Summary());
        }
    }
}