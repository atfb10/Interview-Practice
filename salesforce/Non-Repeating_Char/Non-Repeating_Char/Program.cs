using System;

/// <summary>
/// Find and return the first non-repeating character in a given string
/// </summary>

namespace Non_Repeating_Char
{
    class Program
    {
        static void Main(string[] args)
        {
            // test input
            string test = "aabbbbqqeeeiiip";

            // call method and print
            Console.WriteLine(FirstUniqueChar(test));

            // keep console open
            Console.Read();
        }

        /// <summary>
        /// Turn string into char array
        /// Loop through array
        /// If second character not equal to first, return first
        /// If last character and not equal to preceding character, return
        /// If not first or last character, and not equal to preceding or following character, return
        /// If none of these requirements are met, return !
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static char FirstUniqueChar(string str)
        {
            char[] arr = str.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0 && arr[i] != arr[i + 1])
                {
                    return arr[i];
                }
                else if (i == arr.Length - 1 && arr[i] != arr[i -1])
                {
                    return arr[i];
                }
                else if (arr[i] != arr[i + 1] && arr[i] != arr[i - 1])
                {
                    return arr[i];
                }
            }

            return '!';
        }
    }
}
