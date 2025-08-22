using System;
using System.Collections.Generic;

namespace examen_parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

            List<int> resultado = RecorrerEspiral(matriz);

            Console.WriteLine("Recorrido en espiral:");
            Console.WriteLine(string.Join(", ", resultado));
        }
    }
}