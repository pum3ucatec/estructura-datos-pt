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
        Console.Write("Ingresa la cantidad de términos de la secuencia: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nSecuencia de Fibonacci con {n} términos:");

        for (int i = 0; i < n; i++)
        {
            Console.Write(FibonacciRecursivo(i) + " ");
        }
    }
}