using System;

class Program
{
    static void Main()
    {
        // Ejemplo: falta el número 7
        int[] arr = { 1, 2, 3, 4, 5, 6, 8, 9, 10 };
        int n = arr.Length + 1; // tamaño real debería ser 10

        int missing = FindMissingNumber(arr, n);

        Console.WriteLine("El número que falta es: " + missing);
    }

    static int FindMissingNumber(int[] arr, int n)
    {
        // La suma esperada de 1 hasta n
        int total = n * (n + 1) / 2;

        // Suma real de los elementos en el arreglo
        int sum = 0;
        foreach (int num in arr)
        {
            sum += num;
        }

        // Diferencia = número faltante
        return total - sum;
    }
}
