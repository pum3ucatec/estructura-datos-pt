// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 1, 2, 2, 3, 4, 4 };
        int[] result = RemoveDuplicates(arr);
        
        Console.WriteLine("Arreglo sin duplicados:");
        foreach (int num in result)
        {
            Console.Write(num + " ");
        }
    }

    static int[] RemoveDuplicates(int[] arr)
    {
        if (arr.Length == 0) return arr;
        int j = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] != arr[j])
            {
                j++;
                arr[j] = arr[i]; 
            }
        }
        int[] uniqueArr = new int[j + 1];
        Array.Copy(arr, uniqueArr, j + 1);
        return uniqueArr;
    }
}
