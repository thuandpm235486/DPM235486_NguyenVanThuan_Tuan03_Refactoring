using System;
using System.Collections.Generic;

namespace DPM235486_NguyenVanThuan_Tuan03_Replace_Magic_Number_with_Symbolic_Constant
{
    /// <summary>
    /// REAL: Ung dung thuc te - 
    /// </summary>
    public class ReplaceMagicNumberWithSymbolicConstant_Real
    {
        // Ung dung: hang so nghiep vu co ten ro rang trong he thong ban hang
        private const double VAT_RATE = 0.1;
        private const double LOYALTY_DISCOUNT = 0.05;
        private const double MIN_ORDER_FOR_FREE_SHIP = 500000;
        private const double SHIPPING_FEE = 30000;
        private const int MAX_ITEMS_PER_ORDER = 50;

        public double CalculateBill(double subtotal, bool isLoyalCustomer)
        {
            double discount = isLoyalCustomer ? subtotal * LOYALTY_DISCOUNT : 0;
            double afterDiscount = subtotal - discount;
            double vat = afterDiscount * VAT_RATE;
            double shipping = afterDiscount >= MIN_ORDER_FOR_FREE_SHIP ? 0 : SHIPPING_FEE;
            return afterDiscount + vat + shipping;
        }
        public void Run()
        {
            Console.WriteLine("Bill loyal (600k): " + CalculateBill(600000, true).ToString("N0") + " VND");
            Console.WriteLine("Bill normal(300k): " + CalculateBill(300000, false).ToString("N0") + " VND");
        }
    }
}