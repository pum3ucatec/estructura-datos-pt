using System;

class Ejercicio3
{
    static void Main()
    {
        int[] arr = {1, 1, 2, 2, 3, 4, 4};
        int nuevoTamaño = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (i == 0 || arr[i] != arr[i - 1])
            {
                arr[nuevoTamaño] = arr[i];
                nuevoTamaño++;
            }
        }

        Console.WriteLine("Arreglo sin duplicados:");
        for (int i = 0; i < nuevoTamaño; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}
