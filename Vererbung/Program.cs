using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    class Program
    {
        static void Main(string[] args)
        {
            Person PO = new Person("Rick", "Armbruster");
            Lebewesen leb = PO;
            Console.WriteLine("name: " + leb.Name);
            Console.ReadKey();

        }
    }
}
