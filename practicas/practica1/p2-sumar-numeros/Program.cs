using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un número N: ");
            int N = int.Parse(Console.ReadLine());
            int suma = 0;
            int contador = 1;

            while (contador <= N)
            {
                suma += contador;
                contador++;
            }

            Console.WriteLine("Suma: " + suma);
        }
    }
}