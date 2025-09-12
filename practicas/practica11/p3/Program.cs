using System;

class FibonacciRecursivo
{
    static int Fibonacci(int n)
    {
        if (n <= 1) return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main()
    {
        Console.Write("Ingrese la cantidad de números: ");
        int n = int.Parse(Console.ReadLine()!);
        for (int i = 0; i < n; i++)
        {
            Console.Write(Fibonacci(i));
            if (i < n - 1) Console.Write(" -> ");
        }
        Console.WriteLine();
    }
}
