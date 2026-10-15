using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Move_Field
{
    /// <summary>
    /// AFTER: Code da duoc refactor - 
    /// </summary>
    public class MoveField_After
    {
        // Giai phap: chuyen InterestRate sang AccountType (noi no thuoc ve)
        public class AccountType
        {
            public double InterestRate { get; set; } = 0.05; // field da chuyen sang day
        }
        public class Account
        {
            public AccountType Type { get; set; }
            public double InterestFor(double amount, int days)
            {
                return Type.InterestRate * amount * days / 365.0;
            }
        }
        public void Execute()
        {
            var acc = new Account { Type = new AccountType() };
            Console.WriteLine("Interest: " + Math.Round(acc.InterestFor(10000, 30), 4));
        }
    }
}