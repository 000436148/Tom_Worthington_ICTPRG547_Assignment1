using System;
using System.Collections;
using System.Collections.Generic;

namespace Tom_Worthington_ICTPRG547_Assignment1.Model.DataStructures
{
    /// <summary>
    /// A generic singly linked list implementing ICollection.
    /// Supports insertion, deletion, traversal and searching.
    /// </summary>
    public class SinglyLinkedList<T> : ICollection<T>
    {
        private class Node
        {
            public T Data;
            public Node? Next;

            public Node(T data)
            {
                Data = data;
                Next = null;
            }
        }

        private Node? head;
        private Node? tail;

        public int Count { get; private set; }
        public bool IsReadOnly => false;

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

            for (int i = 0; i < index - 1; i++)
                current = current!.Next;

            newNode.Next = current!.Next;
            current.Next = newNode;

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

            if (head == null)
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

            if (head == tail)
            {
                head = tail = null;
            }
            else
            {
                Node? current = head;

                while (current!.Next != tail)
                    current = current.Next;

                current.Next = null;
                tail = current;
            }

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

            Node? current = head;

            for (int i = 0; i < index - 1; i++)
                current = current!.Next;

            current!.Next = current.Next!.Next;

            if (current.Next == null)
                tail = current;

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

        public void Add(T item) => AddTail(item);

        public bool Remove(T item)
        {
            if (head == null)
                return false;

            if (head.Data!.Equals(item))
            {
                RemoveHead();
                return true;
            }

            Node? current = head;

            while (current!.Next != null && !current.Next.Data!.Equals(item))
                current = current.Next;

            if (current.Next == null)
                return false;

            current.Next = current.Next.Next;

            if (current.Next == null)
                tail = current;

            Count--;
            return true;
        }

        public void Clear()
        {
            head = tail = null;
            Count = 0;
        }

        /// <summary>
        /// Copies the list items into an array starting at the given index.
        /// </summary>
        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            if (arrayIndex < 0)
                throw new ArgumentOutOfRangeException(nameof(arrayIndex));

            if (array.Length - arrayIndex < Count)
                throw new ArgumentException("The target array is too small.");

            Node? current = head;
            int i = arrayIndex;

            while (current != null)
            {
                array[i++] = current.Data;
                current = current.Next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node? current = head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
