using System;

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
            char[] arr = { 'a', 'b', 'c', 'd', 'a', 'f', 'a', 'f', 'e', 'e', 'f' };

            // create array with no duplicates
            char[] noDups = RemoveDups(arr);

            // print the array with no duplicates
            PrintArr(noDups);

            // keep console open
            Console.Read();
        }

        
        private static char[] RemoveDups(char[] arr)
        {
            // sort array 
            Array.Sort(arr);

            // create new array to hold only unique vals
            char[] noDups = new char[arr.Length];

            // counter for each noDups index
            int j = 0;

            // loop through the array
            for (int i = 0; i < arr.Length; i++)
            {
                // check if end of array, or if next val not equal to current
                if (i + 1 >= arr.Length || arr[i] != arr[i + 1])
                {
                    // if so, add value to end of new array
                    noDups[j++] = arr[i];
                }
            }

            // return the new array
            return noDups;
        }

        // utility to neatly print array
        private static void PrintArr(char[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }
    }
}
