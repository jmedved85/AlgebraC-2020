using System;
using System.Collections;

namespace _6._2._4_Znamenke
{
    class Program
    {
        /* Program traži unos prirodnog broja, a zatim znamenke
         * upisanog broja ispisuje naopako.*/
        static void Main(string[] args)
        {
            int broj = int.Parse(Console.ReadLine());
            ArrayList arr = new ArrayList();
            while (broj > 0)
            {
                arr.Add(broj % 10);
                broj /= 10;
            }
            Console.WriteLine("Ispis znamenki naopako:");
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
