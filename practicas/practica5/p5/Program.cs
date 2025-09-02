using System;

class Program
{
    static void Main()
    {
        int[] arr1 = { 1, 2, 2, 1 };
        int[] arr2 = { 2, 2 };

        int[] intersection = IntersectArrays(arr1, arr2);

        Console.WriteLine("Intersección de los dos arreglos:");
        foreach (int num in intersection)
        {
            Console.Write(num + " ");
        }
    }

    static int[] IntersectArrays(int[] a, int[] b)
    {
        int[] result = new int[Math.Min(a.Length, b.Length)];
        int index = 0;
        bool[] used = new bool[b.Length]; // Marca los elementos de b que ya usamos

        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < b.Length; j++)
            {
                if (a[i] == b[j] && !used[j])
                {
                    result[index++] = a[i];
                    used[j] = true; // Marcamos que este elemento ya fue usado
                    break;
                }
            }
        }

        int[] finalResult = new int[index];
        Array.Copy(result, finalResult, index);
        return finalResult;
    }
}
