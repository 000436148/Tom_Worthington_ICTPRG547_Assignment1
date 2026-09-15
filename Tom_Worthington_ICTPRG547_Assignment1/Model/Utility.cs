using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tom_Worthington_ICTPRG547_Assignment1.Model
{
    public static class Utility
    {

        // searching ------------------------------------------------------------------

        /// <summary>
        /// linear search through an array to find a target value
        /// </summary>
        /// <typeparam name="T">any type that can be compared</typeparam>
        /// <param name="array">the array to search</param>
        /// <param name="target">the item to find</param>
        /// <returns>the index of the item or -1 if not found</returns>
        /// <remarks>
        /// pseudocode:
        /// for each item in the array
        ///     if item equals target then return index
        /// return -1
        /// </remarks>
        public static int LinearSearchArray<T>(T[] array, T target) where T : IComparable<T>
        {
            // loop through each item in the array
            for (int i = 0; i < array.Length; i++)
            {
                // check if the current item matches the target
                if (array[i].CompareTo(target) == 0)
                {
                    return i;
                }
            }

            // item not found
            return -1;
        }

        /// <summary>
        /// binary search through a sorted array
        /// </summary>
        /// <typeparam name="T">any type that can be compared</typeparam>
        /// <param name="array">the sorted array to search</param>
        /// <param name="target">the item to find</param>
        /// <returns>the index of the item or -1 if not found</returns>
        /// <remarks>
        /// pseudocode:
        /// set low to start of array
        /// set high to end of array
        /// while low is less than or equal to high
        ///     find middle index
        ///     compare middle item with target
        ///     adjust search range
        /// return -1
        /// </remarks>
        public static int BinarySearchArray<T>(T[] array, T target) where T : IComparable<T>
        {
            int low = 0;
            int high = array.Length - 1;

            // continues to search while the range is valid
            while (low <= high)
            {
                int mid = (low + high) / 2;
                int compare = array[mid].CompareTo(target);

                // if the middle item matches the target
                if (compare == 0)
                {
                    return mid;
                }
                // if target is larger, search right
                else if (compare < 0)
                {
                    low = mid + 1;
                }
                // if target is smaller, search left
                else
                {
                    high = mid - 1;
                }
            }

            // item not found
            return -1;
        }

        // sorting ------------------------------------------------------------------

        /// <summary>
        /// sorts an array in ascending order using insertion sort
        /// </summary>
        /// <typeparam name="T">any type that can be compared</typeparam>
        /// <param name="array">the array to sort</param>
        /// <remarks>
        /// pseudocode:
        /// for each item starting from index 1
        ///     store the item as key
        ///     shift larger items to the right
        ///     insert key into correct position
        /// </remarks>
        public static void SortAscending<T>(T[] array) where T : IComparable<T>
        {
            // loops through each item starting from index 1
            for (int i = 1; i < array.Length; i++)
            {
                T key = array[i];
                int j = i - 1;

                // moves items that are greater than key to the right
                while (j >= 0 && array[j].CompareTo(key) > 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                // inserts key into the correct position
                array[j + 1] = key;
            }
        }

        /// <summary>
        /// sorts an array in descending order using insertion sort
        /// </summary>
        /// <typeparam name="T">any type that can be compared</typeparam>
        /// <param name="array">the array to sort</param>
        /// <remarks>
        /// pseudocode:
        /// for each item starting from index 1
        ///     store the item as key
        ///     shift smaller items to the right
        ///     insert key into correct position
        /// </remarks>
        public static void SortDescending<T>(T[] array) where T : IComparable<T>
        {
            // loops through each item starting from index 1
            for (int i = 1; i < array.Length; i++)
            {
                T key = array[i];
                int j = i - 1;

                // moves items that are smaller than key to the right
                while (j >= 0 && array[j].CompareTo(key) < 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                // inserts key into the correct position
                array[j + 1] = key;
            }
        }
    }
}
