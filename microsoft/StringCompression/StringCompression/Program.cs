using System;
using System.Text;

/// <summary>
/// Given an array of characters, compress the array in such
/// a way that [aBBBAAaaa] becomes [a1B3A2a3]
/// </summary>

namespace StringCompression
{
    class Program
    {
        static void Main(string[] args)
        {
            // test input
            string test = "aBBBAAaaa";

            // call method, pass in arg
            Console.WriteLine(Compress(test));

            // keep console open
            Console.Read();
        }

       private static string Compress(string str)
        {
            // create stringbuilder to hold new string and counter to hold count of dups
            StringBuilder compressed = new StringBuilder();
            int counter = 0;

            // make sure string has a length
            if (str.Length == 0)
            {
                return "Please enter string with a valid length";
            }

            // loop through string
            for (int i = 0; i < str.Length; i++)
            {
                // increment counter
                counter++;

                // check if strings end or next letter is not duplicate
                if (i + 1 >= str.Length || str[i] != str[i + 1])
                {
                    // append character and string. Reset counter
                    compressed.Append(str[i]);
                    compressed.Append(counter);
                    counter = 0;
                }
            }

            // return the new compressed string
            return compressed.ToString();
        }
    }
}
