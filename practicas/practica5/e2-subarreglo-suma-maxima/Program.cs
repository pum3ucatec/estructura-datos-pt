using System;

namespace SubarrayApp
{
    class Analyzer
    {
        // Encuentra la mayor suma posible de un subarreglo contiguo
        public static int FindLargestSum(int[] sequence)
        {
            int best = sequence[0];
            int temp = sequence[0];

            for (int i = 1; i < sequence.Length; i++)
            {
                // Elegir entre iniciar desde el valor actual o continuar sumando
                temp = (sequence[i] > temp + sequence[i]) ? sequence[i] : temp + sequence[i];
                best = (temp > best) ? temp : best;
            }

            return best;
        }
    }

    class Runner
    {
        static void Main(string[] args)
        {
            int[] data = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

            int result = Analyzer.FindLargestSum(data);

            Console.WriteLine("El valor máximo obtenido es: {0}", result);
        }
    }
}
