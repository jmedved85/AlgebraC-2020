using System;

namespace _5._3._4_Faktorijel
{
    class Program
    {
        static void Main()
        {
            Console.Write("Unesite prirodan broj: ");
            int x = int.Parse(Console.ReadLine());
            long faktorijel = 1;
            for (int i = 1; i <= x; i++)
            {
                faktorijel *= i;
            }
            Console.WriteLine("{0}! = {1}", x, faktorijel);Console.ReadKey();
        
        }
    }
}
