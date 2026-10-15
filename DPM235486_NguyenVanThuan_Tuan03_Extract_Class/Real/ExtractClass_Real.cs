using System;
using System.Collections.Generic;

namespace DPM235486_NguyenVanThuan_Tuan03_Extract_Class
{
    /// <summary>
    /// REAL: Ung dung thuc te - 
    /// </summary>
    public class ExtractClass_Real
    {
        // Ung dung: tach Address ra khoi KhachHang
        public class Address
        {
            public string Street { get; set; }
            public string District { get; set; }
            public string City { get; set; }
            public override string ToString() { return Street + ", " + District + ", " + City; }
        }
        public class Customer
        {
            public string Name { get; set; }
            public Address HomeAddress { get; set; } = new Address();
        }
        public void Run()
        {
            var c = new Customer { Name = "Nguyen Van Tuan" };
            c.HomeAddress.Street = "123 Nguyen Hue";
            c.HomeAddress.District = "Quan 1";
            c.HomeAddress.City = "Ho Chi Minh";
            Console.WriteLine(c.Name + " - " + c.HomeAddress);
        }
    }
}