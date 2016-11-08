using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    public class Lebewesen
    {
        
        public string Name { get; protected set; }
        public int Alter { get; protected set; }
        public bool HatHunger { get; protected set; }
        public int Energie { get;  set; }

        public void Laufe(int strecke)
        {
            if (strecke > Energie)
            {
                Console.WriteLine("Person kann nicht laufen, hat Hunger...");
                return;
            }

            Console.WriteLine("person läuft" + strecke + " km");
            Energie = Energie - strecke;
        }
    }
}
