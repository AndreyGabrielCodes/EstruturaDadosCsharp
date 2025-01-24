using System;
using System.Collections.Generic;

namespace Arvores
{
    public class BinaryTree<T>
    {
        public TreeNode<T> Root { get; private set; }

        public BinaryTree()
        {
            Root = null;
        }

        public void Insert(T value)
        {
            Root = InsertRecursive(Root, value);
        }

        private TreeNode<T> InsertRecursive(TreeNode<T> node, T value)
        {
            if (node == null)
            {
                return new TreeNode<T>(value);
            }

            if (Comparer<T>.Default.Compare(value, node.Value) < 0)
            {
                node.Left = InsertRecursive(node.Left, value);
            }
            else if (Comparer<T>.Default.Compare(value, node.Value) > 0)
            {
                node.Right = InsertRecursive(node.Right, value);
            }

            return node;
        }

        public bool Search(T value)
        {
            return SearchRecursive(Root, value);
        }

        private bool SearchRecursive(TreeNode<T> node, T value)
        {
            if (node == null)
            {
                return false;
            }

            if (EqualityComparer<T>.Default.Equals(node.Value, value))
            {
                return true;
            }
            else if (Comparer<T>.Default.Compare(value, node.Value) < 0)
            {
                return SearchRecursive(node.Left, value);
            }
            else
            {
                return SearchRecursive(node.Right, value);
            }
        }

        public void InOrderTraversal(Action<T> action)
        {
            InOrderTraversalRecursive(Root, action);
        }

        private void InOrderTraversalRecursive(TreeNode<T> node, Action<T> action)
        {
            if (node != null)
            {
                InOrderTraversalRecursive(node.Left, action);
                action.Invoke(node.Value);
                InOrderTraversalRecursive(node.Right, action);
            }
        }

    }
}
