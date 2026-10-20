using NUnit.Framework;
using Tom_Worthington_ICTPRG547_Assignment1.Model;
using Tom_Worthington_ICTPRG547_Assignment1.Model.DataStructures;
using System.Linq;

namespace DataStructureTests
{
    public class BinarySearchTreeTests
    {
        private Student BuildStudent(int id)
        {
            return new Student(id);
        }

        [Test]
        public void InOrder_ReturnsSortedOrder()
        {
            var tree = new BinarySearchTree<Student>();

            int[] ids = { 50, 20, 10, 30, 70, 60, 80 };
            foreach (var id in ids)
                tree.Insert(BuildStudent(id));

            var result = tree.InOrder().Select(s => s.StudentID).ToArray();

            Assert.AreEqual(new[] { 10, 20, 30, 50, 60, 70, 80 }, result);
        }

        [Test]
        public void PreOrder_ReturnsCorrectOrder()
        {
            var tree = new BinarySearchTree<Student>();

            int[] ids = { 50, 20, 10, 30, 70, 60, 80 };
            foreach (var id in ids)
                tree.Insert(BuildStudent(id));

            var result = tree.PreOrder().Select(s => s.StudentID).ToArray();

            Assert.AreEqual(new[] { 50, 20, 10, 30, 70, 60, 80 }, result);
        }

        [Test]
        public void PostOrder_ReturnsCorrectOrder()
        {
            var tree = new BinarySearchTree<Student>();

            int[] ids = { 50, 20, 10, 30, 70, 60, 80 };
            foreach (var id in ids)
                tree.Insert(BuildStudent(id));

            var result = tree.PostOrder().Select(s => s.StudentID).ToArray();

            Assert.AreEqual(new[] { 10, 30, 20, 60, 80, 70, 50 }, result);
        }
    }
}
