using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 4, 5, 6 };
        int n = arr.Length + 1; // Número total si no faltara ninguno

        int missingNumber = FindMissingNumber(arr, n);
        Console.WriteLine("El número que falta es: " + missingNumber);
    }

    static int FindMissingNumber(int[] array, int n)
    {
        int totalSum = n * (n + 1) / 2; // Suma de 1 a n
        int arraySum = 0;

        foreach (int num in array)
        {
            arraySum += num; // Sumamos los números que tenemos
        }

        return totalSum - arraySum; // La diferencia es el número que falta
    }
}
