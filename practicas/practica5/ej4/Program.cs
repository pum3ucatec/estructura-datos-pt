using System;

class Program
{
    static int MissingNumber(int[] arr, int n)
    {
        int expectedSum = n * (n + 1) / 2;
        int actualSum = 0;
        foreach (int num in arr) actualSum += num;
        return expectedSum - actualSum;
    }

    static void Main()
    {
        int[] arr = {1, 2, 4, 5, 6};
        Console.WriteLine("Número faltante: " + MissingNumber(arr, 6));
    }
}
