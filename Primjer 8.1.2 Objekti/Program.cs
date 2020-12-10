using System;

namespace Primjer_8._1._2_Objekti
{
    // Program koji opisuje pojam (klasu) Ucenik
    class Program
    {
        static void Main()
        {
            // Instanciranje novog objekta klase Ucenik
            Ucenik ucenik1 = new Ucenik();
            
            // Inicijalizacija objekta
            Console.Write("Unesite ime učenika: ");
            ucenik1.Ime = Console.ReadLine();
            Console.Write("Unesite prezime učenika: ");
            ucenik1.Prezime = Console.ReadLine();

            Console.Write("Unesite ocjenu iz matematike: ");
            ucenik1.OcjenaIzMatematike = int.Parse(Console.ReadLine());
            Console.Write("Unesite ocjenu iz biologije: ");
            ucenik1.OcjenaIzBiologije = int.Parse(Console.ReadLine());
            Console.Write("Unesite ocjenu iz engleskog: ");
            ucenik1.OcjenaIzEngleskog = int.Parse(Console.ReadLine());

            // Poziv metode objekta
            Console.WriteLine("Prosjek je {0}.", ucenik1.Prosjek());

            //2. objekt instanciran je pomoću 2. konstruktora
            Ucenik ucenik2 = new Ucenik("Marko", "Marković");
            Console.WriteLine(ucenik2.Prezime+" "+ucenik2.Ime);
            Console.ReadKey();
        }
    } 
}
