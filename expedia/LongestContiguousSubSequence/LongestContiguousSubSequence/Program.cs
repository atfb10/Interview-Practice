using System;
using System.Collections.Generic;

/// <summary>
/// find longest contiguous subsequence if array
/// 
/// Example (1, 4, 2, 8) = 2
/// </summary>

namespace LongestContiguousSubSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            // test input
            int[] arr = { 1, 88, 3, 44, 21, 8, 4, 90, 5, 2 };

            // show result
            PrintArr(arr);
            Console.WriteLine("The longest contiguous subsequence is {0}", LongestSubsequence(arr));

            // keep console open
            Console.Read();
        }

        /// <summary>
        /// Function to find longest contiguous subsequence using a hashset
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private static int LongestSubsequence(int[] arr)
        {
            int i, j;
            int n = arr.Length;
            int answer = 1;

            // hashset to hold array values
            HashSet<int> myHash = new HashSet<int>();

            // add all values to hashset
            for (i = 0; i < n; i++)
                myHash.Add(arr[i]);

            // loop through all values in array
            for (i = 0; i < n; i++)
            {
                // check if beginning of subsequence
                if (!myHash.Contains(arr[i] - 1))
                {
                    // initialize counter variable
                    j = arr[i];

                    // see how many are in subsequence
                    while (myHash.Contains(j))
                        j++; // increment j by 1 each pass

                    // see if this subsequence is the longest
                    if (answer < j - arr[i])
                        answer = j - arr[i];
                }
            }

            // return answer's value
            return answer;
        }

        /// <summary>
        /// Utility function to print array on single line
        /// </summary>
        /// <param name="arr"></param>
        private static void PrintArr(int[] arr)
        {
            int i, n = arr.Length;

            for (i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}
