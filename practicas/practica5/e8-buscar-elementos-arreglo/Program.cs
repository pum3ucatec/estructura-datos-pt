using System;

namespace SearchApp
{
    class RotatedArraySearch
    {
        // Busca un número en un arreglo rotado usando búsqueda binaria adaptada
        public static int FindIndex(int[] data, int target)
        {
            int start = 0, end = data.Length - 1;

            while (start <= end)
            {
                int middle = (start + end) / 2;

                if (data[middle] == target)
                    return middle;

                // Caso: lado izquierdo está ordenado
                if (data[start] <= data[middle])
                {
                    if (target >= data[start] && target < data[middle])
                        end = middle - 1;
                    else
                        start = middle + 1;
                }
                else // Caso: lado derecho está ordenado
                {
                    if (target > data[middle] && target <= data[end])
                        start = middle + 1;
                    else
                        end = middle - 1;
                }
            }

            return -1; // No encontrado
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] rotatedArray = { 4, 5, 6, 7, 0, 1, 2 };

            int position = RotatedArraySearch.FindIndex(rotatedArray, 0);

            Console.WriteLine("Resultado de la búsqueda:");
            Console.WriteLine(position == -1 ? "Elemento no encontrado" : $"Elemento encontrado en índice {position}");
        }
    }
}
