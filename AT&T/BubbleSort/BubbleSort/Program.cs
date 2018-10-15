using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // test array
            int[] arr = { 5, 22, 1, 99, 332, 44 };

            // call bubble sort and print sorted array
            BubbleSort(arr);
            PrintArr(arr);

            // print array

            // keep console open
            Console.Read();
        }

        // utility function to neatly print array
        private static void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }

        // bubble sort
        private static void BubbleSort(int[] arr)
        {
            // create variables to hold indexes, temp value for swapping and value of array length
            int temp, i, j;
            int n = arr.Length;

            // index control loop
            for (i = 0; i < n; i++)
            {
                // comparision loop
                for (j = 0; j < n - i - 1; j++)
                {
                    // compare two values and swap if left side larger
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}
