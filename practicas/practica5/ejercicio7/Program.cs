using System;

class Ejercicio7
{
    static void Main()
    {
        int[] arr = {1,2,3,4};
        int[] res = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            int prod = 1;
            for (int j = 0; j < arr.Length; j++)
            {
                if (i != j) prod *= arr[j];
            }
            res[i] = prod;
        }

        Console.WriteLine("Arreglo resultado:");
        foreach(int n in res) Console.Write(n + " ");
    }
}
