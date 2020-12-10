using System;

namespace _7._2._3_Pozivanje_parametara
{
    class Program
    {
        static void Main()
        {
            Pozdrav("Marko", true); // Klasično pozivanje metode
            Pozdrav(pPozdrav: false, ime: "Marko"); // Pozivanje metode drugačijim redosljedom parametara
            Console.ReadKey();
        }

        private static void Pozdrav(string ime, bool pPozdrav)
        {
            if (pPozdrav)
            {
                Console.Write("Dobar dan ");
            }
            else
            {
                Console.Write("Bok ");
            }
            Console.WriteLine(ime + "!");
        }
    }
}
