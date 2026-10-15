using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Move_Method
{
    /// <summary>
    /// BEFORE: Code chua duoc refactor - 
    /// </summary>
    public class MoveMethod_Before
    {
        // Van de: method OverdraftCharge trong Account nhung dung nhieu tu AccountType
        public class AccountType { public bool IsPremium { get; set; } }
        public class Account
        {
            public AccountType Type { get; set; }
            public int DaysOverdrawn { get; set; }
            public double OverdraftCharge()
            {
                if (Type.IsPremium)
                {
                    double result = 10.0;
                    if (DaysOverdrawn > 7) result += (DaysOverdrawn - 7) * 0.85;
                    return result;
                }
                return DaysOverdrawn * 1.75;
            }
        }
        public void Execute()
        {
            var acc = new Account { Type = new AccountType { IsPremium = true }, DaysOverdrawn = 10 };
            Console.WriteLine("Overdraft charge: " + acc.OverdraftCharge());
        }
    }
}