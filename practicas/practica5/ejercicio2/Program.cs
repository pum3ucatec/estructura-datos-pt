using System;

class Ejercicio2
{
    static void Main()
    {
        int[] arr = {-2, 1, -3, 4, -1, 2, 1, -5, 4};
        int maxSum = arr[0];
        int current = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (current < 0) current = 0;
            current += arr[i];
            if (current > maxSum) maxSum = current;
        }

        Console.WriteLine("Suma máxima: " + maxSum);
    }
}
