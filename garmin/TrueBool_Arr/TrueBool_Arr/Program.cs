using System;
using System.Collections.Generic;

/// <summary>
/// For boolean array of arbitrary length, return only true values
/// </summary>

namespace TrueBool_Arr
{
    class Program
    {
        static void Main(string[] args)
        {
            // test input
            bool[] test = { true, false, false, false, false, true, false, true, false, true };

            // call method, pass in arg. Assign result to array
            bool[] arr = TrueBool(test);

            // print results
            PrintTrues(arr);

            // keep console open
            Console.Read();
        }

        /// <summary>
        /// Create new list to add trues to
        /// loop through array
        /// if index value = true, add true to list
        /// return the list converted as an array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private static bool[] TrueBool(bool[] arr)
        {
            List<bool> trueBools = new List<bool>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == true)
                {
                    trueBools.Add(true);
                }
            }

            return trueBools.ToArray();
        }

        // utility function to neatly print array of booleans
        private static void PrintTrues(bool[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }
    }
}
