using System;

namespace examenparcial
{

    class Program
    {
        static void Main()
        {
            int[] arreglo = { 1, 2, 4, 5, 7, 8, 10 };
            int n = 10;
            int[] faltantes = EncontrarFaltantes(arreglo, n);

            Console.WriteLine("Los números que faltan son: " + string.Join(", ", faltantes));
        }

        static int[] EncontrarFaltantes(int[] arr, int n)
        {
            bool[] presente = new bool[n + 1];
            foreach (int num in arr)
            {
                if (num >= 1 && num <= n)
                    presente[num] = true;
            }

            var listaFaltantes = new System.Collections.Generic.List<int>();
            for (int i = 1; i <= n; i++)
            {
                if (!presente[i])
                    listaFaltantes.Add(i);
            }
            return listaFaltantes.ToArray();
        }
    }
}