using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número N: ");
        int N = int.Parse(Console.ReadLine());
        int suma = 0;
        int i = 1;

        while (i <= N)
        {
            suma += i;
            i++;
        }

        Console.WriteLine($"La suma de 1 a {N} es: {suma}");
    }
}
