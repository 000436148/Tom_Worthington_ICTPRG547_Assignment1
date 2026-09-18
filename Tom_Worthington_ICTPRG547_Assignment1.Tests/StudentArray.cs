using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tom_Worthington_ICTPRG547_Assignment1.Model;

namespace Tom_Worthington_ICTPRG547_Assignment1.Tests
{
    public static class StudentArray
    {
        // builds an array of 10 students for testing
        public static Student[] Build()
        {
            // creates and returns the array
            return new Student[]
            {
                new Student(1001, "IT", DateTime.Now, "Alice Brown", "alice@example.com", "0400000001",
                    new Address("1", "Main St", "Adelaide", "5000", "SA"), new Enrollment()),

                new Student(1005, "IT", DateTime.Now, "Bob Smith", "bob@example.com", "0400000002",
                    new Address("2", "King William St", "Adelaide", "5000", "SA"), new Enrollment()),

                new Student(1003, "Business", DateTime.Now, "Charlie Jones", "charlie@example.com", "0400000003",
                    new Address("3", "North Terrace", "Adelaide", "5000", "SA"), new Enrollment()),

                new Student(1009, "IT", DateTime.Now, "Diana Lee", "diana@example.com", "0400000004",
                    new Address("4", "Pirie St", "Adelaide", "5000", "SA"), new Enrollment()),

                new Student(1002, "Business", DateTime.Now, "Evan White", "evan@example.com", "0400000005",
                    new Address("5", "Grenfell St", "Adelaide", "5000", "SA"), new Enrollment()),

                new Student(1010, "IT", DateTime.Now, "Fiona Green", "fiona@example.com", "0400000006",
                    new Address("6", "Hutt St", "Adelaide", "5000", "SA"), new Enrollment()),

                new Student(1007, "IT", DateTime.Now, "George Black", "george@example.com", "0400000007",
                    new Address("7", "Flinders St", "Adelaide", "5000", "SA"), new Enrollment()),

                new Student(1004, "Business", DateTime.Now, "Hannah Grey", "hannah@example.com", "0400000008",
                    new Address("8", "Wakefield St", "Adelaide", "5000", "SA"), new Enrollment()),

                new Student(1006, "IT", DateTime.Now, "Ian Silver", "ian@example.com", "0400000009",
                    new Address("9", "Currie St", "Adelaide", "5000", "SA"), new Enrollment()),

                new Student(1008, "Business", DateTime.Now, "Julia Gold", "julia@example.com", "0400000010",
                    new Address("10", "Franklin St", "Adelaide", "5000", "SA"), new Enrollment())
            };
        }
    }
}