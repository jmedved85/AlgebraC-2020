using System;

namespace _5._3._9_Djeljitelji
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Svi djeljitelji");
            Console.Write("Unesi prirodan broj: ");
            int broj = 0;
            int brojac = 0;
            broj = int.Parse(Console.ReadLine());
            for (int i = 1; i <= broj; i++)
            {
                if (broj % i == 0)
                {
                    Console.WriteLine("{0} ", i.ToString());
                    brojac++;
                }
            }
            Console.WriteLine("Djeljitelja je {0}", brojac);
        }
    }
}
