using System;

class Ejercicio5
{
    static void Main()
    {
        int[] arreglo = { 12, 5, 8, 20, 3, 17, 25, 10 };
        int mayor = arreglo[0];
        int menor = arreglo[0];

        for (int i = 1; i < arreglo.Length; i++)
        {
            if (arreglo[i] > mayor) mayor = arreglo[i];
            if (arreglo[i] < menor) menor = arreglo[i];
        }

        Console.WriteLine("Mayor: " + mayor);
        Console.WriteLine("Menor: " + menor);
    }
}
