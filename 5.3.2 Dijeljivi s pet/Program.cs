using System;

namespace _5._3._2_Dijeljivi_s_pet
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Svi brojevi od 1 do 100 dijeljivi s 5:");
            for (int i = 1; i < 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write("{0} ", i.ToString());
                }
            }
            Console.ReadKey();
        }
    }
    // JASMIN MEDVED
}
