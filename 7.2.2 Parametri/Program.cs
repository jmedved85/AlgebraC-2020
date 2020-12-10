using System;

namespace _7._2._2_Parametri
{
    class Program
    {
        static void Main()
        {
            Pozdrav("Pero");
            Pozdrav("Pero", "Perić");
            Console.ReadKey();
        }

        private static void Pozdrav(string ime)
        {
            Console.WriteLine("Dobar dan, " + ime + "!");
        }

        private static void Pozdrav(string ime, string prezime)
        {
            Console.WriteLine("Dobar dan, {0}, {1}!", ime, prezime);
        }
    }
}
