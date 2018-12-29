using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Person : IId
    {
        public string Cprnummer;
        public string Navn;

        public Person(string cprNummer, string navn)
        {
            this.Navn = navn;
            this.Cprnummer = cprNummer;
        }

        public string Id()
        {
            return Navn + " " + Cprnummer;
        }
    }
}
