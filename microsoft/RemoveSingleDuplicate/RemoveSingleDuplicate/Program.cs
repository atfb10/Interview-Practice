using System;

/// <summary>
/// For an array with 100 different numbers and length 101
/// How would you remove the duplicate
/// </summary>

namespace RemoveSingleDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            // test input (Not doing 100 nums)
            int[] test = { 0, 1, 3, 2, 2, 5, 90, 15 };

            // call method, pass in args
            Console.WriteLine("\nDuplicate number: {0}", RemoveDup(test));

            // keep console open
            Console.Read();
        }

        private static int RemoveDup(int[] arr)
        {
            // sort array with quicksort
            QSort(arr, 0, arr.Length - 1);

            // create new array to hold non-duplicated value
            int[] noDups = new int[arr.Length - 1];

            // create a counter for new array
            int j = 0;

            // initialize a variable to hold value of the duplicated num
            int duplicate = 0;

            // loop through array
            for (int i = 0; i < arr.Length; i++)
            {
                // add to new array if not a duplicate
                if (i + 1 >= arr.Length || arr[i] != arr[i + 1])
                    noDups[j++] = arr[i];

                // else set duplicate to duplicate
                else
                    duplicate = arr[i];
            }

            // print the new array
            PrintArr(noDups);

            return duplicate;
        }

        // utility to print array neatly
        private static void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }

        private static int Partition(int[] arr, int start, int end)
        {
            int pivot = arr[end];
            int i = start - 1;

            for (int j = start; j < end; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;

                    int tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                }
            }

            int temp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = temp;

            return i + 1;
        }

        private static void QSort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int pi = Partition(arr, start, end);

                QSort(arr, start, pi - 1);
                QSort(arr, pi + 1, end);
            }
        }
    }
}
