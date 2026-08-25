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
        public Student() : this(DEFAULT_ID, DEFAULT_PROGRAM, DEFAULT_DATE, "", "", "") { }

        // full constructor
        public Student(int studentID, string program, DateTime dateRegistered,
                       string name, string email, string phoneNumber)
            : base(name, email, phoneNumber)
        {
            StudentID = studentID;
            Program = program;
            DateRegistered = dateRegistered;
        }

        // id‑only constructor
        public Student(int studentID) : this(studentID, DEFAULT_PROGRAM, DEFAULT_DATE, "", "", "") { }

        // compare students by id
        public int CompareTo(Student other)
        {
            if (other == null) return 1;
            return StudentID.CompareTo(other.StudentID);
        }

        // check equality by id
        public override bool Equals(object obj)
        {
            if (obj is Student other)
            {
                return this.StudentID == other.StudentID;
            }
            return false;
        }

        // generate hash code from id
        public override int GetHashCode()
        {
            return StudentID.GetHashCode();
        }

        // == operator using id
        public static bool operator ==(Student a, Student b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (a is null || b is null) return false;
            return a.StudentID == b.StudentID;
        }

        // != operator using id
        public static bool operator !=(Student a, Student b)
        {
            return !(a == b);
        }

        // display student details
        public override string ToString()
        {
            return $"ID: {StudentID}, Program: {Program}, Registered: {DateRegistered}, {base.ToString()}";
        }
    }
}