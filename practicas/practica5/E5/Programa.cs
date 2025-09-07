using System;

class InterseccionArreglos
{
    static void Main(string[] args)
    {
        int[] arr1 = { 1, 2, 2, 1 };
        int[] arr2 = { 2, 2 };

        int[] resultado = Interseccion(arr1, arr2);

        Console.WriteLine("Intersección: [" + string.Join(", ", resultado) + "]");
    }

    static int[] Interseccion(int[] arr1, int[] arr2)
    {
        int[] temp = new int[Math.Min(arr1.Length, arr2.Length)];
        int k = 0;
        bool[] usado = new bool[arr2.Length];

        for (int i = 0; i < arr1.Length; i++)
        {
            for (int j = 0; j < arr2.Length; j++)
            {
                if (arr1[i] == arr2[j] && !usado[j])
                {
                    temp[k++] = arr1[i];
                    usado[j] = true;
                    break;
                }
            }
        }

        int[] resultado = new int[k];
        Array.Copy(temp, resultado, k);

        return resultado;
    }
}
