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
/*
Sí, el código sigue la convención de PascalCase para la clase (Ejercicio_2) y el método (Suma).
Sin embargo, hay un error en el método Main: se llama a suma(n) en vez de Suma(n), y el nombre del método debería ser Suma (en PascalCase).
Las variables y parámetros (n, resultado, args) están en camelCase, lo cual es correcto.
*/