using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Rotación de Arreglo ===");

        // Arreglo fijo de ejemplo
        int[] arr = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Arreglo original:");
        Console.WriteLine(string.Join(", ", arr));

        // Leer valor de k
        Console.Write("Ingrese el valor de k (número de posiciones a rotar): ");
        int k = int.Parse(Console.ReadLine());

        // Rotar el arreglo
        int[] resultado = RotarArreglo(arr, k);

        // Mostrar resultado
        Console.WriteLine("Arreglo después de rotación:");
        Console.WriteLine(string.Join(", ", resultado));
    }

    static int[] RotarArreglo(int[] arr, int k)
    {
        int n = arr.Length;
        int[] resultado = new int[n];

        // Ajustar k si es mayor que n
        

        for (int i = 0; i < n; i++)
        {
            resultado[(i + k) % n] = arr[i];
        }

        return resultado;
    }
}
