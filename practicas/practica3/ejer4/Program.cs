/* 4. Promedio de elementos
Ingresa 5 calificaciones en un arreglo y calcula el promedio. */

using System;

class Ejercicio4
{
    static void Main()
    {
        int[] notas = new int[5];
        int suma = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            notas[i] = LeerEntero($"Ingresa la nota #{i + 1}: ");
            suma += notas[i];
        }

        double promedio = (double)suma / notas.Length;

        Console.WriteLine($"Notas: [{string.Join(", ", notas)}]");
        Console.WriteLine($"Promedio: {promedio}");
    }

    static int LeerEntero(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int valor))
                return valor;

            Console.WriteLine("Error, intenta de nuevo.");
        }
    }
}
