using System;

// convert a binary tree to a doubly linked list

namespace BinTree_To_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Node
    {
        public int data;
        public Node left;
        public Node right;

        Node(int item)
        {
            data = item;
            left = right = null;
        }
    }

    class BinaryTree
    {
        Node root;

        Node head;

        public void BinTreeToLinkedList(Node root)
        {
            // check if the root of tree is empty
            if (root == null)
                return;

            // recursively convert right side of tree
            BinTreeToLinkedList(root.right);

            // insert the root into doubly linked list
            root.right = head;

            // Change the left pointer of previous head
            if (head != null)
                (head).left = root;

            // convert left side of tree
            BinTreeToLinkedList(root.left);
        }

        // print new linked list
        public void PrintList(Node head)
        {
            while (head != null)
            {
                Console.Write(head.data + " ");
                head = head.right;
            }
        }
    }
}
