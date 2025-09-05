using System;
class ejercicio_3
{
    public static int fibonacci(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        return fibonacci(n - 1) + fibonacci(n - 2);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== Fibonacci ===");

        Console.Write("Ingresa un número: ");
        int n = int.Parse(Console.ReadLine());

        int resultado = fibonacci(n);

        Console.WriteLine($"El término {n} de fibonacci es: {resultado}");
    }
}