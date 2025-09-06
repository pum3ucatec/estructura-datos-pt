using System;

namespace EliminarDuplicados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese los elementos del arreglo ordenado separados por comas: ");
            string[] entrada = Console.ReadLine().Split(',');
            int[] arr = Array.ConvertAll(entrada, int.Parse);

            int nuevoTamaño = EliminarDuplicadosOrdenados(arr);

            Console.Write("Arreglo sin duplicados: ");
            for (int i = 0; i < nuevoTamaño; i++)
            {
                Console.Write(arr[i] + (i < nuevoTamaño - 1 ? ", " : ""));
            }
        }

        public static int EliminarDuplicadosOrdenados(int[] arr)
        {
            if (arr.Length == 0) return 0;

            int indice = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] != arr[indice - 1])
                {
                    arr[indice] = arr[i];
                    indice++;
                }
            }

            return indice;
        }
    }
}
