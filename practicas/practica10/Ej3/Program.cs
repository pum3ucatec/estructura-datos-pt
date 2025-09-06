using System;

class Program
{
    public static int FibonacciRecursivo(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        return FibonacciRecursivo(n - 1) + FibonacciRecursivo(n - 2);
    }

    static void Main()
    {
        Console.WriteLine(FibonacciRecursivo(6));  // Salida: 8
    }
}