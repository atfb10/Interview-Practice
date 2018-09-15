using System;

/// <summary>
/// Level order traversal of a binary tree
/// </summary>

namespace PrintLevelOrderTree
{
    public class Node
    {
        public int data;
        public Node left, right;

        public Node(int data)
        {
            this.data = data;
            left = null;
            right = null;
        }
    }

    public class BinTree
    {
        // root of tree
        Node root;

        public BinTree()
        {
            root = null;
        }

        // find height of tree
        public int TreeHeight(Node root)
        {
            if (root == null)
                return 0;
            else
            {
                // get height of each side of tree
                int leftHeight = TreeHeight(root.left);
                int rightHeight = TreeHeight(root.right);

                // height is the taller one 
                if (leftHeight > rightHeight)
                    return leftHeight + 1;
                else return rightHeight + 1;
            }
        }

        // print given level
        public void PrintGivenLevel(Node root, int level)
        {
            if (root == null)
                return;
            if (level == 1)
                Console.Write(root.data + " ");
            else if(level > 1)
            {
                PrintGivenLevel(root.left, level - 1);
                PrintGivenLevel(root.right, level - 1);
            }
        }

        // print order by level
        public void PrintOrderByLevel()
        {
            int i = 1;
            int height = TreeHeight(root);

            for (i = 1; i <= height; i++)
                PrintGivenLevel(root, i);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
