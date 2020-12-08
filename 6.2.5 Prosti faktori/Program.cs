using System;
using System.Collections;

namespace _6._2._5_Prosti_faktori
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Program traži unos prirodnog broja, a zatim 
             * ispisuje rastav broja na proste faktore.*/

            int broj = 0;
            int faktor = 2;
            ArrayList arr = new ArrayList();
            Console.Write("Unesite prirodan broj:");
            broj = int.Parse(Console.ReadLine());
            Console.Write("{0} = ", broj);
            while (faktor <= broj)
            {
                if (broj%faktor == 0)
                {
                    arr.Add(faktor);
                    broj /= faktor;
                }
                else
                {
                    faktor++;
                }
            }
            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write(arr[i]);
                if (i < arr.Count - 1)
                {
                    Console.Write("*");
                }
            }
            Console.ReadKey();

           

        }
    }
}
