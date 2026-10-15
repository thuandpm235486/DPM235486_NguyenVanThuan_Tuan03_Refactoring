using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Substitute_Algorithm
{
    /// <summary>
    /// BEFORE: Code chua duoc refactor - 
    /// </summary>
    public class SubstituteAlgorithm_Before
    {
        // Van de: thuat toan hien tai phuc tap, kho bao tri
        public string FoundPerson(string[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].Equals("Don"))  return "Don";
                if (people[i].Equals("John")) return "John";
                if (people[i].Equals("Kent")) return "Kent";
            }
            return "";
        }
        public void Execute()
        {
            string[] team = { "Alice", "John", "Bob" };
            Console.WriteLine("Found: " + FoundPerson(team));
        }
    }
}