using System;

namespace _5._3._3_Suma_100_brojeva
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Suma prvih 100 prirodnih brojeva:");
            int sumaBrojeva = 0;
            for (int i = 0; i < 100; i++)
            {
                sumaBrojeva += i;
            }
            Console.Write(sumaBrojeva);
        }
    }
    // JASMIN MEDVED
}
