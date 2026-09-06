using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tom_Worthington_ICTPRG547_Assignment1.Model
{
    public class Student : Person, IComparable<Student>
    {
        // default values
        private const int DEFAULT_ID = 0;
        private const string DEFAULT_PROGRAM = "";
        private static readonly DateTime DEFAULT_DATE = DateTime.MinValue;

        // student properties
        public int StudentID { get; set; }
        public string Program { get; set; }
        public DateTime DateRegistered { get; set; }

        // no‑arg constructor
        public Student() : this(DEFAULT_ID, DEFAULT_PROGRAM, DEFAULT_DATE, "", "", "", new Address()) { }

        // full constructor
        public Student(int studentID, string program, DateTime dateRegistered, string name, string email, string phoneNumber, Address address) : base(name, email, phoneNumber, address)
        {
            StudentID = studentID;
            Program = program;
            DateRegistered = dateRegistered;
        }

        // id‑only constructor
        public Student(int studentID) : this(studentID, DEFAULT_PROGRAM, DEFAULT_DATE, "", "", "", new Address()) { }

        /// <summary>
        /// compares two Students by StudentID
        /// </summary>
        /// <param name="other">the Student to compare with this Student</param>
        /// <returns>negative when less, zero when equal, positive when greater</returns>
        public int CompareTo(Student other)
        {
            if (other == null) return 1;
            return StudentID.CompareTo(other.StudentID);
        }

        /// <summary>
        /// compares this Student to another object by StudentID
        /// </summary>
        /// <param name="obj">the object to compare with this Student</param>
        /// <returns>true when StudentID values match</returns>
        public override bool Equals(object obj)
        {
            // check null
            if (obj is null)
                return false;

            // check reference
            if (ReferenceEquals(this, obj))
                return true;

            // check type
            if (obj.GetType() != GetType())
                return false;

            // compare value
            Student other = (Student)obj;
            return StudentID == other.StudentID;
        }

        /// <summary>
        /// returns hash based on StudentID
        /// </summary>
        /// <returns>hash code for this Student</returns>
        public override int GetHashCode()
        {
            return StudentID.GetHashCode();
        }

        /// <summary>
        /// compares two Students for equality by StudentID
        /// </summary>
        /// <param name="a">first Student</param>
        /// <param name="b">second Student</param>
        /// <returns>true when StudentID values match</returns>
        public static bool operator ==(Student a, Student b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (a is null || b is null) return false;
            return a.StudentID == b.StudentID;
        }

        /// <summary>
        /// compares two Students for inequality by StudentID
        /// </summary>
        /// <param name="a">first Student</param>
        /// <param name="b">second Student</param>
        /// <returns>true when StudentID values differ</returns>
        public static bool operator !=(Student a, Student b)
        {
            return !(a == b);
        }

        // display student details
        public override string ToString()
        {
            return $"ID: {StudentID}, Program: {Program}, Registered: {DateRegistered}, Address: {Address}, {base.ToString()}";
        }
    }
}