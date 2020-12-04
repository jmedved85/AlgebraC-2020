using System;

namespace _5._3._5_Djeljivi_s_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Svi prirodni brojevi iz intervala [1, 100] koji su dijeljivi s brojem 3:");
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("{0} ", i.ToString());
                }
            }
            Console.ReadKey();
        }
    }
    // JASMIN MEDVED
}
