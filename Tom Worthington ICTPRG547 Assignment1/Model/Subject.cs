using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tom_Worthington_ICTPRG547_Assignment1.Model
{
    public class Subject
    {
        // default values
        private const string DEFAULT_CODE = "";
        private const string DEFAULT_NAME = "";
        private const decimal DEFAULT_COST = 0m;

        // subject properties
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public decimal Cost { get; set; }

        // no‑arg constructor
        public Subject() : this(DEFAULT_CODE, DEFAULT_NAME, DEFAULT_COST) { }

        // full constructor
        public Subject(string subjectCode, string subjectName, decimal cost)
        {
            SubjectCode = subjectCode;
            SubjectName = subjectName;
            Cost = cost;
        }

        // display subject details
        public override string ToString()
        {
            return $"{SubjectCode}, {SubjectName}, ${Cost}";
        }
    }
}