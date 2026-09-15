using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tom_Worthington_ICTPRG547_Assignment1.Model
{
    public class Enrollment
    {
        // default values
        private static readonly DateTime DEFAULT_DATE = DateTime.MinValue;
        private const string DEFAULT_GRADE = "Unknown Grade";
        private const string DEFAULT_SEMESTER = "Unknown Semester";
        private static readonly Subject DEFAULT_SUBJECT = new Subject();

        // enrollment properties
        public DateTime DateEnrolled { get; set; }
        public string Grade { get; set; }
        public string Semester { get; set; }
        public Subject Subject { get; set; }

        // no‑arg constructor
        public Enrollment() : this(DEFAULT_DATE, DEFAULT_GRADE, DEFAULT_SEMESTER, null) { }

        // full constructor
        public Enrollment(DateTime dateEnrolled, string grade, string semester, Subject subject)
        {
            DateEnrolled = dateEnrolled;
            Grade = grade;
            Semester = semester;
            Subject = subject;
        }

        // display enrollment details
        public override string ToString()
        {
            return $"{DateEnrolled}, {Grade}, {Semester}, {Subject}";
        }
    }
}