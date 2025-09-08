﻿using System;
class Ejercicio_2
{
    public static int Suma(int n)
    {
        if (n == 0) 
            return 0;
        return n + Suma(n - 1);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== Suma de N números ===");

        Console.Write("Ingresa un número: ");
        int n = int.Parse(Console.ReadLine());

        int resultado = Suma(n);

        Console.WriteLine($"La suma de los primeros {n} números es: {resultado}");
    }
}
