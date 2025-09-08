using System;

namespace ContadorRegresivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contador regresivo del 10 al 1:");
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("¡Despegue!");
        }
    }
}

