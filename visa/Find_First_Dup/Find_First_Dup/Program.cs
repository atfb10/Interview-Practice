using System;
using System.Collections.Generic;

/// <summary>
/// Find first duplicate in an array
/// </summary>

namespace Find_First_Dup
{
    class Program
    {
        static void Main(string[] args)
        {
            // test input
            char[] testArr = { 'c', 'a', 'z', 'q', 'z', 'a'};

            // print method result
            char firstDup = FindFirstDup(testArr);
            Console.WriteLine(firstDup);

            // keep console open
            Console.Read();
        }

        private static char FindFirstDup(char[] arr)
        {
            // value to hold first repeating val. Initialize to zero, value if no dups are found
            char firstRepeated = '0';

            // hashset to add vals to if not repeated
            HashSet<int> myHash = new HashSet<int>();

            // traverse array from left to right
            for (int i = 0; i < arr.Length; i++)
            {
                // if the element is in hash, set first repeated and exit loop
                if (myHash.Contains(arr[i]))
                {
                    firstRepeated = arr[i];
                    break;
                }

                // otherwise add element to the hash set
                else
                    myHash.Add(arr[i]);
            }

            // return first repeated
            return firstRepeated;
        }
    }
}
