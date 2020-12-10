using System;

namespace _7._3_Kvadrat
{
    class Program
    {
        // Program koji računa kvadrat proslijeđenog broja
        static void Main()
        {
            Console.Write("Unesite broj: ");
            double broj = double.Parse(Console.ReadLine());
            Console.Write("{0} na kvadrat je {1}.", broj, Kvadrat(broj));
            Console.ReadKey();
        }

        private static double Kvadrat(double broj)
        {
            return broj * broj;
        }
    }
}
