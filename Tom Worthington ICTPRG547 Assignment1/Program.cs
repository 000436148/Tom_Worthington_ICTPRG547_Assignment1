using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tom_Worthington_ICTPRG547_Assignment1.Model;

namespace Tom_Worthington_ICTPRG547_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            // heading for test output
            Console.WriteLine("Testing Student Class\n");

            // create sample students for testing
            Student s1 = new Student(1234, "IT", DateTime.Now, "John Smith", "john.smith@example.com", "0412345678");
            Student s2 = new Student(1234, "IT", DateTime.Now, "John Smith", "john.smith@example.com", "0412345678");
            Student s3 = new Student(5678, "Business", DateTime.Now, "Jane Doe", "jane.doe@example.com", "0498765432");

            // test no‑arg constructor
            Student empty = new Student();
            Console.WriteLine("empty: " + empty);

            // display student details
            Console.WriteLine("s1: " + s1);
            Console.WriteLine("s2: " + s2);
            Console.WriteLine("s3: " + s3);

            // test Equals method
            Console.WriteLine("\nTesting Equals():");
            Console.WriteLine(s1.Equals(s2));
            Console.WriteLine(s1.Equals(s3));

            // test == operator
            Console.WriteLine("\nTesting == operator:");
            Console.WriteLine(s1 == s2);
            Console.WriteLine(s1 == s3);

            // test != operator
            Console.WriteLine("\nTesting != operator:");
            Console.WriteLine(s1 != s2);
            Console.WriteLine(s1 != s3);

            // test CompareTo
            Console.WriteLine("\nTesting CompareTo():");
            Console.WriteLine(s1.CompareTo(s2));
            Console.WriteLine(s1.CompareTo(s3));
            Console.WriteLine(s3.CompareTo(s1));

            // test hash codes
            Console.WriteLine("\nTesting GetHashCode():");
            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());
            Console.WriteLine(s3.GetHashCode());

            // pause console
            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}