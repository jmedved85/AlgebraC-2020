using System;

namespace _7._2._1_Hello_World
{
    class Program
    {
        static void Main()
            // Program "Hello World" realiziran pomoću potprograma
        {
            Hello_World();
            Hello_World();
            Hello_World();
            Kraj();
        }

        private static void Hello_World()
        {
            Console.WriteLine("Hello World!");
        }

        private static void Kraj()
        {
            Console.WriteLine("Pritisnite neku tipku za kraj...");
            Console.ReadKey();
        }
    }
}
