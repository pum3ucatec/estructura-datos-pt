//Pedir al usuario un número N y sumar todos los números del 1 hasta N usando while.
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un número N:");
        int N = int.Parse(Console.ReadLine()!); 

        int suma = 0;
        int i = 1;

        while (i <= N)
        {
            suma += i; 
            i++;       
        }

        Console.WriteLine($"La suma de los números del 1 al {N} es: {suma}");
    }
}

