// Sumar números del 1 al N
// Este programa solicita al usuario un número N y calcula la suma de todos los números enteros
//Camilaa

using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número N: ");
        int n = int.Parse(Console.ReadLine());
        int suma = 0;
        int i = 1;
        
        while (i <= n)
        {
            suma += i;
            i++;
        }
        
        Console.WriteLine($"La suma de los números del 1 al {n} es: {suma}");
    }
}
