using System;
using System.Collections.Generic;

namespace _6._2._2_Par_Nepar_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Program koji traži unos 10 prirodnih brojeva i parne i
             * neparne brojeve sprema odvojeno, u dva objekta klase
             * List<int> i zatim ispisuje te dvije kolekcije brojeva.*/

            List<int> listabrojeva = new List<int>();
            List<int> parni = new List<int>();
            List<int> neparni = new List<int>();
            int broj = 0;

            Console.WriteLine("Unesi 10 prirodnih brojeva:");
            for (int i = 0; i < 10; i++)
            {
                broj = int.Parse(Console.ReadLine());
                listabrojeva.Add(broj);
            }

            Console.WriteLine("Upisani brojevi su:");
            foreach (var item in listabrojeva)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            foreach (var item in listabrojeva)
            {
                if (item % 2 == 0)
                {
                    parni.Add(item);
                }
                else
                {
                    neparni.Add(item);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Unešeni parni brojevi:");
            foreach (var item in parni)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Unešeni neparni  brojevi:");
            foreach (var item in neparni)
            {
                Console.Write(item + ", ");
            }
           
        }
    }
}
