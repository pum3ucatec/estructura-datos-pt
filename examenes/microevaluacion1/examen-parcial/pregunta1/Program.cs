using System;

class Program
{
    /// <summary>
    /// Encuentra el número faltante en un arreglo que contiene números del 1 al n con un número faltante.
    /// </summary>
    /// <param name="arr">Arreglo de enteros</param>
    /// <returns>El número que falta</returns>
    static int FindMissingNumber(int[] arr)
    {
        int n = arr.Length + 1;
        int totalSum = n * (n + 1) / 2;
        int arrSum = 0;
        foreach (int num in arr)
        {
            arrSum += num;
        }
        return totalSum - arrSum;
    }

    static void Main(string[] args)
    {
        int[] arreglo = {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
            12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22
        };
        int missingNumber = FindMissingNumber(arreglo);
        Console.WriteLine($"El número faltante es: {missingNumber}");
    }
}
