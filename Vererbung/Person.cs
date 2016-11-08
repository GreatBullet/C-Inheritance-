using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    public class Person : Lebewesen
    {
        public Person(string name, string nachname)
        {
            Name = name;
            Nachname = nachname;
            Energie = 100;
        }

            public string Nachname { get; set; }
    
    }
        
}

