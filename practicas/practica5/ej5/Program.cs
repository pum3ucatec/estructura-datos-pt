using System;

class Program
{
    static void Main()
    {
        int[] arr1 = { 1, 2, 2, 1 };
        int[] arr2 = { 2, 2 };

        Console.WriteLine("Arreglo 1: " + string.Join(", ", arr1));
        Console.WriteLine("Arreglo 2: " + string.Join(", ", arr2));

        int[] intersection = FindIntersection(arr1, arr2);

        Console.WriteLine("Intersección: " + string.Join(", ", intersection));
    }

    static int[] FindIntersection(int[] arr1, int[] arr2)
    {
        int n1 = arr1.Length;
        int n2 = arr2.Length;

        // resultado temporal (máximo tamaño = min(n1,n2))
        int[] temp = new int[Math.Min(n1, n2)];
        int index = 0;

        bool[] used = new bool[n2]; // para marcar elementos ya usados de arr2

        for (int i = 0; i < n1; i++)
        {
            for (int j = 0; j < n2; j++)
            {
                if (arr1[i] == arr2[j] && !used[j])
                {
                    temp[index++] = arr1[i];
                    used[j] = true; // marcamos como usado
                    break;
                }
            }
        }

        // Copiamos el resultado a un arreglo con la longitud correcta
        int[] result = new int[index];
        Array.Copy(temp, result, index);

        return result;
    }
}
