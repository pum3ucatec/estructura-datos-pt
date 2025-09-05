using System;
using System.Collections.Generic;

class InterseccionArreglos
{
    public static int[] Interseccion(int[] arr1, int[] arr2)
    {
        Array.Sort(arr1);
        Array.Sort(arr2);
        
        List<int> resultado = new List<int>();
        int i = 0, j = 0;
        
        while (i < arr1.Length && j < arr2.Length)
        {
            if (arr1[i] == arr2[j])
            {
                resultado.Add(arr1[i]);
                i++;
                j++;
            }
            else if (arr1[i] < arr2[j])
            {
                i++;
            }
            else
            {
                j++;
            }
        }
        
        return resultado.ToArray();
    }

    public static void Main()
    {
        int[] arr1 = {1, 2, 2, 1};
        int[] arr2 = {2, 2};
        
        Console.WriteLine("Arreglo 1: " + string.Join(", ", arr1));
        Console.WriteLine("Arreglo 2: " + string.Join(", ", arr2));
        
        int[] resultado = Interseccion(arr1, arr2);
        Console.WriteLine("Intersección: " + string.Join(", ", resultado));
    }
}