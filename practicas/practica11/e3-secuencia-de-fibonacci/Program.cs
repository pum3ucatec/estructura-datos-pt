using System;

class Ejercicio3
{

    public static int Fibonacci(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    public static void MostrarFibonacci(int n, int i = 0)
    {
        if (i > n) return; // Caso base

        Console.Write(Fibonacci(i) + " ");
        MostrarFibonacci(n, i + 1); // Llamada recursiva 
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== Fibonacci Recursivo ===");

        Console.Write("Ingresa un número: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"La secuencia de Fibonacci hasta el término {n} es:");
        MostrarFibonacci(n);

        Console.WriteLine();
    }
}
