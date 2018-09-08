using System;
using System.Collections.Generic;

/// <summary>
/// Write a function, that given an array returns
/// an array with the same content of the parameter but without duplicates
/// </summary>

namespace RemoveDups
{
    class Program
    {
        static void Main(string[] args)
        {
            // test input
            char[] arr = { 'a', 'b', 'c', 'd', 'a', 'f', 'a', 'f', 'e' };

            // call method, pass in arg
            char[] noDups = RemoveDups(arr);

            PrintArr(noDups);

            // keep console open
            Console.Read();
        }

        
        private static char[] RemoveDups(char[] arr)
        {
            // have list to add string
            List<char> newList = new List<char>();

            // sort array
            Array.Sort(arr);

            // make sure array is not empty
            if (arr.Length == 0)
            {
                Console.WriteLine("Please enter a non-empty array");
                return arr;
            }

            // loop through array
            for (int i = 0; i < arr.Length; i++)
            {
                // if 
                if (i + 1 >= arr.Length || arr[i] != arr[i + 1])
                {
                    newList.Add(arr[i]);
                }
            }

            // convert list to array
            char[] newArr = newList.ToArray();

            // return the array
            return newArr;
        }

        // utility to neatly print array
        private static void PrintArr(char[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }
    }
}
