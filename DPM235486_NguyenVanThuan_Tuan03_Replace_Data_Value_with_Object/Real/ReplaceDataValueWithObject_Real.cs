using System;
using System.Collections.Generic;

namespace DPM235486_NguyenVanThuan_Tuan03_Replace_Data_Value_with_Object
{
    /// <summary>
    /// REAL: Ung dung thuc te - 
    /// </summary>
    public class ReplaceDataValueWithObject_Real
    {
        // Ung dung: Email la object co validation, khong chi la string
        public class Email
        {
            public string Address { get; }
            public string Username { get { return Address.Split('@')[0]; } }
            public string Domain   { get { return Address.Split('@')[1]; } }
            public Email(string addr)
            {
                if (!addr.Contains("@")) throw new ArgumentException("Invalid email: " + addr);
                Address = addr;
            }
        }
        public class User
        {
            public string Name { get; set; }
            public Email Email { get; set; }
        }
        public void Run()
        {
            var user = new User { Name = "Tuan", Email = new Email("tuan@dtu.edu.vn") };
            Console.WriteLine("Name    : " + user.Name);
            Console.WriteLine("Email   : " + user.Email.Address);
            Console.WriteLine("Domain  : " + user.Email.Domain);
        }
    }
}