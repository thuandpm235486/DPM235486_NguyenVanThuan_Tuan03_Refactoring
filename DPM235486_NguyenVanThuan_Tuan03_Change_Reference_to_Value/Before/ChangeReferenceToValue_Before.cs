using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Change_Reference_to_Value
{
    /// <summary>
    /// BEFORE: Code chua duoc refactor - 
    /// </summary>
    public class ChangeReferenceToValue_Before
    {
        // Van de: Currency la class (reference), phai quan ly vong doi phuc tap
        public class Currency
        {
            private string _code;
            public Currency(string code) { _code = code; }
            public string GetCode() { return _code; }
        }
        public void Execute()
        {
            var usd1 = new Currency("USD");
            var usd2 = new Currency("USD");
            Console.WriteLine("Codes same: " + (usd1.GetCode() == usd2.GetCode()));
            Console.WriteLine("Reference same: " + (usd1 == usd2)); // false - khac reference
        }
    }
}