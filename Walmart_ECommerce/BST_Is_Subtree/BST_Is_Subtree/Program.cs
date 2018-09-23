using System;

namespace BST_Is_Subtree
{
    public class Node
    {
        Node left, right;
        int data;

        public Node(int data)
        {
            this.data = data;
            left = null;
            right = null;
        }

        public class BST
        {
            Node root1, root2;

            // check if trees are identical or not
            bool Identical(Node root1, Node root2)
            {
                // if both empty, then identical
                if (root1 == null && root2 == null)
                    return true;

                // if one empty and one not, not identical
                if (root1 == null || root2 == null)
                    return false;

                // check if root and left and right sides are identical
                return (root1.data == root2.data
                    && Identical(root1.left, root2.right)
                    && Identical(root1.right, root2.right));
            }

            // check if second tree is subtree of first
            bool IsSubTree(Node mainTree, Node secondTree)
            {
                // see if second tree is null, then it has to be subtree
                if (secondTree == null)
                    return true;

                // if main tree null, then second cannot be subtree
                if (mainTree == null)
                    return false;

                // check if trees are identical
                if (Identical(mainTree, secondTree) == true)
                    return true;

                // see if left and right subtrees match
                return (IsSubTree(mainTree.left, secondTree)
                    || IsSubTree(mainTree.right, secondTree));
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
