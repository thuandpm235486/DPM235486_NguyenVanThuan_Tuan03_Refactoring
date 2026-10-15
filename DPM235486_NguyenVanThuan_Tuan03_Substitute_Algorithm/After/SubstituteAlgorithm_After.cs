using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DPM235486_NguyenVanThuan_Tuan03_Substitute_Algorithm
{
    /// <summary>
    /// AFTER: Code da duoc refactor - 
    /// </summary>
    public class SubstituteAlgorithm_After
    {
        // Giai phap: thay the bang thuat toan don gian, ro rang hon
        public string FoundPerson(string[] people)
        {
            var candidates = new List<string> { "Don", "John", "Kent" };
            foreach (string person in people)
                if (candidates.Contains(person)) return person;
            return "";
        }
        public void Execute()
        {
            string[] team = { "Alice", "John", "Bob" };
            Console.WriteLine("Found: " + FoundPerson(team));
        }
    }
}