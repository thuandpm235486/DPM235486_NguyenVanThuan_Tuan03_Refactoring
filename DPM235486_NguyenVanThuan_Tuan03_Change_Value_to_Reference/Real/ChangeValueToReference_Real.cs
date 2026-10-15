using System;
using System.Collections.Generic;

namespace DPM235486_NguyenVanThuan_Tuan03_Change_Value_to_Reference
{
    /// <summary>
    /// REAL: Ung dung thuc te - 
    /// </summary>
    public class ChangeValueToReference_Real
    {
        // Ung dung: registry san pham toan cuc
        public class Product
        {
            private static Dictionary<string, Product> _catalog = new Dictionary<string, Product>();
            public string Sku { get; }
            public string Name { get; }
            public double Price { get; }
            private Product(string sku, string name, double price) { Sku = sku; Name = name; Price = price; }
            public static Product Register(string sku, string name, double price)
            {
                if (!_catalog.ContainsKey(sku)) _catalog[sku] = new Product(sku, name, price);
                return _catalog[sku];
            }
            public static Product Get(string sku) { return _catalog.ContainsKey(sku) ? _catalog[sku] : null; }
        }
        public void Run()
        {
            Product.Register("P001", "Laptop Dell", 15000000);
            var a = Product.Get("P001");
            var b = Product.Get("P001");
            Console.WriteLine("Same instance: " + (a == b));
            Console.WriteLine("Product: " + a.Name + " | Price: " + a.Price.ToString("N0") + " VND");
        }
    }
}