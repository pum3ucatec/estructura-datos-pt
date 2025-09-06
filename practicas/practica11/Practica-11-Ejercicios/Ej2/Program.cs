using System;

class Program
{
    static int SumaNaturales(int n)
    {
        if (n == 0) return 0;
        return n + SumaNaturales(n - 1);
    }

    static void Main()
    {
        Console.Write("Ingrese un número para sumar desde 1 hasta N: ");
        int n = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"La suma de los primeros {n} números naturales es {SumaNaturales(n)}");
    }
}
