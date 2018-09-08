using System;

/// <summary>
/// Implement Quicksort
/// </summary>

namespace Quicksort
{
    class Program
    {
        static void Main(string[] args)
        {
            // test input
            int[] test = { 1, 4, 2, 3, 0, 8, 10, 33, 6 };

            // call method, pass in arg
            QuickSort(test, 0, test.Length - 1);

            // print new array
            Console.WriteLine("Sorted Array: ");
            PrintArray(test);

            // keep console open
            Console.Read();
        }

        // partition array
        private static int Partition(int[] arr, int start, int end)
        {
            int pivot = arr[end];
            int i = start - 1;

            for (int j = start; j < end; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;

                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            int tmp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = tmp;

            return i + 1;
        }

        // sort the array
        private static void QuickSort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                // partition
                int p = Partition(arr, start, end);

                // sort array
                QuickSort(arr, start, p - 1);
                QuickSort(arr, p + 1, end);
            }
        }

        // utility to print array
        private static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }
    }
}
