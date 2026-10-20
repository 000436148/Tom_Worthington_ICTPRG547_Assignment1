using System;
using System.Collections.Generic;

namespace Tom_Worthington_ICTPRG547_Assignment1.Model.DataStructures
{
    /// <summary>
    /// A generic Binary Search Tree supporting insertion and traversal.
    /// </summary>
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        private class Node
        {
            public T Data;
            public Node? Left;
            public Node? Right;

            public Node(T data)
            {
                Data = data;
                Left = null;
                Right = null;
            }
        }

        private Node? root;

        /// <summary>
        /// Inserts an item into the BST.
        /// </summary>
        public void Insert(T item)
        {
            root = InsertRecursive(root, item);
        }

        private Node InsertRecursive(Node? node, T item)
        {
            if (node == null)
                return new Node(item);

            int compare = item.CompareTo(node.Data);

            if (compare < 0)
                node.Left = InsertRecursive(node.Left, item);
            else if (compare > 0)
                node.Right = InsertRecursive(node.Right, item);

            return node;
        }

        /// <summary>
        /// InOrder traversal (Left, Root, Right)
        /// </summary>
        public IEnumerable<T> InOrder()
        {
            return InOrderRecursive(root);
        }

        private IEnumerable<T> InOrderRecursive(Node? node)
        {
            if (node != null)
            {
                foreach (var item in InOrderRecursive(node.Left))
                    yield return item;

                yield return node.Data;

                foreach (var item in InOrderRecursive(node.Right))
                    yield return item;
            }
        }

        /// <summary>
        /// PreOrder traversal (Root, Left, Right)
        /// </summary>
        public IEnumerable<T> PreOrder()
        {
            return PreOrderRecursive(root);
        }

        private IEnumerable<T> PreOrderRecursive(Node? node)
        {
            if (node != null)
            {
                yield return node.Data;

                foreach (var item in PreOrderRecursive(node.Left))
                    yield return item;

                foreach (var item in PreOrderRecursive(node.Right))
                    yield return item;
            }
        }

        /// <summary>
        /// PostOrder traversal (Left, Right, Root)
        /// </summary>
        public IEnumerable<T> PostOrder()
        {
            return PostOrderRecursive(root);
        }

        private IEnumerable<T> PostOrderRecursive(Node? node)
        {
            if (node != null)
            {
                foreach (var item in PostOrderRecursive(node.Left))
                    yield return item;

                foreach (var item in PostOrderRecursive(node.Right))
                    yield return item;

                yield return node.Data;
            }
        }
    }
}
