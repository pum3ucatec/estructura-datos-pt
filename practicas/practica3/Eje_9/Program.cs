// Implementar un algoritmo que ordene un arreglo de mayor a menor
// utilizando el método de la burbuja (Bubble Sort).
using System;   
class Program
{
    static void Main(string[] args)
    {
        int[] arreglo = { 5, 2, 9, 1, 5, 6 };
        Console.WriteLine("Arreglo original: " + string.Join(", ", arreglo));
        
        BubbleSort(arreglo);
        
        Console.WriteLine("Arreglo ordenado de mayor a menor: " + string.Join(", ", arreglo));
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] < arr[j + 1]) // Cambiado para ordenar de mayor a menor
                {
                    // Intercambiar arr[j] y arr[j+1]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}
