using System;

class KadaneAlgorithm
{
    public static (int[], int) SubarregloSumaMaxima(int[] arr)
    {
        if (arr == null || arr.Length == 0) return (new int[0], 0);
        
        int maxActual = arr[0];
        int maxGlobal = arr[0];
        int start = 0, end = 0;
        int tempStart = 0;
        
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > maxActual + arr[i])
            {
                maxActual = arr[i];
                tempStart = i;
            }
            else
            {
                maxActual += arr[i];
            }
            
            if (maxActual > maxGlobal)
            {
                maxGlobal = maxActual;
                start = tempStart;
                end = i;
            }
        }
        
        int[] subarreglo = new int[end - start + 1];
        Array.Copy(arr, start, subarreglo, 0, subarreglo.Length);
        
        return (subarreglo, maxGlobal);
    }

    public static void Main()
    {
        int[] arr = {-2, 1, -3, 4, -1, 2, 1, -5, 4};
        var resultado = SubarregloSumaMaxima(arr);
        
        Console.WriteLine("Arreglo: " + string.Join(", ", arr));
        Console.WriteLine("Subarreglo con suma máxima: " + string.Join(", ", resultado.Item1));
        Console.WriteLine("Suma máxima: " + resultado.Item2);
    }
}