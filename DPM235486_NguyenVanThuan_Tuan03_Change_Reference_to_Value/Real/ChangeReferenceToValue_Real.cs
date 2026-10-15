using System;
using System.Collections.Generic;

namespace DPM235486_NguyenVanThuan_Tuan03_Change_Reference_to_Value
{
    /// <summary>
    /// REAL: Ung dung thuc te - 
    /// </summary>
    public class ChangeReferenceToValue_Real
    {
        // Ung dung: Money value object trong he thong thanh toan
        public struct Money
        {
            public decimal Amount { get; }
            public string Currency { get; }
            public Money(decimal amount, string currency) { Amount = amount; Currency = currency; }
            public Money Add(Money other)
            {
                if (Currency != other.Currency) throw new InvalidOperationException("Different currencies");
                return new Money(Amount + other.Amount, Currency);
            }
            public override bool Equals(object obj) { return obj is Money m && Amount == m.Amount && Currency == m.Currency; }
            public override int GetHashCode() { return Amount.GetHashCode() ^ Currency.GetHashCode(); }
            public override string ToString() { return Amount.ToString("N0") + " " + Currency; }
        }
        public void Run()
        {
            var a = new Money(100000, "VND");
            var b = new Money(200000, "VND");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("a + b = " + a.Add(b));
            Console.WriteLine("Equal: " + a.Equals(new Money(100000, "VND")));
        }
    }
}