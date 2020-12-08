using System;

namespace _6._1._2_Max
{
    class Program
    {
        static void Main(string[] args)
        // Program traži unos 5 brojeva, a zatim ih ispisuje, s time da najveći ispisuje crvenom bojom
        {
            int [] niz = new int [5];
            int maxBroj = int.MinValue;
            int minBroj = int.MaxValue;
            Console.WriteLine("Unesite 5 brojeva:");
            for (int i = 0; i < niz.Length; i++)
            {
                niz [i] = int.Parse(Console.ReadLine());
                if (niz [i] >= maxBroj)
                {
                    maxBroj = niz[i];
                }
                if (niz [i] <= minBroj)
                {
                    minBroj = niz[i];
                }
            }

            for (int i = 0; i < niz.Length; i++)
            {
                if (maxBroj == niz[i])
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(niz[i] + " ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else if (minBroj == niz[i])
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(niz[i] + " ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.Write(niz[i] + " ");
                }

            }
        }
    }
}
