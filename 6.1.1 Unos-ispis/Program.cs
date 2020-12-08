using System;

namespace _6._1._1_Unos_ispis
{
    class Program
    {
        static void Main(string[] args)
        {
            // NIZOVI (ARRAYS)
            // Program koji traži unos 10 prirodnih brojeva i zatim ih ispisuje.
            Console.WriteLine("Unesite 10 brojeva:");
            int[] niz = new int[10];

            for (int i = 0; i < niz.Length; i++)
            {
                Console.Write("Unesi {0}. broj. ", i+1);
                niz[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            Console.WriteLine("Unešeni brojevi su:");
            foreach (var item in niz)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("{0} ", item);
                Console.WriteLine();
            }

            // Zbrajanje unešenih brojeva
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Zbroj brojeva je: ");
            int sum = 0;
            foreach (var item in niz)
            {
                sum += item;
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(sum);
        }
    }
}
