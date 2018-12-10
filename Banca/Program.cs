using System;
using System.Collections.Generic;

namespace Banca
{
    class Program
    {
        public delegate void Delegato(decimal importo);

        static void Main(string[] args)
        {
            List<Conto> Banca = new List<Conto>();

            Banca.Add(new ContoIta(1));
            Banca.Add(new ContoIta(2));
            Banca.Add(new ContoIta(3));
            Banca.Add(new ContoIta(4));
            Banca.Add(new ContoIta(5));
            Banca.Add(new ContoCayman(6));
            Banca.Add(new ContoCayman(7));
            Banca.Add(new ContoCayman(8));
            Banca.Add(new ContoCayman(9));
            Banca.Add(new ContoCayman(10));
            Banca.Add(new ContoPremium(11));
            Banca.Add(new ContoPremium(12));
            Banca.Add(new ContoPremium(13));
            Banca.Add(new ContoPremium(14));
            Banca.Add(new ContoPremium(15));

            foreach (Conto Conto in Banca)
            {
                Conto.Versa(100);
            }

            Banca[0].Bonifica(5, Banca[1]);
            Banca[0].Bonifica(5, Banca[5]);
            Banca[0].Bonifica(5, Banca[10]);
            Banca[11].Bonifica(5, Banca[2]);

            Banca[0].Ritira(100);

            foreach (Conto Conto in Banca)
            {
                Console.WriteLine(Conto.ToString());
            }

            ContoIta Pippo = new ContoIta(99);
            Console.WriteLine(Pippo.ToString());

            if (Banca[5].Equals(Banca[6]))
                Console.WriteLine("Il conto è lo stesso.");
            else Console.WriteLine("I conti sono diversi.");

            if (Banca[5].Equals(Banca[5]))
                Console.WriteLine("Il conto è lo stesso.");
            else Console.WriteLine("I conti sono diversi.");
            
            Delegato Ricchezza = delegate(decimal importo) { Console.WriteLine("Regalati " + importo + " soldi a tutti!!!!!"); };
            
            foreach (Conto Conto in Banca)
            {
                Ricchezza += Conto.Versa;
            }

            Ricchezza(100);
            
            foreach (Conto Conto in Banca)
            {
                Console.WriteLine(Conto.ToString());
            }

            Ricchezza(10);
        }
    }
}
