using System;

/// <summary>
/// Count how close array is to being sorted
/// </summary>

namespace Inversion_Count_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // test input
            int[] testArr = { 1, 3, 5, 4, 8, 2, 9, 11, 10 };

            // call method, pass in arg
            int invertedCount = Inversions(testArr);

            Console.WriteLine("Number of inversion in array = {0}", invertedCount);

            // keep console open
            Console.Read();
        }

        // method to find number of inverted
        private static int Inversions(int[] arr)
        {
            // create variable to hold count
            int count = 0;

            // outer loop controls loops through each element
            for (int i = 0; i < arr.Length; i++)
            {
                // inner loop compares current index, to each index to right
                for (int j = i; j < arr.Length; j++)
                {
                    // check if current index is greater than indexes to right of it
                    if (arr[i] > arr[j])
                    {
                        // if so, increase the counter by one
                        count++; 
                    }
                }
            }

            // return the count value
            return count;
        }
    }
}
