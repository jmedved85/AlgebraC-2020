using System;

namespace _5._3._1_Neparni_do_20
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ispis svih neparnih brojeva većih od 1, a manjih ili jednakih 20:");
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write("{0} ", i.ToString());
                }
            }
            //Drugi način
            Console.ReadKey();
            Console.WriteLine("Ispis svih neparnih brojeva većih od 1, a manjih ili jednakih 20 (drugi način):");
            for (int i = 1; i <= 20; i+=2)
            {
                Console.Write("{0} ", i.ToString());

            }
            Console.ReadKey();
        }              
    }
    // Jasmin Medved
}
