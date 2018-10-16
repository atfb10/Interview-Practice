using System;
using System.Collections.Generic;
using System.Text;

// eliminate duplicates from a string

namespace RemoveDupsFromString
{
    class Program
    {
        static void Main(string[] args)
        {
            // test string
            string test = "expedia";

            // call method and print new string
            string noDupStr = RemoveDups(test);

            Console.WriteLine("{0} with no duplicates = {1}", test, noDupStr);

            // keep console open
            Console.Read();
        }

        private static string RemoveDups(string str)
        {
            // create hashset to hold non-dup chars
            HashSet<char> myHash = new HashSet<char>();

            // create stringbuilder object to append non-dup characters to
            StringBuilder noDup = new StringBuilder();

            // loop through string
            for (int i = 0; i < str.Length; i++)
            {
                // if character not found in hashset, put in
                if (!myHash.Contains(str[i]))
                    myHash.Add(str[i]);
            }

            // create new string from each value in hashset
            foreach (char character in myHash)
                noDup.Append(character);

            // return the stringbuilder object
            return noDup.ToString();
        }
    }
}
