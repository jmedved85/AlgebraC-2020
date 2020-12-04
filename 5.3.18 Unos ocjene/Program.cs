using System;

namespace _5._3._18_Unos_ocjene
{
    class Program
    {
        static void Main()
        {
            string ocjena = "";
            bool unosObavljen = false;
            while (!unosObavljen)
            {
                Console.Write("Unesite ocjenu: ");
                ocjena = Console.ReadLine();
                if (ocjena=="1" || ocjena=="2" || ocjena=="3" || ocjena =="4" || ocjena == "5")
                {
                    unosObavljen = true;
                }
                else
                {
                    Console.WriteLine("Pogrešan unos!");
                }
            }
            Console.WriteLine("Ocjena je ispravno unešena."); Console.ReadKey();
        }
    }
}
