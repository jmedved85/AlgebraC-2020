using System;

namespace _01_domaci_zadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.1.2 - Ispis brojeva
            //Napišite program koji na konzoli ispisuje
            //brojeve 1,2,3 svaki u novi red.
            Console.WriteLine(1);
            Console.WriteLine(2);
            Console.WriteLine(3);
            Console.WriteLine("Pritisnite \"ENTER\" za dalje");
            Console.WriteLine();
            Console.ReadKey();

            //4.1.3 - Ledište/Vrelište
            //Napišite program koji će ispisivati temperaturu ledišta i vrelišta
            //vode, svaku u novi red
            int lediste = 0, vreliste = 100;
            Console.WriteLine("Temperatura ledišta vode je: " + lediste +"°C");
            Console.WriteLine("Temperatura vrelišta vode je: " + vreliste +"°C");
            Console.WriteLine("Pritisnite \"ENTER\" za dalje");
            Console.WriteLine();
            Console.ReadKey();

            //5.1.1 - Zbroj i razlika
            //Program koji traži unos 2 cijela broja i prikazuje
            //na ekranu njihov zbroj te razliku
            int prvi_broj = 0;
            int drugi_broj = 0;
            Console.Write("Molimo unesite prvi broj: ");
            prvi_broj = int.Parse(Console.ReadLine());
            Console.Write("Molimo unesite drugi broj: ");
            drugi_broj = int.Parse(Console.ReadLine());
            Console.WriteLine("Zbroj je: {0}", prvi_broj + drugi_broj);
            Console.WriteLine("Razlika je: {0}", prvi_broj - drugi_broj);
            Console.WriteLine("Pritisnite \"ENTER\" za dalje");
            Console.WriteLine();
            Console.ReadKey();

            //5.1.2 - Umnožak i kvocijent
            //Program koji traži unos 2 cijela broja i prikazuje 
            //umnožak i kvocijent
            Console.Write("Molimo unesite prvi broj: ");
            prvi_broj = int.Parse(Console.ReadLine());
            Console.Write("Molimo unesite drugi broj: ");
            drugi_broj = int.Parse(Console.ReadLine());
            Console.WriteLine("Umnozak je: {0}", prvi_broj * drugi_broj);
            Console.WriteLine("Kvocijent je: {0}", (float)prvi_broj / (float)drugi_broj);
            Console.WriteLine("Pritisnite \"ENTER\" za kraj");
            Console.ReadKey();
        }
    }
}
