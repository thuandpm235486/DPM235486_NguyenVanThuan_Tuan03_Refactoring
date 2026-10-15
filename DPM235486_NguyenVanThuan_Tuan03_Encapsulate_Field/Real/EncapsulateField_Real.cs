using System;
using System.Collections.Generic;

namespace DPM235486_NguyenVanThuan_Tuan03_Encapsulate_Field
{
    /// <summary>
    /// REAL: Ung dung thuc te - 
    /// </summary>
    public class EncapsulateField_Real
    {
        // Ung dung: SanPham voi validation qua property
        public class Product
        {
            private string _name;
            private double _price;
            private int _stock;
            public string Name  { get { return _name;  } set { _name  = value ?? "No Name"; } }
            public double Price { get { return _price; } set { _price = value > 0 ? value : 0; } }
            public int Stock    { get { return _stock; } set { _stock = value >= 0 ? value : 0; } }
            public bool IsAvailable() { return _stock > 0; }
        }
        public void Run()
        {
            var p = new Product { Name = "Tai nghe Sony", Price = 750000, Stock = 10 };
            Console.WriteLine(p.Name + " - " + p.Price.ToString("N0") + " VND");
            Console.WriteLine("Available: " + p.IsAvailable() + " (stock: " + p.Stock + ")");
        }
    }
}