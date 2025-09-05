using System;

class Programa
{
    static void Main(string[] args)
    {
        // Declaración e inicialización del arreglo
        int[] numeros = { 10, 20, 30, 40, 50 };

        // Recorrido e impresión de los valores
        Console.WriteLine("Valores del arreglo:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}
