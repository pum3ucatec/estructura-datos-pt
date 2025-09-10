using System;

class Program
{
    static int Factorial(int n)
    {
        if (n == 0 || n == 1) return 1;
        return n * Factorial(n - 1);
    }

    static void Main()
    {
        Console.Write("Ingrese un número para calcular su factorial: ");
        int n = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"El factorial de {n} es {Factorial(n)}");
    }
}
