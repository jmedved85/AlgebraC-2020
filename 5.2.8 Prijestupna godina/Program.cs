using System;

namespace _5._2._8_Prijestupna_godina
{
    class Program
    {
        static void Main()
        {
            int godina = 0;
            try
            {
                Console.Write("Unesite godinu: ");
                godina = int.Parse(Console.ReadLine());
            }
            catch 
            {
                Console.WriteLine("Pogrešan unos.");
                return;
            }
            if (((godina % 4 == 0) && (!(godina % 100 == 0))) || (godina % 400 == 0))
            {
                Console.WriteLine("{0} JEST prijestupna godina.", godina);
            }
            else
            {
                Console.WriteLine("{0} NIJE prijestupna godina.", godina);
            }
            Console.ReadKey();
        }
    }
}
