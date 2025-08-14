// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // Pedir al usuario un número N
        Console.Write("Ingrese un número N: ");
        int N = int.Parse(Console.ReadLine());

        int suma = 0;
        int i = 1;

        // Bucle while para sumar del 1 al N
        while (i <= N)
        {
            suma += i;
            i++;
        }

        // Mostrar el resultado
        Console.WriteLine($"La suma de los números del 1 al {N} es: {suma}");
    }
}

