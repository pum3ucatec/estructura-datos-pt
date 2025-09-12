﻿using System;

class FactorialRecursivo
{
    static int Factorial(int n)
    {
        if (n <= 1) return 1;
        return n * Factorial(n - 1);
    }

    static void Main()
    {
        Console.Write("Ingrese un número: ");
        int n = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"El factorial de {n} es: {Factorial(n)}");
    }
}
