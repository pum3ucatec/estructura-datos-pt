using System;

class Program
{
    static void Main()
    {
        int[] arr = {1, 1, 2, 2, 3, 4, 4};
        int n = arr.Length;

        Console.WriteLine("Arreglo original:");
        Console.WriteLine(string.Join(", ", arr));

        if (n == 0) return;

        int j = 0;
        for (int i = 1; i < n; i++)
            if (arr[i] != arr[j])
                arr[++j] = arr[i];

        for (int i = 0; i <= j; i++)
            console.Write("Arreglo sin repetidos");
            Console.Write(arr[i] + " ");
    }
}
