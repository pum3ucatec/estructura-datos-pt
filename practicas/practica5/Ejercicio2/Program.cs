using System;

namespace SubarregloMaximo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese los elementos del arreglo separados por comas: ");
            string[] entrada = Console.ReadLine().Split(',');
            int[] arr = Array.ConvertAll(entrada, int.Parse);

            int sumaMaxima = Kadane(arr);

            Console.WriteLine($"La suma máxima del subarreglo es: {sumaMaxima}");
        }

        public static int Kadane(int[] arr)
        {
            int maxActual = arr[0];
            int maxGlobal = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                maxActual = Math.Max(arr[i], maxActual + arr[i]);
                if (maxActual > maxGlobal)
                {
                    maxGlobal = maxActual;
                }
            }
            return maxGlobal;
        }
    }
}
