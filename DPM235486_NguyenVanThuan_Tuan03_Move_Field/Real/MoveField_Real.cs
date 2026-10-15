using System;
using System.Collections.Generic;

namespace DPM235486_NguyenVanThuan_Tuan03_Move_Field
{
    /// <summary>
    /// REAL: Ung dung thuc te - 
    /// </summary>
    public class MoveField_Real
    {
        // Ung dung: chuyen thue suat vao LoaiHang (noi no thuoc ve)
        public class ProductCategory
        {
            public string Name { get; set; }
            public double TaxRate { get; set; } // field da chuyen dung cho
        }
        public class Product
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public ProductCategory Category { get; set; }
            public double PriceWithTax() { return Price * (1 + Category.TaxRate); }
        }
        public void Run()
        {
            var p = new Product
            {
                Name = "Laptop",
                Price = 15000000,
                Category = new ProductCategory { Name = "Electronics", TaxRate = 0.1 }
            };
            Console.WriteLine(p.Name + " - Price incl. tax: " + p.PriceWithTax().ToString("N0") + " VND");
        }
    }
}