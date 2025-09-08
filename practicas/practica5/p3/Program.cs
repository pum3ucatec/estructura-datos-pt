using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 1, 2, 2, 3, 4, 4 };
        int newLength = RemoveDuplicates(arr);

        Console.WriteLine("Arreglo sin duplicados:");
        for (int i = 0; i < newLength; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }

    static int RemoveDuplicates(int[] array)
    {
        if (array.Length == 0) return 0;

        int index = 1; // Guarda la posición donde colocar el siguiente valor único

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] != array[i - 1])
            {
                array[index] = array[i];
                index++;
            }
        }

        return index; // Nueva longitud del arreglo
    }
}
