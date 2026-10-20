using NUnit.Framework;
using Tom_Worthington_ICTPRG547_Assignment1.Model;
using Tom_Worthington_ICTPRG547_Assignment1.Model.DataStructures;

namespace DataStructureTests
{
    public class SinglyLinkedListTests
    {
        private Student BuildStudent(int id)
        {
            return new Student(id);
        }

        [Test]
        public void AddHead_AddsStudentAtHead()
        {
            var list = new SinglyLinkedList<Student>();
            var s1 = BuildStudent(1);
            var s2 = BuildStudent(2);

            list.AddTail(s1);
            list.AddHead(s2);

            var result = list.GetEnumerator();
            result.MoveNext();
            Assert.AreEqual(s2.StudentID, result.Current.StudentID);
        }

        [Test]
        public void AddTail_AddsStudentAtTail()
        {
            var list = new SinglyLinkedList<Student>();
            var s1 = BuildStudent(1);
            var s2 = BuildStudent(2);

            list.AddHead(s1);
            list.AddTail(s2);

            Student last = null;
            foreach (var s in list)
                last = s;

            Assert.AreEqual(s2.StudentID, last.StudentID);
        }

        [Test]
        public void Contains_FindsExistingStudent()
        {
            var list = new SinglyLinkedList<Student>();
            var s1 = BuildStudent(1);
            var s2 = BuildStudent(2);

            list.AddTail(s1);
            list.AddTail(s2);

            Assert.IsTrue(list.Contains(s2));
        }

        [Test]
        public void RemoveHead_RemovesFirstStudent()
        {
            var list = new SinglyLinkedList<Student>();
            var s1 = BuildStudent(1);
            var s2 = BuildStudent(2);

            list.AddTail(s1);
            list.AddTail(s2);

            list.RemoveHead();

            var result = list.GetEnumerator();
            result.MoveNext();
            Assert.AreEqual(s2.StudentID, result.Current.StudentID);
        }

        [Test]
        public void RemoveTail_RemovesLastStudent()
        {
            var list = new SinglyLinkedList<Student>();
            var s1 = BuildStudent(1);
            var s2 = BuildStudent(2);

            list.AddTail(s1);
            list.AddTail(s2);

            list.RemoveTail();

            Student last = null;
            foreach (var s in list)
                last = s;

            Assert.AreEqual(s1.StudentID, last.StudentID);
        }
    }
}
