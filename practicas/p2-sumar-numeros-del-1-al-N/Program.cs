// See https://aka.ms/new-console-template for more information
using System;

namespace Sumar_numeros_del_1alN
{
    class Program
    {
        static void Main()
        {
            int N, suma = 0, contador = 1;

            Console.Write("Ingrese un número N: ");
            N = int.Parse(Console.ReadLine());

            while (contador <= N)
            {
                suma += contador;
                contador++;
            }

            Console.WriteLine($"La suma de los números del 1 al {N} es: {suma}");
        }
    }
}
