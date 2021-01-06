using System;
using System.Collections.Generic;
using System.Linq;

namespace DefaultIfEmpty_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Osoba> osobe = new List<Osoba>();
            osobe.Add(new Osoba { Ime = "Marko", Prezime = "Cvek" });
            osobe.Add(new Osoba { Ime = "Jana", Prezime = "Avena" });
            osobe.Add(new Osoba { Ime = "Nana", Prezime = "Dobra" });
            Osoba defaultnaOsoba = new Osoba { Ime = "Jane", Prezime = "Doe" };

            var osobe_na = (
            from tr_os      // postavimo ime varijable za svaki element kolekcije
            in osobe // kolekcija iz koje radimo pretragu
            where tr_os.Ime.Contains("gu")  // filter
            select tr_os.Prezime   // selektiramo kompletan element
            ).ToList().DefaultIfEmpty($"Defaultna osoba: {defaultnaOsoba.Ime} {defaultnaOsoba.Prezime}!"); // Dodao sam metodu DefaultIfEmpty() nakon metode ToList()

            foreach (var item in osobe_na)
            {
                Console.WriteLine(item); 
            }


            Console.WriteLine();
            // primjer u array
            string[] niz_osobe_na = (
                from tr_os      // postavimo ime varijable za svaki element kolekcije
                in osobe //.DefaultIfEmpty($"Defaultna osoba: {defaultnaOsoba.Ime} {defaultnaOsoba.Prezime}!") //  Ne radi, provjeri zasto 
                // ne radi prije filtera, odnosno izbacuje null
                where tr_os.Ime.Contains("na")  // filter
                select tr_os.Prezime   // selektiramo kompletan element
                ).DefaultIfEmpty($"Defaultna osoba: {defaultnaOsoba.Ime} {defaultnaOsoba.Prezime}!").ToArray(); 
            // Dodali smo DefaultIfEmpty() metodu prije ToArray() metode, ovako ispiše defaultnu osobu ako je filter ne pronađe, ukoliko npr. u filter dodamo 'xy' 

            Console.WriteLine("Ispis iz niza stringova:");

            foreach (var item in niz_osobe_na)
            {
                Console.WriteLine("Prezime osobe koja u imenu ima 'na': " + item); 
            }

            Console.WriteLine();
            Console.WriteLine("First ili default");
            // primjer first ili default
            var osobe_def = (
            from tr_os      // postavimo ime varijable za svaki element kolekcije
            in osobe // .DefaultIfEmpty($"Defaultna osoba: {defaultnaOsoba.Ime} {defaultnaOsoba.Prezime}!")        // kolekcija iz koje radimo pretragu
            where tr_os.Ime.Contains("xx")  // filter
            select tr_os.Prezime   // selektiramo kompletan element
            ).FirstOrDefault(); //.DefaultIfEmpty($"Defaultna osoba: {defaultnaOsoba.Ime} {defaultnaOsoba.Prezime}!"); 
            // NE RADI NAKON METODE FirstOrDefault()

            // iz Microsoftove dokumentacije: 
            /* The FirstOrDefault method does not provide a way to specify a default value. 
             * If you want to specify a default value other than default(TSource), 
             * use the DefaultIfEmpty<TSource>(IEnumerable<TSource>, TSource) */

            Console.WriteLine("pronasli smo defaultnu osobu: " + osobe_def); // nismo pronašli defaultnu osobu

            Console.WriteLine();
            Console.WriteLine("First ili default (dodana DefaultInEmpty metoda)");
            var osobe_def2 = (
            from tr_os      // postavimo ime varijable za svaki element kolekcije
            in osobe        // kolekcija iz koje radimo pretragu
            where tr_os.Ime.Contains("xx")  // filter
            select tr_os.Prezime   // selektiramo kompletan element
            ).DefaultIfEmpty($"Defaultna osoba: {defaultnaOsoba.Ime} {defaultnaOsoba.Prezime}!").FirstOrDefault();          
            // Dodali smo DefaultIfEmpty() metodu PRIJE metode FirstOrDefault()           

            Console.WriteLine("pronasli smo defaultnu osobu: " + osobe_def2); // pronasli smo defaultnu odsobu
        }
    }
}
