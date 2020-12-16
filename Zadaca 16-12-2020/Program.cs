using System;
using System.Collections.Generic;

namespace Zadaca_16_12_2020
{
    class Program
    {
     
        static void Main()
        {
            Console.WriteLine("RECEPT");
            Kolac K1 = new Kolac();
            Console.WriteLine();
            Console.WriteLine("Unesite ime kolača:");
            K1.Ime = Console.ReadLine();
            char ponovo = 'd';
            while (ponovo == 'D' || ponovo == 'd')
            {
                Console.WriteLine("Unesite sastojak:");
                K1.Sastojak = Console.ReadLine();
                Console.WriteLine("Unesite količinu (u g):");
                K1.Kolicina = float.Parse(Console.ReadLine());
                Console.WriteLine("Želite li dodati još (D/N)?");
                ponovo = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
            Console.WriteLine("\nKolač {0} je pečen!", K1.Ime);
            Console.WriteLine("Ispis sastojaka i količine:");
            foreach (var item in Kolac.DodajSastojak)
            {
                Console.WriteLine(item);
            }
            foreach (var item in Kolac.DodajKolicinu)
            {
                Console.WriteLine(item);
            }
        
        }
    }
}
