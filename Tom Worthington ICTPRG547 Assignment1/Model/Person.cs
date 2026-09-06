using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tom_Worthington_ICTPRG547_Assignment1.Model
{
    public class Person
    {
        // default values
        private const string DEFAULT_NAME = "";
        private const string DEFAULT_EMAIL = "";
        private const string DEFAULT_PHONE = "";

        // person properties
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Address Address { get; set; }

        // no‑arg constructor
        public Person() : this(DEFAULT_NAME, DEFAULT_EMAIL, DEFAULT_PHONE, new Address()) { }

        // full constructor
        public Person(string name, string email, string phoneNumber, Address address)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        // display person details
        public override string ToString()
        {
            return $"{Name}, {Email}, {PhoneNumber} {Address}";
        }
    }
}