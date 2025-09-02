using System;

class Program
{
    static void Main()
    {
        Console.Write("Escribe N (≥ 1): ");
        int n = int.Parse(Console.ReadLine());

        int suma = 0;
        int i = 1;

        while (i <= n)
        {
            suma = suma + i;
            i++;
        }

        Console.WriteLine($"La suma de 1..{n} es {suma}");
    }
}
