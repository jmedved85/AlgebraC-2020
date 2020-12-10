using System;

namespace Primjer_8._1._3_Osoba
{
    class Program
    {
        static void Main()
        {
            Osoba osoba = new Osoba();
            Console.Write("Ime: ");
            osoba.Ime = Console.ReadLine();
            Console.Write("Prezime: ");
            osoba.Prezime = Console.ReadLine();
            Console.Write("Starost: ");
            try
            {
                osoba.Starost = int.Parse(Console.ReadLine());
                Console.WriteLine("Unos je ispravan.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greška: " + ex.Message);
            }
            Console.ReadKey(); 
        }
    }
}
