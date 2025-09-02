/* 1. Declaración e inicialización
Declara un arreglo de 5 enteros y asígnales valores desde consola. Luego imprime todos los valores en pantalla. */

using System;

class ejercicio_1
{
    static void Main()
    {
        int[] num = new int[5]; // num = numero

        for (int c = 0; c < num.Length; c++) // c = variable de control
        {
            Console.Write($"Ingrese el número {c + 1}: ");
            num[c] = int.Parse(Console.ReadLine()); // Asignación de valor
        }

        Console.WriteLine("Los números ingresados son:");
        for (int c = 0; c < num.Length; c++)
        {
            Console.WriteLine(num[c]);
        }
    }
}