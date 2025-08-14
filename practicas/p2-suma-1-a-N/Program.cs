using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el valor de N: ");
        int n = int.Parse(Console.ReadLine());

        int suma = 0;
        int i = 1;

        while (i <= n)
        {
            suma += i;
            i++;
        }

        Console.WriteLine($"La suma de 1 hasta {n} es: {suma}");
    }
}