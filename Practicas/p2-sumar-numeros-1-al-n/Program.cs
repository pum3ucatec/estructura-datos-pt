// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa un número N: ");
        int N = int.Parse(Console.ReadLine());

        int suma = 0;
        int i = 1;

        while (i <= N)
        {
            suma += i; // suma = suma + i
            i++;
        }

        Console.WriteLine($"La suma de los números del 1 al {N} es: {suma}");
    }
}

