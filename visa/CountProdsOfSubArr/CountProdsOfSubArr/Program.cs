using System;

/// <summary>
/// Count the number of possible subarrays having products less than or equal to given number
/// </summary>

namespace CountProdsOfSubArr
{
    class Program
    {
        static void Main(string[] args)
        {
            // test input
            int[] testArr = { 1, 2, 3, 4 };
            int givenNum = 10;

            // call method, pass arg, print results
            int answer = CountSubArray(testArr, givenNum);
            Console.WriteLine("Number of subarrays from array whose product is less than or equal to {0} = {1}", givenNum, answer);

            // keep console open
            Console.Read();
        }

        private static int CountSubArray(int[] arr, int n)
        {
            // create variable to hold count
            int count = 0;

            // variable to hold multiplied product
            int productVal;

            // outer loop controls each index
            for (int i = 0; i < arr.Length; i++)
            {
                // check if each subarray of index one has value less than n
                if (arr[i] <= n)
                    count++;

                // assign product value the first index value of subarray
                productVal = arr[i];

                // inner loop checks subarrays greater than 1 length
                for (int j = i + 1; j < arr.Length; j++)
                {
                    // multiply subarr
                    productVal *= arr[j];

                    // check if the product value is <= n, if so increment count
                    if (productVal <= n)
                        count++;
                }
            }
            // return count
            return count;
        }
    }
}
