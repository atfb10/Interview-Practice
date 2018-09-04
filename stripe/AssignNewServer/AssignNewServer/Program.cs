using System;
using System.Collections.Generic;
using System.Linq;

// You're running a pool of servers where the servers are numbered sequentially
// starting from 1.

// Over time, any given server might explode, in which case its
// server number is made available for reuse.

// When a new server is launched, it should be given the lowest available number.

// Write a function which, given the list of currently allocated server numbers,
// returns the number of the next server to allocate.

// For example, your function should behave something like the following:

//  >> next_server_number([5, 3, 1])
//  2
//  >> next_server_number([5, 4, 1, 2])
//  3
//  >> next_server_number([3, 2, 1])
//  4
//  >> next_server_number([2, 3])
//  1

namespace AssignNewServer
{
    class Program
    {
        static void Main(string[] args)
        {
            // test input
            List<int> stripeServers = new List<int> { 1, 3, 2, 9, 10, 15, 22, 34};

            // print current servers
            Console.WriteLine("Current servers: ");
            PrintList(stripeServers);

            // call method 
            Console.WriteLine("\nNew Server Number Added: " + AssignLowestAvailable(stripeServers) + "\n");

            // print new list
            Console.WriteLine("New Server List: ");
            PrintList(stripeServers);

            // keep console open
            Console.Read();
        }

        // utility function to neatly print linked list to console
        private static void PrintList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }
        
        /// <summary>
        /// Sort the list
        /// Initialize the new server number as the first in the array
        /// If after sort, the smallest number is greater than 1, add 1 to server and return 1
        /// Loop through list starting at one
        /// If new server + 1 does not equal list index, return new server + 1 after adding to list
        /// If all numbers 1 -> highest in list are taken, add 1 to highest value and return that
        /// Else, get last
        /// </summary>
        /// <param name="list"></param>
        private static int AssignLowestAvailable(List<int> list)
        {
            list.Sort();

            int newServerNum = list[0];

            if (newServerNum > 1)
            {
                list.Add(1);
                return 1;
            }

            for (int i = 1; i < list.Count; i++)
            {
                if (newServerNum + 1 != list[i])
                {
                    newServerNum += 1;
                    list.Add(newServerNum);
                    return newServerNum;
                }
                newServerNum = list[i];
            }

            int lastVal = list.Last();
            newServerNum = lastVal + 1;
            list.Add(newServerNum);
            return newServerNum;
        }
    }
}
