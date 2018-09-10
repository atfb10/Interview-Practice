using System;
using System.Text;

/// <summary>
/// Given array of numbers and target value, find two numbers in that array 
/// and add up to target value
/// </summary>

namespace TwoNums_SumToTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            // test inputs
            int[] arr = { 1, 3, 2, 4, 5, 7, 9, 11};
            int target = 13;

            // test methods
            Console.WriteLine(TwoNums(arr, target));

            // keep console open
            Console.Read();
        }

        // Solve by implementing quicksort

        // partition
        private static int Partition(int[] arr, int start, int end)
        {
            int pivot = arr[end];
            int i = start - 1;

            for (int j = start; j < end; j++)
            {
                if (start <= pivot)
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

        // sort
        private static void QSort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int p = Partition(arr, start, end);

                QSort(arr, start, p - 1);
                QSort(arr, p + 1, end);
            }
        }

        // find nums
        private static string TwoNums(int[] arr, int target)
        {
            // create start and end point
            int start = 0;
            int end = arr.Length - 1;

            // create stringbuilder to hold values
            StringBuilder str = new StringBuilder();

            // sort the array
            QSort(arr, start, end);

            // try to find nums using binary search
            while (start < end)
            {
                // if start and end equal target return. 
                // if target larger, incremement start
                // if target smaller, decrement end
                if (arr[start] + arr[end] == target)
                    return str.Append(arr[start] + " + " + arr[end] + " = " + target).ToString();
                else if (arr[start] + arr[end] < target)
                    start++;
                else
                    end--;
            }
            return "No two nums in array found to sum to target";
        }
    }
}
