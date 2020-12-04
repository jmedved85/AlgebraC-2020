using System;

namespace _5._3._7_Koliko
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Koliko ima brojeva iz intervala [1, 1000] dijeljivih sa 7 i nedjeljivih s 3)");
            int brojac = 0;
            for (int i = 1; i < 1000; i++)
            {
                if ((i%7==0) && !(i % 3 == 0))
                {
                    Console.Write("{0} ", i);
                    brojac++;
                }
            }
            Console.WriteLine("\nBrojeva ima {0}", brojac);
        }
    }
    // JASMIN MEDVED
}
