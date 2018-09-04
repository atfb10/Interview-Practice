using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Print all unique substrings for any given string
/// </summary>

namespace UniqueSubstrings_In_String
{
    class Program
    {
        static void Main(string[] args)
        {
            // test input
            string test = "abacqe";

            // call methods and print result
            List<string> myList = UniqueSubstrings(test);
            PrintSubstringList(myList);

            // keep console open
            Console.Read();
        }

        // utility function to neatly print result
        private static void PrintSubstringList(List<string> list)
        {
            foreach (string substring in list)
            {
                Console.Write(substring + " ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Create list to hold substrings
        /// Loop through each character
        /// Loop through each character following each character
        /// Add the substrings
        /// Return the list after removing duplicate substrings
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static List<string> UniqueSubstrings(string str)
        {
            List<string> subs = new List<string>();

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i; j < str.Length; j++)
                {
                    subs.Add(str.Substring(i, j - i + 1));
                }
            }

            return subs.Distinct().ToList();
        }
    }
}
