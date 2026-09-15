using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Tom_Worthington_ICTPRG547_Assignment1.Model;

namespace Tom_Worthington_ICTPRG547_Assignment1.Tests
{
    [TestFixture]
    public class UtilityTests
    {
        // tests linear search when the item exists
        [Test]
        public void LinearSearch_FindsItem()
        {
            int[] numbers = { 1, 3, 5, 7, 9 };
            int result = Utility.LinearSearchArray(numbers, 5);
            Assert.AreEqual(2, result);
        }

        // tests linear search when the item does not exist
        [Test]
        public void LinearSearch_ItemNotFound()
        {
            int[] numbers = { 1, 3, 5, 7, 9 };
            int result = Utility.LinearSearchArray(numbers, 10);
            Assert.AreEqual(-1, result);
        }

        // tests binary search when the item exists
        [Test]
        public void BinarySearch_FindsItem()
        {
            int[] numbers = { 2, 4, 6, 8, 10 };
            int result = Utility.BinarySearchArray(numbers, 8);
            Assert.AreEqual(3, result);
        }

        // tests binary search when the item does not exist
        [Test]
        public void BinarySearch_ItemNotFound()
        {
            int[] numbers = { 2, 4, 6, 8, 10 };
            int result = Utility.BinarySearchArray(numbers, 7);
            Assert.AreEqual(-1, result);
        }

        // tests ascending sort
        [Test]
        public void SortAscending_WorksCorrectly()
        {
            int[] numbers = { 5, 2, 9, 1, 7 };
            Utility.SortAscending(numbers);
            int[] expected = { 1, 2, 5, 7, 9 };
            Assert.AreEqual(expected, numbers);
        }

        // tests descending sort
        [Test]
        public void SortDescending_WorksCorrectly()
        {
            int[] numbers = { 5, 2, 9, 1, 7 };
            Utility.SortDescending(numbers);
            int[] expected = { 9, 7, 5, 2, 1 };
            Assert.AreEqual(expected, numbers);
        }
    }
}
