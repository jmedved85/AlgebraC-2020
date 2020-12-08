using System;

namespace _6._1._3_Zamjena_mjesta
{
    class Program
    {
        /* Program traži unos 5 brojeva (elemenata niza) i zatim ih ispisuje,
           ali  najvećem i najmanjem treba zamjeniti mjesta */
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi 5 brojeva: ");
            int[] niz = new int[5];
            
            int maxBroj = int.MinValue;
            int minBroj = int.MaxValue;

            int maxPoz = 0;
            int minPoz = 0;

            for (int i = 0; i < niz.Length; i++)
            {
                niz[i] = int.Parse(Console.ReadLine());
                if (niz[i] >= maxBroj)
                {
                    maxBroj = niz[i];
                    maxPoz = i;
                }
                if (niz[i] <= minBroj)
                {
                    minBroj = niz[i];
                    minPoz = i;
                }
            }

            int temp = niz[minPoz];
            niz[minPoz] = niz[maxPoz];
            niz[maxPoz] = temp;
            Console.WriteLine("Ispis:");

            for (int i = 0; i < niz.Length; i++)
            {
                if (i == minPoz || i == maxPoz)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                Console.WriteLine(niz[i]);
                Console.ResetColor();
            }
            Console.ReadKey();
        }
    }
}
