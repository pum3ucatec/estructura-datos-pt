using System;

namespace Ejercicio1
{
    class Program
    {
        static void RotateArray(int[] arr, int k)
        {
            k = k % arr.Length; 
            Reverse(arr, 0, arr.Length - 1);
            Reverse(arr, 0, k - 1);
            Reverse(arr, k, arr.Length - 1);
        }

        static void Reverse(int[] arr, int inicio, int fin)
        {
            while (inicio < fin)
            {
                int temp = arr[inicio];
                arr[inicio] = arr[fin];
                arr[fin] = temp;
                inicio++;
                fin--;
            }
        }

        static void Main(string[] args)
        {
            int[] arreglo = { 1, 2, 3, 4, 5 };
            int k = 2;

            Console.WriteLine("Arreglo original: " + string.Join(", ", arreglo));

            RotateArray(arreglo, k);

            Console.WriteLine($"Arreglo rotado {k} posiciones: " + string.Join(", ", arreglo));
        }
    }
}
