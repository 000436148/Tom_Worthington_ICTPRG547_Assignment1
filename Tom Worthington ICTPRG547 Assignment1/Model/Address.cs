using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tom_Worthington_ICTPRG547_Assignment1.Model
{
    public class Address
    {
        // default values
        private const int DEFAULT_STREETNUM = 0;
        private const string DEFAULT_STREETNAME = "";
        private const string DEFAULT_SUBURB = "";
        private const string DEFAULT_POSTCODE = "";
        private const string DEFAULT_STATE = "";

        // address properties
        public int StreetNum { get; set; }
        public string StreetName { get; set; }
        public string Suburb { get; set; }
        public string Postcode { get; set; }
        public string State { get; set; }

        // no‑arg constructor
        public Address() : this(DEFAULT_STREETNUM, DEFAULT_STREETNAME, DEFAULT_SUBURB, DEFAULT_POSTCODE, DEFAULT_STATE) { }

        // full constructor
        public Address(int streetNum, string streetName, string suburb, string postcode, string state)
        {
            StreetNum = streetNum;
            StreetName = streetName;
            Suburb = suburb;
            Postcode = postcode;
            State = state;
        }

        // display address details
        public override string ToString()
        {
            return $"{StreetNum} {StreetName}, {Suburb}, {Postcode}, {State}";
        }
    }
}