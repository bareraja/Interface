using System;
using System.Collections.Generic;

namespace Interface
{
    class Program 
    {
        static void Main(string[] args)
        {
            List<IId> s = new List<IId>();

            s.Add(new Person("110594-1286", "Svend"));
            s.Add(new Person("010794-2629", "Pia"));

            s.Add(new Maskine("NightRider", "Foldemaskine"));
            s.Add(new Maskine("Razerblade", "Klippemaskine"));

            foreach (IId item in s)

                Console.WriteLine(item.Id());

            
        }
    }
}
