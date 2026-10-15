using System;
using System.Collections.Generic;

namespace DPM235486_NguyenVanThuan_Tuan03_Remove_Assignments_to_Parameters
{
    /// <summary>
    /// REAL: Ung dung thuc te - 
    /// </summary>
    public class RemoveAssignmentsToParameters_Real
    {
        // Ung dung: tinh phi van chuyen ma khong thay doi tham so goc
        public double CalculateShippingFee(double baseWeight, string zone)
        {
            double fee = baseWeight * 5000; // bien cuc bo
            if (zone == "remote") fee += 20000;
            if (baseWeight > 10) fee *= 0.9;
            return fee;
        }
        public void Run()
        {
            Console.WriteLine("Normal 5kg : " + CalculateShippingFee(5, "normal") + " VND");
            Console.WriteLine("Remote 5kg : " + CalculateShippingFee(5, "remote") + " VND");
            Console.WriteLine("Heavy 12kg : " + CalculateShippingFee(12, "normal") + " VND");
        }
    }
}