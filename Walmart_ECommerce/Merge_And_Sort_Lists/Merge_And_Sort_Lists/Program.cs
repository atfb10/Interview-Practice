using System;
using System.Collections.Generic;

namespace Merge_And_Sort_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // test input
            List<int> testInput1 = new List<int>();
            int[] arrayToInput1 = { 1, 2, 9, 10, 44, 8, 4 };
            testInput1.AddRange(arrayToInput1);
            List<int> testInput2 = new List<int>();
            int[] arrayToInput2 = { 7, 9, 3, 14, 90 };
            testInput2.AddRange(arrayToInput2);

            // print the sorted and merged list
            PrintMergedLists(MergeAndSort(testInput1, testInput2));
                
            // keep console open
            Console.Read();
        }

        /// <summary>
        /// Method takes in two lists
        /// </summary>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        /// <returns></returns>
        private static List<int> MergeAndSort(List<int> list1, List<int> list2)
        {
            // add each item in list two to list one
            for (int i = 0; i < list2.Count; i++)
            {
                list1.Add(list2[i]);
            }

            // use standard library to sort list 1, now that it contains list 2 items
            list1.Sort();

            // return the new list
            return list1;
        }

        /// <summary>
        /// utility function to neatly print the new list
        /// </summary>
        /// <param name="list"></param>
        private static void PrintMergedLists(List<int> list)
        {
            // print all items in merged and sorted list on single line
            for (int i = 0; i < list.Count; i++)
                Console.Write(list[i] + " ");
            Console.WriteLine();
        }
    }
}
