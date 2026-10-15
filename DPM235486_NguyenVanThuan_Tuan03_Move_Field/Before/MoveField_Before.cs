using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Move_Field
{
    /// <summary>
    /// BEFORE: Code chua duoc refactor - 
    /// </summary>
    public class MoveField_Before
    {
        // Van de: field _interestRate trong Account nhung chi AccountType dung
        public class AccountType { }
        public class Account
        {
            public AccountType Type { get; set; }
            private double _interestRate = 0.05; // field dat sai cho
            public double InterestFor(double amount, int days)
            {
                return _interestRate * amount * days / 365.0;
            }
        }
        public void Execute()
        {
            var acc = new Account { Type = new AccountType() };
            Console.WriteLine("Interest: " + Math.Round(acc.InterestFor(10000, 30), 4));
        }
    }
}