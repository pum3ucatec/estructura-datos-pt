using System;

class Ejercicio4
{
    static void Main()
    {
        int[] notas = { 80, 70, 90, 60, 100 };
        int total = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            total += notas[i];
        }

        double promedio = (double)total / notas.Length;
        Console.WriteLine("Promedio: " + promedio);
    }
}
