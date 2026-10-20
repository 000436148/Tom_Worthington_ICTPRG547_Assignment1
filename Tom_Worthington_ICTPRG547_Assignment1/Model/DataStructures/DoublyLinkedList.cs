using System;
using System.Collections.Generic;

namespace Tom_Worthington_ICTPRG547_Assignment1.Model.DataStructures
{
    /// <summary>
    /// A generic doubly linked list supporting forward and backward traversal.
    /// </summary>
    public class DoublyLinkedList<T>
    {
        private class Node
        {
            public T Data;
            public Node? Next;
            public Node? Prev;

            public Node(T data)
            {
                Data = data;
                Next = null;
                Prev = null;
            }
        }

        private Node? head;
        private Node? tail;

        public int Count { get; private set; }

        /// <summary>
        /// Adds an item to the head of the list.
        /// </summary>
        public void AddHead(T item)
        {
            Node newNode = new Node(item);

            if (head == null)
            {
                head = tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Prev = newNode;
                head = newNode;
            }

            Count++;
        }

        /// <summary>
        /// Adds an item to the tail of the list.
        /// </summary>
        public void AddTail(T item)
        {
            Node newNode = new Node(item);

            if (tail == null)
            {
                head = tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                newNode.Prev = tail;
                tail = newNode;
            }

            Count++;
        }

        /// <summary>
        /// Inserts an item at a specific index.
        /// </summary>
        public void InsertAt(int index, T item)
        {
            if (index < 0 || index > Count)
                throw new ArgumentOutOfRangeException(nameof(index));

            if (index == 0)
            {
                AddHead(item);
                return;
            }

            if (index == Count)
            {
                AddTail(item);
                return;
            }

            Node newNode = new Node(item);
            Node? current = head;

            for (int i = 0; i < index; i++)
                current = current!.Next;

            newNode.Next = current;
            newNode.Prev = current!.Prev;

            current.Prev!.Next = newNode;
            current.Prev = newNode;

            Count++;
        }

        /// <summary>
        /// Removes the head node.
        /// </summary>
        public void RemoveHead()
        {
            if (head == null)
                throw new InvalidOperationException("List is empty.");

            head = head.Next;

            if (head != null)
                head.Prev = null;
            else
                tail = null;

            Count--;
        }

        /// <summary>
        /// Removes the tail node.
        /// </summary>
        public void RemoveTail()
        {
            if (tail == null)
                throw new InvalidOperationException("List is empty.");

            tail = tail.Prev;

            if (tail != null)
                tail.Next = null;
            else
                head = null;

            Count--;
        }

        /// <summary>
        /// Removes an item at a specific index.
        /// </summary>
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
                throw new ArgumentOutOfRangeException(nameof(index));

            if (index == 0)
            {
                RemoveHead();
                return;
            }

            if (index == Count - 1)
            {
                RemoveTail();
                return;
            }

            Node? current = head;

            for (int i = 0; i < index; i++)
                current = current!.Next;

            current!.Prev!.Next = current.Next;
            current.Next!.Prev = current.Prev;

            Count--;
        }

        /// <summary>
        /// Finds an item in the list.
        /// </summary>
        public bool Contains(T item)
        {
            Node? current = head;

            while (current != null)
            {
                if (current.Data!.Equals(item))
                    return true;

                current = current.Next;
            }

            return false;
        }

        /// <summary>
        /// Traverses forward.
        /// </summary>
        public IEnumerable<T> TraverseForward()
        {
            Node? current = head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        /// <summary>
        /// Traverses backward.
        /// </summary>
        public IEnumerable<T> TraverseBackward()
        {
            Node? current = tail;

            while (current != null)
            {
                yield return current.Data;
                current = current.Prev;
            }
        }
    }
}
