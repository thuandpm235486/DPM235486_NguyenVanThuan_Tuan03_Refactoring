using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Move_Method
{
    /// <summary>
    /// AFTER: Code da duoc refactor - 
    /// </summary>
    public class MoveMethod_After
    {
        // Giai phap: chuyen OverdraftCharge sang AccountType (class su dung no nhieu hon)
        public class AccountType
        {
            public bool IsPremium { get; set; }
            public double OverdraftCharge(int daysOverdrawn) // method da chuyen sang day
            {
                if (IsPremium)
                {
                    double result = 10.0;
                    if (daysOverdrawn > 7) result += (daysOverdrawn - 7) * 0.85;
                    return result;
                }
                return daysOverdrawn * 1.75;
            }
        }
        public class Account
        {
            public AccountType Type { get; set; }
            public int DaysOverdrawn { get; set; }
            public double OverdraftCharge() { return Type.OverdraftCharge(DaysOverdrawn); }
        }
        public void Execute()
        {
            var acc = new Account { Type = new AccountType { IsPremium = true }, DaysOverdrawn = 10 };
            Console.WriteLine("Overdraft charge: " + acc.OverdraftCharge());
        }
    }
}