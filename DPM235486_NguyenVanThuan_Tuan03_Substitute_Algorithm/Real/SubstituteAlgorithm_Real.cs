using System;
using System.Collections.Generic;

namespace DPM235486_NguyenVanThuan_Tuan03_Substitute_Algorithm
{
    /// <summary>
    /// REAL: Ung dung thuc te - 
    /// </summary>
    public class SubstituteAlgorithm_Real
    {
        // Ung dung: tim san pham khuyen mai trong gio hang
        public string FindPromoItem(string[] cartItems)
        {
            var promoItems = new List<string> { "iPhone", "MacBook", "iPad" };
            foreach (string item in cartItems)
                if (promoItems.Contains(item)) return item;
            return "None";
        }
        public void Run()
        {
            string[] cart = { "AirPods", "MacBook", "Mouse" };
            Console.WriteLine("Promo item in cart: " + FindPromoItem(cart));
        }
    }
}