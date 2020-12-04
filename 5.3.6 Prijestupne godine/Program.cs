using System;

namespace _5._3._6_Prijestupne_godine
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Sve prijestupne godine od 1900. do 2020.:");
            for (int i = 1900; i <= 2020; i++)
            {
                if (((i%4==0) && !(i%100==0)) || (i % 400 == 0))
                {
                    Console.Write("{0} ", i.ToString());
                }
            }
            Console.ReadKey();
        }
    }
    // JASMIN MEDVED
}
