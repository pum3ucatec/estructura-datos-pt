using System;

class Program
{
    static void Main()
    {
        int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

        int maxSum = Kadane(arr, out int start, out int end);

        Console.WriteLine("La suma máxima es: " + maxSum);
        Console.Write("El subarreglo es: [ ");
        for (int i = start; i <= end; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine("]");
    }

    static int Kadane(int[] arr, out int startIndex, out int endIndex)
    {
        int maxSoFar = arr[0];
        int maxEndingHere = arr[0];
        int tempStart = 0;

        startIndex = 0;
        endIndex = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > maxEndingHere + arr[i])
            {
                maxEndingHere = arr[i];
                tempStart = i;
            }
            else
            {
                maxEndingHere += arr[i];
            }

            if (maxEndingHere > maxSoFar)
            {
                maxSoFar = maxEndingHere;
                startIndex = tempStart;
                endIndex = i;
            }
        }

        return maxSoFar;
    }
}
