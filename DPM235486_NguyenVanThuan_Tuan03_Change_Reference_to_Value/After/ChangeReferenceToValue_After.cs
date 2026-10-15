using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Change_Reference_to_Value
{
    /// <summary>
    /// AFTER: Code da duoc refactor - 
    /// </summary>
    public class ChangeReferenceToValue_After
    {
        // Giai phap: chuyen Currency thanh struct (value object)
        public struct Currency
        {
            private readonly string _code;
            public Currency(string code) { _code = code; }
            public string GetCode() { return _code; }
            public override bool Equals(object obj)
            {
                if (obj is Currency other) return _code == other._code;
                return false;
            }
            public override int GetHashCode() { return _code != null ? _code.GetHashCode() : 0; }
            public override string ToString() { return _code; }
        }
        public void Execute()
        {
            var usd1 = new Currency("USD");
            var usd2 = new Currency("USD");
            Console.WriteLine("Value equal: " + usd1.Equals(usd2)); // true!
            Console.WriteLine("Currency: " + usd1);
        }
    }
}