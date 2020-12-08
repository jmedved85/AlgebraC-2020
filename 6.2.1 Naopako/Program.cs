using System;
using System.Collections;

namespace _6._2._1_Naopako
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Program koji traži unos 10 elemenata i 
             sprema ih u objekt tipa ArrayList, a zatim
            ih ispisuje naopako.*/

            ArrayList arr = new ArrayList();
            int element = 0;
            try
            {
                Console.WriteLine("Unesi 10 elemenata:");
                for (int i = 0; i < 10; i++)
                {
                    element = int.Parse(Console.ReadLine());
                    arr.Add(element);
                }
            }
            catch (Exception ex)
            {
                
            }

            // Ispis
            Console.WriteLine("Upisani elementi:");
            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();            
            // Ispis naopako
            Console.WriteLine("Upisani elementi naopako:");
            for (int i = arr.Count-1; i>= 0; i--)
            {
                Console.Write(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
