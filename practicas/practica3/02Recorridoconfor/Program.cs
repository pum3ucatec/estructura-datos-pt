﻿using System;

class Program
{
    static void Main()
    {

        int[] numeros = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };

        Console.WriteLine("Contenido del arreglo:");

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine($"Elemento #{i}: {numeros[i]}");
        }
    }
}
