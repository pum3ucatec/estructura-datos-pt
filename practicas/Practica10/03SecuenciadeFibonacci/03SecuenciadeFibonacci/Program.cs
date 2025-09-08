//Calcular el término n de la secuencia de Fibonacci.
using System;

class Program
{
    
    public static int FibonacciRecursivo(int n)
    {
        if (n < 0)
            throw new ArgumentException("El índice debe ser no negativo.");

        if (n == 0)
            return 0;

        if (n == 1)
            return 1;

        return FibonacciRecursivo(n - 1) + FibonacciRecursivo(n - 2);
    }

    
    static void Main(string[] args)
    {
        Console.Write("Ingresa el índice n (no negativo) de la secuencia de Fibonacci: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
        {
            int resultado = FibonacciRecursivo(n);
            Console.WriteLine($"El término {n} de la secuencia de Fibonacci es: {resultado}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor ingresa un número entero no negativo.");
        }
    }
}
