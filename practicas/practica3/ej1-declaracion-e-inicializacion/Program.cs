// Ejercicio 1: Declaración e inicialización 
// Camii
using System;

class Program
{
    static void Main()
    {
        // Se crea eñ arreglo de 5 números enteros
        int[] numeros = { 10, 20, 30, 40, 50 };
        Console.WriteLine("Ejercicio 1 de cami:");
        // Se recorre el arreglo con un ciclo for
        for (int i = 0; i < numeros.Length; i++)
            // Se muestra cada número en consola
            Console.WriteLine(numeros[i]);
    }
}

