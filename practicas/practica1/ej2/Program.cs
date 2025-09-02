using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número N: ");
        int n = int.Parse(Console.ReadLine());

        int suma = 0, i = 1;
        while (i <= n)
        {
            suma += i;
            i++;
        }

        Console.WriteLine($"La suma de 1 a {n} es: {suma}");
    }
}
