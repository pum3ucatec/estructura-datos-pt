using System;
using System.Linq;
using System.Collections.Generic;

public class MissingNumberFinder
{
    public static int FindMissingNumber(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("El arreglo no puede ser nulo o vacío.");
        }

        int n = numbers.Length + 1; // La cantidad total de números en la serie, incluyendo el faltante.
        long expectedSum = (long)n * (n + 1) / 2;
        long actualSum = numbers.Sum(num => (long)num);

        return (int)(expectedSum - actualSum);
    }

    public static void Main(string[] args)
    {
        int[] exampleArray = { 1, 2, 4, 5, 6 };
        int missingNumber = FindMissingNumber(exampleArray);
        
        Console.WriteLine("El número que falta es: " + missingNumber);
    }
}