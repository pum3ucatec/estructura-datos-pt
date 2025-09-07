using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un número: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " x " + i + " = " + (num * i));
            }
        }
    }
}