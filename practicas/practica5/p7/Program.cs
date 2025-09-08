using System;

class Program
{
    static void Main()
    {
        int[] arr = {1, 2, 3, 4};
        int n = arr.Length;
        int[] result = new int[n];

        for (int i = 0; i < n; i++)
        {
            int prod = 1;
            for (int j = 0; j < n; j++)
            {
                if (i != j)
                {
                    prod *= arr[j]; // Multiplicamos todos menos el actual
                }
            }
            result[i] = prod;
        }

        Console.WriteLine("Arreglo de productos excepto el índice:");
        foreach (int num in result)
        {
            Console.Write(num + " ");
        }
    }
}
