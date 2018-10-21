using System;
using System.Collections.Generic;

namespace ReverseLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // test input

            // create linked list object
            LinkedList<int> lList = new LinkedList<int>();

            // set the current head
            LinkedListNode<int> head = lList.AddFirst(85);

            // add additional items
            lList.AddLast(15);
            lList.AddLast(4);
            lList.AddLast(20);

            // show original list
            Console.WriteLine("Given the following linked list: ");
            PrintList(head);

            // reverse the linked list
            head = Reverse(lList);

            // print the reverse linked list
            Console.WriteLine("\nLinked List Reversed:");
            PrintList(head);

            // keep console open
            Console.Read();
        }

        /// <summary>
        /// Method to reverse linked list by setting new head as last
        /// Trickier than other languages using built in Linked List class in C#
        /// .Next property is only get, not settable
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        private static LinkedListNode<int> Reverse(LinkedList<int> list)
        {
            // get original head of list
            LinkedListNode<int> head = list.First;

            // create node that will hold value of next node in last
            LinkedListNode<int> next = null;

            /*
             * go through linear data structure until reaching end
             * Get value of next, remove it, and place at front of list
             */
            while (head.Next != null)
            {
                next = head.Next;
                list.Remove(next);
                list.AddFirst(next.Value);
            }

            // set the new head
            head = list.First;

            // return the new head
            return head;
        }

        /// <summary>
        /// Print items of linked list object on single line
        /// </summary>
        /// <param name="current"></param>
        private static void PrintList(LinkedListNode<int> current)
        {
            while(current != null)
            {
                Console.Write(current.Value + " ");
                current = current.Next;
            }
        }
    }
}
