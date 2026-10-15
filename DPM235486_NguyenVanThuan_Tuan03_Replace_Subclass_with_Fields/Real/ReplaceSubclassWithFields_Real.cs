using System;
using System.Collections.Generic;

namespace DPM235486_NguyenVanThuan_Tuan03_Replace_Subclass_with_Fields
{
    /// <summary>
    /// REAL: Ung dung thuc te - 
    /// </summary>
    public class ReplaceSubclassWithFields_Real
    {
        // Ung dung: loai tai khoan ngan hang khong can subclass
        public class AccountType
        {
            private readonly string _name;
            private readonly double _interestRate;
            private readonly bool _hasOverdraft;
            private AccountType(string name, double rate, bool overdraft)
            { _name = name; _interestRate = rate; _hasOverdraft = overdraft; }
            public static AccountType Checking() { return new AccountType("Thanh toan", 0.01, true); }
            public static AccountType Savings()  { return new AccountType("Tiet kiem",  0.05, false); }
            public static AccountType Premium()  { return new AccountType("Premium",    0.08, true); }
            public string GetName()          { return _name; }
            public double GetInterestRate()  { return _interestRate; }
            public bool HasOverdraft()       { return _hasOverdraft; }
        }
        public void Run()
        {
            var types = new[] { AccountType.Checking(), AccountType.Savings(), AccountType.Premium() };
            foreach (var t in types)
                Console.WriteLine(t.GetName() + " | Rate: " + (t.GetInterestRate() * 100) + "% | Overdraft: " + t.HasOverdraft());
        }
    }
}