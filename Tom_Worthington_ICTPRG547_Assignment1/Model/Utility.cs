using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Tom_Worthington_ICTPRG547_Assignment1.Model
{
    public static class Utility
    {
        // linear search through an array to find a target value
        public static int LinearSearchArray<T>(T[] array, T target) where T : IComparable<T>
        {
            // loops through each item in the array
            for (int i = 0; i < array.Length; i++)
            {
                // checks if the current item matches the target
                if (array[i].CompareTo(target) == 0)
                {
                    return i;
                }
            }

            // item not found
            return -1;
        }

        // binary search through a sorted array
        public static int BinarySearchArray<T>(T[] array, T target) where T : IComparable<T>
        {
            int low = 0;
            int high = array.Length - 1;

            // continues to search while the range is valid
            while (low <= high)
            {
                int mid = (low + high) / 2;
                int compare = array[mid].CompareTo(target);

                // middle item matches the target
                if (compare == 0)
                {
                    return mid;
                }
                // target is larger, search right
                else if (compare < 0)
                {
                    low = mid + 1;
                }
                // target is smaller, search left
                else
                {
                    high = mid - 1;
                }
            }

            // item not found
            return -1;
        }

        // sorts an array in ascending order using insertion sort
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

        // sorts an array in descending order using insertion sort
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
