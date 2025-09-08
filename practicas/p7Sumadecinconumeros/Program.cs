using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Ingresa número " + i + ": ");
                suma += int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Suma total: " + suma);
        }
    }
}