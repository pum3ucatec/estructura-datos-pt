using System;
class Ejercicio2
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

        Console.WriteLine("La suma es: " + suma);

    }
}