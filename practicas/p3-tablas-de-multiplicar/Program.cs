// See https://aka.ms/new-console-template for more information
using System;

namespace Tablas_Multiplicar
{
    class Program
    {
        static void Main()
        {
            int numero;

            Console.Write("Ingrese un número para ver su tabla de multiplicar: ");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nTabla de multiplicar del {numero}:\n");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }
    }
}
