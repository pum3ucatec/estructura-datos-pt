using System;
class Ejercicio4
{
    static void Main()
    {
        int[] notas = { 80, 70, 90, 60, 100 };
        int suma_notas = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            suma_notas += notas[i];
        }

        double promedio = (double)suma_notas / notas.Length;
        Console.WriteLine("Promedio: " + promedio);

    }
}