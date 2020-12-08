using System;
using System.Collections.Generic;

namespace _6._2._3_Sort
{
    class Program
    {
        /* Program traži unos prirodnih brojeva dok se ne unese 0
         * i zatim ispisuje unesene brojeve poredane prema 
         * veličini pomoću petlje "foreach" */
        static void Main(string[] args)
        {
            List<int> listabrojeva = new List<int>();
            int broj = int.MaxValue;

            Console.WriteLine("Unesi brojeve (za izlaz unesi \'0\')");
            while (broj != 0)
            {
                broj = int.Parse(Console.ReadLine());
                listabrojeva.Add(broj);
            }

            Console.WriteLine("Sortirani brojevi:");
            listabrojeva.Sort();
            foreach (var item in listabrojeva)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(item + " ");
                Console.ResetColor();
            }

            Console.WriteLine();
            listabrojeva.Reverse();
            foreach (var item in listabrojeva)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(item + " ");
                Console.ResetColor();
            }

            Console.ReadKey();            
        }
    }
}
